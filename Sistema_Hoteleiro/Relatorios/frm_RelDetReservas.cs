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
    public partial class frm_RelDetReservas : Form
    {
        public frm_RelDetReservas()
        {
            InitializeComponent();
        }

        private void frm_RelDetReservas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'athenasDataSet1.detalhesReservas'. Você pode movê-la ou removê-la conforme necessário.
            this.detalhesReservasTableAdapter.Fill(this.athenasDataSet1.detalhesReservas, Convert.ToInt32(Program.idReserva));
            this.reportViewer1.RefreshReport();
        }
    }
}
