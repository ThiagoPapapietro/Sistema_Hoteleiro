
namespace Sistema_Hoteleiro.Reservas
{
    partial class frm_CheckOut
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
            this.btn_CkeckOut = new System.Windows.Forms.Button();
            this.txt_BuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.dt_BuscarFinalReserva = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CkeckOut
            // 
            this.btn_CkeckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CkeckOut.Location = new System.Drawing.Point(298, 396);
            this.btn_CkeckOut.Name = "btn_CkeckOut";
            this.btn_CkeckOut.Size = new System.Drawing.Size(75, 23);
            this.btn_CkeckOut.TabIndex = 148;
            this.btn_CkeckOut.Text = "Check - Out";
            this.btn_CkeckOut.UseVisualStyleBackColor = true;
            this.btn_CkeckOut.Click += new System.EventHandler(this.btn_CkeckOut_Click);
            // 
            // txt_BuscarNome
            // 
            this.txt_BuscarNome.Location = new System.Drawing.Point(140, 41);
            this.txt_BuscarNome.Name = "txt_BuscarNome";
            this.txt_BuscarNome.Size = new System.Drawing.Size(100, 20);
            this.txt_BuscarNome.TabIndex = 147;
            this.txt_BuscarNome.TextChanged += new System.EventHandler(this.txt_BuscarNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "Nome:";
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 89);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(644, 287);
            this.Grid.TabIndex = 145;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // dt_BuscarFinalReserva
            // 
            this.dt_BuscarFinalReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_BuscarFinalReserva.Location = new System.Drawing.Point(451, 39);
            this.dt_BuscarFinalReserva.Name = "dt_BuscarFinalReserva";
            this.dt_BuscarFinalReserva.Size = new System.Drawing.Size(98, 20);
            this.dt_BuscarFinalReserva.TabIndex = 144;
            this.dt_BuscarFinalReserva.ValueChanged += new System.EventHandler(this.dt_BuscarFinalReserva_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 143;
            this.label1.Text = "Data final da reserva:";
            // 
            // frm_CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.btn_CkeckOut);
            this.Controls.Add(this.txt_BuscarNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.dt_BuscarFinalReserva);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_CheckOut";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check - Out";
            this.Load += new System.EventHandler(this.frm_CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CkeckOut;
        private System.Windows.Forms.TextBox txt_BuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DateTimePicker dt_BuscarFinalReserva;
        private System.Windows.Forms.Label label1;
    }
}