
namespace Sistema_Hoteleiro.Relatorios
{
    partial class frm_RelVendas
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
            this.vendasPorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athenasDataSet1 = new Sistema_Hoteleiro.AthenasDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dt_Inicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_Final = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.vendasPorDataTableAdapter = new Sistema_Hoteleiro.AthenasDataSet1TableAdapters.VendasPorDataTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.vendasPorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasPorDataBindingSource
            // 
            this.vendasPorDataBindingSource.DataMember = "VendasPorData";
            this.vendasPorDataBindingSource.DataSource = this.athenasDataSet1;
            // 
            // athenasDataSet1
            // 
            this.athenasDataSet1.DataSetName = "AthenasDataSet1";
            this.athenasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSVendasData";
            reportDataSource1.Value = this.vendasPorDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Hoteleiro.Relatorios.RelVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(680, 563);
            this.reportViewer1.TabIndex = 0;
            // 
            // dt_Inicial
            // 
            this.dt_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Inicial.Location = new System.Drawing.Point(359, 12);
            this.dt_Inicial.Name = "dt_Inicial";
            this.dt_Inicial.Size = new System.Drawing.Size(98, 20);
            this.dt_Inicial.TabIndex = 44;
            this.dt_Inicial.ValueChanged += new System.EventHandler(this.dt_Inicial_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Data Inicial:";
            // 
            // dt_Final
            // 
            this.dt_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Final.Location = new System.Drawing.Point(571, 12);
            this.dt_Final.Name = "dt_Final";
            this.dt_Final.Size = new System.Drawing.Size(98, 20);
            this.dt_Final.TabIndex = 46;
            this.dt_Final.ValueChanged += new System.EventHandler(this.dt_Final_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Data Final:";
            // 
            // vendasPorDataTableAdapter
            // 
            this.vendasPorDataTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Status:";
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "Efetuada",
            "Cancelada"});
            this.cmb_Status.Location = new System.Drawing.Point(138, 11);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(121, 21);
            this.cmb_Status.TabIndex = 48;
            this.cmb_Status.SelectedIndexChanged += new System.EventHandler(this.cmb_Status_SelectedIndexChanged);
            // 
            // frm_RelVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 606);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_Final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_Inicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_RelVendas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.frm_RelVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasPorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dt_Inicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_Final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource vendasPorDataBindingSource;
        private AthenasDataSet1 athenasDataSet1;
        private AthenasDataSet1TableAdapters.VendasPorDataTableAdapter vendasPorDataTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Status;
    }
}