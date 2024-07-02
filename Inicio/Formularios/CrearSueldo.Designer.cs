namespace Inicio.Formularios
{
    partial class CrearSueldo
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
            this.btActualizar = new System.Windows.Forms.Button();
            this.dgvSueldo = new System.Windows.Forms.DataGridView();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSueldo)).BeginInit();
            this.SuspendLayout();
            // 
            // btCrear
            // 
            this.btCrear.BackColor = System.Drawing.Color.Orange;
            this.btCrear.FlatAppearance.BorderSize = 0;
            this.btCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrear.ForeColor = System.Drawing.Color.White;
            this.btCrear.Location = new System.Drawing.Point(45, 190);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(150, 50);
            this.btCrear.TabIndex = 0;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = false;
            this.btCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.Color.SlateGray;
            this.btActualizar.FlatAppearance.BorderSize = 0;
            this.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.ForeColor = System.Drawing.Color.White;
            this.btActualizar.Location = new System.Drawing.Point(213, 190);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(150, 50);
            this.btActualizar.TabIndex = 1;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvSueldo
            // 
            this.dgvSueldo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSueldo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSueldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSueldo.Location = new System.Drawing.Point(394, 49);
            this.dgvSueldo.Name = "dgvSueldo";
            this.dgvSueldo.Size = new System.Drawing.Size(567, 191);
            this.dgvSueldo.TabIndex = 2;
            this.dgvSueldo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSueldo_CellClick);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(213, 73);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpleado.TabIndex = 3;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(213, 109);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 4;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            this.txtSueldo.Leave += new System.EventHandler(this.txtSueldo_Leave);
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDEmpleado.Location = new System.Drawing.Point(98, 71);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(109, 19);
            this.lblIDEmpleado.TabIndex = 5;
            this.lblIDEmpleado.Text = "Id Empleado";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(98, 107);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(62, 19);
            this.lblSueldo.TabIndex = 6;
            this.lblSueldo.Text = "Sueldo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Crear Sueldo";
            // 
            // CrearSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(973, 300);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblIDEmpleado);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.dgvSueldo);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btCrear);
            this.Name = "CrearSueldo";
            this.Text = "CrearSueldo";
            this.Load += new System.EventHandler(this.CrearSueldo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSueldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.DataGridView dgvSueldo;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label label9;
    }
}