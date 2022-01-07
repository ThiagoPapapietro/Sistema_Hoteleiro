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
    public partial class frm_RelComprovante : Form
    {
        public frm_RelComprovante()
        {
            InitializeComponent();
        }

        private void frm_RelComprovante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'athenasDataSet1.VendaPorId'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaPorIdTableAdapter.Fill(this.athenasDataSet1.VendaPorId, Convert.ToInt32(Program.idVenda));
            // TODO: esta linha de código carrega dados na tabela 'athenasDataSet1.Detalhes_Venda_Id'. Você pode movê-la ou removê-la conforme necessário.
            this.detalhes_Venda_IdTableAdapter.Fill(this.athenasDataSet1.Detalhes_Venda_Id, Convert.ToInt32(Program.idVenda));

            this.reportViewer1.RefreshReport();
        }
    }
}
