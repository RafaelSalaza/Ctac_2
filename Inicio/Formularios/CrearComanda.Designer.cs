namespace Inicio.Formularios
{
    partial class CrearComanda
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.cmbIdProyecto = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VerVehiculos = new System.Windows.Forms.Button();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Transparent;
            this.btnCrear.Location = new System.Drawing.Point(424, 111);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(121, 27);
            this.btnCrear.TabIndex = 47;
            this.btnCrear.Text = "Guardar";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.UseWaitCursor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cmbIdProyecto
            // 
            this.cmbIdProyecto.FormattingEnabled = true;
            this.cmbIdProyecto.Location = new System.Drawing.Point(248, 180);
            this.cmbIdProyecto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIdProyecto.Name = "cmbIdProyecto";
            this.cmbIdProyecto.Size = new System.Drawing.Size(115, 21);
            this.cmbIdProyecto.TabIndex = 40;
            this.cmbIdProyecto.UseWaitCursor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(248, 102);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(115, 20);
            this.txtNombre.TabIndex = 38;
            this.txtNombre.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Proyecto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Vehiculo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre de comanda";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ingresar datos para la comanda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VerVehiculos
            // 
            this.VerVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.VerVehiculos.FlatAppearance.BorderSize = 0;
            this.VerVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerVehiculos.ForeColor = System.Drawing.Color.Transparent;
            this.VerVehiculos.Location = new System.Drawing.Point(424, 160);
            this.VerVehiculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VerVehiculos.Name = "VerVehiculos";
            this.VerVehiculos.Size = new System.Drawing.Size(121, 27);
            this.VerVehiculos.TabIndex = 48;
            this.VerVehiculos.Text = "Ver Vehiculos";
            this.VerVehiculos.UseVisualStyleBackColor = false;
            this.VerVehiculos.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(248, 147);
            this.txtVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.ReadOnly = true;
            this.txtVehiculo.Size = new System.Drawing.Size(114, 20);
            this.txtVehiculo.TabIndex = 49;
            // 
            // CrearComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(598, 271);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.VerVehiculos);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cmbIdProyecto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearComanda";
            this.Text = "CrearComanda";
            this.Load += new System.EventHandler(this.CrearComanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cmbIdProyecto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VerVehiculos;
        private System.Windows.Forms.TextBox txtVehiculo;
    }
}