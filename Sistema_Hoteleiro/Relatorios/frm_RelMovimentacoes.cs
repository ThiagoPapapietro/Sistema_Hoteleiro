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
    public partial class frm_RelMovimentacoes : Form
    {
        public frm_RelMovimentacoes()
        {
            InitializeComponent();
        }

        private void frm_RelMovimentacoes_Load(object sender, EventArgs e)
        {
            dt_Inicial.Value = DateTime.Today;
            dt_Final.Value = DateTime.Today;
            cb_Tipo.SelectedIndex = 0;
            BuscarData();           
        }

        private void BuscarData()
        {
            // TODO: esta linha de código carrega dados na tabela 'athenasDataSet1.movimentacoesPorDataeTipo'. Você pode movê-la ou removê-la conforme necessário.
            this.movimentacoesPorDataeTipoTableAdapter.Fill(this.athenasDataSet1.MovimentacoesPorDataeTipo, dt_Inicial.Text, dt_Final.Text, cb_Tipo.Text);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", dt_Inicial.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", dt_Final.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Tipo", cb_Tipo.Text));
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

        private void cb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarData();
        }
    }
}
