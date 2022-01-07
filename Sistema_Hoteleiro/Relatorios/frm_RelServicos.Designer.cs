
namespace Sistema_Hoteleiro.Relatorios
{
    partial class frm_RelServicos
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
            this.servicosPorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athenasDataSet1 = new Sistema_Hoteleiro.AthenasDataSet1();
            this.dt_Final = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_Inicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.servicosPorDataTableAdapter = new Sistema_Hoteleiro.AthenasDataSet1TableAdapters.ServicosPorDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.servicosPorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // servicosPorDataBindingSource
            // 
            this.servicosPorDataBindingSource.DataMember = "ServicosPorData";
            this.servicosPorDataBindingSource.DataSource = this.athenasDataSet1;
            // 
            // athenasDataSet1
            // 
            this.athenasDataSet1.DataSetName = "AthenasDataSet1";
            this.athenasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dt_Final
            // 
            this.dt_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Final.Location = new System.Drawing.Point(558, 12);
            this.dt_Final.Name = "dt_Final";
            this.dt_Final.Size = new System.Drawing.Size(98, 20);
            this.dt_Final.TabIndex = 50;
            this.dt_Final.ValueChanged += new System.EventHandler(this.dt_Final_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Data Final:";
            // 
            // dt_Inicial
            // 
            this.dt_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Inicial.Location = new System.Drawing.Point(346, 12);
            this.dt_Inicial.Name = "dt_Inicial";
            this.dt_Inicial.Size = new System.Drawing.Size(98, 20);
            this.dt_Inicial.TabIndex = 48;
            this.dt_Inicial.ValueChanged += new System.EventHandler(this.dt_Inicial_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Data Inicial:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DS_Servicos";
            reportDataSource1.Value = this.servicosPorDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Hoteleiro.Relatorios.RelServicos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(694, 535);
            this.reportViewer1.TabIndex = 51;
            // 
            // servicosPorDataTableAdapter
            // 
            this.servicosPorDataTableAdapter.ClearBeforeFill = true;
            // 
            // frm_RelServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 590);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dt_Final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_Inicial);
            this.Controls.Add(this.label1);
            this.Name = "frm_RelServicos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Serviços";
            this.Load += new System.EventHandler(this.frm_RelServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicosPorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_Final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_Inicial;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource servicosPorDataBindingSource;
        private AthenasDataSet1 athenasDataSet1;
        private AthenasDataSet1TableAdapters.ServicosPorDataTableAdapter servicosPorDataTableAdapter;
    }
}