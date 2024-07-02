namespace Inicio
{
    partial class Marcaformcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombremarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtactualizar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonbuscar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.tablaMarcas = new System.Windows.Forms.DataGridView();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la marca: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombremarca
            // 
            this.txtNombremarca.Location = new System.Drawing.Point(364, 44);
            this.txtNombremarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombremarca.Multiline = true;
            this.txtNombremarca.Name = "txtNombremarca";
            this.txtNombremarca.Size = new System.Drawing.Size(160, 32);
            this.txtNombremarca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por nombre: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(364, 149);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(160, 32);
            this.txtBuscar.TabIndex = 4;
            // 
            // txtactualizar
            // 
            this.txtactualizar.Location = new System.Drawing.Point(364, 248);
            this.txtactualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtactualizar.Multiline = true;
            this.txtactualizar.Name = "txtactualizar";
            this.txtactualizar.Size = new System.Drawing.Size(160, 32);
            this.txtactualizar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Editar nombre: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackColor = System.Drawing.Color.DimGray;
            this.botonAgregar.FlatAppearance.BorderSize = 0;
            this.botonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonAgregar.Location = new System.Drawing.Point(551, 18);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(114, 57);
            this.botonAgregar.TabIndex = 7;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonbuscar
            // 
            this.botonbuscar.BackColor = System.Drawing.Color.DimGray;
            this.botonbuscar.FlatAppearance.BorderSize = 0;
            this.botonbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonbuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonbuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonbuscar.Location = new System.Drawing.Point(551, 123);
            this.botonbuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonbuscar.Name = "botonbuscar";
            this.botonbuscar.Size = new System.Drawing.Size(114, 57);
            this.botonbuscar.TabIndex = 8;
            this.botonbuscar.Text = "Buscar";
            this.botonbuscar.UseVisualStyleBackColor = false;
            this.botonbuscar.Click += new System.EventHandler(this.botonbuscar_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.DimGray;
            this.actualizar.FlatAppearance.BorderSize = 0;
            this.actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actualizar.Location = new System.Drawing.Point(551, 227);
            this.actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(114, 57);
            this.actualizar.TabIndex = 9;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = false;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // tablaMarcas
            // 
            this.tablaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMarca,
            this.Nombre});
            this.tablaMarcas.Location = new System.Drawing.Point(23, 18);
            this.tablaMarcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablaMarcas.Name = "tablaMarcas";
            this.tablaMarcas.RowHeadersWidth = 51;
            this.tablaMarcas.RowTemplate.Height = 24;
            this.tablaMarcas.Size = new System.Drawing.Size(271, 220);
            this.tablaMarcas.TabIndex = 10;
            this.tablaMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMarcas_CellClick_1);
            // 
            // IdMarca
            // 
            this.IdMarca.HeaderText = "ID";
            this.IdMarca.MinimumWidth = 6;
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre marca";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Marcaformcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(688, 321);
            this.Controls.Add(this.tablaMarcas);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.botonbuscar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.txtactualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombremarca);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Marcaformcs";
            this.Text = "Marcaformcs";
            this.Load += new System.EventHandler(this.Marcaformcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombremarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtactualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonbuscar;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.DataGridView tablaMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}