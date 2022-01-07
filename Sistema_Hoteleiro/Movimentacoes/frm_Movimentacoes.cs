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
    public partial class frm_Movimentacoes : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable dt;
        SqlCommand cmd;

        double totalEntradas;
        double totalSaidas;
        // necessario string strCon para  o banco no forms conexao
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_Movimentacoes()
        {
            InitializeComponent();
        }

        private void frm_Movimentacoes_Load(object sender, EventArgs e)
        {
            cb_Buscar.SelectedIndex = 0;
            dt_Inicial.Value = DateTime.Today;
            dt_Final.Value = DateTime.Today;
            BuscarData();
        }

        private void Listar()
        {
            con.conectar();
            adpt = new SqlDataAdapter("SELECT * FROM Movimentacoes ORDER BY Data DESC", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }

        // Formatar DataGridView vendas
        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Tipo";
            Grid.Columns[2].HeaderText = "Movimento";
            Grid.Columns[3].HeaderText = "Valor";
            Grid.Columns[4].HeaderText = "Funcionário";
            Grid.Columns[5].HeaderText = "Data";
            Grid.Columns[6].HeaderText = "ID Movimento";


            // Formatação das colunas para moeda
            Grid.Columns[3].DefaultCellStyle.Format = "C2";

            // colunas ocultas
            Grid.Columns[0].Visible = false;
            Grid.Columns[6].Visible = false;

            TotalizarEntradas();
            TotalizarSaidas();
            Totalizar();
        }
        private void BuscarData()
        {
            con.conectar();
            if(cb_Buscar.Text == "Todos")
            {
                strSql = "SELECT * FROM Movimentacoes WHERE Data >= @DataInicial AND Data <= @DataFinal ORDER BY Data DESC";
                cmd = new SqlCommand(strSql, sqlCon);
            }
            else
            {
                strSql = "SELECT * FROM Movimentacoes WHERE Data >= @DataInicial AND Data <= @DataFinal AND Tipo = @Tipo ORDER BY Data DESC";
                cmd = new SqlCommand(strSql, sqlCon);
                cmd.Parameters.AddWithValue("@Tipo", cb_Buscar.Text);
            }
            cmd.Parameters.AddWithValue("@DataInicial", Convert.ToDateTime(dt_Inicial.Text));
            cmd.Parameters.AddWithValue("@DataFinal", Convert.ToDateTime(dt_Final.Text));
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }

        private void dt_Inicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void dt_Final_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void cb_Buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        // Codigo para mostrar o valor total
        private void Totalizar()
        {
            double total = 0;
            foreach (DataGridViewRow linha in Grid.Rows)
            {
                total = totalEntradas - totalSaidas; 
            }
            lbl_Total.Text = Convert.ToDouble(total).ToString("C2"); // "C2" para passar como moeda

            if (total >= 0)
            {
                lbl_Total.ForeColor = Color.Green;
            }
            else
            {
                lbl_Total.ForeColor = Color.Red;
            }
        }

        // Codigo para mostrar o valor total de entradas
        private void TotalizarEntradas()
        {
            double total = 0;
            foreach (DataGridViewRow linha in Grid.Rows)
            {
                if (linha.Cells["Tipo"].Value.ToString() == "Entrada")
                {
                    total += Convert.ToDouble(linha.Cells["Valor"].Value); // += vai incrementar na linha em que estiver passando para o campo valor
                }
            }
            totalEntradas = total;
            lbl_Entradas.Text = Convert.ToDouble(total).ToString("C2"); // "C2" para passar como moeda
        }

        // Codigo para mostrar o valor total de saídas

        private void TotalizarSaidas()
        {
            double total = 0;
            foreach (DataGridViewRow linha in Grid.Rows)
            {
                if (linha.Cells["Tipo"].Value.ToString() == "Saída")
                {
                    total += Convert.ToDouble(linha.Cells["Valor"].Value); // += vai incrementar na linha em que estiver passando para o campo valor
                }
            }
            totalSaidas = total;
            lbl_Saidas.Text = Convert.ToDouble(total).ToString("C2"); // "C2" para passar como moeda
        }
    }
}
