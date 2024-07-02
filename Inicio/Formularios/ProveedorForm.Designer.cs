namespace Inicio.Formularios
{
    partial class ProveedorForm
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
            this.tablaProveedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreproveedor = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonactualizar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProveedor
            // 
            this.tablaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProveedor.Location = new System.Drawing.Point(24, 242);
            this.tablaProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablaProveedor.Name = "tablaProveedor";
            this.tablaProveedor.RowHeadersWidth = 51;
            this.tablaProveedor.RowTemplate.Height = 24;
            this.tablaProveedor.Size = new System.Drawing.Size(852, 247);
            this.tablaProveedor.TabIndex = 0;
            this.tablaProveedor.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tablaProveedor_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo proveedor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre:";
            // 
            // txtNombreproveedor
            // 
            this.txtNombreproveedor.Location = new System.Drawing.Point(106, 38);
            this.txtNombreproveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreproveedor.Multiline = true;
            this.txtNombreproveedor.Name = "txtNombreproveedor";
            this.txtNombreproveedor.Size = new System.Drawing.Size(186, 32);
            this.txtNombreproveedor.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(106, 83);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(186, 32);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(106, 130);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(186, 32);
            this.txtnumero.TabIndex = 9;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(106, 171);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(186, 32);
            this.txtdireccion.TabIndex = 10;
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackColor = System.Drawing.Color.DimGray;
            this.botonAgregar.FlatAppearance.BorderSize = 0;
            this.botonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonAgregar.Location = new System.Drawing.Point(309, 38);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(183, 57);
            this.botonAgregar.TabIndex = 11;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonactualizar
            // 
            this.botonactualizar.BackColor = System.Drawing.Color.DimGray;
            this.botonactualizar.FlatAppearance.BorderSize = 0;
            this.botonactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonactualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonactualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonactualizar.Location = new System.Drawing.Point(309, 130);
            this.botonactualizar.Margin = new System.Windows.Forms.Padding(2);
            this.botonactualizar.Name = "botonactualizar";
            this.botonactualizar.Size = new System.Drawing.Size(183, 57);
            this.botonactualizar.TabIndex = 12;
            this.botonactualizar.Text = "Actualizar";
            this.botonactualizar.UseVisualStyleBackColor = false;
            this.botonactualizar.Click += new System.EventHandler(this.botonactualizar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(588, 69);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(288, 32);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(585, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Buscar por nombre: ";
            // 
            // ProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.botonactualizar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombreproveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaProveedor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProveedorForm";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.ProveedorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreproveedor;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonactualizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
    }
}