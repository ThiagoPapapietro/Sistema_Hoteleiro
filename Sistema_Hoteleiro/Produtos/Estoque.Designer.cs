
namespace Sistema_Hoteleiro.Produtos
{
    partial class frm_Estoque
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
            this.lbl_Fornecedores = new System.Windows.Forms.Label();
            this.cb_Fornecedores = new System.Windows.Forms.ComboBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.txt_Produto = new System.Windows.Forms.TextBox();
            this.lbl_Produto = new System.Windows.Forms.Label();
            this.txt_Estoque = new System.Windows.Forms.TextBox();
            this.lbl_Estoque = new System.Windows.Forms.Label();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.btn_Produto = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Fornecedores
            // 
            this.lbl_Fornecedores.AutoSize = true;
            this.lbl_Fornecedores.Location = new System.Drawing.Point(274, 56);
            this.lbl_Fornecedores.Name = "lbl_Fornecedores";
            this.lbl_Fornecedores.Size = new System.Drawing.Size(64, 13);
            this.lbl_Fornecedores.TabIndex = 22;
            this.lbl_Fornecedores.Text = "Fornecedor:";
            // 
            // cb_Fornecedores
            // 
            this.cb_Fornecedores.FormattingEnabled = true;
            this.cb_Fornecedores.Location = new System.Drawing.Point(338, 52);
            this.cb_Fornecedores.Name = "cb_Fornecedores";
            this.cb_Fornecedores.Size = new System.Drawing.Size(153, 21);
            this.cb_Fornecedores.TabIndex = 21;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(409, 95);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(73, 20);
            this.txt_Valor.TabIndex = 20;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(369, 98);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_Valor.TabIndex = 19;
            this.lbl_Valor.Text = "Valor:";
            // 
            // txt_Produto
            // 
            this.txt_Produto.Enabled = false;
            this.txt_Produto.Location = new System.Drawing.Point(86, 56);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(134, 20);
            this.txt_Produto.TabIndex = 26;
            // 
            // lbl_Produto
            // 
            this.lbl_Produto.AutoSize = true;
            this.lbl_Produto.Location = new System.Drawing.Point(31, 59);
            this.lbl_Produto.Name = "lbl_Produto";
            this.lbl_Produto.Size = new System.Drawing.Size(47, 13);
            this.lbl_Produto.TabIndex = 25;
            this.lbl_Produto.Text = "Produto:";
            // 
            // txt_Estoque
            // 
            this.txt_Estoque.Enabled = false;
            this.txt_Estoque.Location = new System.Drawing.Point(86, 95);
            this.txt_Estoque.Name = "txt_Estoque";
            this.txt_Estoque.Size = new System.Drawing.Size(70, 20);
            this.txt_Estoque.TabIndex = 28;
            // 
            // lbl_Estoque
            // 
            this.lbl_Estoque.AutoSize = true;
            this.lbl_Estoque.Location = new System.Drawing.Point(31, 98);
            this.lbl_Estoque.Name = "lbl_Estoque";
            this.lbl_Estoque.Size = new System.Drawing.Size(49, 13);
            this.lbl_Estoque.TabIndex = 27;
            this.lbl_Estoque.Text = "Estoque:";
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(238, 95);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.txt_Quantidade.TabIndex = 30;
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Location = new System.Drawing.Point(173, 98);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(65, 13);
            this.lbl_Quantidade.TabIndex = 29;
            this.lbl_Quantidade.Text = "Quantidade:";
            // 
            // btn_Produto
            // 
            this.btn_Produto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Produto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produto.Location = new System.Drawing.Point(226, 54);
            this.btn_Produto.Name = "btn_Produto";
            this.btn_Produto.Size = new System.Drawing.Size(23, 23);
            this.btn_Produto.TabIndex = 31;
            this.btn_Produto.Text = "+";
            this.btn_Produto.UseVisualStyleBackColor = false;
            this.btn_Produto.Click += new System.EventHandler(this.btn_Produto_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(211, 148);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(95, 23);
            this.btn_Salvar.TabIndex = 109;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // frm_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 224);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Produto);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.txt_Estoque);
            this.Controls.Add(this.lbl_Estoque);
            this.Controls.Add(this.txt_Produto);
            this.Controls.Add(this.lbl_Produto);
            this.Controls.Add(this.lbl_Fornecedores);
            this.Controls.Add(this.cb_Fornecedores);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lbl_Valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Estoque";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Activated += new System.EventHandler(this.frm_Estoque_Activated);
            this.Load += new System.EventHandler(this.frm_Estoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Fornecedores;
        private System.Windows.Forms.ComboBox cb_Fornecedores;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.TextBox txt_Produto;
        private System.Windows.Forms.Label lbl_Produto;
        private System.Windows.Forms.TextBox txt_Estoque;
        private System.Windows.Forms.Label lbl_Estoque;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.Button btn_Produto;
        private System.Windows.Forms.Button btn_Salvar;
    }
}