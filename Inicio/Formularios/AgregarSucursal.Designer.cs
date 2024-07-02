namespace Inicio.Formularios
{
    partial class AgregarSucursal
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
            this.btCrear = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.txtIdDireccion = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtHoraCierre = new System.Windows.Forms.TextBox();
            this.txtHoraApertura = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHoraCierre = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btAgregarDireccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // btCrear
            // 
            this.btCrear.BackColor = System.Drawing.Color.Orange;
            this.btCrear.FlatAppearance.BorderSize = 0;
            this.btCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrear.ForeColor = System.Drawing.Color.White;
            this.btCrear.Location = new System.Drawing.Point(15, 245);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(150, 50);
            this.btCrear.TabIndex = 0;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = false;
            this.btCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.SlateGray;
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(190, 245);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(150, 50);
            this.btEditar.TabIndex = 1;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIdDireccion
            // 
            this.txtIdDireccion.Location = new System.Drawing.Point(181, 37);
            this.txtIdDireccion.Name = "txtIdDireccion";
            this.txtIdDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtIdDireccion.TabIndex = 2;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(181, 78);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtCuenta.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtHoraCierre
            // 
            this.txtHoraCierre.Location = new System.Drawing.Point(181, 166);
            this.txtHoraCierre.Name = "txtHoraCierre";
            this.txtHoraCierre.Size = new System.Drawing.Size(100, 20);
            this.txtHoraCierre.TabIndex = 5;
            // 
            // txtHoraApertura
            // 
            this.txtHoraApertura.Location = new System.Drawing.Point(181, 207);
            this.txtHoraApertura.Name = "txtHoraApertura";
            this.txtHoraApertura.Size = new System.Drawing.Size(100, 20);
            this.txtHoraApertura.TabIndex = 6;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(58, 35);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(102, 19);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Id direccion";
            this.lblDireccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.Location = new System.Drawing.Point(58, 76);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(83, 19);
            this.lblCuenta.TabIndex = 8;
            this.lblCuenta.Text = "Id cuenta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(58, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 19);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblHoraCierre
            // 
            this.lblHoraCierre.AutoSize = true;
            this.lblHoraCierre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCierre.Location = new System.Drawing.Point(58, 167);
            this.lblHoraCierre.Name = "lblHoraCierre";
            this.lblHoraCierre.Size = new System.Drawing.Size(94, 19);
            this.lblHoraCierre.TabIndex = 10;
            this.lblHoraCierre.Text = "Hora cierre";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApertura.Location = new System.Drawing.Point(55, 205);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(117, 19);
            this.lblApertura.TabIndex = 11;
            this.lblApertura.Text = "Hora apertura";
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSucursal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursal.Location = new System.Drawing.Point(399, 56);
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.Size = new System.Drawing.Size(425, 239);
            this.dgvSucursal.TabIndex = 12;
            this.dgvSucursal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Agregar Sucursal";
            // 
            // btAgregarDireccion
            // 
            this.btAgregarDireccion.BackColor = System.Drawing.Color.Aqua;
            this.btAgregarDireccion.FlatAppearance.BorderSize = 0;
            this.btAgregarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarDireccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarDireccion.Location = new System.Drawing.Point(287, 37);
            this.btAgregarDireccion.Name = "btAgregarDireccion";
            this.btAgregarDireccion.Size = new System.Drawing.Size(106, 23);
            this.btAgregarDireccion.TabIndex = 23;
            this.btAgregarDireccion.Text = "Crear Dirección";
            this.btAgregarDireccion.UseVisualStyleBackColor = false;
            this.btAgregarDireccion.Click += new System.EventHandler(this.button3_Click);
            // 
            // AgregarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 387);
            this.Controls.Add(this.btAgregarDireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvSucursal);
            this.Controls.Add(this.lblApertura);
            this.Controls.Add(this.lblHoraCierre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtHoraApertura);
            this.Controls.Add(this.txtHoraCierre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtIdDireccion);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCrear);
            this.Name = "AgregarSucursal";
            this.Text = "AgregarSucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox txtIdDireccion;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtHoraCierre;
        private System.Windows.Forms.TextBox txtHoraApertura;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHoraCierre;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.DataGridView dgvSucursal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btAgregarDireccion;
    }
}