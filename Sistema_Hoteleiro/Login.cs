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
using static Sistema_Hoteleiro.Conexao;

namespace Sistema_Hoteleiro
{
    public partial class frm_Login : Form
    {
        Conexao con = new Conexao();
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;


        public frm_Login()
        {
            InitializeComponent();
            pnl_Login.Visible = false;
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            // Posiciona o painel de Login sempre ao centro do forms login
            // (this.Width / 2 - metade da largura, this.Heigth / 2 - metade da altura)
            pnl_Login.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);

            pnl_Login.Visible = true;
            // Alterando cor do botão ao passar o mouse sobre o mesmo
            btn_Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160);

            btn_Login.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }

        private void ChamarLogin()
        {
            // Validação de preenchimento dos campos Login e Senha
            if (txt_Usuario.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Usuário", "Campo usário vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Usuario.Text = "";
                txt_Usuario.Focus();
                return;
            }
            if (txt_Senha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Senha.", "Campo senha vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Senha.Text = "";
                txt_Senha.Focus();
                return;
            }
            // Codigo do Login
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand();
            
            SqlDataReader reader;


            cmd = new SqlCommand("Select * from Usuarios where Usuario = @Usuario and Senha = @Senha");
            cmd.Parameters.AddWithValue("@Usuario", txt_Usuario.Text);
            cmd.Parameters.AddWithValue("@Senha", txt_Senha.Text);

            cmd.Connection = con.conectar();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                //Extraindo informações da consulta de login
                while (reader.Read())
                {
                    Program.nomeUsuario = Convert.ToString(reader["Nome"]);
                    Program.cargoUsuario = Convert.ToString(reader["Cargo"]);
                }

                MessageBox.Show("Bem Vindo, " + Program.nomeUsuario + "", "Login Efetuado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Home form = new frm_Home();
                //this.Hide(); // fecha a tela usuario/login e direciona para tela Home
                Limpar();
                form.Show();
            }
            else
            {
                MessageBox.Show("Erro ao logar!", "Dados incorretos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Text = "";
                txt_Usuario.Focus();
                txt_Senha.Text = "";
            }
            // Fechar conexao
            con.desconectar();

        }

        private void Limpar()
        {
            txt_Usuario.Text = "";
            txt_Senha.Text = "";
            txt_Usuario.Focus();
        }

        private void frm_Login_Resize(object sender, EventArgs e)
        {
            // Reposicionamento do painel a cada vez que ocorrer o redimencionamento 
            pnl_Login.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
        }
    }
}
