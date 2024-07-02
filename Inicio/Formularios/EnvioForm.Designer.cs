namespace Inicio
{
    partial class EnvioForm
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
            this.botonMarcar = new System.Windows.Forms.Button();
            this.dataGridEnvios = new System.Windows.Forms.DataGridView();
            this.comboBoxVehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxConductores = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MostrarEntregados = new System.Windows.Forms.Button();
            this.mostrarPendientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // botonMarcar
            // 
            this.botonMarcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonMarcar.FlatAppearance.BorderSize = 0;
            this.botonMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMarcar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMarcar.ForeColor = System.Drawing.Color.White;
            this.botonMarcar.Location = new System.Drawing.Point(46, 175);
            this.botonMarcar.Margin = new System.Windows.Forms.Padding(2);
            this.botonMarcar.Name = "botonMarcar";
            this.botonMarcar.Size = new System.Drawing.Size(318, 39);
            this.botonMarcar.TabIndex = 53;
            this.botonMarcar.Text = "Marcar como entregado";
            this.botonMarcar.UseVisualStyleBackColor = false;
            this.botonMarcar.Click += new System.EventHandler(this.botonMarcar_Click);
            // 
            // dataGridEnvios
            // 
            this.dataGridEnvios.AllowUserToOrderColumns = true;
            this.dataGridEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEnvios.Location = new System.Drawing.Point(396, 43);
            this.dataGridEnvios.Name = "dataGridEnvios";
            this.dataGridEnvios.Size = new System.Drawing.Size(551, 318);
            this.dataGridEnvios.TabIndex = 52;
            // 
            // comboBoxVehiculo
            // 
            this.comboBoxVehiculo.FormattingEnabled = true;
            this.comboBoxVehiculo.Location = new System.Drawing.Point(144, 123);
            this.comboBoxVehiculo.Name = "comboBoxVehiculo";
            this.comboBoxVehiculo.Size = new System.Drawing.Size(220, 21);
            this.comboBoxVehiculo.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Vehiculo";
            // 
            // comboBoxConductores
            // 
            this.comboBoxConductores.FormattingEnabled = true;
            this.comboBoxConductores.Location = new System.Drawing.Point(144, 75);
            this.comboBoxConductores.Name = "comboBoxConductores";
            this.comboBoxConductores.Size = new System.Drawing.Size(220, 21);
            this.comboBoxConductores.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Empleado";
            // 
            // MostrarEntregados
            // 
            this.MostrarEntregados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MostrarEntregados.FlatAppearance.BorderSize = 0;
            this.MostrarEntregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostrarEntregados.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarEntregados.ForeColor = System.Drawing.Color.White;
            this.MostrarEntregados.Location = new System.Drawing.Point(396, 380);
            this.MostrarEntregados.Margin = new System.Windows.Forms.Padding(2);
            this.MostrarEntregados.Name = "MostrarEntregados";
            this.MostrarEntregados.Size = new System.Drawing.Size(195, 39);
            this.MostrarEntregados.TabIndex = 58;
            this.MostrarEntregados.Text = "Mostrar Entregados";
            this.MostrarEntregados.UseVisualStyleBackColor = false;
            this.MostrarEntregados.Click += new System.EventHandler(this.MostrarEntregados_Click);
            // 
            // mostrarPendientes
            // 
            this.mostrarPendientes.BackColor = System.Drawing.Color.Red;
            this.mostrarPendientes.FlatAppearance.BorderSize = 0;
            this.mostrarPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrarPendientes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarPendientes.ForeColor = System.Drawing.Color.White;
            this.mostrarPendientes.Location = new System.Drawing.Point(716, 380);
            this.mostrarPendientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mostrarPendientes.Name = "mostrarPendientes";
            this.mostrarPendientes.Size = new System.Drawing.Size(231, 39);
            this.mostrarPendientes.TabIndex = 61;
            this.mostrarPendientes.Text = "Mostrar Pedientes";
            this.mostrarPendientes.UseVisualStyleBackColor = false;
            this.mostrarPendientes.Click += new System.EventHandler(this.mostrarPendientes_Click);
            // 
            // EnvioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 456);
            this.Controls.Add(this.mostrarPendientes);
            this.Controls.Add(this.MostrarEntregados);
            this.Controls.Add(this.comboBoxVehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxConductores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonMarcar);
            this.Controls.Add(this.dataGridEnvios);
            this.Name = "EnvioForm";
            this.Text = "EnvioForm";
            this.Load += new System.EventHandler(this.EnvioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonMarcar;
        private System.Windows.Forms.DataGridView dataGridEnvios;
        private System.Windows.Forms.ComboBox comboBoxVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxConductores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MostrarEntregados;
        private System.Windows.Forms.Button mostrarPendientes;
    }
}