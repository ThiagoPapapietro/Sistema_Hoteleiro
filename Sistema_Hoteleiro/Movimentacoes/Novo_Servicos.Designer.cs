
namespace Sistema_Hoteleiro.Movimentacoes
{
    partial class frm_NovoServicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Relatorio = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.dt_Buscar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Hospede = new System.Windows.Forms.Button();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.lbl_Estoque = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Produto = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.cb_Servico = new System.Windows.Forms.ComboBox();
            this.cb_Quarto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Relatorio
            // 
            this.btn_Relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Relatorio.Enabled = false;
            this.btn_Relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Relatorio.Location = new System.Drawing.Point(453, 397);
            this.btn_Relatorio.Name = "btn_Relatorio";
            this.btn_Relatorio.Size = new System.Drawing.Size(95, 23);
            this.btn_Relatorio.TabIndex = 53;
            this.btn_Relatorio.Text = "Relatorio";
            this.btn_Relatorio.UseVisualStyleBackColor = true;
            this.btn_Relatorio.Click += new System.EventHandler(this.btn_Relatorio_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.Location = new System.Drawing.Point(144, 397);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(95, 23);
            this.btn_Novo.TabIndex = 50;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(352, 397);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(95, 23);
            this.btn_Excluir.TabIndex = 52;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(245, 397);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(95, 23);
            this.btn_Salvar.TabIndex = 51;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Location = new System.Drawing.Point(17, 166);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.Size = new System.Drawing.Size(692, 210);
            this.Grid.TabIndex = 136;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // dt_Buscar
            // 
            this.dt_Buscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Buscar.Location = new System.Drawing.Point(611, 25);
            this.dt_Buscar.Name = "dt_Buscar";
            this.dt_Buscar.Size = new System.Drawing.Size(98, 20);
            this.dt_Buscar.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 134;
            this.label1.Text = "Pesquisar:";
            // 
            // btn_Hospede
            // 
            this.btn_Hospede.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Hospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hospede.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Hospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hospede.Location = new System.Drawing.Point(257, 80);
            this.btn_Hospede.Name = "btn_Hospede";
            this.btn_Hospede.Size = new System.Drawing.Size(23, 23);
            this.btn_Hospede.TabIndex = 133;
            this.btn_Hospede.Text = "+";
            this.btn_Hospede.UseVisualStyleBackColor = false;
            this.btn_Hospede.Click += new System.EventHandler(this.btn_Hospede_Click);
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Enabled = false;
            this.txt_Quantidade.Location = new System.Drawing.Point(85, 123);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(165, 20);
            this.txt_Quantidade.TabIndex = 3;
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Location = new System.Drawing.Point(22, 126);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(65, 13);
            this.lbl_Quantidade.TabIndex = 131;
            this.lbl_Quantidade.Text = "Quantidade:";
            // 
            // lbl_Estoque
            // 
            this.lbl_Estoque.AutoSize = true;
            this.lbl_Estoque.Location = new System.Drawing.Point(329, 85);
            this.lbl_Estoque.Name = "lbl_Estoque";
            this.lbl_Estoque.Size = new System.Drawing.Size(46, 13);
            this.lbl_Estoque.TabIndex = 129;
            this.lbl_Estoque.Text = "Serviço:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Location = new System.Drawing.Point(85, 82);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(165, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // lbl_Produto
            // 
            this.lbl_Produto.AutoSize = true;
            this.lbl_Produto.Location = new System.Drawing.Point(22, 85);
            this.lbl_Produto.Name = "lbl_Produto";
            this.lbl_Produto.Size = new System.Drawing.Size(53, 13);
            this.lbl_Produto.TabIndex = 127;
            this.lbl_Produto.Text = "Hóspede:";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Enabled = false;
            this.txt_Valor.Location = new System.Drawing.Point(379, 123);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(153, 20);
            this.txt_Valor.TabIndex = 4;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(329, 126);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_Valor.TabIndex = 125;
            this.lbl_Valor.Text = "Valor:";
            // 
            // cb_Servico
            // 
            this.cb_Servico.FormattingEnabled = true;
            this.cb_Servico.Location = new System.Drawing.Point(379, 82);
            this.cb_Servico.Name = "cb_Servico";
            this.cb_Servico.Size = new System.Drawing.Size(153, 21);
            this.cb_Servico.TabIndex = 2;
            this.cb_Servico.SelectedValueChanged += new System.EventHandler(this.cb_Servico_SelectedValueChanged);
            // 
            // cb_Quarto
            // 
            this.cb_Quarto.FormattingEnabled = true;
            this.cb_Quarto.Location = new System.Drawing.Point(611, 82);
            this.cb_Quarto.Name = "cb_Quarto";
            this.cb_Quarto.Size = new System.Drawing.Size(92, 21);
            this.cb_Quarto.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "Quarto:";
            // 
            // frm_NovoServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.cb_Quarto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Servico);
            this.Controls.Add(this.btn_Relatorio);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.dt_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Hospede);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.lbl_Estoque);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Produto);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lbl_Valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_NovoServicos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitação de Serviço";
            this.Activated += new System.EventHandler(this.frm_NovoServicos_Activated);
            this.Load += new System.EventHandler(this.frm_Servicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Relatorio;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DateTimePicker dt_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Hospede;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.Label lbl_Estoque;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Produto;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.ComboBox cb_Servico;
        private System.Windows.Forms.ComboBox cb_Quarto;
        private System.Windows.Forms.Label label2;
    }
}