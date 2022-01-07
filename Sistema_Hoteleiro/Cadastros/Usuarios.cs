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
    public partial class frm_Usuarios : Form
    {
        // codigo de conexao com banco

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        string id;

        string UsuarioAntigo;

        // Formatar DataGridView
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[2].HeaderText = "Cargo";
            Grid.Columns[3].HeaderText = "Usuario";
            Grid.Columns[4].HeaderText = "Senha";
            Grid.Columns[5].HeaderText = "Data";

            Grid.Columns[0].Visible = false;
        }
        // Codigo para listar cargos
        private void Listar()
        {
            adpt = new SqlDataAdapter("Select * from Usuarios order by Nome", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            FormatarDG();
        }
        //Codigo para buscar o nome
        private void BuscarNome()
        {
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            SqlCommand cmd;

            cmd = new SqlCommand("Select * from Usuarios where Nome like @Nome order by Nome", sqlCon);
            cmd.Parameters.AddWithValue("@Nome", txt_PesquisarNome.Text + "%"); // A porcentagem é utilizado quando começa a digitar os caracteres ela auxilia na busca pelo nome mais proximo
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            FormatarDG();
        }
    
        private void CarregarComboBox()
        {
            adpt = new SqlDataAdapter("Select * from Cargos order by Cargo", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            cb_CargoFunc.DataSource = dt;
            //cb_CargoFunc.ValueMember = "id_Cargo";
            cb_CargoFunc.DisplayMember = "Cargo";
        }

        private void habilitarCampos()
        {
            txt_NomeFunc.Enabled = true;
            cb_CargoFunc.Enabled = true;
            txt_Usuario.Enabled = true;
            txt_Senha.Enabled = true;
            
            txt_NomeFunc.Focus();
        }
        private void desabilitarCampos()
        {
            txt_NomeFunc.Enabled = false;
            cb_CargoFunc.Enabled = false;
            txt_Usuario.Enabled = false;
            txt_Senha.Enabled = false;

        }
        private void limparDados()
        {
            txt_NomeFunc.Text = "";
            txt_Usuario.Text = "";
            txt_Senha.Text = "";

        }
        public frm_Usuarios()
        {
            InitializeComponent();
        }

        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
            CarregarComboBox();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            if (cb_CargoFunc.Text == "")
            {
                MessageBox.Show("Cadastre antes um cargo!");
                Close();
            }
            habilitarCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into Usuarios (Nome, Cargo, Usuario, Senha, Data)" +
    "values (@Nome, @Cargo, @Usuario, @Senha, GETDATE())";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Nome", txt_NomeFunc.Text);
            comando.Parameters.AddWithValue("@Cargo", cb_CargoFunc.Text);
            comando.Parameters.AddWithValue("@Usuario", txt_Usuario.Text);
            comando.Parameters.AddWithValue("@Senha", txt_Senha.Text);

            // Verificação se o nome do usuario existe no BD
            SqlCommand cmdVerificar;

            cmdVerificar = new SqlCommand("Select * from Usuarios where Usuario = @Usuario", sqlCon);
            cmdVerificar.Parameters.AddWithValue("@Usuario", txt_Usuario.Text);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmdVerificar;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Usuario já registrado!", "Usuario já registrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Text = "";
                txt_Usuario.Focus();
                return;
            }
            FormatarDG();

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!");
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
            txt_PesquisarNome.Enabled = true;
            Listar();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_NomeFunc.Text.ToString().Trim() == "")
            {
                txt_NomeFunc.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NomeFunc.Focus();
                return;
            }
            strSql = "update Usuarios set Nome=@Nome, Cargo=@Cargo, Usuario=@Usuario, Senha=@Senha where id_Usuario = @id_Usuario";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Nome", txt_NomeFunc.Text);
            comando.Parameters.AddWithValue("@Cargo", cb_CargoFunc.Text);
            comando.Parameters.AddWithValue("@Usuario", txt_Usuario.Text);
            comando.Parameters.AddWithValue("@Senha", txt_Senha.Text);

            comando.Parameters.AddWithValue("@id_Usuario", id);

            // Verificação se o usuario existe no BD
            if (txt_Usuario.Text != UsuarioAntigo)
            {
                SqlCommand cmdVerificar;

                cmdVerificar = new SqlCommand("Select * from Usuarios where Usuario = @Usuario", sqlCon);
                cmdVerificar.Parameters.AddWithValue("@Usuario", txt_Usuario.Text);
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = cmdVerificar;
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Insira outro nome de Usuario!", "Usuario já registrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Usuario.Text = "";
                    txt_Usuario.Focus();
                    return;
                }
            }

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro alterado com sucesso!");
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

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Editar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_Salvar.Enabled = false;
            habilitarCampos();

            id = Grid.CurrentRow.Cells[0].Value.ToString();
            txt_NomeFunc.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            cb_CargoFunc.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txt_Usuario.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            txt_Senha.Text = Grid.CurrentRow.Cells[4].Value.ToString();

            UsuarioAntigo= Grid.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            strSql = "delete from Usuarios where id_Usuario=@id_Usuario";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@id_Usuario", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                var resultado = MessageBox.Show("Deseja excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Registro excluido com sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Novo.Enabled = true;
                    btn_Editar.Enabled = false;
                    btn_Excluir.Enabled = false;
                    txt_NomeFunc.Text = "";
                    txt_NomeFunc.Enabled = false;
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
            Listar();
        }

        private void txt_PesquisarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }
    }
}
