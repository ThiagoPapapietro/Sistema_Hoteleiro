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
    public partial class frm_Reservas : Form
    {
        // codigo de conexao com banco
        Conexao con = new Conexao();
        
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        string id;

        string valorQuarto;
        Int32 mes;
        Int32 diasMes;

        string dataPainel;
        double valorTotal;
        double diasReserva;
        string dataInicial;
        string dataFinal;
        string ultimoIdReserva;

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;
        public frm_Reservas()
        {
            InitializeComponent();
        }

        private void CarregarComboBox()
        {
            adpt = new SqlDataAdapter("Select * from Quartos order by Quarto", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            cb_Quarto.DataSource = dt;
            cb_Quarto.DisplayMember = "Quarto";
            desabilitarCampos();
        }

        private void FormatarDG()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Quarto";
            Grid.Columns[2].HeaderText = "Data";

            // Ocultar coluna
            Grid.Columns[0].Visible = false;
            Grid.Columns[3].Visible = false;
            Grid.Columns[4].Visible = false;
            //Grid.Columns[1].Width = 200;
        }
        // Codigo para listar cargos
        private void Listar()
        {
            con.conectar();
            strSql = ("Select * from Ocupacoes where id_Reserva = @id and Funcionario = @Funcionario order by Data");
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@id", "0");
            cmd.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            con.conectar();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }
        private void habilitarCampos()
        {
            cb_Quarto.Enabled = true;
            cb_Mes.Enabled = true;
            cb_Ano.Enabled = true;
            txt_Dias.Enabled = true;
            txt_Nome.Enabled = true;
            msktxt_Telefone.Enabled = true;
            txt_Valor.Enabled = true;
            btn_Remove.Enabled = true;
            cb_Quarto.Focus();
 
        }
        private void desabilitarCampos()
        {
            cb_Quarto.Enabled = false;
            cb_Mes.Enabled = false;
            cb_Ano.Enabled = false;
            txt_Dias.Enabled = false;
            txt_Nome.Enabled = false;
            msktxt_Telefone.Enabled = false;
            txt_Valor.Enabled = false;
            btn_Remove.Enabled = false;
   
        }
        private void limparDados()
        {
            txt_Dias.Text = "0";
            txt_Nome.Text = "";
            msktxt_Telefone.Text = "";
        }
        private void habilitarPanel()
        {
            panel1.Enabled = true;

            panel2.Enabled = true;

            panel3.Enabled = true;

            panel4.Enabled = true;

            panel5.Enabled = true;

            panel6.Enabled = true;

            panel7.Enabled = true;

            panel8.Enabled = true;

            panel9.Enabled = true;

            panel10.Enabled = true;

            panel11.Enabled = true;

            panel12.Enabled = true;

            panel13.Enabled = true;

            panel14.Enabled = true;

            panel15.Enabled = true;

            panel16.Enabled = true;

            panel17.Enabled = true;

            panel18.Enabled = true;

            panel19.Enabled = true;

            panel20.Enabled = true;

            panel21.Enabled = true;

            panel22.Enabled = true;

            panel23.Enabled = true;

            panel24.Enabled = true;

            panel25.Enabled = true;

            panel26.Enabled = true;

            panel27.Enabled = true;

            panel28.Enabled = true;

            panel29.Enabled = true;

            panel30.Enabled = true;

            panel31.Enabled = true;

        }
        private void desabilitarPanel()
        {
                panel1.Enabled = false;

                panel2.Enabled = false;

                panel3.Enabled = false;

                panel4.Enabled = false;

                panel5.Enabled = false;
           
                panel6.Enabled = false;
           
                panel7.Enabled = false;
            
                panel8.Enabled = false;
           
                panel9.Enabled = false;
           
                panel10.Enabled = false;
            
                panel11.Enabled = false;
            
                panel12.Enabled = false;
            
                panel13.Enabled = false;
            
                panel14.Enabled = false;
           
                panel15.Enabled = false;
           
                panel16.Enabled = false;
            
                panel17.Enabled = false;
            
                panel18.Enabled = false;
            
                panel19.Enabled = false;
            
                panel20.Enabled = false;
            
                panel21.Enabled = false;
           
                panel22.Enabled = false;
            
                panel23.Enabled = false;

                panel24.Enabled = false;

                panel25.Enabled = false;

                panel26.Enabled = false;

                panel27.Enabled = false;

                panel28.Enabled = false;

                panel29.Enabled = false;

                panel30.Enabled = false;

                panel31.Enabled = false;

        }
        private void limparOcupacoes()
        {
            
                panel1.BackColor = Color.LightGreen;
                panel1.Enabled = true;            
            
                panel2.BackColor = Color.LightGreen;
                panel2.Enabled = true;
           
                panel3.BackColor = Color.LightGreen;
                panel3.Enabled = true;
            
                panel4.BackColor = Color.LightGreen;
                panel4.Enabled = true;
           
                panel5.BackColor = Color.LightGreen;
                panel5.Enabled = true;
           
                panel6.BackColor = Color.LightGreen;
                panel6.Enabled = true;
            
                panel7.BackColor = Color.LightGreen;
                panel7.Enabled = true;
            
                panel8.BackColor = Color.LightGreen;
                panel8.Enabled = true;
            
                panel9.BackColor = Color.LightGreen;
                panel9.Enabled = true;
          
                panel10.BackColor = Color.LightGreen;
                panel10.Enabled = true;
           
                panel11.BackColor = Color.LightGreen;
                panel11.Enabled = true;
          
                panel12.BackColor = Color.LightGreen;
                panel12.Enabled = true;
          
                panel13.BackColor = Color.LightGreen;
                panel13.Enabled = true;
           
                panel14.BackColor = Color.LightGreen;
                panel14.Enabled = true;
           
                panel15.BackColor = Color.LightGreen;
                panel15.Enabled = true;
         
                panel16.BackColor = Color.LightGreen;
                panel16.Enabled = true;
           
                panel17.BackColor = Color.LightGreen;
                panel17.Enabled = true;
           
                panel18.BackColor = Color.LightGreen;
                panel18.Enabled = true;
            
                panel19.BackColor = Color.LightGreen;
                panel19.Enabled = true;
            
                panel20.BackColor = Color.LightGreen;
                panel20.Enabled = true;
            
                panel21.BackColor = Color.LightGreen;
                panel21.Enabled = true;
           
                panel22.BackColor = Color.LightGreen;
                panel22.Enabled = true;
           
                panel23.BackColor = Color.LightGreen;
                panel23.Enabled = true;
         
                panel24.BackColor = Color.LightGreen;
                panel24.Enabled = true;
           
                panel25.BackColor = Color.LightGreen;
                panel25.Enabled = true;
         
                panel26.BackColor = Color.LightGreen;
                panel26.Enabled = true;
         
                panel27.BackColor = Color.LightGreen;
                panel27.Enabled = true;
        
                panel28.BackColor = Color.LightGreen;
                panel28.Enabled = true;
          
                panel29.BackColor = Color.LightGreen;
                panel29.Enabled = true;
       
                panel30.BackColor = Color.LightGreen;
                panel30.Enabled = true;
          
                panel31.BackColor = Color.LightGreen;
                panel31.Enabled = true;
        }
        private void verificarOcupacoes() // arrumar Convert.ToDateTime(data) e o adpt.Fill(dt)
        {
            limparOcupacoes();
            string data;
            con.conectar();

            for (int i = 1; i <= diasMes; i += 1)
            {
                if (i < 10)
                {                    
                    data = 0 + i.ToString() + "/" + cb_Mes.Text + "/" + "2021";

                    //data = 0 + i.ToString() + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
                }
                else
                {
                    data = i + "/" + cb_Mes.Text + "/" + "2021";
                    
                    //data = i + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
                }


                strSql = "SELECT * FROM Ocupacoes WHERE Data = @Data and Quarto = @Quarto";
                sqlCon = new SqlConnection(strCon);

                cmd = new SqlCommand(strSql, sqlCon);
                cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(data)); // ERRO ao substituir o data pelo Convert.ToDateTime(data), ele não consegue converter para a data solicitada
                cmd.Parameters.AddWithValue("@Quarto", cb_Quarto.Text);
                SqlDataAdapter adpt = new SqlDataAdapter();
                adpt.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adpt.Fill(dt); // ele pede a conversão da data

                if (i == 1 && dt.Rows.Count > 0)
                {
                    panel1.BackColor = Color.Tomato;
                    panel1.Enabled = false;
                }
                if (i == 2 && dt.Rows.Count > 0)
                {
                    panel2.BackColor = Color.Tomato;
                    panel2.Enabled = false;
                }
                if (i == 3 && dt.Rows.Count > 0)
                {
                    panel3.BackColor = Color.Tomato;
                    panel3.Enabled = false;
                }
                if (i == 4 && dt.Rows.Count > 0)
                {
                    panel4.BackColor = Color.Tomato;
                    panel4.Enabled = false;
                }
                if (i == 5 && dt.Rows.Count > 0)
                {
                    panel5.BackColor = Color.Tomato;
                    panel5.Enabled = false;
                }
                if (i == 6 && dt.Rows.Count > 0)
                {
                    panel6.BackColor = Color.Tomato;
                    panel6.Enabled = false;
                }
                if (i == 7 && dt.Rows.Count > 0)
                {
                    panel7.BackColor = Color.Tomato;
                    panel7.Enabled = false;
                }
                if (i == 8 && dt.Rows.Count > 0)
                {
                    panel8.BackColor = Color.Tomato;
                    panel8.Enabled = false;
                }
                if (i == 9 && dt.Rows.Count > 0)
                {
                    panel9.BackColor = Color.Tomato;
                    panel9.Enabled = false;
                }
                if (i == 10 && dt.Rows.Count > 0)
                {
                    panel10.BackColor = Color.Tomato;
                    panel10.Enabled = false;
                }
                if (i == 11 && dt.Rows.Count > 0)
                {
                    panel11.BackColor = Color.Tomato;
                    panel11.Enabled = false;
                }
                if (i == 12 && dt.Rows.Count > 0)
                {
                    panel12.BackColor = Color.Tomato;
                    panel12.Enabled = false;
                }
                if (i == 13 && dt.Rows.Count > 0)
                {
                    panel13.BackColor = Color.Tomato;
                    panel13.Enabled = false;
                }
                if (i == 14 && dt.Rows.Count > 0)
                {
                    panel14.BackColor = Color.Tomato;
                    panel14.Enabled = false;
                }
                if (i == 15 && dt.Rows.Count > 0)
                {
                    panel15.BackColor = Color.Tomato;
                    panel15.Enabled = false;
                }
                if (i == 16 && dt.Rows.Count > 0)
                {
                    panel16.BackColor = Color.Tomato;
                    panel16.Enabled = false;
                }
                if (i == 17 && dt.Rows.Count > 0)
                {
                    panel17.BackColor = Color.Tomato;
                    panel17.Enabled = false;
                }
                if (i == 18 && dt.Rows.Count > 0)
                {
                    panel18.BackColor = Color.Tomato;
                    panel18.Enabled = false;
                }
                if (i == 19 && dt.Rows.Count > 0)
                {
                    panel19.BackColor = Color.Tomato;
                    panel19.Enabled = false;
                }
                if (i == 20 && dt.Rows.Count > 0)
                {
                    panel20.BackColor = Color.Tomato;
                    panel20.Enabled = false;
                }
                if (i == 21 && dt.Rows.Count > 0)
                {
                    panel21.BackColor = Color.Tomato;
                    panel21.Enabled = false;
                }
                if (i == 22 && dt.Rows.Count > 0)
                {
                    panel22.BackColor = Color.Tomato;
                    panel22.Enabled = false;
                }
                if (i == 23 && dt.Rows.Count > 0)
                {
                    panel23.BackColor = Color.Tomato;
                    panel23.Enabled = false;
                }
                if (i == 24 && dt.Rows.Count > 0)
                {
                    panel24.BackColor = Color.Tomato;
                    panel24.Enabled = false;
                }
                if (i == 25 && dt.Rows.Count > 0)
                {
                    panel25.BackColor = Color.Tomato;
                    panel25.Enabled = false;
                }
                if (i == 26 && dt.Rows.Count > 0)
                {
                    panel26.BackColor = Color.Tomato;
                    panel26.Enabled = false;
                }
                if (i == 27 && dt.Rows.Count > 0)
                {
                    panel27.BackColor = Color.Tomato;
                    panel27.Enabled = false;
                }
                if (i == 28 && dt.Rows.Count > 0)
                {
                    panel28.BackColor = Color.Tomato;
                    panel28.Enabled = false;
                }
                if (i == 29 && dt.Rows.Count > 0)
                {
                    panel29.BackColor = Color.Tomato;
                    panel29.Enabled = false;
                }
                if (i == 30 && dt.Rows.Count > 0)
                {
                    panel30.BackColor = Color.Tomato;
                    panel30.Enabled = false;
                }
                if (i == 31 && dt.Rows.Count > 0)
                {
                    panel31.BackColor = Color.Tomato;
                    panel31.Enabled = false;
                }
                con.desconectar();
            }
        }
        private void frm_Reservas_Load(object sender, EventArgs e)
        {
            
            int mes = DateTime.Now.Month;
            cb_Mes.Text = mes.ToString();
            int ano = DateTime.Now.Year;
            cb_Ano.Text = ano.ToString();
            CarregarComboBox();
            cb_Quarto.SelectedIndex = 0;
            desabilitarCampos();
            Listar();
            verificarDias31();
            verificarOcupacoes();

        }

        // Todas as vezes que a combobox de quarto for alterada para outro valor
        private void cb_Quarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            con.conectar();
            cmd = new SqlCommand("Select * from Quartos where Quarto = @Quarto");
            cmd.Parameters.AddWithValue("@Quarto", cb_Quarto.Text);

            cmd.Connection = con.conectar();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                //Extraindo informações da consulta de login
                while (reader.Read())
                {
                    valorQuarto = Convert.ToString(reader["valor"]);
                }
                txt_Valor.Text = valorQuarto;
            }
            // Fechar conexao
            con.desconectar();
            verificarOcupacoes();
        }

        private void cb_Mes_SelectedValueChanged(object sender, EventArgs e)
        {
            //mes = Convert.ToInt32(cb_Mes.Text);
            //verificarDias31();
            //verificarOcupacoes();
        }

        private void verificarDias31()
        {
            // Ajuste de dias conforme o mês
            if (cb_Mes.Text == "01" || cb_Mes.Text == "1")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = true;
                diasMes = 31;
            }
            if (cb_Mes.Text == "02" || cb_Mes.Text == "2")
            {
                panel29.Visible = false;
                panel30.Visible = false;
                panel31.Visible = false;
                diasMes = 28;
                // validação do dia 29 para anos bissexto
                if (cb_Ano.Text == "2024" || cb_Ano.Text == "2028" || cb_Ano.Text == "2032" || cb_Ano.Text == "2036" || cb_Ano.Text == "2040" || cb_Ano.Text == "2044" || cb_Ano.Text == "2048" || cb_Ano.Text == "2052" || cb_Ano.Text == "2056" || cb_Ano.Text == "2060" || cb_Ano.Text == "2064" || cb_Ano.Text == "2068" || cb_Ano.Text == "2072" || cb_Ano.Text == "2076" || cb_Ano.Text == "2080")
                {
                    panel29.Visible = true;
                    diasMes = 29;
                }
            }
            if (cb_Mes.Text == "03" || cb_Mes.Text == "3")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = true;
                diasMes = 31;
            }
            if (cb_Mes.Text == "04" || cb_Mes.Text == "4")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = false;
                diasMes = 30;
            }
            if (cb_Mes.Text == "05" || cb_Mes.Text == "5")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = true;
                diasMes = 31;
            }
            if (cb_Mes.Text == "06" || cb_Mes.Text == "6")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = false;
                diasMes = 30;
            }
            if (cb_Mes.Text == "07" || cb_Mes.Text == "7")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = true;
                diasMes = 31;
            }
            if (cb_Mes.Text == "08" || cb_Mes.Text == "8")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = true;
                diasMes = 31;
            }
            if (cb_Mes.Text == "09" || cb_Mes.Text == "9")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = false;
                diasMes = 30;
            }
            if (cb_Mes.Text == "10")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = true;
                diasMes = 31;
            }
            if (cb_Mes.Text == "11")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = false;
                diasMes = 30;
            }
            if (cb_Mes.Text == "12")
            {
                panel29.Visible = true;
                panel30.Visible = true;
                panel31.Visible = true;
                diasMes = 31;
            }
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            if (cb_Quarto.Text == "")
            {
                MessageBox.Show("Cadastre antes um quarto!", "Campo Quarto Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            habilitarCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;


        }

        private void cb_Ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificarDias31();
            verificarOcupacoes();
        }

        private void cb_Mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mes = Convert.ToInt32(cb_Mes.Text);
            verificarDias31();
            verificarOcupacoes();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_1.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_1.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }

            salvarOcupacao();
        }

        private void salvarOcupacao()
        {
            strSql = "insert into Ocupacoes (Quarto, Data, Funcionario) values (@Quarto, @Data ,@Funcionario)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Quarto", cb_Quarto.Text);
            comando.Parameters.AddWithValue("@Data", Convert.ToDateTime(dataPainel));
            comando.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);


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
            verificarOcupacoes();
            Listar();
            cb_Quarto.Enabled = false;
            AtualizarTotalReserva();
        }

        private void AtualizarTotalReserva()
        {
            diasReserva += 1;
            txt_Dias.Text = diasReserva.ToString();
            valorTotal = diasReserva * Convert.ToDouble(txt_Valor.Text);
            lbl_Total.Text = string.Format("{0:c2}", valorTotal);
        }

        private void AbaterTotalReserva()
        {
            diasReserva -= 1;
            txt_Dias.Text = diasReserva.ToString();
            valorTotal = diasReserva * Convert.ToDouble(txt_Valor.Text);
            lbl_Total.Text = string.Format("{0:c2}", valorTotal);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            con.conectar();
            strSql = "DELETE FROM Ocupacoes WHERE id= @id";
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
            con.desconectar();
            verificarOcupacoes();
            AbaterTotalReserva();
            Listar();
            
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Remove.Enabled = true;
            id = Grid.CurrentRow.Cells[0].Value.ToString();
        }

        private void lbl_1_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_1.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_1.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }

            salvarOcupacao();
        }

        private void lbl_2_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_2.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_2.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }

            salvarOcupacao();
        }

        private void lbl_3_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_3.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_3.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }

            salvarOcupacao();
        }

        private void lbl_4_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_4.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_4.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_5_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_5.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_5.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_6_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_6.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_6.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_7_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_7.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_7.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_8_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_8.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_8.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_9_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_9.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_9.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_10_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_10.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_10.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_11_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_11.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_11.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_12_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_12.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_12.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_13_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_13.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_13.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_14_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_14.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_14.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_15_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_15.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_15.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_16_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_16.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_16.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_17_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_17.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_17.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_18_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_18.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_18.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_19_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_19.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_19.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_20_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_20.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_20.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_21_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_21.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_21.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_22_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_22.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_22.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_23_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_23.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_23.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_24_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_24.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_24.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_25_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_25.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_25.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_26_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_26.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_26.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_27_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_27.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_27.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_28_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_28.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_28.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_29_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_29.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_29.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_30_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_30.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_30.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void lbl_31_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_31.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_31.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_2.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_2.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }

            salvarOcupacao();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_3.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_3.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }

            salvarOcupacao();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_4.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_4.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_5.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_5.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_6.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_6.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_7.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_7.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_8.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_8.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_9.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_9.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_10.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_10.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_11.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_11.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_12.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_12.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_13.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_13.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_14.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_14.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_15.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_15.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_16.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_16.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_17.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_17.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_18.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_18.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_19.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_19.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_20.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_20.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_21.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_21.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel22_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_22.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_22.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel23_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_23.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_23.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel24_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_24.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_24.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel25_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_25.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_25.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel26_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_26.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_26.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel27_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_27.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_27.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel28_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_28.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_28.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel29_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_29.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_29.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel30_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_30.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_30.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void panel31_Click(object sender, EventArgs e)
        {
            if (mes < 10)
            {
                dataPainel = lbl_31.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            else
            {
                dataPainel = lbl_31.Text + "/" + cb_Mes.Text + "/" + cb_Ano.Text;
            }
            salvarOcupacao();
        }

        private void frm_Reservas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (valorTotal != 0)
            {
                MessageBox.Show("A reserva possui datas selecionados, favor remover antes de sair ou salvar a reserva!", "Remover datas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
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

            if (valorTotal > 0)
            {
                dataInicial = Grid.Rows[0].Cells[2].Value.ToString();
                dataFinal = Grid.Rows[Grid.Rows.Count - 1].Cells[2].Value.ToString();

                var resultado = MessageBox.Show("Deseja confirmar a reserva nas datas do dia " + Convert.ToDateTime(dataInicial).ToString("dd/MM/yyyy") + " até o dia " + Convert.ToDateTime(dataFinal).ToString("dd/MM/yyyy") + " ?", "Confirmar Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)

                {
                    strSql = "insert into Reservas (Quarto, Entrada, Saida, Dias, Valor, Nome, Telefone, Data, Funcionario)" +
                                 "values (@Quarto, @Entrada, @Saida, @Dias, @Valor, @Nome, @Telefone, GETDATE(), @Funcionario)";

                    sqlCon = new SqlConnection(strCon);
                    SqlCommand comando = new SqlCommand(strSql, sqlCon);

                    comando.Parameters.AddWithValue("@Quarto", cb_Quarto.Text);
                    comando.Parameters.AddWithValue("@Entrada", Convert.ToDateTime(dataInicial));
                    comando.Parameters.AddWithValue("@Saida", Convert.ToDateTime(dataFinal)); //Convert.ToDateTime(dataFinal)
                    comando.Parameters.AddWithValue("@Dias", txt_Dias.Text);
                    comando.Parameters.AddWithValue("@Valor", valorTotal);
                    comando.Parameters.AddWithValue("@Nome", txt_Nome.Text);
                    comando.Parameters.AddWithValue("@Telefone", msktxt_Telefone.Text);
                    comando.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);

                    try
                    {
                        sqlCon.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Reserva efetuada com sucesso!", "Reserva efetuada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sqlCon.Close();
                    }

                    // Recupera o ultimo ID da reserva 
                    sqlCon = new SqlConnection(strCon);
                    SqlCommand cmdRecuperar = new SqlCommand();

                    SqlDataReader readerId;
                    cmdRecuperar = new SqlCommand("Select top 1 * from Reservas order by id DESC");

                    cmdRecuperar.Connection = con.conectar();
                    readerId = cmdRecuperar.ExecuteReader();

                    if (readerId.HasRows)
                    {

                        while (readerId.Read())
                        {
                            ultimoIdReserva = Convert.ToString(readerId["id"]);
                        }

                        
                    }
                    readerId.Close();
                    // Relacionar as ocupações com a reservas
                    con.conectar();

                    strSql = "UPDATE Ocupacoes SET id_Reserva = @id_Reserva WHERE id_Reserva = @id";
                    sqlCon = new SqlConnection(strCon);
                    SqlCommand cmd = new SqlCommand(strSql, sqlCon);
                    cmd.Parameters.AddWithValue("@id", "0");
                    cmd.Parameters.AddWithValue("@id_Reserva", ultimoIdReserva);

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
                    btn_Novo.Enabled = true;
                    btn_Salvar.Enabled = false;
                    limparDados();
                    desabilitarCampos();
                    Listar();
                    valorTotal = 0;
                    lbl_Total.Text = "0";
                    txt_Dias.Text = "0";
                    diasReserva = 0;
                }
            }
            else
            {
                MessageBox.Show("A reserva não possui datas!", "Reservas sem datas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}


