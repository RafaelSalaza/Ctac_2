namespace Inicio.Formularios
{
    partial class PagarCuota
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
            this.cuotaDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuotaNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorCuota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInteresMora = new System.Windows.Forms.TextBox();
            this.btnCalcularPago = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarProyecto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDineroAPagar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cuotaDataGridView
            // 
            this.cuotaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cuotaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cuotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuotaDataGridView.Location = new System.Drawing.Point(51, 107);
            this.cuotaDataGridView.Name = "cuotaDataGridView";
            this.cuotaDataGridView.ReadOnly = true;
            this.cuotaDataGridView.RowHeadersWidth = 51;
            this.cuotaDataGridView.RowTemplate.Height = 24;
            this.cuotaDataGridView.Size = new System.Drawing.Size(933, 190);
            this.cuotaDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(709, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.AcceptsReturn = true;
            this.txtFechaVencimiento.Location = new System.Drawing.Point(51, 362);
            this.txtFechaVencimiento.Multiline = true;
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.ReadOnly = true;
            this.txtFechaVencimiento.Size = new System.Drawing.Size(132, 37);
            this.txtFechaVencimiento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cuota";
            // 
            // txtCuotaNumero
            // 
            this.txtCuotaNumero.Location = new System.Drawing.Point(254, 362);
            this.txtCuotaNumero.Multiline = true;
            this.txtCuotaNumero.Name = "txtCuotaNumero";
            this.txtCuotaNumero.ReadOnly = true;
            this.txtCuotaNumero.Size = new System.Drawing.Size(132, 37);
            this.txtCuotaNumero.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor por cuota";
            // 
            // txtValorCuota
            // 
            this.txtValorCuota.Location = new System.Drawing.Point(476, 362);
            this.txtValorCuota.Multiline = true;
            this.txtValorCuota.Name = "txtValorCuota";
            this.txtValorCuota.ReadOnly = true;
            this.txtValorCuota.Size = new System.Drawing.Size(132, 37);
            this.txtValorCuota.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "A pagar";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Location = new System.Drawing.Point(483, 479);
            this.txtTotalAPagar.Multiline = true;
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.ReadOnly = true;
            this.txtTotalAPagar.Size = new System.Drawing.Size(132, 37);
            this.txtTotalAPagar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Interes mora";
            // 
            // txtInteresMora
            // 
            this.txtInteresMora.Location = new System.Drawing.Point(51, 479);
            this.txtInteresMora.Multiline = true;
            this.txtInteresMora.Name = "txtInteresMora";
            this.txtInteresMora.Size = new System.Drawing.Size(132, 37);
            this.txtInteresMora.TabIndex = 10;
            // 
            // btnCalcularPago
            // 
            this.btnCalcularPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalcularPago.FlatAppearance.BorderSize = 0;
            this.btnCalcularPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularPago.Location = new System.Drawing.Point(709, 431);
            this.btnCalcularPago.Name = "btnCalcularPago";
            this.btnCalcularPago.Size = new System.Drawing.Size(141, 43);
            this.btnCalcularPago.TabIndex = 12;
            this.btnCalcularPago.Text = "Calcular pago";
            this.btnCalcularPago.UseVisualStyleBackColor = false;
            this.btnCalcularPago.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(51, 29);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(367, 37);
            this.txtBuscar.TabIndex = 17;
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarProyecto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarProyecto.Location = new System.Drawing.Point(451, 31);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(116, 35);
            this.btnBuscarProyecto.TabIndex = 18;
            this.btnBuscarProyecto.Text = "Buscar";
            this.btnBuscarProyecto.UseVisualStyleBackColor = false;
            this.btnBuscarProyecto.Click += new System.EventHandler(this.btnBuscarProyecto_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 33);
            this.label8.TabIndex = 20;
            this.label8.Text = "Dinero a pagar";
            // 
            // txtDineroAPagar
            // 
            this.txtDineroAPagar.Location = new System.Drawing.Point(259, 479);
            this.txtDineroAPagar.Multiline = true;
            this.txtDineroAPagar.Name = "txtDineroAPagar";
            this.txtDineroAPagar.ReadOnly = true;
            this.txtDineroAPagar.Size = new System.Drawing.Size(132, 37);
            this.txtDineroAPagar.TabIndex = 19;
            // 
            // PagarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1085, 565);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDineroAPagar);
            this.Controls.Add(this.btnBuscarProyecto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCalcularPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInteresMora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorCuota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuotaNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuotaDataGridView);
            this.Name = "PagarCuota";
            this.Text = "PagarCuota";
            this.Load += new System.EventHandler(this.PagarCuota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuotaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cuotaDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuotaNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorCuota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInteresMora;
        private System.Windows.Forms.Button btnCalcularPago;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscarProyecto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDineroAPagar;
    }
}