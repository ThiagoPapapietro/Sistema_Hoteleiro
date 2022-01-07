
namespace Sistema_Hoteleiro.Movimentacoes
{
    partial class frm_Movimentacoes
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.dt_Final = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_Inicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Buscar = new System.Windows.Forms.ComboBox();
            this.lbl_Entradas = new System.Windows.Forms.Label();
            this.lbl_Saidas = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 65);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(669, 313);
            this.Grid.TabIndex = 46;
            // 
            // dt_Final
            // 
            this.dt_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Final.Location = new System.Drawing.Point(554, 25);
            this.dt_Final.Name = "dt_Final";
            this.dt_Final.Size = new System.Drawing.Size(98, 20);
            this.dt_Final.TabIndex = 45;
            this.dt_Final.ValueChanged += new System.EventHandler(this.dt_Final_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Data Final:";
            // 
            // dt_Inicial
            // 
            this.dt_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Inicial.Location = new System.Drawing.Point(371, 25);
            this.dt_Inicial.Name = "dt_Inicial";
            this.dt_Inicial.Size = new System.Drawing.Size(98, 20);
            this.dt_Inicial.TabIndex = 48;
            this.dt_Inicial.ValueChanged += new System.EventHandler(this.dt_Inicial_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Data Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Entrada/Saída:";
            // 
            // cb_Buscar
            // 
            this.cb_Buscar.FormattingEnabled = true;
            this.cb_Buscar.Items.AddRange(new object[] {
            "Todos",
            "Entrada",
            "Saída"});
            this.cb_Buscar.Location = new System.Drawing.Point(119, 24);
            this.cb_Buscar.Name = "cb_Buscar";
            this.cb_Buscar.Size = new System.Drawing.Size(121, 21);
            this.cb_Buscar.TabIndex = 50;
            this.cb_Buscar.SelectedIndexChanged += new System.EventHandler(this.cb_Buscar_SelectedIndexChanged);
            // 
            // lbl_Entradas
            // 
            this.lbl_Entradas.AutoSize = true;
            this.lbl_Entradas.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Entradas.Location = new System.Drawing.Point(90, 385);
            this.lbl_Entradas.Name = "lbl_Entradas";
            this.lbl_Entradas.Size = new System.Drawing.Size(13, 13);
            this.lbl_Entradas.TabIndex = 51;
            this.lbl_Entradas.Text = "0";
            // 
            // lbl_Saidas
            // 
            this.lbl_Saidas.AutoSize = true;
            this.lbl_Saidas.ForeColor = System.Drawing.Color.Red;
            this.lbl_Saidas.Location = new System.Drawing.Point(261, 385);
            this.lbl_Saidas.Name = "lbl_Saidas";
            this.lbl_Saidas.Size = new System.Drawing.Size(13, 13);
            this.lbl_Saidas.TabIndex = 52;
            this.lbl_Saidas.Text = "0";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(613, 385);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(13, 13);
            this.lbl_Total.TabIndex = 53;
            this.lbl_Total.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Saídas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Entradas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Total:";
            // 
            // frm_Movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Saidas);
            this.Controls.Add(this.lbl_Entradas);
            this.Controls.Add(this.cb_Buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_Inicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.dt_Final);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Movimentacoes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentações";
            this.Load += new System.EventHandler(this.frm_Movimentacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DateTimePicker dt_Final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_Inicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Buscar;
        private System.Windows.Forms.Label lbl_Entradas;
        private System.Windows.Forms.Label lbl_Saidas;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}