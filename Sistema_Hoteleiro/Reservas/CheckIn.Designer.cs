
namespace Sistema_Hoteleiro.Reservas
{
    partial class frm_CheckIn
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
            this.btn_CkeckIn = new System.Windows.Forms.Button();
            this.txt_BuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.dt_BuscarInicioReserva = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CkeckIn
            // 
            this.btn_CkeckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CkeckIn.Location = new System.Drawing.Point(300, 391);
            this.btn_CkeckIn.Name = "btn_CkeckIn";
            this.btn_CkeckIn.Size = new System.Drawing.Size(75, 23);
            this.btn_CkeckIn.TabIndex = 142;
            this.btn_CkeckIn.Text = "Check - In";
            this.btn_CkeckIn.UseVisualStyleBackColor = true;
            this.btn_CkeckIn.Click += new System.EventHandler(this.btn_CkeckIn_Click);
            // 
            // txt_BuscarNome
            // 
            this.txt_BuscarNome.Location = new System.Drawing.Point(146, 35);
            this.txt_BuscarNome.Name = "txt_BuscarNome";
            this.txt_BuscarNome.Size = new System.Drawing.Size(100, 20);
            this.txt_BuscarNome.TabIndex = 141;
            this.txt_BuscarNome.TextChanged += new System.EventHandler(this.txt_BuscarNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 140;
            this.label2.Text = "Nome:";
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 87);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(644, 287);
            this.Grid.TabIndex = 139;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // dt_BuscarInicioReserva
            // 
            this.dt_BuscarInicioReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_BuscarInicioReserva.Location = new System.Drawing.Point(457, 35);
            this.dt_BuscarInicioReserva.Name = "dt_BuscarInicioReserva";
            this.dt_BuscarInicioReserva.Size = new System.Drawing.Size(98, 20);
            this.dt_BuscarInicioReserva.TabIndex = 138;
            this.dt_BuscarInicioReserva.ValueChanged += new System.EventHandler(this.dt_BuscarInicioReserva_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 137;
            this.label1.Text = "Data inicial da reserva:";
            // 
            // frm_CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.btn_CkeckIn);
            this.Controls.Add(this.txt_BuscarNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.dt_BuscarInicioReserva);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_CheckIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-In";
            this.Load += new System.EventHandler(this.frm_CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CkeckIn;
        private System.Windows.Forms.TextBox txt_BuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DateTimePicker dt_BuscarInicioReserva;
        private System.Windows.Forms.Label label1;
    }
}