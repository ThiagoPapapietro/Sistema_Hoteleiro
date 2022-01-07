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
    public partial class frm_Vendas : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable dt;
        SqlCommand cmd;
        string idVenda;
        string idDetVenda;
        string idProduto;
        string totalVenda;
        string ultimoIdVenda;
        string exclusaoVenda;

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_Vendas()
        {
            InitializeComponent();
        }

        // Formatar DataGridView vendas
        private void FormatarDGVendas()
        {
            Grid.Columns[0].HeaderText = "ID";
            Grid.Columns[1].HeaderText = "Valor Total";
            Grid.Columns[2].HeaderText = "Funcionario";
            Grid.Columns[3].HeaderText = "Status";
            Grid.Columns[4].HeaderText = "Data";

            // Formatação das colunas para moeda
            Grid.Columns[1].DefaultCellStyle.Format = "C2";

            // colunas ocultas
            Grid.Columns[0].Visible = false;
        }
        // Codigo para listar Vendas
        private void ListarVendas()
        {
            con.conectar();
            adpt = new SqlDataAdapter("SELECT * FROM Vendas order by Data asc", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDGVendas();
            grid_DetalhesVendas.Visible = false;
        }

        // Formatar DataGridView Detalhes Vendas
        private void FormatarDGDetalhesVendas()
        {
            grid_DetalhesVendas.Columns[0].HeaderText = "ID";
            grid_DetalhesVendas.Columns[1].HeaderText = "Código Venda";
            grid_DetalhesVendas.Columns[2].HeaderText = "Produto";
            grid_DetalhesVendas.Columns[3].HeaderText = "Quantidade";
            grid_DetalhesVendas.Columns[4].HeaderText = "Valor Unitário";
            grid_DetalhesVendas.Columns[5].HeaderText = "Valor Total";
            grid_DetalhesVendas.Columns[6].HeaderText = "Funcionário";
            grid_DetalhesVendas.Columns[7].HeaderText = "Id Produto";


            // Formatação das colunas para moeda
            grid_DetalhesVendas.Columns[4].DefaultCellStyle.Format = "C2";
            grid_DetalhesVendas.Columns[5].DefaultCellStyle.Format = "C2";

            // colunas ocultas
            grid_DetalhesVendas.Columns[0].Visible = false;
            grid_DetalhesVendas.Columns[1].Visible = false;
            grid_DetalhesVendas.Columns[7].Visible = false;
        }
        // Codigo para listar Detalhes Vendas
        private void ListarDetalhesVendas()
        {
            con.conectar();
            strSql="SELECT * FROM Detalhes_Venda WHERE id_Venda = @id_Venda AND Funcionario = @Funcionario";
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@id_Venda", "0");
            cmd.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            con.conectar();
            adpt.Fill(dt);
            grid_DetalhesVendas.DataSource = dt;
            con.desconectar();

            FormatarDGDetalhesVendas();
            grid_DetalhesVendas.Visible = true;
        }

        private void habilitarCampos()
        {
            txt_Quantidade.Enabled = true;
            btn_Produto.Enabled = true;
            btn_Add.Enabled = true;
            btn_Remove.Enabled = true;
            txt_Quantidade.Focus();
        }
        private void desabilitarCampos()
        {
            txt_Produto.Enabled = false;
            txt_Estoque.Enabled = false;
            txt_Quantidade.Enabled = false;
            txt_Valor.Enabled = false;
            btn_Produto.Enabled = false;
            btn_Add.Enabled = false;
            btn_Remove.Enabled = false;
        }
        private void limparDados()
        {
            txt_Produto.Text = "";
            txt_Estoque.Text = "";
            txt_Quantidade.Text = "";
            txt_Valor.Text = "";
            lbl_Total.Text = "0";
        }

        private void BuscarData()
        {
            con.conectar();
            strSql = "SELECT * FROM Vendas WHERE Data = @Data ORDER BY Data DESC";
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(dt_Buscar.Text));
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDGVendas();
        }


        private void frm_Vendas_Load(object sender, EventArgs e)
        {
            ListarVendas();
            desabilitarCampos();
            totalVenda = "0";
            btn_Fechar.Visible = false;
            dt_Buscar.Value = DateTime.Today;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (lbl_Total.Text == "0")
            {
                MessageBox.Show("É preciso inserir produto para venda!", "Venda sem produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            strSql = "INSERT INTO Vendas (Valor_Total, Funcionario, Status, Data) VALUES (@Valor_Total, @Funcionario, @Status, GETDATE())";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            con.conectar();
            cmd.Parameters.AddWithValue("@Valor_Total", Convert.ToDouble(totalVenda));
            cmd.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            cmd.Parameters.AddWithValue("@Status", "Efetuada");

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

            // Recupera o ultimo ID da venda **** Arrumar esse  ou o dataGRID
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmdRecuperar = new SqlCommand();

            SqlDataReader readerId;
            cmdRecuperar = new SqlCommand("Select top 1 * from Vendas order by id_Vendas DESC");

            cmdRecuperar.Connection = con.conectar();
            readerId = cmdRecuperar.ExecuteReader();

            if (readerId.HasRows)
            {

                while (readerId.Read())
                {
                    ultimoIdVenda = Convert.ToString(readerId["id_Vendas"]);
                }

                // Relacionar os itens com a venda
                con.conectar();
            }
            readerId.Close();

            // Salvar a venda na tabela de movimentações
            strSql = "INSERT INTO Movimentacoes (Tipo, Movimento, Valor, Funcionario, Data, id_Movimento) VALUES (@Tipo, @Movimento, @Valor, @Funcionario, GETDATE(), @id_Movimento)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd1 = new SqlCommand(strSql, sqlCon);

            con.conectar();
            cmd1.Parameters.AddWithValue("@Tipo", "Entrada");
            cmd1.Parameters.AddWithValue("@Movimento", "Venda");
            cmd1.Parameters.AddWithValue("@Valor", Convert.ToDouble(totalVenda));
            cmd1.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            cmd1.Parameters.AddWithValue("@id_Movimento", ultimoIdVenda);

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
            strSql = "UPDATE Detalhes_Venda SET id_Venda = @id_Venda WHERE id_Venda = @id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.AddWithValue("@id", "0");
            comando.Parameters.AddWithValue("@id_Venda", ultimoIdVenda);

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
            MessageBox.Show("Venda salva com sucesso!", "Venda Salao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_Novo.Enabled = true;
            btn_Salvar.Enabled = false;
            limparDados();
            desabilitarCampos();
            ListarVendas();
            totalVenda = "0";
        }
        // ao clicar no botao ao lado de textbox produto, ele ira abrir o form produto para adicionar a vendas
        private void btn_Produto_Click(object sender, EventArgs e)
        {
            Program.chamadaProdutos = "estoque";
            Produtos.frm_Produtos form = new Produtos.frm_Produtos();
            form.Show();
        }

        private void frm_Vendas_Activated(object sender, EventArgs e)
        {
            txt_Produto.Text = Program.nomeProduto;
            txt_Estoque.Text = Program.estoqueProduto;
            txt_Valor.Text = Program.valorProduto;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Quantidade.Text == "")
            {
                MessageBox.Show("Preencha a quantidade!", "Campo quantidade vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Quantidade.Focus();
                return;
            }
            // Verificar se o valor inserido é maior que o estoque
            if (Convert.ToInt32(txt_Estoque.Text) < Convert.ToInt32(txt_Quantidade.Text)) 
            {
                MessageBox.Show("Não possui produtos suficiente em estoque!", "Estoque Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Quantidade.Focus();
                return;
            }
            // codigo botao salvar
            strSql = "INSERT INTO Detalhes_Venda (id_Venda, Produto, Quantidade, Valor_Unitario, Valor_Total, Funcionario, id_Produto) VALUES (@id_Venda, @Produto, @Quantidade, @Valor_Unitario, @Valor_Total, @Funcionario, @id_Produto)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            con.conectar();
            cmd.Parameters.AddWithValue("@id_Venda", "0");
            cmd.Parameters.AddWithValue("@Produto", txt_Produto.Text);
            cmd.Parameters.AddWithValue("@Quantidade", txt_Quantidade.Text);
            cmd.Parameters.AddWithValue("@Valor_Unitario", Convert.ToDouble(txt_Valor.Text)); //Convert.ToDouble converte o valor que antes era uma string para um valor Decimal
            cmd.Parameters.AddWithValue("@Valor_Total", Convert.ToDouble(txt_Valor.Text) * Convert.ToDouble(txt_Quantidade.Text));
            cmd.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            cmd.Parameters.AddWithValue("@id_Produto", Program.idProduto);

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
            // Abater quantidade estoque
            con.conectar();

            strSql = "UPDATE Produtos SET Estoque = @Estoque WHERE id_Produtos = @id_Produtos";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.AddWithValue("@id_Produtos", Program.idProduto);
            comando.Parameters.AddWithValue("@Estoque", Convert.ToInt32(txt_Estoque.Text) - Convert.ToInt32(txt_Quantidade.Text));

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

            // Totalizar a Venda
            double total;
            total = Convert.ToDouble(totalVenda) + Convert.ToDouble(txt_Valor.Text) * Convert.ToDouble(txt_Quantidade.Text);
            totalVenda = total.ToString();
            lbl_Total.Text = string.Format("{0:c2}", total);

            txt_Quantidade.Text = "";
            txt_Produto.Text = "";
            txt_Estoque.Text = "0";
            txt_Valor.Text = "";
            idDetVenda = "";
            ListarDetalhesVendas();
        }

        private void grid_DetalhesVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idDetVenda = grid_DetalhesVendas.CurrentRow.Cells[0].Value.ToString();
            txt_Produto.Text = grid_DetalhesVendas.CurrentRow.Cells[2].Value.ToString();
            txt_Quantidade.Text = grid_DetalhesVendas.CurrentRow.Cells[3].Value.ToString();
            txt_Valor.Text = grid_DetalhesVendas.CurrentRow.Cells[4].Value.ToString();
            idProduto = grid_DetalhesVendas.CurrentRow.Cells[7].Value.ToString();

            // Recuperar o total do estoque do produto
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand();

            SqlDataReader reader;
            cmd = new SqlCommand("Select * from Produtos where id_Produtos = @id_Produtos");
            cmd.Parameters.AddWithValue("@id_Produtos", idProduto);

            cmd.Connection = con.conectar();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                //Extraindo informações da consulta
                while (reader.Read())
                {
                    txt_Estoque.Text = Convert.ToString(reader["Estoque"]);
                }
            }
            reader.Close();
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (idDetVenda == "")
            {
                MessageBox.Show("Selecione um produto para remover!", "Remover produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Código botão remover produto da venda
            strSql = "DELETE FROM Detalhes_Venda WHERE id_DetalhesVendas = @id_DetalhesVendas";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            con.conectar();
            cmd.Parameters.AddWithValue("@id_DetalhesVendas", idDetVenda);
            
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
            // Devolver quantidade estoque
            con.conectar();

            strSql = "UPDATE Produtos SET Estoque = @Estoque WHERE id_Produtos = @id_Produtos";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.AddWithValue("@id_Produtos", idProduto);
            comando.Parameters.AddWithValue("@Estoque", Convert.ToInt32(txt_Estoque.Text) + Convert.ToInt32(txt_Quantidade.Text));

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

            // Totalizar a Venda
            double total;
            total = Convert.ToDouble(totalVenda) - Convert.ToDouble(txt_Valor.Text) * Convert.ToDouble(txt_Quantidade.Text);
            totalVenda = total.ToString();
            lbl_Total.Text = string.Format("{0:c2}", total);

            txt_Quantidade.Text = "";
            txt_Produto.Text = "";
            txt_Estoque.Text = "0";
            txt_Valor.Text = "";
            idDetVenda = "";
            btn_Fechar.Visible = false;

            if (exclusaoVenda == "1")
            {
                BuscarDetalhesVenda();
            }
            else
            {
                ListarDetalhesVendas();
            }
        }

        private void frm_Vendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (totalVenda != "0")
            {
                MessageBox.Show("A venda possui itens, favor remover antes de sair!", "Remover produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }           
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idVenda = Grid.CurrentRow.Cells[0].Value.ToString();
            Program.idVenda = Grid.CurrentRow.Cells[0].Value.ToString();
            totalVenda = Grid.CurrentRow.Cells[1].Value.ToString();
            lbl_Total.Text = string.Format("{0:c2}", totalVenda);
            BuscarDetalhesVenda();
            btn_Fechar.Visible = true;
            btn_Add.Enabled = true;
            btn_Remove.Enabled = true;
            btn_Excluir.Enabled = true;
            exclusaoVenda = "1";
            btn_Relatorio.Enabled = true;
        }

        private void BuscarDetalhesVenda()
        {
            con.conectar();
            strSql = "SELECT * FROM Detalhes_Venda WHERE id_Venda = @id_Venda";
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);
            cmd.Parameters.AddWithValue("@id_Venda", idVenda);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            cmd.Connection = con.conectar();
            adpt.Fill(dt);
            grid_DetalhesVendas.DataSource = dt;
            con.desconectar();

            FormatarDGDetalhesVendas();
            grid_DetalhesVendas.Visible = true;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            grid_DetalhesVendas.Visible = false;
            btn_Fechar.Visible = false;
            totalVenda = "0";
            lbl_Total.Text = "0";
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (totalVenda == "0")
            {
                strSql = "UPDATE Vendas SET Status = @Status WHERE id_Vendas=@id_Vendas";

                sqlCon = new SqlConnection(strCon);

                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.AddWithValue("@Status", "Cancelada");
                comando.Parameters.AddWithValue("@id_Vendas", idVenda);

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    var resultado = MessageBox.Show("Deseja realmente cancelar a venda?", "Cancelar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        MessageBox.Show("Venda cancelada com sucesso!", "Venda Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                btn_Novo.Enabled = true;
                btn_Excluir.Enabled = false;
                limparDados();
                desabilitarCampos();
                ListarVendas();
                totalVenda = "0";
                exclusaoVenda = "1";
                btn_Fechar.Visible = false;

                // Exclusão da venda na tabela movimento
                con.conectar();
                strSql = "DELETE FROM Movimentacoes WHERE id_Movimento = @id_Movimento AND Movimento = @Movimento";
                sqlCon = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand(strSql, sqlCon);
                cmd.Parameters.AddWithValue("@id_Movimento", idVenda);
                cmd.Parameters.AddWithValue("@Movimento", "Venda");

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
            }
            else
            {
                MessageBox.Show("É necessario excluir todos os itens da venda!", "Remover produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dt_Buscar_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void btn_Relatorio_Click(object sender, EventArgs e)
        {
            Relatorios.frm_RelComprovante form = new Relatorios.frm_RelComprovante();
            form.Show();
        }
    }
}
