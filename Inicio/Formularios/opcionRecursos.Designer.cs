namespace Inicio.Formularios
{
    partial class opcionRecursos
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
            this.AgregarVehiculos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgregarVehiculos
            // 
            this.AgregarVehiculos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AgregarVehiculos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AgregarVehiculos.FlatAppearance.BorderSize = 2;
            this.AgregarVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AgregarVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarVehiculos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarVehiculos.Image = global::Inicio.Properties.Resources.carros;
            this.AgregarVehiculos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarVehiculos.Location = new System.Drawing.Point(90, 60);
            this.AgregarVehiculos.Name = "AgregarVehiculos";
            this.AgregarVehiculos.Size = new System.Drawing.Size(168, 152);
            this.AgregarVehiculos.TabIndex = 2;
            this.AgregarVehiculos.Text = "Agregar Vehiculos";
            this.AgregarVehiculos.UseVisualStyleBackColor = false;
            this.AgregarVehiculos.Click += new System.EventHandler(this.AgregarVehiculos_Click);
            // 
            // opcionRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Inicio.Properties.Resources.truck_2707699_1280;
            this.ClientSize = new System.Drawing.Size(974, 587);
            this.Controls.Add(this.AgregarVehiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "opcionRecursos";
            this.Text = "opcionRecursos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AgregarVehiculos;
    }
}