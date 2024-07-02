namespace Inicio.Formularios
{
    partial class opcionSucursal
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
            this.button1 = new System.Windows.Forms.Button();
            this.AgregarSucursal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Inicio.Properties.Resources.ubicacion_del_terreno;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(226, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 152);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear Dirección";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarSucursal
            // 
            this.AgregarSucursal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AgregarSucursal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AgregarSucursal.FlatAppearance.BorderSize = 2;
            this.AgregarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AgregarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarSucursal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarSucursal.Image = global::Inicio.Properties.Resources.tienda_alt;
            this.AgregarSucursal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarSucursal.Location = new System.Drawing.Point(28, 88);
            this.AgregarSucursal.Name = "AgregarSucursal";
            this.AgregarSucursal.Size = new System.Drawing.Size(168, 152);
            this.AgregarSucursal.TabIndex = 2;
            this.AgregarSucursal.Text = "Agregar Sucursal";
            this.AgregarSucursal.UseVisualStyleBackColor = false;
            this.AgregarSucursal.Click += new System.EventHandler(this.AgregarSucursal_Click);
            // 
            // opcionSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Inicio.Properties.Resources.buildings_217878_1280;
            this.ClientSize = new System.Drawing.Size(921, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AgregarSucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "opcionSucursal";
            this.Text = "opcionSucursal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AgregarSucursal;
    }
}