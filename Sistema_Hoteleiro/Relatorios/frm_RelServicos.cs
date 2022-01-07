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
    public partial class frm_RelServicos : Form
    {
        public frm_RelServicos()
        {
            InitializeComponent();
        }

        private void frm_RelServicos_Load(object sender, EventArgs e)
        {
            dt_Inicial.Value = DateTime.Today;
            dt_Final.Value = DateTime.Today;
            BuscarPorData();
            //this.reportViewer1.RefreshReport();
        }

        private void BuscarPorData()
        {
            // TODO: esta linha de código carrega dados na tabela 'athenasDataSet1.ServicosPorData'. Você pode movê-la ou removê-la conforme necessário.
            this.servicosPorDataTableAdapter.Fill(this.athenasDataSet1.ServicosPorData, dt_Inicial.Text, dt_Final.Text);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataInicial", dt_Inicial.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", dt_Final.Text));
            this.reportViewer1.RefreshReport();
        }

        private void dt_Inicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarPorData();
        }

        private void dt_Final_ValueChanged(object sender, EventArgs e)
        {
            BuscarPorData();
        }
    }
}
