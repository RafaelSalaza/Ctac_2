namespace Inicio.Formularios
{
    partial class CrearFinanciacion
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
            this.dataGridViewFinanciaciones = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarProyecto = new System.Windows.Forms.Button();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.txtAnios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.btnCalcularFinanciacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinanciaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFinanciaciones
            // 
            this.dataGridViewFinanciaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFinanciaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFinanciaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinanciaciones.Location = new System.Drawing.Point(18, 22);
            this.dataGridViewFinanciaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewFinanciaciones.Name = "dataGridViewFinanciaciones";
            this.dataGridViewFinanciaciones.RowHeadersWidth = 51;
            this.dataGridViewFinanciaciones.RowTemplate.Height = 24;
            this.dataGridViewFinanciaciones.Size = new System.Drawing.Size(665, 148);
            this.dataGridViewFinanciaciones.TabIndex = 0;
            // 
            // btnSeleccionarProyecto
            // 
            this.btnSeleccionarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSeleccionarProyecto.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionarProyecto.Location = new System.Drawing.Point(18, 181);
            this.btnSeleccionarProyecto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionarProyecto.Name = "btnSeleccionarProyecto";
            this.btnSeleccionarProyecto.Size = new System.Drawing.Size(142, 53);
            this.btnSeleccionarProyecto.TabIndex = 1;
            this.btnSeleccionarProyecto.Text = "Seleccionar proyecto";
            this.btnSeleccionarProyecto.UseVisualStyleBackColor = false;
            this.btnSeleccionarProyecto.Click += new System.EventHandler(this.btnSeleccionarProyecto_Click);
            // 
            // txtProyecto
            // 
            this.txtProyecto.Location = new System.Drawing.Point(18, 247);
            this.txtProyecto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProyecto.Multiline = true;
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.ReadOnly = true;
            this.txtProyecto.Size = new System.Drawing.Size(144, 25);
            this.txtProyecto.TabIndex = 2;
            // 
            // txtAnios
            // 
            this.txtAnios.Location = new System.Drawing.Point(203, 236);
            this.txtAnios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnios.Multiline = true;
            this.txtAnios.Name = "txtAnios";
            this.txtAnios.Size = new System.Drawing.Size(103, 25);
            this.txtAnios.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar cantidad de años";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Interes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(434, 236);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInteres.Multiline = true;
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(103, 25);
            this.txtInteres.TabIndex = 5;
            // 
            // btnCalcularFinanciacion
            // 
            this.btnCalcularFinanciacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalcularFinanciacion.FlatAppearance.BorderSize = 0;
            this.btnCalcularFinanciacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularFinanciacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularFinanciacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularFinanciacion.Location = new System.Drawing.Point(521, 282);
            this.btnCalcularFinanciacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcularFinanciacion.Name = "btnCalcularFinanciacion";
            this.btnCalcularFinanciacion.Size = new System.Drawing.Size(162, 45);
            this.btnCalcularFinanciacion.TabIndex = 7;
            this.btnCalcularFinanciacion.Text = "Calcular Financiacion";
            this.btnCalcularFinanciacion.UseVisualStyleBackColor = false;
            this.btnCalcularFinanciacion.Click += new System.EventHandler(this.btnCalcularFinanciacion_Click);
            // 
            // CrearFinanciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(706, 338);
            this.Controls.Add(this.btnCalcularFinanciacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnios);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.btnSeleccionarProyecto);
            this.Controls.Add(this.dataGridViewFinanciaciones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearFinanciacion";
            this.Text = "CrearFinanciacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinanciaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFinanciaciones;
        private System.Windows.Forms.Button btnSeleccionarProyecto;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.TextBox txtAnios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Button btnCalcularFinanciacion;
    }
}