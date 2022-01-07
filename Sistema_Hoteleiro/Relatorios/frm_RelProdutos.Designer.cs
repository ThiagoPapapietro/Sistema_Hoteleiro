
namespace Sistema_Hoteleiro.Relatorios
{
    partial class frm_RelProdutos
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
            this.produtosFornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athenasDataSet1 = new Sistema_Hoteleiro.AthenasDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Sistema_Hoteleiro.AthenasDataSet1TableAdapters.ProdutosTableAdapter();
            this.produtosFornecedoresTableAdapter = new Sistema_Hoteleiro.AthenasDataSet1TableAdapters.ProdutosFornecedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.produtosFornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produtosFornecedoresBindingSource
            // 
            this.produtosFornecedoresBindingSource.DataMember = "ProdutosFornecedores";
            this.produtosFornecedoresBindingSource.DataSource = this.athenasDataSet1;
            // 
            // athenasDataSet1
            // 
            this.athenasDataSet1.DataSetName = "AthenasDataSet1";
            this.athenasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetProdutos";
            reportDataSource1.Value = this.produtosFornecedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Hoteleiro.Relatorios.RelProdutos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(659, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.athenasDataSet1;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // produtosFornecedoresTableAdapter
            // 
            this.produtosFornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // frm_RelProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_RelProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.frm_RelProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosFornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athenasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AthenasDataSet1 athenasDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private AthenasDataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource produtosFornecedoresBindingSource;
        private AthenasDataSet1TableAdapters.ProdutosFornecedoresTableAdapter produtosFornecedoresTableAdapter;
    }
}