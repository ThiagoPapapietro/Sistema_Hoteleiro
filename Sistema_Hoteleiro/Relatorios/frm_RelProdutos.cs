using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Hoteleiro.Relatorios
{
    public partial class frm_RelProdutos : Form
    {
        public frm_RelProdutos()
        {
            InitializeComponent();
        }

        private void frm_RelProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'athenasDataSet1.ProdutosFornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosFornecedoresTableAdapter.Fill(this.athenasDataSet1.ProdutosFornecedores);
            // TODO: esta linha de código carrega dados na tabela 'athenasDataSet1.ProdutosFornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosFornecedoresTableAdapter.Fill(this.athenasDataSet1.ProdutosFornecedores);
            // TODO: esta linha de código carrega dados na tabela 'athenasDataSet1.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.athenasDataSet1.Produtos);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
