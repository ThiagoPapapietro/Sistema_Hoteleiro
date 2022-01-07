
namespace Sistema_Hoteleiro.Cadastros
{
    partial class frm_Hospedes
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
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.msktxt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msktxt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_BuscarNome = new System.Windows.Forms.TextBox();
            this.lbl_Pesquisar = new System.Windows.Forms.Label();
            this.rb_Nome = new System.Windows.Forms.RadioButton();
            this.rb_CPF = new System.Windows.Forms.RadioButton();
            this.msktxt_BuscarCpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.cb_Sexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.msktxt_Cep = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.Location = new System.Drawing.Point(96, 368);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(95, 23);
            this.btn_Novo.TabIndex = 123;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(412, 368);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(95, 23);
            this.btn_Excluir.TabIndex = 125;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(304, 368);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 23);
            this.btn_Editar.TabIndex = 124;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(197, 368);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(95, 23);
            this.btn_Salvar.TabIndex = 123;
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
            this.Grid.Location = new System.Drawing.Point(33, 182);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(545, 164);
            this.Grid.TabIndex = 10;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.Grid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentDoubleClick);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Location = new System.Drawing.Point(84, 75);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(494, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(31, 78);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 118;
            this.lbl_Nome.Text = "Nome:";
            // 
            // msktxt_Cpf
            // 
            this.msktxt_Cpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxt_Cpf.Location = new System.Drawing.Point(84, 103);
            this.msktxt_Cpf.Mask = "000,000,000-00";
            this.msktxt_Cpf.Name = "msktxt_Cpf";
            this.msktxt_Cpf.Size = new System.Drawing.Size(96, 21);
            this.msktxt_Cpf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "CPF:";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Enabled = false;
            this.txt_Endereco.Location = new System.Drawing.Point(218, 130);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(262, 20);
            this.txt_Endereco.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 131;
            this.label3.Text = "Celular:";
            // 
            // msktxt_Celular
            // 
            this.msktxt_Celular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxt_Celular.Location = new System.Drawing.Point(404, 102);
            this.msktxt_Celular.Mask = "(00) 0 000-0000";
            this.msktxt_Celular.Name = "msktxt_Celular";
            this.msktxt_Celular.Size = new System.Drawing.Size(103, 21);
            this.msktxt_Celular.TabIndex = 4;
            // 
            // txt_BuscarNome
            // 
            this.txt_BuscarNome.Location = new System.Drawing.Point(482, 12);
            this.txt_BuscarNome.Name = "txt_BuscarNome";
            this.txt_BuscarNome.Size = new System.Drawing.Size(96, 20);
            this.txt_BuscarNome.TabIndex = 135;
            this.txt_BuscarNome.TextChanged += new System.EventHandler(this.txt_BuscarNome_TextChanged);
            // 
            // lbl_Pesquisar
            // 
            this.lbl_Pesquisar.AutoSize = true;
            this.lbl_Pesquisar.Location = new System.Drawing.Point(235, 15);
            this.lbl_Pesquisar.Name = "lbl_Pesquisar";
            this.lbl_Pesquisar.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pesquisar.TabIndex = 134;
            this.lbl_Pesquisar.Text = "Pesquisar:";
            // 
            // rb_Nome
            // 
            this.rb_Nome.AutoSize = true;
            this.rb_Nome.Location = new System.Drawing.Point(323, 13);
            this.rb_Nome.Name = "rb_Nome";
            this.rb_Nome.Size = new System.Drawing.Size(53, 17);
            this.rb_Nome.TabIndex = 136;
            this.rb_Nome.TabStop = true;
            this.rb_Nome.Text = "Nome";
            this.rb_Nome.UseVisualStyleBackColor = true;
            this.rb_Nome.CheckedChanged += new System.EventHandler(this.rb_Nome_CheckedChanged);
            // 
            // rb_CPF
            // 
            this.rb_CPF.AutoSize = true;
            this.rb_CPF.Location = new System.Drawing.Point(382, 13);
            this.rb_CPF.Name = "rb_CPF";
            this.rb_CPF.Size = new System.Drawing.Size(45, 17);
            this.rb_CPF.TabIndex = 137;
            this.rb_CPF.TabStop = true;
            this.rb_CPF.Text = "CPF";
            this.rb_CPF.UseVisualStyleBackColor = true;
            this.rb_CPF.CheckedChanged += new System.EventHandler(this.rb_CPF_CheckedChanged);
            // 
            // msktxt_BuscarCpf
            // 
            this.msktxt_BuscarCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxt_BuscarCpf.Location = new System.Drawing.Point(482, 12);
            this.msktxt_BuscarCpf.Mask = "000,000,000-00";
            this.msktxt_BuscarCpf.Name = "msktxt_BuscarCpf";
            this.msktxt_BuscarCpf.Size = new System.Drawing.Size(96, 20);
            this.msktxt_BuscarCpf.TabIndex = 138;
            this.msktxt_BuscarCpf.TextChanged += new System.EventHandler(this.msktxt_BuscarCpf_TextChanged);
            // 
            // txt_Numero
            // 
            this.txt_Numero.Enabled = false;
            this.txt_Numero.Location = new System.Drawing.Point(533, 130);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(45, 20);
            this.txt_Numero.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 140;
            this.label4.Text = "Numero:";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Enabled = false;
            this.txt_Bairro.Location = new System.Drawing.Point(84, 156);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(170, 20);
            this.txt_Bairro.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 142;
            this.label5.Text = "Bairro:";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Enabled = false;
            this.txt_Cidade.Location = new System.Drawing.Point(304, 156);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(175, 20);
            this.txt_Cidade.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 144;
            this.label6.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 145;
            this.label7.Text = "Estado:";
            // 
            // cb_Estado
            // 
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cb_Estado.Location = new System.Drawing.Point(533, 155);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(45, 21);
            this.cb_Estado.TabIndex = 10;
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.Items.AddRange(new object[] {
            "",
            "Feminino",
            "Masculino"});
            this.cb_Sexo.Location = new System.Drawing.Point(218, 102);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(136, 21);
            this.cb_Sexo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 147;
            this.label8.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 149;
            this.label9.Text = "CEP:";
            // 
            // msktxt_Cep
            // 
            this.msktxt_Cep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxt_Cep.Location = new System.Drawing.Point(84, 130);
            this.msktxt_Cep.Mask = "00000-000";
            this.msktxt_Cep.Name = "msktxt_Cep";
            this.msktxt_Cep.Size = new System.Drawing.Size(71, 21);
            this.msktxt_Cep.TabIndex = 5;
            // 
            // frm_Hospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 424);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.msktxt_Cep);
            this.Controls.Add(this.cb_Sexo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_Estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msktxt_BuscarCpf);
            this.Controls.Add(this.rb_CPF);
            this.Controls.Add(this.rb_Nome);
            this.Controls.Add(this.txt_BuscarNome);
            this.Controls.Add(this.lbl_Pesquisar);
            this.Controls.Add(this.msktxt_Celular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msktxt_Cpf);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Hospedes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospedes";
            this.Load += new System.EventHandler(this.frm_Hospedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.MaskedTextBox msktxt_Cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktxt_Celular;
        private System.Windows.Forms.TextBox txt_BuscarNome;
        private System.Windows.Forms.Label lbl_Pesquisar;
        private System.Windows.Forms.RadioButton rb_Nome;
        private System.Windows.Forms.RadioButton rb_CPF;
        private System.Windows.Forms.MaskedTextBox msktxt_BuscarCpf;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.ComboBox cb_Sexo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msktxt_Cep;
    }
}