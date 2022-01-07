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

namespace Sistema_Hoteleiro
{
    public partial class frm_Home : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable dt;
        SqlCommand cmd;

        string id;
        Int32 totalReservaDia;
        Int32 totalQuartosDisponiveis;
        Int32 totalQuartosOcupados;
        Int32 totalQuartos;
        Int32 totalCheckin;
        Int32 totalCheckout;
        Int32 totalCheckinConfirmados;
        Int32 totalCheckoutConfirmados;
        string pago;
        string valor;


        // necessario string strCon para  o banco no forms conexao
        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_Home()
        {
            InitializeComponent();
        }


        private void FormatarDGCheckIn()
        {
            Grid1.Columns[0].HeaderText = "ID";
            Grid1.Columns[1].HeaderText = "Quarto";
            Grid1.Columns[2].HeaderText = "Data Entrada";
            Grid1.Columns[3].HeaderText = "Data Saída";
            Grid1.Columns[4].HeaderText = "Dias";
            Grid1.Columns[5].HeaderText = "Valor";
            Grid1.Columns[6].HeaderText = "Nome";
            Grid1.Columns[7].HeaderText = "Telefone";
            Grid1.Columns[8].HeaderText = "Data";
            Grid1.Columns[9].HeaderText = "Funcionario";
            Grid1.Columns[10].HeaderText = "Status";
            Grid1.Columns[11].HeaderText = "Check-In";
            Grid1.Columns[12].HeaderText = "Check-Out";
            Grid1.Columns[13].HeaderText = "Pago";

            // Ocultar coluna
            Grid1.Columns[0].Visible = false;
            Grid1.Columns[5].Visible = false;
            Grid1.Columns[8].Visible = false;
            Grid1.Columns[9].Visible = false;
            Grid1.Columns[10].Visible = false;
            Grid1.Columns[12].Visible = false;
            //Tamanho das colunas
            Grid1.Columns[1].Width = 50;
            Grid1.Columns[4].Width = 50;
            Grid1.Columns[11].Width = 60;
            Grid1.Columns[13].Width = 50;

        }
        // Codigo para listar 
        private void ListarCheckIn()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Entrada = @Data and Status = @Status and Checkin = @Checkin order by Quarto");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", DateTime.Today);
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            cmd.Parameters.AddWithValue("@Checkin", "Não");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid1.DataSource = dt;
            con.desconectar();

            FormatarDGCheckIn();
        }

        private void FormatarDGCheckOut()
        {
            Grid2.Columns[0].HeaderText = "ID";
            Grid2.Columns[1].HeaderText = "Quarto";
            Grid2.Columns[2].HeaderText = "Data Entrada";
            Grid2.Columns[3].HeaderText = "Data Saída";
            Grid2.Columns[4].HeaderText = "Dias";
            Grid2.Columns[5].HeaderText = "Valor";
            Grid2.Columns[6].HeaderText = "Nome";
            Grid2.Columns[7].HeaderText = "Telefone";
            Grid2.Columns[8].HeaderText = "Data";
            Grid2.Columns[9].HeaderText = "Funcionario";
            Grid2.Columns[10].HeaderText = "Status";
            Grid2.Columns[11].HeaderText = "Check-In";
            Grid2.Columns[12].HeaderText = "Check-Out";
            Grid2.Columns[13].HeaderText = "Pago";

            // Ocultar coluna
            Grid2.Columns[0].Visible = false;
            Grid2.Columns[5].Visible = false;
            Grid2.Columns[8].Visible = false;
            Grid2.Columns[9].Visible = false;
            Grid2.Columns[10].Visible = false;
            Grid2.Columns[11].Visible = false;
            Grid2.Columns[13].Visible = false;
            //Tamanho das colunas
            Grid2.Columns[1].Width = 50;
            Grid2.Columns[4].Width = 50;

        }
        // Codigo para listar cargos
        private void ListarCheckOut()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Saida = @Data and Status = @Status and Checkout = @Checkout order by Quarto");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", DateTime.Today);
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            cmd.Parameters.AddWithValue("@Checkout", "Não");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid2.DataSource = dt;
            con.desconectar();

            FormatarDGCheckOut();
        }
        private void frm_Home_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja fazer logout do sistema?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }

        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            pnl_Topo.BackColor = Color.FromArgb(213, 213, 213);
            pnl_Direito.BackColor = Color.FromArgb(120, 120, 120);

            lbl_Usuario.Text = Program.nomeUsuario;
            lbl_Cargo.Text = Program.cargoUsuario;

            lbl_Data.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss");

            VerificarNivelUsuario();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frm_Funcionarios form = new Cadastros.frm_Funcionarios();
            form.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frm_Cargos form = new Cadastros.frm_Cargos();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos.frm_Produtos form = new Produtos.frm_Produtos();
            form.Show();
        }

        private void novoProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.frm_Produtos form = new Produtos.frm_Produtos();
            form.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frm_ListaFuncionarios form = new Cadastros.frm_ListaFuncionarios();
            form.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frm_Usuarios form = new Cadastros.frm_Usuarios();
            form.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frm_Fornecedores form = new Cadastros.frm_Fornecedores();
            form.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.frm_Estoque form = new Produtos.frm_Estoque();
            form.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frm_Servicos form = new Cadastros.frm_Servicos();
            form.Show();
        }

        private void relatórioDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.frm_RelProdutos form = new Relatorios.frm_RelProdutos();
            form.Show();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.frm_Vendas form = new Movimentacoes.frm_Vendas();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movimentacoes.frm_Vendas form = new Movimentacoes.frm_Vendas();
            form.Show();
        }

        private void relatóriosDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.frm_RelVendas form = new Relatorios.frm_RelVendas();
            form.Show();
        }

        private void entradasESaídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.frm_Movimentacoes form = new Movimentacoes.frm_Movimentacoes();
            form.Show();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacoes.frm_Gastos form = new Movimentacoes.frm_Gastos();
            form.Show();
        }

        private void hóspedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frm_Hospedes form = new Cadastros.frm_Hospedes();
            form.Show();
        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frm_Quartos form = new Cadastros.frm_Quartos();
            form.Show();
        }

        private void novoServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Movimentacoes.frm_NovoServicos form = new Movimentacoes.frm_NovoServicos();
            form.Show();
        }

        private void relatórioDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.frm_RelServicos form = new Relatorios.frm_RelServicos();
            form.Show();
        }

        private void relatoriosDeEntradasESaídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.frm_RelMovimentacoes form = new Relatorios.frm_RelMovimentacoes();
            form.Show();
        }

        private void relatóriosDeMovimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.frm_MovimentacoesGerais form = new Relatorios.frm_MovimentacoesGerais();
            form.Show();
        }

        private void novaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas.frm_Reservas form = new Reservas.frm_Reservas();
            form.Show();
        }

        private void consultarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas.frm_ConsultarReservas form = new Reservas.frm_ConsultarReservas();
            form.Show();
        }

        private void novoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas.frm_CheckIn form = new Reservas.frm_CheckIn();
            form.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas.frm_CheckOut form = new Reservas.frm_CheckOut();
            form.Show();
        }

        private void estoqueBaixoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.frm_EstoqueBaixo form = new Produtos.frm_EstoqueBaixo();
            form.Show();
        }

        private void lbl_Estoque_Click(object sender, EventArgs e)
        {
            Produtos.frm_EstoqueBaixo form = new Produtos.frm_EstoqueBaixo();
            form.Show();
        }

        private void imgEstoque_Click(object sender, EventArgs e)
        {
            Produtos.frm_EstoqueBaixo form = new Produtos.frm_EstoqueBaixo();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void BuscarReservaDia()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Data = @Data and Status = @Status order by Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", DateTime.Today);
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            totalReservaDia = dt.Rows.Count;
            lbl_TotalReservas.Text = totalReservaDia.ToString();
            con.desconectar();
        }
        private void BuscarQuartosDisponiveis()
        {
            con.conectar();
            strSql = ("Select * from Ocupacoes where Data = @Data");
            cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", DateTime.Today);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            totalQuartosDisponiveis = dt.Rows.Count;

            // Buscar total de quartos
            con.conectar();
            strSql = "SELECT * FROM Quartos";
            cmd = new SqlCommand(strSql, sqlCon);

            SqlDataAdapter adpt2 = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt2 = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt2);
            totalQuartos = dt2.Rows.Count;
            double total;
            total = totalQuartos - totalQuartosDisponiveis;
            lbl_QuartosDisponiveis.Text = total.ToString();
            con.desconectar();
        }
        private void BuscarQuartosOcupados()
        {
            con.conectar();
            strSql = ("Select * from Ocupacoes where Data = @Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", DateTime.Today);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            totalQuartosOcupados = dt.Rows.Count;
            lbl_QuartosOcupados.Text = totalQuartosOcupados.ToString();
            con.desconectar();
        }

        private void BuscarTotalCheckin()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Entrada = @Data and Status = @Status order by Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", DateTime.Today);
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            totalCheckin = dt.Rows.Count;
            lbl_TotalCheckin.Text = totalCheckin.ToString();
            con.desconectar();
        }

        private void BuscarTotalCheckOut()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Saida = @Data and Status = @Status order by Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", DateTime.Today);
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            totalCheckout = dt.Rows.Count;
            lbl_TotalCheckout.Text = totalCheckout.ToString();
            con.desconectar();
        }

        private void BuscarTotalCheckinConfirmados()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Entrada = @Data and Status = @Status and Checkin = @Checkin");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", DateTime.Today);
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            cmd.Parameters.AddWithValue("@Checkin", "Sim");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            totalCheckinConfirmados = dt.Rows.Count;
            lbl_CheckinConfirmados.Text = totalCheckinConfirmados.ToString();
            con.desconectar();
        }

        private void BuscarTotalCheckoutConfirmados()
        {
            con.conectar();
            strSql = ("Select * from Reservas where Saida = @Data and Status = @Status and Checkout = @Checkout");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", DateTime.Today);
            cmd.Parameters.AddWithValue("@Status", "Confirmada");
            cmd.Parameters.AddWithValue("@Checkout", "Sim");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            totalCheckoutConfirmados = dt.Rows.Count;
            lbl_CheckoutConfirmados.Text = totalCheckoutConfirmados.ToString();
            con.desconectar();
        }

        private void VerificarEstoque()
        {
            con.conectar();
            strSql = ("Select * from Produtos where Estoque < @Estoque");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Estoque", 15);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lbl_Estoque.Text = "Estoque Baixo!";
                imgEstoque.Image = Properties.Resources.baixo;
            }
            else
            {
                lbl_Estoque.Text = "Estoque OK!";
                imgEstoque.Image = Properties.Resources.bom;
            }
            con.desconectar();
        }
        private void frm_Home_Activated(object sender, EventArgs e)
        {
            BuscarReservaDia();
            BuscarQuartosDisponiveis();
            BuscarQuartosOcupados();
            BuscarTotalCheckin();
            BuscarTotalCheckOut();
            BuscarTotalCheckinConfirmados();
            BuscarTotalCheckoutConfirmados();
            VerificarEstoque();
            ListarCheckIn();
            ListarCheckOut();
        }

        private void btn_ConsultarReservas_Click(object sender, EventArgs e)
        {
            Reservas.frm_ConsultarReservas form = new Reservas.frm_ConsultarReservas();
            form.Show();
        }

        private void btn_NovaReserva_Click(object sender, EventArgs e)
        {
            Reservas.frm_Reservas form = new Reservas.frm_Reservas();
            form.Show();
        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            Reservas.frm_CheckIn form = new Reservas.frm_CheckIn();
            form.Show();
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            Reservas.frm_CheckOut form = new Reservas.frm_CheckOut();
            form.Show();
        }

        private void btn_RelatorioMovimentacoes_Click(object sender, EventArgs e)
        {
            Relatorios.frm_MovimentacoesGerais form = new Relatorios.frm_MovimentacoesGerais();
            form.Show();
        }

        private void VerificarNivelUsuario()
        {
            if (lbl_Cargo.Text == "Gerente")
            {
                cargoToolStripMenuItem.Enabled = true;
                funcionáriosToolStripMenuItem.Enabled = true;
                quartosToolStripMenuItem.Enabled = true;
                serviçosToolStripMenuItem.Enabled = true;
                usuáriosToolStripMenuItem.Enabled = true;
                listaToolStripMenuItem.Enabled = true;
                entradasESaídasToolStripMenuItem.Enabled = true;
                gastosToolStripMenuItem.Enabled = true;
                Menu_Relatorios.Enabled = true;
            }
        }

        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_DgCkeckIn.Enabled = true;
            btn_Pago.Enabled = true;
            id = Grid1.CurrentRow.Cells[0].Value.ToString();
            valor = Grid1.CurrentRow.Cells[5].Value.ToString();
            pago = Grid1.CurrentRow.Cells[13].Value.ToString();
        }

        private void btn_DgCkeckIn_Click(object sender, EventArgs e)
        {
            if (pago == "Sim")
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
                ListarCheckIn();
                btn_DgCkeckIn.Enabled = false;
                btn_Pago.Enabled = false;
            }
            else
            {
                MessageBox.Show("É necessário confirmar antes o pagamento!", "Confirme antes o pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_DgCkeckIn.Enabled = false;
            }
        }

        private void Grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_DgCheckOut.Enabled = true;
            id = Grid2.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_DgCheckOut_Click(object sender, EventArgs e)
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
            ListarCheckOut();
            btn_DgCheckOut.Enabled = false;
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
            ListarCheckIn();
            btn_Pago.Enabled = false;
        }
    }
}
