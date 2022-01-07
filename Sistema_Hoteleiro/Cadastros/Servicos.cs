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
    public partial class frm_Servicos : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        string id;

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_Servicos()
        {
            InitializeComponent();
        }
        // Formatar DataGridView
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Serviço";
            Grid.Columns[2].HeaderText = "Valor";

            // Formatação das colunas para moeda
            Grid.Columns[2].DefaultCellStyle.Format = "C2";
            // Ocultar coluna
            Grid.Columns[0].Visible = false;
            // Formatar o tamanho da coluna
            Grid.Columns[1].Width = 270;

        }
        // Codigo para listar cargos
        private void Listar()
        {
            adpt = new SqlDataAdapter("Select * from Servicos order by Nome", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            FormatarDG();
        }
        private void habilitarCampos()
        {
            txt_Nome.Enabled = true;
            txt_Valor.Enabled = true;
            txt_Nome.Focus();
        }
        private void desabilitarCampos()
        {
            txt_Nome.Enabled = false;
            txt_Valor.Enabled = false;
        }
        private void limparDados()
        {
            txt_Nome.Text = "";
            txt_Valor.Text = "";
        }

        private void frm_Servicos_Load(object sender, EventArgs e)
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
            // Codigo botão salvar
            strSql = "INSERT INTO Servicos (Nome, Valor) VALUES (@Nome, @Valor)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            con.conectar();
            comando.Parameters.AddWithValue("@Nome", txt_Nome.Text);
            comando.Parameters.AddWithValue("@Valor", txt_Valor.Text.Replace(",", "."));

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Serviço salvo com sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Editar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_Salvar.Enabled = false;
            habilitarCampos();

            // recuperar o valor do id
            id = Grid.CurrentRow.Cells[0].Value.ToString();
            txt_Nome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txt_Valor.Text = Grid.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome do serviço!", "Campo nome vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor do serviço!", "Campo valor vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Valor.Text = "";
                txt_Valor.Focus();
                return;
            }

            // codigo botao editar
            strSql = "UPDATE Servicos SET Nome=@Nome, Valor=@Valor WHERE id_Servico = @id_Servico";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            con.conectar();
            comando.Parameters.AddWithValue("@Nome", txt_Nome.Text);
            comando.Parameters.AddWithValue("@Valor", txt_Valor.Text.Replace(",", "."));
            comando.Parameters.AddWithValue("@id_Servico", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Serviço editado com sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            strSql = "DELETE FROM Servicos where id_Servico=@id_Servico";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@id_Servico", id);

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
        }
    }
}
