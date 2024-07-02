namespace Inicio.Formularios
{
    partial class opcionVentas
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
            this.Agregarclientes = new System.Windows.Forms.Button();
            this.historialVentas = new System.Windows.Forms.Button();
            this.Envios = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Agregarclientes
            // 
            this.Agregarclientes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Agregarclientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Agregarclientes.FlatAppearance.BorderSize = 2;
            this.Agregarclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Agregarclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregarclientes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarclientes.Image = global::Inicio.Properties.Resources.revisar;
            this.Agregarclientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregarclientes.Location = new System.Drawing.Point(223, 72);
            this.Agregarclientes.Name = "Agregarclientes";
            this.Agregarclientes.Size = new System.Drawing.Size(168, 152);
            this.Agregarclientes.TabIndex = 6;
            this.Agregarclientes.Text = "Agregar Clientes";
            this.Agregarclientes.UseVisualStyleBackColor = false;
            this.Agregarclientes.Click += new System.EventHandler(this.Agregarclientes_Click);
            // 
            // historialVentas
            // 
            this.historialVentas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.historialVentas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.historialVentas.FlatAppearance.BorderSize = 2;
            this.historialVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.historialVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historialVentas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialVentas.Image = global::Inicio.Properties.Resources.alt_de_inventario;
            this.historialVentas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.historialVentas.Location = new System.Drawing.Point(49, 247);
            this.historialVentas.Name = "historialVentas";
            this.historialVentas.Size = new System.Drawing.Size(168, 152);
            this.historialVentas.TabIndex = 5;
            this.historialVentas.Text = " Historial Ventas";
            this.historialVentas.UseVisualStyleBackColor = false;
            this.historialVentas.Click += new System.EventHandler(this.historialVentas_Click);
            // 
            // Envios
            // 
            this.Envios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Envios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Envios.FlatAppearance.BorderSize = 2;
            this.Envios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.Envios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Envios.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Envios.Image = global::Inicio.Properties.Resources.flecha_del_camion_hacia_la_derecha;
            this.Envios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Envios.Location = new System.Drawing.Point(397, 72);
            this.Envios.Name = "Envios";
            this.Envios.Size = new System.Drawing.Size(168, 152);
            this.Envios.TabIndex = 4;
            this.Envios.Text = "Envio";
            this.Envios.UseVisualStyleBackColor = false;
            this.Envios.Click += new System.EventHandler(this.Envios_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::Inicio.Properties.Resources.venta;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.Location = new System.Drawing.Point(49, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(168, 152);
            this.button8.TabIndex = 2;
            this.button8.Text = "Vender";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // opcionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Inicio.Properties.Resources.tools_4088531_1280;
            this.ClientSize = new System.Drawing.Size(940, 570);
            this.Controls.Add(this.Agregarclientes);
            this.Controls.Add(this.historialVentas);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Envios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "opcionVentas";
            this.Text = "opcionVentas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button historialVentas;
        private System.Windows.Forms.Button Envios;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Agregarclientes;
    }
}