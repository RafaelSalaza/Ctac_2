namespace Inicio.Formularios
{
    partial class opcionesEmpleado
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
            this.crearcuenta = new System.Windows.Forms.Button();
            this.crearemepleado = new System.Windows.Forms.Button();
            this.CrearUsuario = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crearcuenta
            // 
            this.crearcuenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.crearcuenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.crearcuenta.FlatAppearance.BorderSize = 2;
            this.crearcuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.crearcuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearcuenta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearcuenta.Image = global::Inicio.Properties.Resources.cheque_de_dinero;
            this.crearcuenta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crearcuenta.Location = new System.Drawing.Point(477, 73);
            this.crearcuenta.Name = "crearcuenta";
            this.crearcuenta.Size = new System.Drawing.Size(168, 152);
            this.crearcuenta.TabIndex = 8;
            this.crearcuenta.Text = "Crear cuenta";
            this.crearcuenta.UseVisualStyleBackColor = false;
            this.crearcuenta.Click += new System.EventHandler(this.crearcuenta_Click);
            // 
            // crearemepleado
            // 
            this.crearemepleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.crearemepleado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.crearemepleado.FlatAppearance.BorderSize = 2;
            this.crearemepleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.crearemepleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearemepleado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearemepleado.Image = global::Inicio.Properties.Resources.usuarios_alt;
            this.crearemepleado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crearemepleado.Location = new System.Drawing.Point(290, 73);
            this.crearemepleado.Name = "crearemepleado";
            this.crearemepleado.Size = new System.Drawing.Size(168, 152);
            this.crearemepleado.TabIndex = 7;
            this.crearemepleado.Text = "Crear Empleados";
            this.crearemepleado.UseVisualStyleBackColor = false;
            this.crearemepleado.Click += new System.EventHandler(this.crearemepleado_Click);
            // 
            // CrearUsuario
            // 
            this.CrearUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CrearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CrearUsuario.FlatAppearance.BorderSize = 2;
            this.CrearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearUsuario.Image = global::Inicio.Properties.Resources.circulo_de_usuario;
            this.CrearUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CrearUsuario.Location = new System.Drawing.Point(105, 73);
            this.CrearUsuario.Name = "CrearUsuario";
            this.CrearUsuario.Size = new System.Drawing.Size(168, 152);
            this.CrearUsuario.TabIndex = 6;
            this.CrearUsuario.Text = "Crear Usuarios";
            this.CrearUsuario.UseVisualStyleBackColor = false;
            this.CrearUsuario.Click += new System.EventHandler(this.CrearUsuario_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Inicio.Properties.Resources.money_cheque_editar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(664, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 152);
            this.button3.TabIndex = 5;
            this.button3.Text = " Crear sueldo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // opcionesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Inicio.Properties.Resources.worker_8463424_1280;
            this.ClientSize = new System.Drawing.Size(935, 588);
            this.Controls.Add(this.crearcuenta);
            this.Controls.Add(this.crearemepleado);
            this.Controls.Add(this.CrearUsuario);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "opcionesEmpleado";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button crearemepleado;
        private System.Windows.Forms.Button CrearUsuario;
        private System.Windows.Forms.Button crearcuenta;
    }
}