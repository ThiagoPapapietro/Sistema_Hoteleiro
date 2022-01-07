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

namespace Sistema_Hoteleiro.Produtos
{
    public partial class frm_EstoqueBaixo : Form
    {
        string foto;
        string alterou;

        Conexao con = new Conexao();
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        string id;

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        // Formatar DataGridView
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[2].HeaderText = "Descricao";
            Grid.Columns[3].HeaderText = "Valor Venda";
            Grid.Columns[4].HeaderText = "Valor Compra";
            Grid.Columns[5].HeaderText = "Estoque";
            Grid.Columns[6].HeaderText = "Fornecedor";
            Grid.Columns[7].HeaderText = "Data";
            Grid.Columns[8].HeaderText = "Imagem";
            Grid.Columns[9].HeaderText = "id Fornecedor";

            // Formatação das colunas para moeda
            Grid.Columns[3].DefaultCellStyle.Format = "C2";
            Grid.Columns[4].DefaultCellStyle.Format = "C2";

            // colunas ocultas
            Grid.Columns[0].Visible = false;
            Grid.Columns[7].Visible = false;
            Grid.Columns[8].Visible = false;
            Grid.Columns[9].Visible = false;
            // Tamanho das colunas
            //Grid.Columns[3].Width = 90;
            //Grid.Columns[4].Width = 95;
            //Grid.Columns[5].Width = 60;

        }
        // Codigo para listar
        private void Listar()
        {

            con.conectar();
            strSql = ("SELECT pro.id_Produtos, pro.Nome, pro.Descricao, pro.Valor_Venda, pro.Valor_Compra, pro.Estoque, forn.Nome, pro.Data, pro.Imagem, pro.Fornecedor FROM Produtos as pro INNER JOIN Fornecedores as forn ON pro.Fornecedor = forn.id_Fornecedores where Estoque < @Estoque order by pro.Nome");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Estoque", 15);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            FormatarDG();
            con.desconectar();

        }
        public frm_EstoqueBaixo()
        {
            InitializeComponent();
        }

        private void frm_EstoqueBaixo_Load(object sender, EventArgs e)
        {
            Listar();
        }


        private void frm_EstoqueBaixo_Activated(object sender, EventArgs e)
        {
            Listar();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.idProduto = Grid.CurrentRow.Cells[0].Value.ToString();
            Program.nomeProduto = Grid.CurrentRow.Cells[1].Value.ToString();
            Program.valorProduto = Grid.CurrentRow.Cells[3].Value.ToString();
            Program.estoqueProduto = Grid.CurrentRow.Cells[5].Value.ToString();
            Produtos.frm_Estoque form = new Produtos.frm_Estoque();
            form.Show();
        }
    }
}
