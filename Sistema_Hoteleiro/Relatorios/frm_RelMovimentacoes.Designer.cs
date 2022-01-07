
namespace Sistema_Hoteleiro.Relatorios
{
    partial class frm_RelMovimentacoes
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
            this.movimentacoesPorDataeTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athenasDataSet1 = new Sistema_Hoteleiro.AthenasDataSet1();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_Final = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_Inicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.movimentacoesPorDataeTipoTableAdapter = new Sistema_Hoteleiro.AthenasDataSet1TableAdapters.MovimentacoesPorDataeTipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacoesPorDataeTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // movimentacoesPorDataeTipoBindingSource
            // 
            this.movimentacoesPorDataeTipoBindingSource.DataMember = "MovimentacoesPorDataeTipo";
            this.movimentacoesPorDataeTipoBindingSource.DataSource = this.athenasDataSet1;
            // 
            // athenasDataSet1
            // 
            this.athenasDataSet1.DataSetName = "AthenasDataSet1";
            this.athenasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cb_Tipo.Location = new System.Drawing.Point(131, 11);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_Tipo.TabIndex = 54;
            this.cb_Tipo.SelectedIndexChanged += new System.EventHandler(this.cb_Tipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tipo:";
            // 
            // dt_Final
            // 
            this.dt_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Final.Location = new System.Drawing.Point(564, 12);
            this.dt_Final.Name = "dt_Final";
            this.dt_Final.Size = new System.Drawing.Size(98, 20);
            this.dt_Final.TabIndex = 52;
            this.dt_Final.ValueChanged += new System.EventHandler(this.dt_Final_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Data Final:";
            // 
            // dt_Inicial
            // 
            this.dt_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Inicial.Location = new System.Drawing.Point(352, 12);
            this.dt_Inicial.Name = "dt_Inicial";
            this.dt_Inicial.Size = new System.Drawing.Size(98, 20);
            this.dt_Inicial.TabIndex = 50;
            this.dt_Inicial.ValueChanged += new System.EventHandler(this.dt_Inicial_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Data Inicial:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSMovimentacoes";
            reportDataSource1.Value = this.movimentacoesPorDataeTipoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Hoteleiro.Relatorios.RelMovimentacoes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(680, 444);
            this.reportViewer1.TabIndex = 55;
            // 
            // movimentacoesPorDataeTipoTableAdapter
            // 
            this.movimentacoesPorDataeTipoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_RelMovimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 496);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_Final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_Inicial);
            this.Controls.Add(this.label1);
            this.Name = "frm_RelMovimentacoes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Movimentações";
            this.Load += new System.EventHandler(this.frm_RelMovimentacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movimentacoesPorDataeTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_Final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_Inicial;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource movimentacoesPorDataeTipoBindingSource;
        private AthenasDataSet1 athenasDataSet1;
        private AthenasDataSet1TableAdapters.MovimentacoesPorDataeTipoTableAdapter movimentacoesPorDataeTipoTableAdapter;
    }
}