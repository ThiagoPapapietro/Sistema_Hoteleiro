
namespace Sistema_Hoteleiro.Produtos
{
    partial class frm_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Produtos));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_PesquisarNome = new System.Windows.Forms.TextBox();
            this.lbl_Pesquisar = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.cb_Fornecedores = new System.Windows.Forms.ComboBox();
            this.lbl_Fornecedores = new System.Windows.Forms.Label();
            this.txt_Estoque = new System.Windows.Forms.TextBox();
            this.lbl_Estoque = new System.Windows.Forms.Label();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_imagem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(45, 198);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(679, 199);
            this.Grid.TabIndex = 8;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Location = new System.Drawing.Point(91, 118);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(106, 20);
            this.txt_Nome.TabIndex = 7;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(47, 121);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 6;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txt_PesquisarNome
            // 
            this.txt_PesquisarNome.Location = new System.Drawing.Point(434, 12);
            this.txt_PesquisarNome.Name = "txt_PesquisarNome";
            this.txt_PesquisarNome.Size = new System.Drawing.Size(100, 20);
            this.txt_PesquisarNome.TabIndex = 10;
            this.txt_PesquisarNome.TextChanged += new System.EventHandler(this.txt_PesquisarNome_TextChanged);
            // 
            // lbl_Pesquisar
            // 
            this.lbl_Pesquisar.AutoSize = true;
            this.lbl_Pesquisar.Location = new System.Drawing.Point(372, 15);
            this.lbl_Pesquisar.Name = "lbl_Pesquisar";
            this.lbl_Pesquisar.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pesquisar.TabIndex = 9;
            this.lbl_Pesquisar.Text = "Pesquisar:";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Enabled = false;
            this.txt_Descricao.Location = new System.Drawing.Point(278, 118);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(256, 20);
            this.txt_Descricao.TabIndex = 12;
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Location = new System.Drawing.Point(214, 121);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(58, 13);
            this.lbl_Descricao.TabIndex = 11;
            this.lbl_Descricao.Text = "Descrição:";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Enabled = false;
            this.txt_Valor.Location = new System.Drawing.Point(91, 169);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 14;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(51, 172);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_Valor.TabIndex = 13;
            this.lbl_Valor.Text = "Valor:";
            // 
            // cb_Fornecedores
            // 
            this.cb_Fornecedores.FormattingEnabled = true;
            this.cb_Fornecedores.Location = new System.Drawing.Point(422, 168);
            this.cb_Fornecedores.Name = "cb_Fornecedores";
            this.cb_Fornecedores.Size = new System.Drawing.Size(112, 21);
            this.cb_Fornecedores.TabIndex = 15;
            // 
            // lbl_Fornecedores
            // 
            this.lbl_Fornecedores.AutoSize = true;
            this.lbl_Fornecedores.Location = new System.Drawing.Point(358, 172);
            this.lbl_Fornecedores.Name = "lbl_Fornecedores";
            this.lbl_Fornecedores.Size = new System.Drawing.Size(64, 13);
            this.lbl_Fornecedores.TabIndex = 16;
            this.lbl_Fornecedores.Text = "Fornecedor:";
            // 
            // txt_Estoque
            // 
            this.txt_Estoque.Enabled = false;
            this.txt_Estoque.Location = new System.Drawing.Point(252, 169);
            this.txt_Estoque.Name = "txt_Estoque";
            this.txt_Estoque.Size = new System.Drawing.Size(100, 20);
            this.txt_Estoque.TabIndex = 18;
            // 
            // lbl_Estoque
            // 
            this.lbl_Estoque.AutoSize = true;
            this.lbl_Estoque.Location = new System.Drawing.Point(197, 172);
            this.lbl_Estoque.Name = "lbl_Estoque";
            this.lbl_Estoque.Size = new System.Drawing.Size(49, 13);
            this.lbl_Estoque.TabIndex = 17;
            this.lbl_Estoque.Text = "Estoque:";
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.Location = new System.Drawing.Point(167, 429);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(95, 23);
            this.btn_Novo.TabIndex = 111;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(483, 429);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(95, 23);
            this.btn_Excluir.TabIndex = 110;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(375, 429);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 23);
            this.btn_Editar.TabIndex = 109;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(268, 429);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(95, 23);
            this.btn_Salvar.TabIndex = 108;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_imagem
            // 
            this.btn_imagem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_imagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imagem.Enabled = false;
            this.btn_imagem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_imagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_imagem.Location = new System.Drawing.Point(574, 168);
            this.btn_imagem.Name = "btn_imagem";
            this.btn_imagem.Size = new System.Drawing.Size(150, 23);
            this.btn_imagem.TabIndex = 112;
            this.btn_imagem.Text = "+";
            this.btn_imagem.UseVisualStyleBackColor = false;
            this.btn_imagem.Click += new System.EventHandler(this.btn_imagem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_imagem);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_Estoque);
            this.Controls.Add(this.lbl_Estoque);
            this.Controls.Add(this.lbl_Fornecedores);
            this.Controls.Add(this.cb_Fornecedores);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.txt_PesquisarNome);
            this.Controls.Add(this.lbl_Pesquisar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Produtos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frm_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_PesquisarNome;
        private System.Windows.Forms.Label lbl_Pesquisar;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.ComboBox cb_Fornecedores;
        private System.Windows.Forms.Label lbl_Fornecedores;
        private System.Windows.Forms.TextBox txt_Estoque;
        private System.Windows.Forms.Label lbl_Estoque;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_imagem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}