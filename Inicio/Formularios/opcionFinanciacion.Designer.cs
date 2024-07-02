namespace Inicio.Formularios
{
    partial class opcionFinanciacion
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
            this.Pagocuotas = new System.Windows.Forms.Button();
            this.Verfinan = new System.Windows.Forms.Button();
            this.Calcularfinan = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pagocuotas
            // 
            this.Pagocuotas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pagocuotas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Pagocuotas.FlatAppearance.BorderSize = 2;
            this.Pagocuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pagocuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pagocuotas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pagocuotas.Image = global::Inicio.Properties.Resources.tarifa;
            this.Pagocuotas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pagocuotas.Location = new System.Drawing.Point(612, 82);
            this.Pagocuotas.Name = "Pagocuotas";
            this.Pagocuotas.Size = new System.Drawing.Size(168, 152);
            this.Pagocuotas.TabIndex = 5;
            this.Pagocuotas.Text = "Pago de cuotas";
            this.Pagocuotas.UseVisualStyleBackColor = false;
            this.Pagocuotas.Click += new System.EventHandler(this.Pagocuotas_Click);
            // 
            // Verfinan
            // 
            this.Verfinan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Verfinan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Verfinan.FlatAppearance.BorderSize = 2;
            this.Verfinan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Verfinan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Verfinan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verfinan.Image = global::Inicio.Properties.Resources.money_cheque_editar__1_;
            this.Verfinan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Verfinan.Location = new System.Drawing.Point(422, 82);
            this.Verfinan.Name = "Verfinan";
            this.Verfinan.Size = new System.Drawing.Size(168, 152);
            this.Verfinan.TabIndex = 4;
            this.Verfinan.Text = "Financiaciones";
            this.Verfinan.UseVisualStyleBackColor = false;
            this.Verfinan.Click += new System.EventHandler(this.Verfinan_Click);
            // 
            // Calcularfinan
            // 
            this.Calcularfinan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Calcularfinan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Calcularfinan.FlatAppearance.BorderSize = 2;
            this.Calcularfinan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Calcularfinan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calcularfinan.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcularfinan.Image = global::Inicio.Properties.Resources.dinero_calculadora;
            this.Calcularfinan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Calcularfinan.Location = new System.Drawing.Point(233, 82);
            this.Calcularfinan.Name = "Calcularfinan";
            this.Calcularfinan.Size = new System.Drawing.Size(168, 152);
            this.Calcularfinan.TabIndex = 3;
            this.Calcularfinan.Text = "Calcular finaciacion y cuotas";
            this.Calcularfinan.UseVisualStyleBackColor = false;
            this.Calcularfinan.Click += new System.EventHandler(this.Calcularfinan_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::Inicio.Properties.Resources.manos_usd;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.Location = new System.Drawing.Point(35, 82);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(168, 152);
            this.button8.TabIndex = 2;
            this.button8.Text = "Agregar financiacion";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // opcionFinanciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Inicio.Properties.Resources.stock_1863880_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 549);
            this.Controls.Add(this.Pagocuotas);
            this.Controls.Add(this.Verfinan);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Calcularfinan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "opcionFinanciacion";
            this.Text = "opcionFinanciacion";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Pagocuotas;
        private System.Windows.Forms.Button Verfinan;
        private System.Windows.Forms.Button Calcularfinan;
        private System.Windows.Forms.Button button8;
    }
}