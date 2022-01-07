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
    public partial class frm_RelComprovanteServico : Form
    {
        public frm_RelComprovanteServico()
        {
            InitializeComponent();
        }

        private void frm_RelComprovanteServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'athenasDataSet1.Comprovante_Servico'. Você pode movê-la ou removê-la conforme necessário.
            this.comprovante_ServicoTableAdapter.Fill(this.athenasDataSet1.Comprovante_Servico, Convert.ToInt32(Program.idNovoServico));
            this.reportViewer1.RefreshReport();
        }
    }
}
