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
    public partial class frm_ListaFuncionarios : Form
    {
        public frm_ListaFuncionarios()
        {
            InitializeComponent();
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

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[2].HeaderText = "Data de Nascimento";
            Grid.Columns[3].HeaderText = "RG";
            Grid.Columns[4].HeaderText = "DataExpedição";
            Grid.Columns[5].HeaderText = "Orgão Emissor";
            Grid.Columns[6].HeaderText = "CPF";
            Grid.Columns[7].HeaderText = "Cargo";
            Grid.Columns[8].HeaderText = "Salario";
            Grid.Columns[9].HeaderText = "Sexo";
            Grid.Columns[10].HeaderText = "CEP";
            Grid.Columns[11].HeaderText = "Rua";
            Grid.Columns[12].HeaderText = "Numero";
            Grid.Columns[13].HeaderText = "Complemento";
            Grid.Columns[14].HeaderText = "Bairro";
            Grid.Columns[15].HeaderText = "Cidade";
            Grid.Columns[16].HeaderText = "Estado";
            Grid.Columns[17].HeaderText = "Telefone";
            Grid.Columns[18].HeaderText = "Celular";
            Grid.Columns[19].HeaderText = "Email";
            Grid.Columns[20].HeaderText = "Data";

            Grid.Columns[0].Visible = false;            
        }
        private void Listar()
        {
            adpt = new SqlDataAdapter("Select * from Funcionario order by Nome", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            FormatarDG();
        }



        private void frm_ListaFuncionarios_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
