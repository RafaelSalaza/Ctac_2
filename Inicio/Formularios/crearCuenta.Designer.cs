namespace Inicio.Formularios
{
    partial class crearCuenta
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
            this.txtIdCuenta = new System.Windows.Forms.TextBox();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.btCrear = new System.Windows.Forms.Button();
            this.dgvCuenta = new System.Windows.Forms.DataGridView();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.lblIdCuenta = new System.Windows.Forms.Label();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCuenta
            // 
            this.txtIdCuenta.Location = new System.Drawing.Point(239, 77);
            this.txtIdCuenta.Name = "txtIdCuenta";
            this.txtIdCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdCuenta.TabIndex = 0;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(239, 118);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCuenta.TabIndex = 1;
            // 
            // btCrear
            // 
            this.btCrear.BackColor = System.Drawing.Color.Orange;
            this.btCrear.FlatAppearance.BorderSize = 0;
            this.btCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrear.ForeColor = System.Drawing.Color.White;
            this.btCrear.Location = new System.Drawing.Point(55, 259);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(150, 50);
            this.btCrear.TabIndex = 2;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = false;
            this.btCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCuenta
            // 
            this.dgvCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuenta.Location = new System.Drawing.Point(392, 66);
            this.dgvCuenta.Name = "dgvCuenta";
            this.dgvCuenta.Size = new System.Drawing.Size(509, 243);
            this.dgvCuenta.TabIndex = 3;
            this.dgvCuenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuenta_CellClick);
            this.dgvCuenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Location = new System.Drawing.Point(239, 197);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCuenta.TabIndex = 4;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(239, 158);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(100, 20);
            this.txtBanco.TabIndex = 5;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.SlateGray;
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(224, 259);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(150, 50);
            this.btEditar.TabIndex = 6;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblIdCuenta
            // 
            this.lblIdCuenta.AutoSize = true;
            this.lblIdCuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCuenta.Location = new System.Drawing.Point(86, 75);
            this.lblIdCuenta.Name = "lblIdCuenta";
            this.lblIdCuenta.Size = new System.Drawing.Size(87, 19);
            this.lblIdCuenta.TabIndex = 7;
            this.lblIdCuenta.Text = "Id_cuenta";
            // 
            // lblNumeroCuenta
            // 
            this.lblNumeroCuenta.AutoSize = true;
            this.lblNumeroCuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCuenta.Location = new System.Drawing.Point(86, 116);
            this.lblNumeroCuenta.Name = "lblNumeroCuenta";
            this.lblNumeroCuenta.Size = new System.Drawing.Size(131, 19);
            this.lblNumeroCuenta.TabIndex = 8;
            this.lblNumeroCuenta.Text = "Numero cuenta";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(86, 156);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(59, 19);
            this.lblBanco.TabIndex = 9;
            this.lblBanco.Text = "Banco";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCuenta.Location = new System.Drawing.Point(86, 198);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(100, 19);
            this.lblTipoCuenta.TabIndex = 10;
            this.lblTipoCuenta.Text = "Tipo cuenta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(387, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Crear Cuenta";
            // 
            // seleccionar
            // 
            this.seleccionar.BackColor = System.Drawing.Color.Orange;
            this.seleccionar.FlatAppearance.BorderSize = 0;
            this.seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionar.ForeColor = System.Drawing.Color.White;
            this.seleccionar.Location = new System.Drawing.Point(55, 340);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(150, 50);
            this.seleccionar.TabIndex = 23;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseVisualStyleBackColor = false;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // crearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(942, 412);
            this.Controls.Add(this.seleccionar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.lblNumeroCuenta);
            this.Controls.Add(this.lblIdCuenta);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.cmbTipoCuenta);
            this.Controls.Add(this.dgvCuenta);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.txtIdCuenta);
            this.Name = "crearCuenta";
            this.Text = "crearCuenta";
            this.Load += new System.EventHandler(this.crearCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCuenta;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.DataGridView dgvCuenta;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label lblIdCuenta;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button seleccionar;
    }
}