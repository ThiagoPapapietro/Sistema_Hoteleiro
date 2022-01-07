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
    public partial class frm_MovimentacoesGerais : Form
    {
        public frm_MovimentacoesGerais()
        {
            InitializeComponent();
        }

        private void frm_MovimentacoesGerais_Load(object sender, EventArgs e)
        {
            dt_Inicial.Value = DateTime.Today;
            dt_Final.Value = DateTime.Today;
            BuscarData();
        }

        private void BuscarData()
        {
            // TODO: esta linha de código carrega dados na tabela 'athenasDataSet1.MovimentacoesGerais'. Você pode movê-la ou removê-la conforme necessário.
            this.movimentacoesGeraisTableAdapter.Fill(this.athenasDataSet1.MovimentacoesGerais, dt_Inicial.Text, dt_Final.Text);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", dt_Inicial.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", dt_Final.Text));
            this.reportViewer1.RefreshReport();
        }

        private void dt_Inicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void dt_Final_ValueChanged(object sender, EventArgs e)
        {
            BuscarData();
        }
    }
}
