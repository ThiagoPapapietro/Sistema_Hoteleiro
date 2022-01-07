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
    public partial class frm_NovoServicos : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable dt;
        SqlCommand cmd;
        string id;       
        string ultimoIdServico;
        string valorServico;

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_NovoServicos()
        {
            InitializeComponent();
        }
        private void CarregarComboBoxServico()
        {
            adpt = new SqlDataAdapter("Select * from Servicos order by Nome", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            cb_Servico.DataSource = dt;
            cb_Servico.DisplayMember = "Nome";
        }

        private void CarregarComboBoxQuartos()
        {
            adpt = new SqlDataAdapter("Select * from Quartos order by Quarto", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            cb_Quarto.DataSource = dt;
            cb_Quarto.DisplayMember = "Quarto";
        }
        // Formatar DataGridView seriços
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Hóspede";
            Grid.Columns[2].HeaderText = "Serviço";
            Grid.Columns[3].HeaderText = "Quarto";
            Grid.Columns[4].HeaderText = "Quantidade";
            Grid.Columns[5].HeaderText = "Valor";
            Grid.Columns[6].HeaderText = "Funcionário";
            Grid.Columns[7].HeaderText = "Data";


            // Formatação das colunas para moeda
            Grid.Columns[5].DefaultCellStyle.Format = "C2";

            // colunas ocultas
            Grid.Columns[0].Visible = false;
            Grid.Columns[3].Width = 80;
            Grid.Columns[4].Width = 80;
            Grid.Columns[7].Width = 90;

        }
        // Codigo para listar Serviços
        private void Listar()
        {
            con.conectar();
            adpt = new SqlDataAdapter("SELECT * FROM Novo_Servico order by Data asc", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }

        private void habilitarCampos()
        {
            txt_Nome.Enabled = true;
            cb_Servico.Enabled = true;
            cb_Quarto.Enabled = true;
            txt_Quantidade.Enabled = true;
            txt_Valor.Enabled = true;
            btn_Hospede.Enabled = true;
            txt_Quantidade.Focus();
        }
        private void desabilitarCampos()
        {
            txt_Nome.Enabled = false;
            cb_Servico.Enabled = false;
            cb_Quarto.Enabled = false;
            txt_Quantidade.Enabled = false;
            txt_Valor.Enabled = false;
            btn_Hospede.Enabled = false;
        }
        private void limparDados()
        {
            txt_Nome.Text = "";
            txt_Quantidade.Text = "";
            txt_Valor.Text = "";
        }

        private void BuscarData()
        {
            con.conectar();
            strSql = "SELECT * FROM Novo_Servico WHERE Data = @Data ORDER BY Data DESC";
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
        private void frm_Servicos_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
            Listar();
            dt_Buscar.Value = DateTime.Today;
            CarregarComboBoxServico();
            CarregarComboBoxQuartos();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            if (cb_Quarto.Text == "")
            {
                MessageBox.Show("Cadastre antes um quarto!");
                Close();
            }
            if (cb_Servico.Text == "")
            {
                MessageBox.Show("Cadastre antes um Serviço!");
                Close();
            }
            habilitarCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;           
            btn_Excluir.Enabled = false;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_Quantidade.Text == "0")
            {
                MessageBox.Show("É preciso inserir um valor acima de 0 para quantidade!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_Quantidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É preciso inserir um valor para quantidade!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            strSql = "INSERT INTO Novo_Servico (Hospede, Servico, Quarto, Quantidade, Valor, Funcionario, Data) VALUES (@Hospede, @Servico, @Quarto, @Quantidade, @Valor, @Funcionario, GETDATE())";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            con.conectar();
            cmd.Parameters.AddWithValue("@Hospede", txt_Nome.Text);
            cmd.Parameters.AddWithValue("@Servico", cb_Servico.Text);
            cmd.Parameters.AddWithValue("@Quarto", cb_Quarto.Text);
            cmd.Parameters.AddWithValue("@Quantidade", txt_Quantidade.Text);
            cmd.Parameters.AddWithValue("@Valor", Convert.ToDouble(txt_Valor.Text) * Convert.ToDouble(txt_Quantidade.Text));
            cmd.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);

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

            // Recupera o ultimo ID do Serviço
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmdRecuperar = new SqlCommand();
            SqlDataReader readerId;
            cmdRecuperar = new SqlCommand("Select top 1 * from Novo_Servico order by id_NovoServico DESC");

            cmdRecuperar.Connection = con.conectar();
            readerId = cmdRecuperar.ExecuteReader();

            if (readerId.HasRows)
            {

                while (readerId.Read())
                {
                    ultimoIdServico = Convert.ToString(readerId["id_NovoServico"]);
                }

                // Relacionar os itens com a venda
                con.conectar();
            }
            readerId.Close();

            // Salvar a venda na tabela de movimentações
            strSql = "INSERT INTO Movimentacoes (Tipo, Movimento, Valor, Funcionario, Data, id_Movimento) VALUES (@Tipo, @Movimento, @Valor, @Funcionario, GETDATE(), @id_Movimento)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd1 = new SqlCommand(strSql, sqlCon);

            con.conectar();
            cmd1.Parameters.AddWithValue("@Tipo", "Entrada");
            cmd1.Parameters.AddWithValue("@Movimento", "Serviço");
            cmd1.Parameters.AddWithValue("@Valor", Convert.ToDouble(txt_Quantidade.Text) * Convert.ToDouble(txt_Valor.Text));
            cmd1.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            cmd1.Parameters.AddWithValue("@id_Movimento", ultimoIdServico);

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



            MessageBox.Show("Serviço salvo com sucesso!", "Serviço Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            limparDados();
            desabilitarCampos();
            Listar();
        }

        private void btn_Hospede_Click(object sender, EventArgs e)
        {
            Program.chamadaHospedes = "hospedes";
            Cadastros.frm_Hospedes form = new Cadastros.frm_Hospedes();
            form.Show();
        }

        private void frm_NovoServicos_Activated(object sender, EventArgs e)
        {
            txt_Nome.Text = Program.nomeHospede;
        }

        private void cb_Servico_SelectedValueChanged(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand();

            SqlDataReader reader;


            cmd = new SqlCommand("Select * from Servicos where Nome = @Nome");
            cmd.Parameters.AddWithValue("@Nome", cb_Servico.Text);

            cmd.Connection = con.conectar();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                //Extraindo informações da consulta de login
                while (reader.Read())
                {
                    valorServico = Convert.ToString(reader["valor"]);
                }
                txt_Valor.Text = valorServico;
            }
            
            // Fechar conexao
            con.desconectar();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (Program.cargoUsuario == "Gerente")
            {
                strSql = "delete from Novo_Servico where id_NovoServico=@id_NovoServico";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.AddWithValue("@id_NovoServico", id);

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    var resultado = MessageBox.Show("Deseja excluir o serviço?", "Excluir Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        MessageBox.Show("Serviço excluido com sucesso!", "Serviço Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        btn_Novo.Enabled = true;
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
                // Exclusão da venda na tabela movimento
                con.conectar();
                strSql = "DELETE FROM Movimentacoes WHERE id_Movimento = @id_Movimento AND Movimento = @Movimento";
                sqlCon = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand(strSql, sqlCon);
                cmd.Parameters.AddWithValue("@id_Movimento", id);
                cmd.Parameters.AddWithValue("@Movimento", "Serviço");

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
                Listar();
            }
            else
            {
                MessageBox.Show("Somente um Gerente pode excluir um serviço!", "Não autorizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limparDados();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Relatorio.Enabled = true;
            btn_Excluir.Enabled = true;

            id = Grid.CurrentRow.Cells[0].Value.ToString();
            Program.idNovoServico = id;
        }

        private void btn_Relatorio_Click(object sender, EventArgs e)
        {
            Relatorios.frm_RelComprovanteServico form = new Relatorios.frm_RelComprovanteServico();
            form.Show();
            btn_Relatorio.Enabled = false;
        }
    }
}
