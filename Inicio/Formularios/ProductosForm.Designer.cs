namespace Inicio
{
    partial class ProductosForm
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
            this.comboSucursales = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combocategorias = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.botonactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProductos
            // 
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Location = new System.Drawing.Point(12, 79);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.Size = new System.Drawing.Size(515, 385);
            this.tablaProductos.TabIndex = 0;
            this.tablaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellClick);
            // 
            // comboSucursales
            // 
            this.comboSucursales.FormattingEnabled = true;
            this.comboSucursales.Location = new System.Drawing.Point(663, 43);
            this.comboSucursales.Name = "comboSucursales";
            this.comboSucursales.Size = new System.Drawing.Size(220, 21);
            this.comboSucursales.TabIndex = 37;
            this.comboSucursales.SelectedIndexChanged += new System.EventHandler(this.comboSucursales_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Sucursal";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(172, 28);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(215, 32);
            this.txtBuscar.TabIndex = 39;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Buscar por nombre: ";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(659, 287);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecioventa.Multiline = true;
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(186, 32);
            this.txtprecioventa.TabIndex = 47;
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(659, 240);
            this.txtdescrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescrip.Multiline = true;
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(186, 32);
            this.txtdescrip.TabIndex = 46;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(659, 202);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(186, 32);
            this.txtnombre.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(558, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Descripcción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Precio venta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(547, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Actualizar producto:";
            // 
            // combocategorias
            // 
            this.combocategorias.FormattingEnabled = true;
            this.combocategorias.Location = new System.Drawing.Point(663, 87);
            this.combocategorias.Name = "combocategorias";
            this.combocategorias.Size = new System.Drawing.Size(220, 21);
            this.combocategorias.TabIndex = 50;
            this.combocategorias.SelectedIndexChanged += new System.EventHandler(this.combocategorias_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Categoria:";
            // 
            // botonactualizar
            // 
            this.botonactualizar.BackColor = System.Drawing.Color.DimGray;
            this.botonactualizar.FlatAppearance.BorderSize = 0;
            this.botonactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonactualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonactualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonactualizar.Location = new System.Drawing.Point(561, 335);
            this.botonactualizar.Margin = new System.Windows.Forms.Padding(2);
            this.botonactualizar.Name = "botonactualizar";
            this.botonactualizar.Size = new System.Drawing.Size(292, 57);
            this.botonactualizar.TabIndex = 51;
            this.botonactualizar.Text = "Actualizar";
            this.botonactualizar.UseVisualStyleBackColor = false;
            this.botonactualizar.Click += new System.EventHandler(this.botonactualizar_Click);
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 489);
            this.Controls.Add(this.botonactualizar);
            this.Controls.Add(this.combocategorias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.txtdescrip);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboSucursales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaProductos);
            this.Name = "ProductosForm";
            this.Text = "ProductosForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.ComboBox comboSucursales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combocategorias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button botonactualizar;
    }
}