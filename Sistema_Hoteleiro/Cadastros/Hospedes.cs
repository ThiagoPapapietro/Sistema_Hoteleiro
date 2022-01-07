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
    public partial class frm_Hospedes : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable dt;
        SqlCommand cmd;

        string id;
        string cpfAntigo;

        // necessario string strCon para  o banco no forms conexao
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_Hospedes()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        private void BuscarNome()
        {
            con.conectar();
            strSql = "select * from Hospedes where Nome like @Nome order by Nome";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Nome", txt_BuscarNome.Text + "%"); // A porcentagem é utilizado para quando começar a digitar os caracteres ela auxilia na busca pelo nome mais proximo
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();

        }
        private void BuscarCPF()
        {
            strSql = "select * from Hospedes where CPF=@CPF order by Nome";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@CPF", msktxt_BuscarCpf.Text);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[2].HeaderText = "CPF";
            Grid.Columns[3].HeaderText = "Sexo";
            Grid.Columns[4].HeaderText = "Celular";
            Grid.Columns[5].HeaderText = "CEP";
            Grid.Columns[6].HeaderText = "Endereço";
            Grid.Columns[7].HeaderText = "Numero";
            Grid.Columns[8].HeaderText = "Bairro";
            Grid.Columns[9].HeaderText = "Cidade";
            Grid.Columns[10].HeaderText = "Estado";
            Grid.Columns[11].HeaderText = "Funcionário";
            Grid.Columns[12].HeaderText = "Data";

            // Ocultar coluna
            Grid.Columns[0].Visible = false;
            Grid.Columns[12].Visible = false;
        }
        // Codigo para listar cargos
        private void Listar()
        {
            con.conectar();
            adpt = new SqlDataAdapter("Select * from Hospedes order by Data desc", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }
        private void habilitarCampos()
        {
            txt_Nome.Enabled = true;
            msktxt_Cpf.Enabled = true;
            cb_Sexo.Enabled = true;
            msktxt_Celular.Enabled = true;
            msktxt_Cep.Enabled = true;
            txt_Endereco.Enabled = true;
            txt_Numero.Enabled = true;
            txt_Bairro.Enabled = true;
            txt_Cidade.Enabled = true;
            cb_Estado.Enabled = true;
            txt_Nome.Focus();
        }
        private void desabilitarCampos()
        {
            txt_Nome.Enabled = false;
            msktxt_Cpf.Enabled = false;
            cb_Sexo.Enabled = false;
            msktxt_Celular.Enabled = false;
            msktxt_Cep.Enabled = false;
            txt_Endereco.Enabled = false;
            txt_Numero.Enabled = false;
            txt_Bairro.Enabled = false;
            txt_Cidade.Enabled = false;
            cb_Estado.Enabled = false;
        }
        private void limparDados()
        {
            txt_Nome.Text = "";
            msktxt_Cpf.Text = "";
            cb_Sexo.Text = "";
            msktxt_Celular.Text = "";
            msktxt_Cep.Text = "";
            txt_Endereco.Text = "";
            txt_Numero.Text = "";
            txt_Bairro.Text = "";
            txt_Cidade.Text = "";
            cb_Estado.Text = "";
        }               

        private void frm_Hospedes_Load(object sender, EventArgs e)
        {
            Listar();
            rb_Nome.Checked = true;
        }

        private void rb_Nome_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = true;
            msktxt_BuscarCpf.Visible = false;
            txt_BuscarNome.Text = "";
            msktxt_BuscarCpf.Text = "";
        }

        private void rb_CPF_CheckedChanged(object sender, EventArgs e)
        {
            txt_BuscarNome.Visible = false;
            msktxt_BuscarCpf.Visible = true;
            txt_BuscarNome.Text = "";
            msktxt_BuscarCpf.Text = "";
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
            // Validação de preenchimento dos campos 
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher o Nome!", "Campo Nome Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }
            if (msktxt_Cpf.Text == "   .   .   -")
            {
                MessageBox.Show("Preencher o CPF!.", "Campo CPF Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msktxt_Cpf.Focus();
                return;
            }

            strSql = "insert into Hospedes (Nome, CPF, Sexo, Celular, CEP, Endereco, Numero, Bairro, Cidade, Estado, Funcionario, Data)" +
                                  "values (@Nome, @CPF, @Sexo, @Celular, @CEP, @Endereco, @Numero, @Bairro, @Cidade, @Estado,@Funcionario, GETDATE())";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Nome", txt_Nome.Text);
            comando.Parameters.AddWithValue("@CPF", msktxt_Cpf.Text);
            comando.Parameters.AddWithValue("@Sexo", cb_Sexo.Text);
            comando.Parameters.AddWithValue("@Celular", msktxt_Celular.Text);
            comando.Parameters.AddWithValue("@CEP", msktxt_Cep.Text);
            comando.Parameters.AddWithValue("@Endereco", txt_Endereco.Text);
            comando.Parameters.AddWithValue("@Numero", txt_Numero.Text);
            comando.Parameters.AddWithValue("@Bairro", txt_Bairro.Text);
            comando.Parameters.AddWithValue("@Cidade", txt_Cidade.Text);
            comando.Parameters.AddWithValue("@Estado", cb_Estado.Text);
            comando.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);

            // Verificação se o numero do CPF existe no BD
            SqlCommand cmdVerificar;

            cmdVerificar = new SqlCommand("Select * from Hospedes where CPF = @CPF", sqlCon);
            cmdVerificar.Parameters.AddWithValue("@CPF", msktxt_Cpf.Text);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmdVerificar;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Insira outro numero de CPF!", "CPF já registrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msktxt_Cpf.Text = "";
                msktxt_Cpf.Focus();
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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            // Validação de preenchimento dos campos 
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher o Nome!.", "Campo Nome Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }
            if (msktxt_Cpf.Text == "   .   .   -")
            {
                MessageBox.Show("Preencher o CPF!.", "Campo CPF Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msktxt_Cpf.Focus();
                return;
            }

            strSql = "update Hospedes set Nome=@Nome, CPF=@CPF, Sexo=@Sexo, Celular=@Celular, CEP=@CEP, Endereco=@Endereco, Numero=@Numero, Bairro=@Bairro, Cidade=@Cidade, Estado=@Estado, Funcionario=@Funcionario where id_Hospede=@id_Hospede";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Nome", txt_Nome.Text);
            comando.Parameters.AddWithValue("@CPF", msktxt_Cpf.Text);
            comando.Parameters.AddWithValue("@Sexo", cb_Sexo.Text);
            comando.Parameters.AddWithValue("@Celular", msktxt_Celular.Text);
            comando.Parameters.AddWithValue("@CEP", msktxt_Cep.Text);
            comando.Parameters.AddWithValue("@Endereco", txt_Endereco.Text);
            comando.Parameters.AddWithValue("@Numero", txt_Numero.Text);
            comando.Parameters.AddWithValue("@Bairro", txt_Bairro.Text);
            comando.Parameters.AddWithValue("@Cidade", txt_Cidade.Text);
            comando.Parameters.AddWithValue("@Estado", cb_Estado.Text);
            comando.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            comando.Parameters.AddWithValue("@id_Hospede", id);

            // verifica se o cpf existe no banco
            if (msktxt_Cpf.Text!= cpfAntigo)
            {
                SqlCommand cmdVerificar;

                cmdVerificar = new SqlCommand("Select * from Hospedes where CPF = @CPF", sqlCon);
                cmdVerificar.Parameters.AddWithValue("@CPF", msktxt_Cpf.Text);
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = cmdVerificar;
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                  MessageBox.Show("Insira outro numero de CPF!", "CPF já registrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msktxt_Cpf.Text = "";
                msktxt_Cpf.Focus();
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
            limparDados();
            desabilitarCampos();
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            strSql = "delete from Hospedes where id_Hospede=@id_Hospede";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.AddWithValue("@id_Hospede", id);

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
            btn_Editar.Enabled = true;
            btn_Excluir.Enabled = true;
            habilitarCampos();

            id = Grid.CurrentRow.Cells[0].Value.ToString();
            txt_Nome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            msktxt_Cpf.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            cb_Sexo.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            msktxt_Celular.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            msktxt_Cep.Text = Grid.CurrentRow.Cells[5].Value.ToString();
            txt_Endereco.Text = Grid.CurrentRow.Cells[6].Value.ToString();
            txt_Numero.Text = Grid.CurrentRow.Cells[7].Value.ToString();
            txt_Bairro.Text = Grid.CurrentRow.Cells[8].Value.ToString();
            txt_Cidade.Text = Grid.CurrentRow.Cells[9].Value.ToString();
            cb_Estado.Text = Grid.CurrentRow.Cells[10].Value.ToString();

            cpfAntigo = Grid.CurrentRow.Cells[2].Value.ToString();

        }

        private void msktxt_BuscarCpf_TextChanged(object sender, EventArgs e)
        {
            if (msktxt_BuscarCpf.Text == "   .   .   -")
            {
                Listar();
            }
            else
            {
                BuscarCPF();
            }
        }

        private void txt_BuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.chamadaHospedes == "hospedes")
            {
                Program.nomeHospede = Grid.CurrentRow.Cells[1].Value.ToString();
                Close();
            }
        }
    }
}
