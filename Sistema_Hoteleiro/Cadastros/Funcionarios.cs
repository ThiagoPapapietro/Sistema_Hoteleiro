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
    public partial class frm_Funcionarios : Form
    {
        // codigo de conexao com banco
        Conexao con = new Conexao();
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        string id;
        string CpfAntigo;

        public frm_Funcionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void CarregarComboBox()
        {
            adpt = new SqlDataAdapter("Select * from Cargos order by Cargo", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            cb_CargoFunc.DataSource = dt;
            cb_CargoFunc.ValueMember = "id_Cargo";
            cb_CargoFunc.DisplayMember = "Cargo";
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;
        private void habilitarCampos()
        {
            txt_NomeFunc.Enabled = true;
            msktxt_DataNascFunc.Enabled = true;
            msktxt_RgFunc.Enabled = true;
            msktxt_DataExpFunc.Enabled = true;
            cb_OrgEmissor.Enabled = true;
            msktxt_CpfFunc.Enabled = true;
            cb_CargoFunc.Enabled = true;
            txt_SalarioFunc.Enabled = true;
            cb_SexoFunc.Enabled = true;
            msktxt_CepFunc.Enabled = true;
            txt_RuaFunc.Enabled = true;
            txt_NumeroFunc.Enabled = true;
            txt_ComplFunc.Enabled = true;
            txt_BairroFunc.Enabled = true;
            txt_CidadeFunc.Enabled = true;
            cb_EstadoFunc.Enabled = true;
            msktxt_TelefoneFunc.Enabled = true;
            msktxt_CelularFunc.Enabled = true;
            txt_EmailFunc.Enabled = true;            
            txt_NomeFunc.Focus();
        }
        private void desabilitarCampos()
        {
            txt_NomeFunc.Enabled = false;
            msktxt_DataNascFunc.Enabled = false;
            msktxt_RgFunc.Enabled = false;
            msktxt_DataExpFunc.Enabled = false;
            cb_OrgEmissor.Enabled = false;
            msktxt_CpfFunc.Enabled = false;
            cb_CargoFunc.Enabled = false;
            txt_SalarioFunc.Enabled = false;
            cb_SexoFunc.Enabled = false;
            msktxt_CepFunc.Enabled = false;
            txt_RuaFunc.Enabled = false;
            txt_NumeroFunc.Enabled = false;
            txt_ComplFunc.Enabled = false;
            txt_BairroFunc.Enabled = false;
            txt_CidadeFunc.Enabled = false;
            cb_EstadoFunc.Enabled = false;
            msktxt_TelefoneFunc.Enabled = false;
            msktxt_CelularFunc.Enabled = false;
            txt_EmailFunc.Enabled = false;
        }
        private void limparDados()
        {
            txt_NomeFunc.Text = "";
            msktxt_DataNascFunc.Text = "";
            msktxt_RgFunc.Text = "";
            msktxt_DataExpFunc.Text = "";
            cb_OrgEmissor.Text = "";
            msktxt_CpfFunc.Text = "";
            cb_CargoFunc.Text = "";
            txt_SalarioFunc.Text = "";
            cb_SexoFunc.Text = "";
            msktxt_CepFunc.Text = "";
            txt_RuaFunc.Text = "";
            txt_NumeroFunc.Text = "";
            txt_ComplFunc.Text = "";
            txt_BairroFunc.Text = "";
            txt_CidadeFunc.Text = "";
            cb_EstadoFunc.Text = "";
            msktxt_TelefoneFunc.Text = "";
            msktxt_CelularFunc.Text = "";
            txt_EmailFunc.Text = "";
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (cb_CargoFunc.Text == "")
            {
                MessageBox.Show("Cadastre antes um cargo!");
                Close();
            }
            habilitarCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
        }

        // codigo botão Cadastrar dados funcionario
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            // Validação de preenchimento dos campos 
            if (txt_NomeFunc.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_NomeFunc.Text = "";
                txt_NomeFunc.Focus();
                return;
            }
            if (msktxt_DataNascFunc.Text == "  /  /")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msktxt_DataNascFunc.Focus();
                return;
            }
            if (msktxt_CpfFunc.Text == "   .   .   -")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msktxt_CpfFunc.Focus();
                return;
            }
            if (msktxt_RgFunc.Text == "  .   .   -")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msktxt_RgFunc.Focus();
                return;
            }
            if (msktxt_DataExpFunc.Text == "  /  /")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msktxt_DataExpFunc.Focus();
                return;
            }
            if (cb_OrgEmissor.Text == "")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_OrgEmissor.Focus();
                return;
            }
            if (cb_CargoFunc.Text == "")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_CargoFunc.Focus();
                return;
            }
            if (txt_SalarioFunc.Text == "")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SalarioFunc.Focus();
                return;
            }
            if (cb_SexoFunc.Text == "")
            {
                MessageBox.Show("Preencher os campos obrigatórios.");
                cb_SexoFunc.Focus();
                return;
            }
            if (msktxt_CepFunc.Text == "     -")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msktxt_CepFunc.Focus();
                return;
            }
            if (txt_RuaFunc.Text == "")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_RuaFunc.Focus();
                return;
            }
            if (txt_BairroFunc.Text == "")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_BairroFunc.Focus();
                return;
            }
            if (txt_CidadeFunc.Text == "")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_CidadeFunc.Focus();
                return;
            }
            if (cb_EstadoFunc.Text == "")
            {
                MessageBox.Show("Preencher os campos obrigatórios.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_EstadoFunc.Focus();
                return;
            }

            strSql = "insert into Funcionario (Nome, DataDeNasc, RG, DataExpedicao, OrgaoEmissor, CPF, Cargo, Salario, Sexo, CEP, Rua, Numero, Complemento, Bairro, Cidade, Estado, Tel_Res, Celular, Email, Data)" +
                "values (@Nome, @DataDeNasc, @RG, @DataExpedicao, @OrgaoEmissor, @CPF, @Cargo, @Salario, @Sexo, @CEP, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @Tel_Res, @Celular, @Email, GETDATE())";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Nome", txt_NomeFunc.Text);
            comando.Parameters.AddWithValue("@DataDeNasc",msktxt_DataNascFunc.Text );
            comando.Parameters.AddWithValue("@RG", msktxt_RgFunc.Text);
            comando.Parameters.AddWithValue("@DataExpedicao", msktxt_DataExpFunc.Text);
            comando.Parameters.AddWithValue("@OrgaoEmissor", cb_OrgEmissor.Text);
            comando.Parameters.AddWithValue("@CPF", msktxt_CpfFunc.Text);
            comando.Parameters.AddWithValue("@Cargo", cb_CargoFunc.Text);
            comando.Parameters.AddWithValue("@Salario", txt_SalarioFunc.Text);
            comando.Parameters.AddWithValue("@Sexo", cb_SexoFunc.Text);
            comando.Parameters.AddWithValue("@CEP", msktxt_CepFunc.Text);
            comando.Parameters.AddWithValue("@Rua", txt_RuaFunc.Text);
            comando.Parameters.AddWithValue("@Numero", txt_NumeroFunc.Text);
            comando.Parameters.AddWithValue("@Complemento", txt_ComplFunc.Text);
            comando.Parameters.AddWithValue("@Bairro", txt_BairroFunc.Text);
            comando.Parameters.AddWithValue("@Cidade", txt_CidadeFunc.Text );
            comando.Parameters.AddWithValue("@Estado", cb_EstadoFunc.Text);
            comando.Parameters.AddWithValue("@Tel_Res", msktxt_TelefoneFunc.Text);
            comando.Parameters.AddWithValue("@Celular", msktxt_CelularFunc.Text);
            comando.Parameters.AddWithValue("@Email", txt_EmailFunc.Text);

            // Verificação se o numero do CPF existe no BD
            SqlCommand cmdVerificar;

            cmdVerificar = new SqlCommand("Select * from Funcionario where CPF = @CPF", sqlCon);
            cmdVerificar.Parameters.AddWithValue("@CPF", msktxt_CpfFunc.Text);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmdVerificar;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Insira outro numero de CPF!", "CPF já registrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msktxt_CpfFunc.Text = "";
                msktxt_CpfFunc.Focus();
                return;
            }

            // Verificação se o numero do RG existe no BD
            SqlCommand cmdVerificarRg;

            cmdVerificarRg = new SqlCommand("Select * from Funcionario where RG = @RG", sqlCon);
            cmdVerificarRg.Parameters.AddWithValue("@RG", msktxt_RgFunc.Text);
            SqlDataAdapter adpt1 = new SqlDataAdapter();
            adpt.SelectCommand = cmdVerificarRg;
            DataTable dt1 = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Insira outro numero de RG!", "RG já registrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msktxt_RgFunc.Text = "";
                msktxt_RgFunc.Focus();
                return;
            }

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!", "Dados Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            limparDados();
            msktxt_Pesquisar.Enabled = true;
        }

        // codigo botão excluir dados funcionario
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            strSql = "delete from Funcionario where Nome=@Nome";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_NomeFunc.Text;

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
        }

        // codigo botão pesquisar dados funcionario
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {

            strSql = "select * from Funcionario where CPF=@pesquisa";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@pesquisa", msktxt_Pesquisar.Text);

            try
            {
                if (msktxt_Pesquisar.Text == string.Empty)
                {
                    MessageBox.Show("Campo pesquisa vazio. Digite um nome.");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();
                if(dr.HasRows==false)
                {
                    throw new Exception("Este Funcionario não está cadastrado.");
                }

                dr.Read();
                
                txt_NomeFunc.Text=Convert.ToString(dr["Nome"]);
                msktxt_DataNascFunc.Text = Convert.ToString(dr["DataDeNasc"]);
                msktxt_RgFunc.Text = Convert.ToString(dr["RG"]);
                msktxt_DataExpFunc.Text = Convert.ToString(dr["DataExpedicao"]);
                cb_OrgEmissor.Text = Convert.ToString(dr["OrgaoEmissor"]);
                msktxt_CpfFunc.Text = Convert.ToString(dr["CPF"]);
                cb_CargoFunc.Text = Convert.ToString(dr["Cargo"]);
                txt_SalarioFunc.Text = Convert.ToString(dr["Salario"]);
                cb_SexoFunc.Text = Convert.ToString(dr["Sexo"]);
                msktxt_CepFunc.Text = Convert.ToString(dr["CEP"]);
                txt_RuaFunc.Text = Convert.ToString(dr["Rua"]);
                txt_NumeroFunc.Text = Convert.ToString(dr["Numero"]);
                txt_ComplFunc.Text = Convert.ToString(dr["Complemento"]);
                txt_BairroFunc.Text = Convert.ToString(dr["Bairro"]);
                txt_CidadeFunc.Text = Convert.ToString(dr["Cidade"]);
                cb_EstadoFunc.Text = Convert.ToString(dr["Estado"]);
                msktxt_TelefoneFunc.Text = Convert.ToString(dr["Tel_Res"]);
                msktxt_CelularFunc.Text = Convert.ToString(dr["Celular"]);
                txt_EmailFunc.Text = Convert.ToString(dr["Email"]);

               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            //Limpar pesquisa apos o uso
            msktxt_Pesquisar.Clear();
            habilitarCampos();
            msktxt_CpfFunc.Enabled = false;
            btn_Editar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_Novo.Enabled = false;
        }


        // codigo botão atualizar dados funcionario
        private void btn_Editar_Click(object sender, EventArgs e)
        
        {               
            strSql = "update Funcionario set Nome=@Nome,DataDeNasc=@DataDeNasc, RG=@RG, DataExpedicao=@DataExpedicao, OrgaoEmissor=@OrgaoEmissor, CPF=@CPF, Cargo=@Cargo, Salario=@Salario, Sexo=@Sexo, CEP=@CEP, Rua=@Rua, Numero=@Numero, Complemento=@Complemento, Bairro=@Bairro, Cidade=@Cidade, Estado=@Estado, Tel_Res=@Tel_Res, Celular=@Celular, Email=@Email where CPF=@CPF";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Nome", txt_NomeFunc.Text);
            comando.Parameters.AddWithValue("@DataDeNasc", msktxt_DataNascFunc.Text);
            comando.Parameters.AddWithValue("@RG", msktxt_RgFunc.Text);
            comando.Parameters.AddWithValue("@DataExpedicao", msktxt_DataExpFunc.Text);
            comando.Parameters.AddWithValue("@OrgaoEmissor", cb_OrgEmissor.Text);
            comando.Parameters.AddWithValue("@CPF", msktxt_CpfFunc.Text);
            comando.Parameters.AddWithValue("@Cargo", cb_CargoFunc.Text);
            comando.Parameters.AddWithValue("@Salario", txt_SalarioFunc.Text);
            comando.Parameters.AddWithValue("@Sexo", cb_SexoFunc.Text);
            comando.Parameters.AddWithValue("@CEP", msktxt_CepFunc.Text);
            comando.Parameters.AddWithValue("@Rua", txt_RuaFunc.Text);
            comando.Parameters.AddWithValue("@Numero", txt_NumeroFunc.Text);
            comando.Parameters.AddWithValue("@Complemento", txt_ComplFunc.Text);
            comando.Parameters.AddWithValue("@Bairro", txt_BairroFunc.Text);
            comando.Parameters.AddWithValue("@Cidade", txt_CidadeFunc.Text);
            comando.Parameters.AddWithValue("@Estado", cb_EstadoFunc.Text);
            comando.Parameters.AddWithValue("@Tel_Res", msktxt_TelefoneFunc.Text);
            comando.Parameters.AddWithValue("@Celular", msktxt_CelularFunc.Text);
            comando.Parameters.AddWithValue("@Email", txt_EmailFunc.Text);
           
            {
                //SqlCommand cmdVerificar;

                //cmdVerificar = new SqlCommand("Select * from Funcionario where CPF = @CPF", sqlCon);
                //cmdVerificar.Parameters.AddWithValue("@CPF", msktxt_CpfFunc.Text);
                //SqlDataAdapter adpt = new SqlDataAdapter();
                //adpt.SelectCommand = cmdVerificar;
                //DataTable dt = new DataTable();
                //adpt.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                  //  MessageBox.Show("Insira outro numero de CPF!", "CPF já registrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //msktxt_CpfFunc.Text = "";
                    //msktxt_CpfFunc.Focus();
                    //return;
               // }
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
            habilitarCampos();
            msktxt_Pesquisar.Enabled = true;
            btn_Novo.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void frm_Funcionarios_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
        }
    }
}
