
namespace Sistema_Hoteleiro.Movimentacoes
{
    partial class frm_Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Vendas));
            this.btn_Produto = new System.Windows.Forms.Button();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.txt_Estoque = new System.Windows.Forms.TextBox();
            this.lbl_Estoque = new System.Windows.Forms.Label();
            this.txt_Produto = new System.Windows.Forms.TextBox();
            this.lbl_Produto = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_Buscar = new System.Windows.Forms.DateTimePicker();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.grid_DetalhesVendas = new System.Windows.Forms.DataGridView();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Relatorio = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DetalhesVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Produto
            // 
            this.btn_Produto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Produto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produto.Location = new System.Drawing.Point(244, 72);
            this.btn_Produto.Name = "btn_Produto";
            this.btn_Produto.Size = new System.Drawing.Size(23, 23);
            this.btn_Produto.TabIndex = 40;
            this.btn_Produto.Text = "+";
            this.btn_Produto.UseVisualStyleBackColor = false;
            this.btn_Produto.Click += new System.EventHandler(this.btn_Produto_Click);
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Enabled = false;
            this.txt_Quantidade.Location = new System.Drawing.Point(358, 74);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(84, 20);
            this.txt_Quantidade.TabIndex = 39;
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Location = new System.Drawing.Point(291, 77);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(65, 13);
            this.lbl_Quantidade.TabIndex = 38;
            this.lbl_Quantidade.Text = "Quantidade:";
            // 
            // txt_Estoque
            // 
            this.txt_Estoque.Enabled = false;
            this.txt_Estoque.Location = new System.Drawing.Point(634, 74);
            this.txt_Estoque.Name = "txt_Estoque";
            this.txt_Estoque.Size = new System.Drawing.Size(43, 20);
            this.txt_Estoque.TabIndex = 37;
            // 
            // lbl_Estoque
            // 
            this.lbl_Estoque.AutoSize = true;
            this.lbl_Estoque.Location = new System.Drawing.Point(579, 77);
            this.lbl_Estoque.Name = "lbl_Estoque";
            this.lbl_Estoque.Size = new System.Drawing.Size(49, 13);
            this.lbl_Estoque.TabIndex = 36;
            this.lbl_Estoque.Text = "Estoque:";
            // 
            // txt_Produto
            // 
            this.txt_Produto.Enabled = false;
            this.txt_Produto.Location = new System.Drawing.Point(105, 74);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(133, 20);
            this.txt_Produto.TabIndex = 35;
            // 
            // lbl_Produto
            // 
            this.lbl_Produto.AutoSize = true;
            this.lbl_Produto.Location = new System.Drawing.Point(52, 77);
            this.lbl_Produto.Name = "lbl_Produto";
            this.lbl_Produto.Size = new System.Drawing.Size(47, 13);
            this.lbl_Produto.TabIndex = 34;
            this.lbl_Produto.Text = "Produto:";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Enabled = false;
            this.txt_Valor.Location = new System.Drawing.Point(498, 74);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(66, 20);
            this.txt_Valor.TabIndex = 33;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(459, 77);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_Valor.TabIndex = 32;
            this.lbl_Valor.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Pesquisar:";
            // 
            // dt_Buscar
            // 
            this.dt_Buscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Buscar.Location = new System.Drawing.Point(579, 12);
            this.dt_Buscar.Name = "dt_Buscar";
            this.dt_Buscar.Size = new System.Drawing.Size(98, 20);
            this.dt_Buscar.TabIndex = 42;
            this.dt_Buscar.ValueChanged += new System.EventHandler(this.dt_Buscar_ValueChanged);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(37, 125);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(669, 243);
            this.Grid.TabIndex = 43;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.Location = new System.Drawing.Point(175, 399);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(95, 23);
            this.btn_Novo.TabIndex = 115;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(276, 399);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(95, 23);
            this.btn_Salvar.TabIndex = 112;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(383, 399);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(95, 23);
            this.btn_Excluir.TabIndex = 113;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "Total:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(79, 372);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(13, 13);
            this.lbl_Total.TabIndex = 121;
            this.lbl_Total.Text = "0";
            // 
            // grid_DetalhesVendas
            // 
            this.grid_DetalhesVendas.AllowUserToAddRows = false;
            this.grid_DetalhesVendas.AllowUserToDeleteRows = false;
            this.grid_DetalhesVendas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_DetalhesVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DetalhesVendas.Location = new System.Drawing.Point(37, 125);
            this.grid_DetalhesVendas.Name = "grid_DetalhesVendas";
            this.grid_DetalhesVendas.ReadOnly = true;
            this.grid_DetalhesVendas.Size = new System.Drawing.Size(669, 243);
            this.grid_DetalhesVendas.TabIndex = 122;
            this.grid_DetalhesVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DetalhesVendas_CellClick);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(683, 125);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(23, 23);
            this.btn_Fechar.TabIndex = 123;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Relatorio
            // 
            this.btn_Relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Relatorio.Enabled = false;
            this.btn_Relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Relatorio.Location = new System.Drawing.Point(484, 399);
            this.btn_Relatorio.Name = "btn_Relatorio";
            this.btn_Relatorio.Size = new System.Drawing.Size(95, 23);
            this.btn_Relatorio.TabIndex = 124;
            this.btn_Relatorio.Text = "Relatorio";
            this.btn_Relatorio.UseVisualStyleBackColor = true;
            this.btn_Relatorio.Click += new System.EventHandler(this.btn_Relatorio_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.BackgroundImage")));
            this.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Remove.FlatAppearance.BorderSize = 0;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Location = new System.Drawing.Point(672, 372);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(23, 23);
            this.btn_Remove.TabIndex = 119;
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(641, 372);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(23, 23);
            this.btn_Add.TabIndex = 116;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frm_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.btn_Relatorio);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.grid_DetalhesVendas);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.dt_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Produto);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.txt_Estoque);
            this.Controls.Add(this.lbl_Estoque);
            this.Controls.Add(this.txt_Produto);
            this.Controls.Add(this.lbl_Produto);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lbl_Valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Vendas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Activated += new System.EventHandler(this.frm_Vendas_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Vendas_FormClosing);
            this.Load += new System.EventHandler(this.frm_Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DetalhesVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Produto;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.TextBox txt_Estoque;
        private System.Windows.Forms.Label lbl_Estoque;
        private System.Windows.Forms.TextBox txt_Produto;
        private System.Windows.Forms.Label lbl_Produto;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_Buscar;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.DataGridView grid_DetalhesVendas;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Relatorio;
    }
}