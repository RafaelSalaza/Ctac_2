namespace Inicio
{
    partial class VentasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.combocategorias = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabladetalleventas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.CantidadSpinner = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboSucursales = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.clienteEventual = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tablaclientes = new System.Windows.Forms.DataGridView();
            this.comboSuc = new System.Windows.Forms.ComboBox();
            this.botonquitarcliente = new System.Windows.Forms.Button();
            this.botonagregarcliente = new System.Windows.Forms.Button();
            this.nombrecliente = new System.Windows.Forms.Label();
            this.Buscarcliente = new System.Windows.Forms.TextBox();
            this.labeltotal = new System.Windows.Forms.Label();
            this.pagar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTipoPago = new System.Windows.Forms.ComboBox();
            this.radioagregarenvio = new System.Windows.Forms.RadioButton();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioConFactura = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabladetalleventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadSpinner)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaclientes)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(233, 64);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(237, 32);
            this.txtBuscar.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Buscar por nombre: ";
            // 
            // tablaProductos
            // 
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Location = new System.Drawing.Point(12, 136);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.Size = new System.Drawing.Size(614, 166);
            this.tablaProductos.TabIndex = 32;
            this.tablaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellClick);
            // 
            // combocategorias
            // 
            this.combocategorias.FormattingEnabled = true;
            this.combocategorias.Location = new System.Drawing.Point(314, 20);
            this.combocategorias.Name = "combocategorias";
            this.combocategorias.Size = new System.Drawing.Size(156, 21);
            this.combocategorias.TabIndex = 54;
            this.combocategorias.SelectedIndexChanged += new System.EventHandler(this.combocategorias_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(229, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(20, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Sucursal";
            // 
            // tabladetalleventas
            // 
            this.tabladetalleventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabladetalleventas.Location = new System.Drawing.Point(12, 359);
            this.tabladetalleventas.Name = "tabladetalleventas";
            this.tabladetalleventas.Size = new System.Drawing.Size(443, 197);
            this.tabladetalleventas.TabIndex = 56;
            this.tabladetalleventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Detalles de la venta";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProducto.Location = new System.Drawing.Point(506, 11);
            this.labelProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(68, 17);
            this.labelProducto.TabIndex = 64;
            this.labelProducto.Text = "Producto";
            // 
            // CantidadSpinner
            // 
            this.CantidadSpinner.Location = new System.Drawing.Point(509, 57);
            this.CantidadSpinner.Name = "CantidadSpinner";
            this.CantidadSpinner.Size = new System.Drawing.Size(120, 20);
            this.CantidadSpinner.TabIndex = 61;
            this.CantidadSpinner.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Cantidad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.comboSucursales);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.botonAgregar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.labelProducto);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.CantidadSpinner);
            this.panel1.Controls.Add(this.combocategorias);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tablaProductos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 312);
            this.panel1.TabIndex = 66;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboSucursales
            // 
            this.comboSucursales.FormattingEnabled = true;
            this.comboSucursales.Location = new System.Drawing.Point(93, 16);
            this.comboSucursales.Name = "comboSucursales";
            this.comboSucursales.Size = new System.Drawing.Size(121, 21);
            this.comboSucursales.TabIndex = 67;
            this.comboSucursales.SelectedIndexChanged += new System.EventHandler(this.comboSucursales_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(24, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Sucursal";
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackColor = System.Drawing.Color.Transparent;
            this.botonAgregar.FlatAppearance.BorderSize = 0;
            this.botonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.botonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonAgregar.Image = global::Inicio.Properties.Resources.agregar__1_;
            this.botonAgregar.Location = new System.Drawing.Point(507, 84);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(74, 47);
            this.botonAgregar.TabIndex = 65;
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // clienteEventual
            // 
            this.clienteEventual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clienteEventual.Location = new System.Drawing.Point(23, 266);
            this.clienteEventual.Name = "clienteEventual";
            this.clienteEventual.Size = new System.Drawing.Size(153, 36);
            this.clienteEventual.TabIndex = 67;
            this.clienteEventual.TabStop = true;
            this.clienteEventual.Text = "Cliente Eventual";
            this.clienteEventual.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tablaclientes);
            this.panel2.Controls.Add(this.comboSuc);
            this.panel2.Controls.Add(this.botonquitarcliente);
            this.panel2.Controls.Add(this.botonagregarcliente);
            this.panel2.Controls.Add(this.nombrecliente);
            this.panel2.Controls.Add(this.clienteEventual);
            this.panel2.Controls.Add(this.Buscarcliente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(650, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 312);
            this.panel2.TabIndex = 68;
            // 
            // tablaclientes
            // 
            this.tablaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaclientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaclientes.Location = new System.Drawing.Point(23, 136);
            this.tablaclientes.Name = "tablaclientes";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.tablaclientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaclientes.Size = new System.Drawing.Size(322, 117);
            this.tablaclientes.TabIndex = 74;
            this.tablaclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaclientes_CellClick);
            // 
            // comboSuc
            // 
            this.comboSuc.FormattingEnabled = true;
            this.comboSuc.Location = new System.Drawing.Point(104, 53);
            this.comboSuc.Name = "comboSuc";
            this.comboSuc.Size = new System.Drawing.Size(121, 21);
            this.comboSuc.TabIndex = 73;
            this.comboSuc.SelectedIndexChanged += new System.EventHandler(this.comboSuc_SelectedIndexChanged);
            // 
            // botonquitarcliente
            // 
            this.botonquitarcliente.BackColor = System.Drawing.Color.DarkRed;
            this.botonquitarcliente.FlatAppearance.BorderSize = 0;
            this.botonquitarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonquitarcliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonquitarcliente.ForeColor = System.Drawing.Color.Snow;
            this.botonquitarcliente.Location = new System.Drawing.Point(196, 266);
            this.botonquitarcliente.Margin = new System.Windows.Forms.Padding(2);
            this.botonquitarcliente.Name = "botonquitarcliente";
            this.botonquitarcliente.Size = new System.Drawing.Size(149, 36);
            this.botonquitarcliente.TabIndex = 70;
            this.botonquitarcliente.Text = "Quitar";
            this.botonquitarcliente.UseVisualStyleBackColor = false;
            this.botonquitarcliente.Click += new System.EventHandler(this.botonquitarcliente_Click);
            // 
            // botonagregarcliente
            // 
            this.botonagregarcliente.BackColor = System.Drawing.Color.Transparent;
            this.botonagregarcliente.FlatAppearance.BorderSize = 0;
            this.botonagregarcliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.botonagregarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonagregarcliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonagregarcliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonagregarcliente.Image = global::Inicio.Properties.Resources.agregar;
            this.botonagregarcliente.Location = new System.Drawing.Point(257, 37);
            this.botonagregarcliente.Margin = new System.Windows.Forms.Padding(2);
            this.botonagregarcliente.Name = "botonagregarcliente";
            this.botonagregarcliente.Size = new System.Drawing.Size(88, 82);
            this.botonagregarcliente.TabIndex = 72;
            this.botonagregarcliente.UseVisualStyleBackColor = false;
            this.botonagregarcliente.Click += new System.EventHandler(this.botonagregarcliente_Click);
            // 
            // nombrecliente
            // 
            this.nombrecliente.AutoSize = true;
            this.nombrecliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrecliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nombrecliente.Location = new System.Drawing.Point(20, 20);
            this.nombrecliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombrecliente.Name = "nombrecliente";
            this.nombrecliente.Size = new System.Drawing.Size(57, 17);
            this.nombrecliente.TabIndex = 71;
            this.nombrecliente.Text = "Cliente";
            // 
            // Buscarcliente
            // 
            this.Buscarcliente.Location = new System.Drawing.Point(23, 89);
            this.Buscarcliente.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarcliente.Multiline = true;
            this.Buscarcliente.Name = "Buscarcliente";
            this.Buscarcliente.Size = new System.Drawing.Size(187, 32);
            this.Buscarcliente.TabIndex = 70;
            this.Buscarcliente.TextChanged += new System.EventHandler(this.Buscarcliente_TextChanged);
            // 
            // labeltotal
            // 
            this.labeltotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.Location = new System.Drawing.Point(301, 571);
            this.labeltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(154, 17);
            this.labeltotal.TabIndex = 69;
            this.labeltotal.Text = "$$$$";
            // 
            // pagar
            // 
            this.pagar.BackColor = System.Drawing.Color.LimeGreen;
            this.pagar.FlatAppearance.BorderSize = 0;
            this.pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagar.ForeColor = System.Drawing.Color.White;
            this.pagar.Location = new System.Drawing.Point(707, 549);
            this.pagar.Margin = new System.Windows.Forms.Padding(2);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(216, 39);
            this.pagar.TabIndex = 74;
            this.pagar.Text = "PAGAR";
            this.pagar.UseVisualStyleBackColor = false;
            this.pagar.Click += new System.EventHandler(this.pagar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(474, 417);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 39);
            this.button2.TabIndex = 73;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(474, 359);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 39);
            this.button3.TabIndex = 72;
            this.button3.Text = "Quitar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(699, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Tipo de pago:";
            // 
            // comboTipoPago
            // 
            this.comboTipoPago.FormattingEnabled = true;
            this.comboTipoPago.Location = new System.Drawing.Point(810, 370);
            this.comboTipoPago.Name = "comboTipoPago";
            this.comboTipoPago.Size = new System.Drawing.Size(109, 21);
            this.comboTipoPago.TabIndex = 71;
            // 
            // radioagregarenvio
            // 
            this.radioagregarenvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioagregarenvio.Location = new System.Drawing.Point(707, 430);
            this.radioagregarenvio.Name = "radioagregarenvio";
            this.radioagregarenvio.Size = new System.Drawing.Size(153, 36);
            this.radioagregarenvio.TabIndex = 75;
            this.radioagregarenvio.TabStop = true;
            this.radioagregarenvio.Text = "Añadir envio";
            this.radioagregarenvio.UseVisualStyleBackColor = false;
            this.radioagregarenvio.CheckedChanged += new System.EventHandler(this.radioagregarenvio_CheckedChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(880, 437);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 29);
            this.txtMonto.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(888, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Monto envio";
            // 
            // radioConFactura
            // 
            this.radioConFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioConFactura.Location = new System.Drawing.Point(3, 5);
            this.radioConFactura.Name = "radioConFactura";
            this.radioConFactura.Size = new System.Drawing.Size(243, 33);
            this.radioConFactura.TabIndex = 78;
            this.radioConFactura.TabStop = true;
            this.radioConFactura.Text = "Con factura";
            this.radioConFactura.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioConFactura);
            this.panel3.Location = new System.Drawing.Point(707, 485);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 41);
            this.panel3.TabIndex = 79;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 609);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.radioagregarenvio);
            this.Controls.Add(this.pagar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboTipoPago);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabladetalleventas);
            this.Name = "VentasForm";
            this.Text = "VentasForm";
            this.Load += new System.EventHandler(this.VentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabladetalleventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadSpinner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaclientes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.ComboBox combocategorias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabladetalleventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.NumericUpDown CantidadSpinner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton clienteEventual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nombrecliente;
        private System.Windows.Forms.TextBox Buscarcliente;
        private System.Windows.Forms.Button botonagregarcliente;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Button botonquitarcliente;
        private System.Windows.Forms.Button pagar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTipoPago;
        private System.Windows.Forms.ComboBox comboSuc;
        private System.Windows.Forms.ComboBox comboSucursales;
        private System.Windows.Forms.DataGridView tablaclientes;
        private System.Windows.Forms.RadioButton radioagregarenvio;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioConFactura;
        private System.Windows.Forms.Panel panel3;
    }
}