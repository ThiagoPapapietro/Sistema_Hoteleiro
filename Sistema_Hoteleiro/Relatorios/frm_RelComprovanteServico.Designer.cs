
namespace Sistema_Hoteleiro.Relatorios
{
    partial class frm_RelComprovanteServico
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
            this.comprovanteServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athenasDataSet1 = new Sistema_Hoteleiro.AthenasDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comprovante_ServicoTableAdapter = new Sistema_Hoteleiro.AthenasDataSet1TableAdapters.Comprovante_ServicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.comprovanteServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // comprovanteServicoBindingSource
            // 
            this.comprovanteServicoBindingSource.DataMember = "Comprovante_Servico";
            this.comprovanteServicoBindingSource.DataSource = this.athenasDataSet1;
            // 
            // athenasDataSet1
            // 
            this.athenasDataSet1.DataSetName = "AthenasDataSet1";
            this.athenasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSComprovanteServico";
            reportDataSource1.Value = this.comprovanteServicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Hoteleiro.Relatorios.RelComprovanteServico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(751, 639);
            this.reportViewer1.TabIndex = 0;
            // 
            // comprovante_ServicoTableAdapter
            // 
            this.comprovante_ServicoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_RelComprovanteServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 639);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_RelComprovanteServico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprovante do Servico";
            this.Load += new System.EventHandler(this.frm_RelComprovanteServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comprovanteServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource comprovanteServicoBindingSource;
        private AthenasDataSet1 athenasDataSet1;
        private AthenasDataSet1TableAdapters.Comprovante_ServicoTableAdapter comprovante_ServicoTableAdapter;
    }
}