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
    public partial class frm_Estoque : Form
    {
        Conexao con = new Conexao();
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        string id;
        string ultimoIdGasto;

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Athenas;Data Source=DESKTOP-EPJFRJN\SQLEXPRESS";
        private string strSql = string.Empty;

        public frm_Estoque()
        {
            InitializeComponent();
        }
        private void CarregarComboBox()
        {
            adpt = new SqlDataAdapter("Select * from Fornecedores order by Nome", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            cb_Fornecedores.DataSource = dt;
            cb_Fornecedores.ValueMember = "id_Fornecedores";
            cb_Fornecedores.DisplayMember = "Nome";

            con.desconectar();
        }
        private void habilitarCampos()
        {
            //txt_Produto.Enabled = true;
            cb_Fornecedores.Enabled = true;
            //txt_Estoque.Enabled = true;
            txt_Quantidade.Enabled = true;
            txt_Valor.Enabled = true;
            txt_Quantidade.Focus();
            btn_Salvar.Enabled = true;
        }
        private void desabilitarCampos()
        {
            txt_Produto.Enabled = false;
            cb_Fornecedores.Enabled = false;
            txt_Estoque.Enabled = false;
            txt_Quantidade.Enabled = false;
            txt_Valor.Enabled = false;
            btn_Salvar.Enabled = false;
        }
        private void limparDados()
        {
            txt_Produto.Text = "";
            txt_Estoque.Text = "";
            txt_Quantidade.Text = "";
            txt_Valor.Text = "";
        }

        private void frm_Estoque_Load(object sender, EventArgs e)
        {
            habilitarCampos();
            CarregarComboBox();
        }

        // ao clicar no botao ao lado de textbox produto, ele ira abrir o form produto para adicionar a estoque
        private void btn_Produto_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparDados();
            Program.chamadaProdutos = "estoque";
            Produtos.frm_Produtos form = new Produtos.frm_Produtos();
            form.Show();
        }
        private void frm_Estoque_Activated(object sender, EventArgs e)
        {
            txt_Produto.Text = Program.nomeProduto;
            txt_Estoque.Text = Program.estoqueProduto;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_Produto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Selecione um produto!", "Campo produto vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Produto.Text = "";
                txt_Produto.Focus();
                return;
            }
            if (txt_Quantidade.Text == "")
            {
                MessageBox.Show("Preencha a quantidade do produto!", "Campo quantidade vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Quantidade.Focus();
                return;
            }

            // codigo botao editar os produtos
            strSql = "update Produtos set Fornecedor=@Fornecedor, Estoque=@Estoque, Valor_Compra=@Valor where id_Produtos = @id_Produtos";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            con.conectar();
            comando.Parameters.AddWithValue("@Fornecedor", cb_Fornecedores.SelectedValue);  // ele carrega um numero int e nao esta salvando o txt cargo vindo de outra tabela
            comando.Parameters.AddWithValue("@Estoque", Convert.ToDouble(txt_Quantidade.Text) + Convert.ToDouble(txt_Estoque.Text)); // Estoque vem a partir do txt.Quantidade // Convert.ToDouble()+Convert.ToDouble() utilizado para somar valores 
            comando.Parameters.AddWithValue("@Valor", txt_Valor.Text.Replace(",", "."));
            comando.Parameters.AddWithValue("@id_Produtos", Program.idProduto);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Lançamento realizado com sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            // Lançar o valor do pedido nos gastos
            strSql = "INSERT INTO Gastos (Descricao, Valor, Funcionario, Data) VALUES (@Descricao, @Valor, @Funcionario, GETDATE())";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(strSql, sqlCon);

            con.conectar();
            cmd.Parameters.AddWithValue("@Descricao", "Compra de Produtos");
            cmd.Parameters.AddWithValue("@Valor", Convert.ToDouble(txt_Valor.Text) * Convert.ToDouble(txt_Quantidade.Text));
            cmd.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);


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

            // Recupera o ultimo ID do gasto 
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmdRecuperar = new SqlCommand();

            SqlDataReader readerId;


            cmdRecuperar = new SqlCommand("Select top 1 * from Gastos order by id_Gastos DESC"); // top 1 * seria o equivalente ao LIMIT do MySql

            cmdRecuperar.Connection = con.conectar();
            readerId = cmdRecuperar.ExecuteReader();

            if (readerId.HasRows)
            {

                //Extraindo informações da consulta de login
                while (readerId.Read())
                {
                    ultimoIdGasto = Convert.ToString(readerId["id_Gastos"]);
                }

                // Relacionar os itens com a venda
                con.conectar();
            }
            readerId.Close();


            // Lançar o valor do pedido nas movimentações
            strSql = "INSERT INTO Movimentacoes (Tipo, Movimento, Valor, Funcionario, Data, id_Movimento) VALUES (@Tipo, @Movimento, @Valor, @Funcionario, GETDATE(), @id_Movimento)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand cmd1 = new SqlCommand(strSql, sqlCon);

            con.conectar();
            cmd1.Parameters.AddWithValue("@Tipo", "Saída");
            cmd1.Parameters.AddWithValue("@Movimento", "Gastos");
            cmd1.Parameters.AddWithValue("@Valor", Convert.ToDouble(txt_Valor.Text) * Convert.ToDouble(txt_Quantidade.Text));
            cmd1.Parameters.AddWithValue("@Funcionario", Program.nomeUsuario);
            cmd1.Parameters.AddWithValue("@id_Movimento", ultimoIdGasto);

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

            limparDados();
            desabilitarCampos();
        }
    }
}
