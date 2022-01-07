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

namespace Sistema_Hoteleiro.Cadastros
{
    public partial class frm_Quartos : Form
    {

        Conexao con = new Conexao();
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable dt;
        SqlCommand cmd;

        string id;
        string quartoAntigo;

        // necessario string strCon para  o banco no forms conexao
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_Quartos()
        {
            InitializeComponent();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Descrição";
            Grid.Columns[2].HeaderText = "Quarto";
            Grid.Columns[3].HeaderText = "Valor";
            Grid.Columns[4].HeaderText = "Pessoas";

            // Formatação das colunas para moeda
            Grid.Columns[3].DefaultCellStyle.Format = "C2";

            // colunas ocultas
            Grid.Columns[0].Visible = false;
            Grid.Columns[1].Width = 150;
            Grid.Columns[2].Width = 150;
            Grid.Columns[3].Width = 150;
            Grid.Columns[4].Width = 130;

        }
        // Codigo para listar Serviços
        private void Listar()
        {
            con.conectar();
            adpt = new SqlDataAdapter("SELECT * FROM Quartos order by Quarto asc", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }

        private void habilitarCampos()
        {
            txt_Descrição.Enabled = true;
            txt_Quarto.Enabled = true;
            txt_Valor.Enabled = true;
            txt_Pessoas.Enabled = true;
            txt_Descrição.Focus();
        }
        private void desabilitarCampos()
        {
            txt_Descrição.Enabled = false;
            txt_Quarto.Enabled = false;
            txt_Valor.Enabled = false;
            txt_Pessoas.Enabled = false;
        }
        private void limparDados()
        {
            txt_Descrição.Text = "";
            txt_Quarto.Text = "";
            txt_Valor.Text = "";
            txt_Pessoas.Text = "";
        }

        private void frm_Quartos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // Validação de preenchimento dos campos 
            if (txt_Descrição.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher a Descrição!.", "Campo Descrição Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Descrição.Text = "";
                txt_Descrição.Focus();
                return;
            }
            if (txt_Quarto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher o nuemro do quarto!.", "Campo Quarto Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Quarto.Text = "";
                txt_Quarto.Focus();
                return;
            }
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher o Valor!.", "Campo Valor Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Valor.Text = "";
                txt_Valor.Focus();
                return;
            }
            if (txt_Pessoas.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher o numero de pessoas!.", "Campo Pessoas Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Pessoas.Text = "";
                txt_Pessoas.Focus();
                return;
            }

            strSql = "insert into Quartos (Descricao, Quarto, Valor, Pessoas) values (@Descricao, @Quarto, @Valor, @Pessoas)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Descricao", txt_Descrição.Text);
            comando.Parameters.AddWithValue("@Quarto", txt_Quarto.Text);
            comando.Parameters.AddWithValue("@Valor", Convert.ToDouble(txt_Valor.Text));
            comando.Parameters.AddWithValue("@Pessoas", txt_Pessoas.Text);

            // Verificação se o numero do quarto existe no BD
            SqlCommand cmdVerificar;

            cmdVerificar = new SqlCommand("Select * from Quartos where Quarto = @Quarto", sqlCon);
            cmdVerificar.Parameters.AddWithValue("@Quarto", txt_Quarto.Text);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmdVerificar;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Insira outro numero de Quarto!", "Quarto já cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Quarto.Text = "";
                txt_Quarto.Focus();
                return;
            }
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Dados Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            limparDados();
            desabilitarCampos();
            Listar();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            strSql = "delete from Quartos where id_Quarto=@id_Quarto";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.AddWithValue("@id_Quarto", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                var resultado = MessageBox.Show("Deseja excluir o quarto?", "Excluir Quarto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Quarto excluido com sucesso!", "Quarto Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Novo.Enabled = true;
                    btn_Alterar.Enabled = false;
                    btn_Excluir.Enabled = false;
                    limparDados();
                    desabilitarCampos();
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
            Listar();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Alterar.Enabled = true;
            btn_Excluir.Enabled = true;
            habilitarCampos();

            id = Grid.CurrentRow.Cells[0].Value.ToString();
            txt_Descrição.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txt_Quarto.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txt_Valor.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            txt_Pessoas.Text = Grid.CurrentRow.Cells[4].Value.ToString();
           
            quartoAntigo = Grid.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            // Validação de preenchimento dos campos 
            if (txt_Descrição.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher a Descrição!.", "Campo Descrição Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Descrição.Text = "";
                txt_Descrição.Focus();
                return;
            }
            if (txt_Quarto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher o nuemro do quarto!.", "Campo Quarto Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Quarto.Text = "";
                txt_Quarto.Focus();
                return;
            }
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher o Valor!.", "Campo Valor Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Valor.Text = "";
                txt_Valor.Focus();
                return;
            }
            if (txt_Pessoas.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher o numero de pessoas!.", "Campo Pessoas Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Pessoas.Text = "";
                txt_Pessoas.Focus();
                return;
            }
            strSql = "update Quartos set Descricao=@Descricao, Quarto=@Quarto, Valor=@Valor, Pessoas=@Pessoas where id_Quarto=@id_Quarto";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.AddWithValue("@Descricao", txt_Descrição.Text);
            comando.Parameters.AddWithValue("@Quarto", txt_Quarto.Text);
            comando.Parameters.AddWithValue("@Valor", Convert.ToDouble(txt_Valor.Text));
            comando.Parameters.AddWithValue("@Pessoas", txt_Pessoas.Text);
            comando.Parameters.AddWithValue("@id_Quarto", id);


            // verifica se o cpf existe no banco
            if (txt_Quarto.Text != quartoAntigo)
            {
                SqlCommand cmdVerificar;

                cmdVerificar = new SqlCommand("Select * from Quartos where Quarto = @Quarto", sqlCon);
                cmdVerificar.Parameters.AddWithValue("@Quarto", txt_Quarto.Text);
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = cmdVerificar;
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Insira outro numero de Quarto!", "Quarto já cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Quarto.Text = "";
                    txt_Quarto.Focus();
                    return;
                }
            }
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro alterado com sucesso!", "Dados Alterados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            Listar();
            limparDados();
            desabilitarCampos();
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
        }
    }
}
