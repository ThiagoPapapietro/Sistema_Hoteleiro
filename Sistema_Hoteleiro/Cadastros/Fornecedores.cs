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
    public partial class frm_Fornecedores : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        string id;

        string sql;


        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;


        public frm_Fornecedores()
        {
            InitializeComponent();
            desabilitarCampos();
            btn_Salvar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        // Formatar DataGridView
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[2].HeaderText = "Endereco";
            Grid.Columns[3].HeaderText = "Telefone";

            Grid.Columns[0].Visible = false;
            Grid.Columns[1].Width = 200;
            Grid.Columns[2].Width = 180;
            Grid.Columns[3].Width = 180;
        }
        // Codigo para listar cargos
        private void Listar()
        {
            adpt = new SqlDataAdapter("Select * from Fornecedores order by Nome", strCon);
            sql = ("Select * from Fornecedores order by Nome");
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            FormatarDG();
        }

        private void BuscarNome()
        {
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            SqlCommand cmd;

            con.conectar();
            cmd = new SqlCommand("Select * from Fornecedores where Nome like @Nome order by Nome", sqlCon);
            cmd.Parameters.AddWithValue("@Nome", txt_PesquisarNome.Text + "%"); // A porcentagem é utilizado quando começa a digitar os caracteres ela auxilia na busca pelo nome mais proximo
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            FormatarDG(); 
        }

        private void habilitarCampos()
        {
            txt_Nome.Enabled = true;
            txt_Endereco.Enabled = true;
            msktxt_Telefone.Enabled = true;
            txt_Nome.Focus();
        }
        private void desabilitarCampos()
        {
            txt_Nome.Enabled = false;
            txt_Endereco.Enabled = false;
            msktxt_Telefone.Enabled = false;
        }
        private void limparDados()
        {
            txt_Nome.Text = "";
            txt_Endereco.Text = "";
            msktxt_Telefone.Text = "";
        }

        private void frm_Fornecedores_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if(txt_Nome.Text.ToString().Trim() == "")
            {
                txt_Nome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nome.Focus();
                return;
            }
            strSql = "insert into Fornecedores (Nome, Endereco, Telefone) values(@Nome, @Endereco, @Telefone)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Nome", txt_Nome.Text);
            comando.Parameters.AddWithValue("@Endereco", txt_Endereco.Text);
            comando.Parameters.AddWithValue("@Telefone", msktxt_Telefone.Text);

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
                con.desconectar();
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
            txt_Endereco.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            msktxt_Telefone.Text = Grid.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                txt_Nome.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nome.Focus();
                return;
            }
            strSql = "update Fornecedores set Nome=@Nome, Endereco=@Endereco, Telefone=@Telefone where id_Fornecedores = @id_Fornecedores";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Nome", txt_Nome.Text);
            comando.Parameters.AddWithValue("@Endereco", txt_Endereco.Text);
            comando.Parameters.AddWithValue("@Telefone", msktxt_Telefone.Text);
            comando.Parameters.AddWithValue("@id_Fornecedores", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro editado com sucesso!", "Dados Editados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            strSql = "delete from Fornecedores where id_Fornecedores=@id_Fornecedores";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@id_Fornecedores", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                var resultado = MessageBox.Show("Deseja excluir o registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Registro excluido com sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txt_Nome.Text = "";            
            desabilitarCampos();
            limparDados();
            Listar();
        }

        private void txt_PesquisarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }
    }
}

