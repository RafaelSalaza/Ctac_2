namespace Inicio.Formularios
{
    partial class Compras
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
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.tablaDetallescompra = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboprov = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipoPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CantidadSpinner = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.botonquitar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetallescompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadSpinner)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaProductos
            // 
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Location = new System.Drawing.Point(777, 116);
            this.tablaProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.Size = new System.Drawing.Size(488, 361);
            this.tablaProductos.TabIndex = 0;
            this.tablaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellClick);
            // 
            // tablaDetallescompra
            // 
            this.tablaDetallescompra.AllowUserToOrderColumns = true;
            this.tablaDetallescompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDetallescompra.Location = new System.Drawing.Point(16, 518);
            this.tablaDetallescompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaDetallescompra.Name = "tablaDetallescompra";
            this.tablaDetallescompra.RowHeadersWidth = 51;
            this.tablaDetallescompra.Size = new System.Drawing.Size(639, 185);
            this.tablaDetallescompra.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(248, 293);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(159, 38);
            this.txtPrecio.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Detalles de la compra";
            // 
            // comboprov
            // 
            this.comboprov.FormattingEnabled = true;
            this.comboprov.Location = new System.Drawing.Point(248, 15);
            this.comboprov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboprov.Name = "comboprov";
            this.comboprov.Size = new System.Drawing.Size(305, 24);
            this.comboprov.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Proveedor:";
            // 
            // comboTipoPago
            // 
            this.comboTipoPago.FormattingEnabled = true;
            this.comboTipoPago.Location = new System.Drawing.Point(1121, 518);
            this.comboTipoPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTipoPago.Name = "comboTipoPago";
            this.comboTipoPago.Size = new System.Drawing.Size(144, 24);
            this.comboTipoPago.TabIndex = 23;
            this.comboTipoPago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(973, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tipo de pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cantidad:";
            // 
            // CantidadSpinner
            // 
            this.CantidadSpinner.Location = new System.Drawing.Point(248, 231);
            this.CantidadSpinner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CantidadSpinner.Name = "CantidadSpinner";
            this.CantidadSpinner.Size = new System.Drawing.Size(160, 22);
            this.CantidadSpinner.TabIndex = 25;
            this.CantidadSpinner.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(419, 62);
            this.label6.TabIndex = 26;
            this.label6.Text = "Selecciona el producto de la tabla de la derecha dando click sobre el.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Producto seleccionado: ";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProducto.Location = new System.Drawing.Point(251, 162);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(82, 19);
            this.labelProducto.TabIndex = 28;
            this.labelProducto.Text = "Producto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboCat);
            this.panel1.Controls.Add(this.botonAgregar);
            this.panel1.Controls.Add(this.labelProducto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CantidadSpinner);
            this.panel1.Controls.Add(this.comboprov);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 462);
            this.panel1.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Categoria del producto:";
            // 
            // comboCat
            // 
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(248, 58);
            this.comboCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(305, 24);
            this.comboCat.TabIndex = 31;
            this.comboCat.SelectedIndexChanged += new System.EventHandler(this.comboCat_SelectedIndexChanged);
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackColor = System.Drawing.Color.White;
            this.botonAgregar.FlatAppearance.BorderSize = 0;
            this.botonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonAgregar.Location = new System.Drawing.Point(248, 376);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(308, 59);
            this.botonAgregar.TabIndex = 29;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(777, 59);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(487, 38);
            this.txtBuscar.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(773, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Buscar por nombre: ";
            // 
            // labeltotal
            // 
            this.labeltotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.Location = new System.Drawing.Point(449, 721);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(205, 21);
            this.labeltotal.TabIndex = 33;
            this.labeltotal.Text = "$$$$";
            // 
            // botonquitar
            // 
            this.botonquitar.BackColor = System.Drawing.Color.Gray;
            this.botonquitar.FlatAppearance.BorderSize = 0;
            this.botonquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonquitar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonquitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonquitar.Location = new System.Drawing.Point(697, 518);
            this.botonquitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonquitar.Name = "botonquitar";
            this.botonquitar.Size = new System.Drawing.Size(199, 48);
            this.botonquitar.TabIndex = 34;
            this.botonquitar.Text = "Quitar";
            this.botonquitar.UseVisualStyleBackColor = false;
            this.botonquitar.Click += new System.EventHandler(this.botonquitar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(697, 590);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 48);
            this.button2.TabIndex = 35;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pagar
            // 
            this.pagar.BackColor = System.Drawing.Color.LimeGreen;
            this.pagar.FlatAppearance.BorderSize = 0;
            this.pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagar.ForeColor = System.Drawing.Color.White;
            this.pagar.Location = new System.Drawing.Point(977, 597);
            this.pagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(288, 48);
            this.pagar.TabIndex = 36;
            this.pagar.Text = "PAGAR";
            this.pagar.UseVisualStyleBackColor = false;
            this.pagar.Click += new System.EventHandler(this.pagar_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 778);
            this.Controls.Add(this.pagar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botonquitar);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablaDetallescompra);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTipoPago);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Compras";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetallescompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadSpinner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.DataGridView tablaDetallescompra;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboprov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CantidadSpinner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Button botonquitar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button pagar;
    }
}