
namespace Sistema_Hoteleiro.Cadastros
{
    partial class frm_Quartos
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
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.txt_Quarto = new System.Windows.Forms.TextBox();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.txt_Pessoas = new System.Windows.Forms.TextBox();
            this.lbl_Pessoas = new System.Windows.Forms.Label();
            this.txt_Descrição = new System.Windows.Forms.TextBox();
            this.lbl_Produto = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.btn_Alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.Location = new System.Drawing.Point(107, 380);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(95, 23);
            this.btn_Novo.TabIndex = 10;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(410, 380);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(95, 23);
            this.btn_Excluir.TabIndex = 13;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(208, 380);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(95, 23);
            this.btn_Salvar.TabIndex = 11;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 119);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(625, 243);
            this.Grid.TabIndex = 133;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // txt_Quarto
            // 
            this.txt_Quarto.Enabled = false;
            this.txt_Quarto.Location = new System.Drawing.Point(293, 68);
            this.txt_Quarto.Name = "txt_Quarto";
            this.txt_Quarto.Size = new System.Drawing.Size(84, 20);
            this.txt_Quarto.TabIndex = 2;
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Location = new System.Drawing.Point(252, 71);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(42, 13);
            this.lbl_Quantidade.TabIndex = 131;
            this.lbl_Quantidade.Text = "Quarto:";
            // 
            // txt_Pessoas
            // 
            this.txt_Pessoas.Enabled = false;
            this.txt_Pessoas.Location = new System.Drawing.Point(569, 68);
            this.txt_Pessoas.Name = "txt_Pessoas";
            this.txt_Pessoas.Size = new System.Drawing.Size(43, 20);
            this.txt_Pessoas.TabIndex = 4;
            // 
            // lbl_Pessoas
            // 
            this.lbl_Pessoas.AutoSize = true;
            this.lbl_Pessoas.Location = new System.Drawing.Point(514, 71);
            this.lbl_Pessoas.Name = "lbl_Pessoas";
            this.lbl_Pessoas.Size = new System.Drawing.Size(50, 13);
            this.lbl_Pessoas.TabIndex = 129;
            this.lbl_Pessoas.Text = "Pessoas:";
            // 
            // txt_Descrição
            // 
            this.txt_Descrição.Enabled = false;
            this.txt_Descrição.Location = new System.Drawing.Point(86, 68);
            this.txt_Descrição.Name = "txt_Descrição";
            this.txt_Descrição.Size = new System.Drawing.Size(160, 20);
            this.txt_Descrição.TabIndex = 1;
            // 
            // lbl_Produto
            // 
            this.lbl_Produto.AutoSize = true;
            this.lbl_Produto.Location = new System.Drawing.Point(27, 71);
            this.lbl_Produto.Name = "lbl_Produto";
            this.lbl_Produto.Size = new System.Drawing.Size(58, 13);
            this.lbl_Produto.TabIndex = 127;
            this.lbl_Produto.Text = "Descrição:";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Enabled = false;
            this.txt_Valor.Location = new System.Drawing.Point(433, 68);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(66, 20);
            this.txt_Valor.TabIndex = 3;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(394, 71);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_Valor.TabIndex = 125;
            this.lbl_Valor.Text = "Valor:";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alterar.Enabled = false;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Location = new System.Drawing.Point(309, 380);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(95, 23);
            this.btn_Alterar.TabIndex = 12;
            this.btn_Alterar.Text = "Editar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // frm_Quartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txt_Quarto);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.txt_Pessoas);
            this.Controls.Add(this.lbl_Pessoas);
            this.Controls.Add(this.txt_Descrição);
            this.Controls.Add(this.lbl_Produto);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lbl_Valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Quartos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quartos";
            this.Load += new System.EventHandler(this.frm_Quartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txt_Quarto;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.TextBox txt_Pessoas;
        private System.Windows.Forms.Label lbl_Pessoas;
        private System.Windows.Forms.TextBox txt_Descrição;
        private System.Windows.Forms.Label lbl_Produto;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Button btn_Alterar;
    }
}