
namespace Sistema_Hoteleiro.Reservas
{
    partial class frm_ConsultarReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConsultarReservas));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.dt_BuscarInicioReserva = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.txt_BuscarNome = new System.Windows.Forms.TextBox();
            this.dt_BuscarReserva = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Pago = new System.Windows.Forms.Button();
            this.btn_Relatorio = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 85);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(1090, 287);
            this.Grid.TabIndex = 126;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // dt_BuscarInicioReserva
            // 
            this.dt_BuscarInicioReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_BuscarInicioReserva.Location = new System.Drawing.Point(671, 33);
            this.dt_BuscarInicioReserva.Name = "dt_BuscarInicioReserva";
            this.dt_BuscarInicioReserva.Size = new System.Drawing.Size(98, 20);
            this.dt_BuscarInicioReserva.TabIndex = 125;
            this.dt_BuscarInicioReserva.ValueChanged += new System.EventHandler(this.dt_BuscarInicioReserva_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 124;
            this.label1.Text = "Pesquisar data da reserva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 130;
            this.label3.Text = "Status:";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Confirmada",
            "Cancelada"});
            this.cb_Status.Location = new System.Drawing.Point(145, 36);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(121, 21);
            this.cb_Status.TabIndex = 131;
            this.cb_Status.SelectedIndexChanged += new System.EventHandler(this.cb_Status_SelectedIndexChanged);
            // 
            // txt_BuscarNome
            // 
            this.txt_BuscarNome.Location = new System.Drawing.Point(360, 36);
            this.txt_BuscarNome.Name = "txt_BuscarNome";
            this.txt_BuscarNome.Size = new System.Drawing.Size(100, 20);
            this.txt_BuscarNome.TabIndex = 132;
            this.txt_BuscarNome.TextChanged += new System.EventHandler(this.txt_BuscarNome_TextChanged);
            // 
            // dt_BuscarReserva
            // 
            this.dt_BuscarReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_BuscarReserva.Location = new System.Drawing.Point(899, 33);
            this.dt_BuscarReserva.Name = "dt_BuscarReserva";
            this.dt_BuscarReserva.Size = new System.Drawing.Size(98, 20);
            this.dt_BuscarReserva.TabIndex = 134;
            this.dt_BuscarReserva.ValueChanged += new System.EventHandler(this.dt_BuscarReserva_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 133;
            this.label4.Text = "Data da reserva:";
            // 
            // btn_Pago
            // 
            this.btn_Pago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pago.Location = new System.Drawing.Point(422, 392);
            this.btn_Pago.Name = "btn_Pago";
            this.btn_Pago.Size = new System.Drawing.Size(75, 23);
            this.btn_Pago.TabIndex = 136;
            this.btn_Pago.Text = "Pagar";
            this.btn_Pago.UseVisualStyleBackColor = true;
            this.btn_Pago.Click += new System.EventHandler(this.btn_Pago_Click);
            // 
            // btn_Relatorio
            // 
            this.btn_Relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Relatorio.Location = new System.Drawing.Point(614, 392);
            this.btn_Relatorio.Name = "btn_Relatorio";
            this.btn_Relatorio.Size = new System.Drawing.Size(79, 23);
            this.btn_Relatorio.TabIndex = 138;
            this.btn_Relatorio.Text = "Comprovante";
            this.btn_Relatorio.UseVisualStyleBackColor = true;
            this.btn_Relatorio.Click += new System.EventHandler(this.btn_Relatorio_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(517, 392);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 137;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // frm_ConsultarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 440);
            this.Controls.Add(this.btn_Relatorio);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.btn_Pago);
            this.Controls.Add(this.dt_BuscarReserva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_BuscarNome);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.dt_BuscarInicioReserva);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_ConsultarReservas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Reservas";
            this.Load += new System.EventHandler(this.frm_ConsultarReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DateTimePicker dt_BuscarInicioReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.TextBox txt_BuscarNome;
        private System.Windows.Forms.DateTimePicker dt_BuscarReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Pago;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button btn_Relatorio;
    }
}