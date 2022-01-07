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
    public partial class frm_CheckOut : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable dt;
        SqlCommand cmd;

        string id;

        // necessario string strCon para  o banco no forms conexao
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;
        public frm_CheckOut()
        {
            InitializeComponent();
        }

        private void BuscarNome()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Nome like @Nome and Saida = @Data and Status = @Status and Checkout = @Checkout and Checkin = @Checkin order by Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dt_BuscarFinalReserva.Text));
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            cmd.Parameters.AddWithValue("@Checkout", "Não");
            cmd.Parameters.AddWithValue("@Nome", txt_BuscarNome.Text + "%");
            cmd.Parameters.AddWithValue("@Checkin", "Sim");

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
            Grid.Columns[11].Visible = false;
            Grid.Columns[13].Visible = false;

        }
        // Codigo para listar cargos
        private void ListarData()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Saida = @Data and Status = @Status and Checkout = @Checkout and Checkin = @Checkin order by Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dt_BuscarFinalReserva.Text));
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            cmd.Parameters.AddWithValue("@Checkout", "Não");
            cmd.Parameters.AddWithValue("@Checkin", "Sim");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }

        private void frm_CheckOut_Load(object sender, EventArgs e)
        {
            ListarData();
            dt_BuscarFinalReserva.Value = DateTime.Today;
            btn_CkeckOut.Enabled = false;
        }



        private void txt_BuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Grid_Click(object sender, EventArgs e)
        {
            btn_CkeckOut.Enabled = true;
            id = Grid.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_CkeckOut_Click(object sender, EventArgs e)
        {          
                strSql = "update Reservas set Checkout=@Checkout where id=@id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.AddWithValue("@Checkout", "Sim");
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

            strSql = "DELETE FROM Ocupacoes WHERE id_Reserva=@id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            MessageBox.Show("Check-Out efetuado com sucesso!", "Check-Out efetuado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarData();
                btn_CkeckOut.Enabled = false;
        }

        private void dt_BuscarFinalReserva_ValueChanged(object sender, EventArgs e)
        {
            ListarData();
        }
    }
}
