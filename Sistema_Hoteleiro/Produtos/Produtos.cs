using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Hoteleiro.Produtos
{
    public partial class frm_Produtos : Form
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
            Grid.Columns[8].Visible = false;
            Grid.Columns[9].Visible = false;
            // Tamanho das colunas
            Grid.Columns[3].Width = 90;
            Grid.Columns[4].Width = 95;
            Grid.Columns[5].Width = 60;
            Grid.Columns[7].Width = 90;

        }
        // Codigo para listar
        private void Listar()
        {
            adpt = new SqlDataAdapter("SELECT pro.id_Produtos, pro.Nome, pro.Descricao, pro.Valor_Venda, pro.Valor_Compra, pro.Estoque, forn.Nome, pro.Data, pro.Imagem, pro.Fornecedor FROM Produtos as pro INNER JOIN Fornecedores as forn ON pro.Fornecedor = forn.id_Fornecedores order by pro.Nome", strCon);
            dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            FormatarDG();

            con.desconectar();
        }

        private void BuscarNome()
        {
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            SqlCommand cmd;

            con.conectar();
            cmd = new SqlCommand("SELECT pro.id_Produtos, pro.Nome, pro.Descricao, pro.Valor_Venda, pro.Valor_Compra, pro.Estoque, forn.Nome, pro.Data, pro.Imagem, pro.Fornecedor FROM Produtos as pro INNER JOIN Fornecedores as forn ON pro.Fornecedor = forn.id_Fornecedores where pro.Nome like @Nome order by pro.Nome", sqlCon);
            cmd.Parameters.AddWithValue("@Nome", txt_PesquisarNome.Text + "%"); // A porcentagem é utilizado quando começa a digitar os caracteres ela auxilia na busca pelo nome mais proximo
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            Grid.DataSource = dt;
            con.desconectar();

            FormatarDG();
        }
        private void habilitarCampos()
        {
            txt_Nome.Enabled = true;
            txt_Descricao.Enabled = true;
            txt_Valor.Enabled = true;
            //txt_Estoque.Enabled = true;
            cb_Fornecedores.Enabled = true;
            btn_imagem.Enabled = true;
            txt_Nome.Focus();
        }
        private void desabilitarCampos()
        {
            txt_Nome.Enabled = false;
            txt_Descricao.Enabled = false;
            txt_Valor.Enabled = false;
            txt_Estoque.Enabled = false;
            cb_Fornecedores.Enabled = false;
            btn_imagem.Enabled = false;
        }
        private void limparDados()
        {
            txt_Nome.Text = "";
            txt_Descricao.Text = "";
            txt_Valor.Text = "";
            txt_Estoque.Text = "";
            LimparFoto();
        }

        public frm_Produtos()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        // incluindo imagem da pasta Resources (não é necessario passar a extenção da imagem)
        private void LimparFoto()
        {
            pictureBox1.Image = Properties.Resources.sem_foto;
            foto = "img/sem-foto.jpg";
        }

        private void frm_Produtos_Load(object sender, EventArgs e)
        {
            LimparFoto();
            Listar();
            CarregarComboBox();
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            if (cb_Fornecedores.Text == "")
            {
                MessageBox.Show("Cadastre antes um Fornecedor!");
                Close();
            }
            habilitarCampos();
            btn_Salvar.Enabled = true;
            btn_Novo.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome do produto!", "Campo nome vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor do produto!", "Campo valor vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Valor.Text = "";
                txt_Valor.Focus();
                return;
            }
            // codigo botao salvar

            strSql = "insert into Produtos (Nome, Descricao, Valor_Venda, Fornecedor, Data, Imagem) values (@Nome, @Descricao, @Valor_Venda, @Fornecedor, GETDATE(), @Imagem)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            con.conectar();
            comando.Parameters.AddWithValue("@Nome", txt_Nome.Text);
            comando.Parameters.AddWithValue("@Descricao", txt_Descricao.Text);
            comando.Parameters.AddWithValue("@Valor_Venda", txt_Valor.Text.Replace(",", "."));
            comando.Parameters.AddWithValue("@Fornecedor", cb_Fornecedores.SelectedValue);
            comando.Parameters.AddWithValue("@Imagem", img());

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto salvo com sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o nome do produto!", "Campo nome vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Nome.Text = "";
                txt_Nome.Focus();
                return;
            }
            if (txt_Valor.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o valor do produto!", "Campo valor vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Valor.Text = "";
                txt_Valor.Focus();
                return;
            }

            // codigo botao editar
            con.conectar();
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);


            if (alterou == "1")
            {
                strSql = "update Produtos set Nome=@Nome, Descricao=@Descricao, Valor_Venda=@Valor_Venda, Fornecedor=@Fornecedor, Imagem=@Imagem where id_Produtos = @id_Produtos";
                comando.Parameters.AddWithValue("@Imagem", img());
            }
            else
            {
                strSql = "update Produtos set Nome=@Nome, Descricao=@Descricao, Valor_Venda=@Valor_Venda, Fornecedor=@Fornecedor where id_Produtos = @id_Produtos";
            }
            comando.Parameters.AddWithValue("@Nome", txt_Nome.Text);
            comando.Parameters.AddWithValue("@Descricao", txt_Descricao.Text);
            comando.Parameters.AddWithValue("@Valor_Venda", txt_Valor.Text.Replace(",", "."));
            comando.Parameters.AddWithValue("@Fornecedor", cb_Fornecedores.SelectedValue);  // ele carrega um numero int e nao esta salvando o txt cargo vindo de outra tabela
            comando.Parameters.AddWithValue("@id_Produtos", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto editado com sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btn_Editar.Enabled = false;
            btn_Excluir.Enabled = false;
            limparDados();
            desabilitarCampos();
            Listar();
            alterou = "";
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM Produtos where id_Produtos=@id_Produtos";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@id_Produtos", id);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                var resultado = MessageBox.Show("Deseja excluir o Produto?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Produto excluido com sucesso!", "Produto Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Novo.Enabled = true;
                    btn_Editar.Enabled = false;
                    btn_Excluir.Enabled = false;
                    txt_Nome.Text = "";
                    txt_Nome.Enabled = false;
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
            limparDados();
            Listar();
        }

        // codigo para fazer um upload de uma imagem para o sistema
        private void btn_imagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Arquivos de Imagens (*.jpg;*.png)|*.jpg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK) ;
            {
                foto = dialog.FileName.ToString();
                pictureBox1.ImageLocation = foto; //pictureBox1=img
                alterou = "1";
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Editar.Enabled = true;
            btn_Excluir.Enabled = true;
            btn_Salvar.Enabled = false;
            habilitarCampos();

            // recuperar o valor do id
            id = Grid.CurrentRow.Cells[0].Value.ToString();
            txt_Nome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txt_Descricao.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txt_Valor.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            txt_Estoque.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            cb_Fornecedores.Text = Grid.CurrentRow.Cells[5].Value.ToString();

            if(Grid.CurrentRow.Cells[8].Value != DBNull.Value)
            {
                // buscando um dado do Banco de dados de imagem
                byte[] imagem = (byte[])Grid.CurrentRow.Cells[8].Value;
                MemoryStream ms = new MemoryStream(imagem);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = Properties.Resources.sem_foto;
            }

        }

        private void txt_PesquisarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.chamadaProdutos == "estoque")
            {
                Program.idProduto = Grid.CurrentRow.Cells[0].Value.ToString();
                Program.nomeProduto = Grid.CurrentRow.Cells[1].Value.ToString();
                Program.valorProduto = Grid.CurrentRow.Cells[3].Value.ToString();
                Program.estoqueProduto = Grid.CurrentRow.Cells[5].Value.ToString();
                Close();
            }
        }

        // Metodo para enviar uma imagem para o banco de dados
       private byte[] img()// img=Img
        {
            byte[] imagem_byte = null;
            if (foto == "")
            {
                return null;
            }
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }
    }
}
