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
    public partial class frm_Cargos : Form
    {

        public frm_Cargos()
        {
            InitializeComponent();
            btn_Salvar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            Listar();
        }


        // codigo de conexao com banco
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        string id;

        // codigo limpar campo "Nome Cargo"
        private void limparDados()
        {
            txt_NomeCargo.Text = "";
        }

        // Formatar DataGridView
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Cargo";

            Grid.Columns[0].Visible = false;
            Grid.Columns[1].Width = 348;
        }
        // Codigo para listar cargos
        private void Listar()
        {
            adpt = new SqlDataAdapter("Select * from Cargos order by Cargo",strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            FormatarDG();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_NomeCargo.Enabled = true;
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            txt_NomeCargo.Focus();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_NomeCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome do cargo!", "Campo cargo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_NomeCargo.Text = "";
                txt_NomeCargo.Focus();
                return;
            }
            // Programando botão salvar
            strSql = "insert into Cargos (Cargo) values(@Cargo)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = txt_NomeCargo.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cargo salvo com sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Grid.Enabled = true;
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            txt_NomeCargo.Text = "";
            txt_NomeCargo.Enabled = false;
            Listar();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btn_Editar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_Salvar.Enabled = false;
        }

        // Codigo para botão editar cargo
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_NomeCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome do cargo!", "Campo cargo vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_NomeCargo.Text = "";
                txt_NomeCargo.Focus();
                return;
            }

            strSql = "UPDATE Cargos SET Cargo=@Cargo where id_Cargo = @id";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = txt_NomeCargo.Text;
            comando.Parameters.AddWithValue("@id", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cargo editado com sucesso!", "Dados editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Grid.Enabled = true;
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            txt_NomeCargo.Text = "";
            txt_NomeCargo.Enabled = false;
            Listar();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            strSql = "delete from Cargos where id_Cargo = @id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.AddWithValue("@id", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                var resultado = MessageBox.Show("Deseja excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Cargo excluido com sucesso!", "Cargo Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Novo.Enabled = true;
                    btn_Editar.Enabled = false;
                    btn_Excluir.Enabled = false;
                    txt_NomeCargo.Text = "";
                    txt_NomeCargo.Enabled = false;
                    Listar();
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
            limparDados();
            }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Editar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_Salvar.Enabled = false;
            txt_NomeCargo.Enabled = true;

            // recuperar o valor do id
            id = Grid.CurrentRow.Cells[0].Value.ToString();
            txt_NomeCargo.Text = Grid.CurrentRow.Cells[1].Value.ToString();

        }

        private void frm_Cargos_Load(object sender, EventArgs e)
        {

        }
    }
}


