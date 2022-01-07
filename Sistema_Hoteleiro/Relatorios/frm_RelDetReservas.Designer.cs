
namespace Sistema_Hoteleiro.Relatorios
{
    partial class frm_RelDetReservas
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
            this.detalhesReservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athenasDataSet1 = new Sistema_Hoteleiro.AthenasDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.detalhesReservasTableAdapter = new Sistema_Hoteleiro.AthenasDataSet1TableAdapters.detalhesReservasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesReservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // detalhesReservasBindingSource
            // 
            this.detalhesReservasBindingSource.DataMember = "detalhesReservas";
            this.detalhesReservasBindingSource.DataSource = this.athenasDataSet1;
            // 
            // athenasDataSet1
            // 
            this.athenasDataSet1.DataSetName = "AthenasDataSet1";
            this.athenasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsReservas";
            reportDataSource1.Value = this.detalhesReservasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Hoteleiro.Relatorios.RelDetReservas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(678, 496);
            this.reportViewer1.TabIndex = 0;
            // 
            // detalhesReservasTableAdapter
            // 
            this.detalhesReservasTableAdapter.ClearBeforeFill = true;
            // 
            // frm_RelDetReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 496);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_RelDetReservas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes Reservas";
            this.Load += new System.EventHandler(this.frm_RelDetReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalhesReservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource detalhesReservasBindingSource;
        private AthenasDataSet1 athenasDataSet1;
        private AthenasDataSet1TableAdapters.detalhesReservasTableAdapter detalhesReservasTableAdapter;
    }
}