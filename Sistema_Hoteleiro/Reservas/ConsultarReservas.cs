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
    public partial class frm_ConsultarReservas : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable dt;
        SqlCommand cmd;

        string id;
        string valor;


        // necessario string strCon para  o banco no forms conexao
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_ConsultarReservas()
        {
            InitializeComponent();
        }

        private void ListarNome()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Nome like @Nome order by Data desc");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
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

            // tamanho das colunas
            Grid.Columns[1].Width = 50;
            Grid.Columns[4].Width = 50;
            Grid.Columns[5].Width = 73;
            Grid.Columns[11].Width = 60;
            Grid.Columns[12].Width = 65;
            Grid.Columns[13].Width = 50;
        }
        // Codigo para listar cargos
        private void ListarData()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Data = @Data and Status = @Status order by Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dt_BuscarReserva.Text));
            cmd.Parameters.AddWithValue("@Status", cb_Status.Text);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }
        private void ListarDataInicio()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Data = @Data and Status = @Status order by Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dt_BuscarInicioReserva.Text));
            cmd.Parameters.AddWithValue("@Status", cb_Status.Text);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }

        private void desabilitarBotoes()
        {
            btn_Pago.Enabled = false;
            Btn_Cancelar.Enabled = false;
            btn_Relatorio.Enabled = false;
        }
        private void habilitarBotoes()
        {
            btn_Pago.Enabled = true;
            Btn_Cancelar.Enabled = true;
            btn_Relatorio.Enabled = true;
        }
        private void frm_ConsultarReservas_Load(object sender, EventArgs e)
        {
            ListarData();
            dt_BuscarInicioReserva.Value = DateTime.Today;
            dt_BuscarReserva.Value = DateTime.Today;
            cb_Status.SelectedIndex = 0;
            desabilitarBotoes();
        }

        private void txt_BuscarNome_TextChanged(object sender, EventArgs e)
        {
            ListarNome();
        }

        private void dt_BuscarInicioReserva_ValueChanged(object sender, EventArgs e)
        {
            ListarDataInicio();
        }

        private void dt_BuscarReserva_ValueChanged(object sender, EventArgs e)
        {
            ListarData();
        }

        private void cb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarData();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotoes();
            id = Grid.CurrentRow.Cells[0].Value.ToString();
            valor = Grid.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_Pago_Click(object sender, EventArgs e)
        {
            strSql = "update Reservas set Pago=@Pago where id=@id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.AddWithValue("@Pago", "Sim");
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
            // Salvar valor da reserva na tabela de movimentações
            strSql = "INSERT INTO Movimentacoes (Tipo, Movimento, Valor, Funcionario, Data, id_Movimento) VALUES (@Tipo, @Movimento, @Valor, @Funcionario, GETDATE(), @id_Movimento)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd1 = new SqlCommand(strSql, sqlCon);

            con.conectar();
            cmd1.Parameters.AddWithValue("@Tipo", "Entrada");
            cmd1.Parameters.AddWithValue("@Movimento", "Reserva");
            cmd1.Parameters.AddWithValue("@Valor", Convert.ToDouble(valor));
            cmd1.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            cmd1.Parameters.AddWithValue("@id_Movimento", id);

            try
            {
                sqlCon.Open();
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            MessageBox.Show("Lançamento de valor efetuado!", "Efetuado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarData();
            desabilitarBotoes();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            strSql = "update Reservas set Status=@Status where id=@id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.AddWithValue("@Status", "Cancelada");
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
            MessageBox.Show("Reserva cancelada com sucesso!", "Reserva Cancelada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarData();
            desabilitarBotoes();
        }

        private void btn_Relatorio_Click(object sender, EventArgs e)
        {
            Program.idReserva = id;
            Relatorios.frm_RelDetReservas form = new Relatorios.frm_RelDetReservas();
            form.Show();
        }
    }
}
