
namespace Sistema_Hoteleiro.Relatorios
{
    partial class frm_RelComprovante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vendaPorIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athenasDataSet1 = new Sistema_Hoteleiro.AthenasDataSet1();
            this.detalhesVendaIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vendaPorIdTableAdapter = new Sistema_Hoteleiro.AthenasDataSet1TableAdapters.VendaPorIdTableAdapter();
            this.detalhes_Venda_IdTableAdapter = new Sistema_Hoteleiro.AthenasDataSet1TableAdapters.Detalhes_Venda_IdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vendaPorIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesVendaIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendaPorIdBindingSource
            // 
            this.vendaPorIdBindingSource.DataMember = "VendaPorId";
            this.vendaPorIdBindingSource.DataSource = this.athenasDataSet1;
            // 
            // athenasDataSet1
            // 
            this.athenasDataSet1.DataSetName = "AthenasDataSet1";
            this.athenasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalhesVendaIdBindingSource
            // 
            this.detalhesVendaIdBindingSource.DataMember = "Detalhes_Venda_Id";
            this.detalhesVendaIdBindingSource.DataSource = this.athenasDataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vendaPorIdBindingSource;
            reportDataSource2.Name = "DSDetalhesVendas";
            reportDataSource2.Value = this.detalhesVendaIdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Hoteleiro.Relatorios.RelComprovante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(681, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // vendaPorIdTableAdapter
            // 
            this.vendaPorIdTableAdapter.ClearBeforeFill = true;
            // 
            // detalhes_Venda_IdTableAdapter
            // 
            this.detalhes_Venda_IdTableAdapter.ClearBeforeFill = true;
            // 
            // frm_RelComprovante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_RelComprovante";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprovante Venda";
            this.Load += new System.EventHandler(this.frm_RelComprovante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaPorIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesVendaIdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vendaPorIdBindingSource;
        private AthenasDataSet1 athenasDataSet1;
        private System.Windows.Forms.BindingSource detalhesVendaIdBindingSource;
        private AthenasDataSet1TableAdapters.VendaPorIdTableAdapter vendaPorIdTableAdapter;
        private AthenasDataSet1TableAdapters.Detalhes_Venda_IdTableAdapter detalhes_Venda_IdTableAdapter;
    }
}