using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Hoteleiro.Movimentacoes
{
    public partial class frm_Gastos : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        string id;
        string ultimoIdGasto;

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_Gastos()
        {
            InitializeComponent();
        }
        // Formatar DataGridView
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Descrição";
            Grid.Columns[2].HeaderText = "Valor";
            Grid.Columns[3].HeaderText = "Funcionário";
            Grid.Columns[4].HeaderText = "Data";

            // Formatação das colunas para moeda
            Grid.Columns[2].DefaultCellStyle.Format = "C2";
            // Ocultar coluna
            Grid.Columns[0].Visible = false;
            // Formatar o tamanho da coluna
            Grid.Columns[1].Width = 140;
            Grid.Columns[4].Width = 75;
            Totalizar();
        }
        // Codigo para listar cargos
        private void Listar()
        {
            adpt = new SqlDataAdapter("Select * from Gastos order by Data desc", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            FormatarDG();
        }
        private void habilitarCampos()
        {
            txt_Descricao.Enabled = true;
            txt_Valor.Enabled = true;
            txt_Descricao.Focus();
        }
        private void desabilitarCampos()
        {
            txt_Descricao.Enabled = false;
            txt_Valor.Enabled = false;
        }
        private void limparDados()
        {
            txt_Descricao.Text = "";
            txt_Valor.Text = "";
        }

        private void BuscarData()
        {
            con.conectar();
            strSql = "SELECT * FROM Gastos WHERE Data = @Data ORDER BY Data DESC";
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dt_Buscar.Text));
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }


        private void frm_Gastos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // Codigo botão novo
            habilitarCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo descrição esta vazio
            if (txt_Descricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha a descrição do gasto!", "Campo descrição vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Descricao.Text = "";
                txt_Descricao.Focus();
                return;
            }
            // Verificar se o campo valor esta vazio
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor do serviço!", "Campo valor vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Valor.Text = "";
                txt_Valor.Focus();
                return;
            }
            // Codigo botão salvar
            strSql = "INSERT INTO Gastos (Descricao, Valor, Funcionario, Data) VALUES (@Descricao, @Valor, @Funcionario, GETDATE())";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            con.conectar();
            comando.Parameters.AddWithValue("@Descricao", txt_Descricao.Text);
            comando.Parameters.AddWithValue("@Valor", txt_Valor.Text.Replace(",", "."));
            comando.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Gasto salvo com sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            // Recupera o ultimo ID do gasto 
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmdRecuperar = new SqlCommand();

            SqlDataReader readerId;


            cmdRecuperar = new SqlCommand("Select top 1 * from Gastos order by id_Gastos DESC"); // top 1 * seria o equivalente ao LIMIT do MySql

            cmdRecuperar.Connection = con.conectar();
            readerId = cmdRecuperar.ExecuteReader();

            if (readerId.HasRows)
            {

                //Extraindo informações da consulta de login
                while (readerId.Read())
                {
                    ultimoIdGasto = Convert.ToString(readerId["id_Gastos"]);
                }

                // Relacionar os itens com a venda
                con.conectar();
            }
            readerId.Close();

            // Lançar o gasto nas movimentações
            strSql = "INSERT INTO Movimentacoes (Tipo, Movimento, Valor, Funcionario, Data, id_Movimento) VALUES (@Tipo, @Movimento, @Valor, @Funcionario, GETDATE(), @id_Movimento)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd1 = new SqlCommand(strSql, sqlCon);

            con.conectar();
            cmd1.Parameters.AddWithValue("@Tipo", "Saída");
            cmd1.Parameters.AddWithValue("@Movimento", "Gastos");
            cmd1.Parameters.AddWithValue("@Valor", txt_Valor.Text);
            cmd1.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            cmd1.Parameters.AddWithValue("@id_Movimento", ultimoIdGasto);
            try
            {
                sqlCon.Open();
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            limparDados();
            desabilitarCampos();
            Listar();

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo descrição esta vazio
            if (txt_Descricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha a descrição!", "Campo descrição vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Descricao.Text = "";
                txt_Descricao.Focus();
                return;
            }
            // Verificar se o campo valor esta vazio
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor!", "Campo valor vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Valor.Text = "";
                txt_Valor.Focus();
                return;
            }

            // codigo botao editar
            con.conectar();
            strSql = "UPDATE Gastos SET Descricao = @Descricao, Valor = @Valor, Funcionario =@Funcionario, Data = GETDATE() WHERE id_Gastos = @id_Gastos";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            con.conectar();
            comando.Parameters.AddWithValue("@Descricao", txt_Descricao.Text);
            comando.Parameters.AddWithValue("@Valor", txt_Valor.Text.Replace(",", "."));
            comando.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            comando.Parameters.AddWithValue("@id_Gastos", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Gasto editado com sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            // Atualizar o valor na movimentação **** corrigir esse update onde ao fazer uma alteração nos gastos ela atualiza em movimentaçao
            con.conectar();
            strSql = "UPDATE Movimentacoes SET Valor = @Valor, Funcionario =@Funcionario, Data = GETDATE() WHERE id_Movimento = @id and Movimento = @Movimento";

            sqlCon = new SqlConnection(strCon);
            SqlCommand cmdUpdate = new SqlCommand(strSql, sqlCon);

            con.conectar();
            cmdUpdate.Parameters.AddWithValue("@Valor", txt_Valor.Text.Replace(",", "."));
            cmdUpdate.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            cmdUpdate.Parameters.AddWithValue("@id", id);
            cmdUpdate.Parameters.AddWithValue("@Movimento", "Gasto");

            try
            {
                sqlCon.Open();
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }


            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            limparDados();
            desabilitarCampos();
            Listar();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM Gastos where id_Gastos=@id_Gastos";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@id_Gastos", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                var resultado = MessageBox.Show("Deseja excluir o Serviço?", "Excluir Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Serviço excluido com sucesso!", "Serviço Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            limparDados();
            desabilitarCampos();
            Listar();

            // Exclusão do gasto na tabela movimento
            con.conectar();
            strSql = "DELETE FROM Movimentacoes WHERE id_Movimento = @id_Movimento AND Movimento = @Movimento";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@id_Movimento", id);
            cmd.Parameters.AddWithValue("@Movimento", "Gasto");

            try
            {
                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Editar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_Salvar.Enabled = false;
            habilitarCampos();

            // recuperar o valor do id
            id = Grid.CurrentRow.Cells[0].Value.ToString();
            txt_Descricao.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txt_Valor.Text = Grid.CurrentRow.Cells[2].Value.ToString();
        }

        private void dt_Buscar_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void Totalizar()
        {
            double total = 0;
            foreach(DataGridViewRow linha in Grid.Rows)
            {
                total += Convert.ToDouble(linha.Cells["Valor"].Value); // += vai incrementar na linha em que estiver passando para o campo valor
            }
            lbl_Total.Text = Convert.ToDouble(total).ToString("C2"); // "C2" para passar como moeda
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
