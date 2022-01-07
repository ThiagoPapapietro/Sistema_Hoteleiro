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

namespace Sistema_Hoteleiro.Reservas
{
    public partial class frm_CheckIn : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable dt;
        SqlCommand cmd;

        string id;
        string pago;

        // necessario string strCon para  o banco no forms conexao
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_CheckIn()
        {
            InitializeComponent();
        }

        private void BuscarNome()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Nome like @Nome and Entrada = @Data and Status = @Status and Checkin = @Checkin order by Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dt_BuscarInicioReserva.Text));
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            cmd.Parameters.AddWithValue("@Checkin", "Não");
            cmd.Parameters.AddWithValue("@Nome", txt_BuscarNome.Text + "%");
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
            Grid.Columns[1].HeaderText = "Quarto";
            Grid.Columns[2].HeaderText = "Data Entrada";
            Grid.Columns[3].HeaderText = "Data Saída";
            Grid.Columns[4].HeaderText = "Dias";
            Grid.Columns[5].HeaderText = "Valor";
            Grid.Columns[6].HeaderText = "Nome";
            Grid.Columns[7].HeaderText = "Telefone";
            Grid.Columns[8].HeaderText = "Data";
            Grid.Columns[9].HeaderText = "Funcionario";
            Grid.Columns[10].HeaderText = "Status";
            Grid.Columns[11].HeaderText = "Check-In";
            Grid.Columns[12].HeaderText = "Check-Out";
            Grid.Columns[13].HeaderText = "Pago";

            // Ocultar coluna
            Grid.Columns[0].Visible = false;
            Grid.Columns[4].Visible = false;
            Grid.Columns[5].Visible = false;
            Grid.Columns[8].Visible = false;
            Grid.Columns[9].Visible = false;
            Grid.Columns[10].Visible = false;
            Grid.Columns[12].Visible = false;
            Grid.Columns[13].Visible = false;



        }
        // Codigo para listar
        private void ListarData()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Entrada = @Data and Status = @Status and Checkin = @Checkin order by Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dt_BuscarInicioReserva.Text));
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            cmd.Parameters.AddWithValue("@Checkin", "Não");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }

        private void frm_CheckIn_Load(object sender, EventArgs e)
        {
            ListarData();
            dt_BuscarInicioReserva.Value = DateTime.Today;
            btn_CkeckIn.Enabled = false;
        }

        private void dt_BuscarInicioReserva_ValueChanged(object sender, EventArgs e)
        {
            ListarData();
        }

        private void txt_BuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void btn_CkeckIn_Click(object sender, EventArgs e)
        {
            if(pago == "Sim")
            {
                strSql = "update Reservas set Checkin=@Checkin where id=@id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.AddWithValue("@Checkin", "Sim");
                comando.Parameters.AddWithValue("@id", id);
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
                MessageBox.Show("Check-In efetuado com sucesso!", "Check-In efetuado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarData();
                btn_CkeckIn.Enabled = false;
            }
            else
            {
                MessageBox.Show("É necessário confirmar antes o pagamento!", "Confirme antes o pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_CkeckIn.Enabled = false;
            }
        }

        private void Grid_Click(object sender, EventArgs e)
        {

        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_CkeckIn.Enabled = true;
            id = Grid.CurrentRow.Cells[0].Value.ToString();
            pago = Grid.CurrentRow.Cells[13].Value.ToString();
        }
    }
}
