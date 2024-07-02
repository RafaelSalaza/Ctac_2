namespace Inicio.Formularios
{
    partial class VerProyectos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPagado = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbIdDireccion = new System.Windows.Forms.ComboBox();
            this.cmbIdEstadoProyecto = new System.Windows.Forms.ComboBox();
            this.chkFinanciado = new System.Windows.Forms.CheckBox();
            this.cmbIdTipoPago = new System.Windows.Forms.ComboBox();
            this.txtPrecioProyecto = new System.Windows.Forms.TextBox();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.cmbIdCategoriaProyecto = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1269, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyectos";
            // 
            // chkPagado
            // 
            this.chkPagado.AutoSize = true;
            this.chkPagado.Location = new System.Drawing.Point(981, 502);
            this.chkPagado.Name = "chkPagado";
            this.chkPagado.Size = new System.Drawing.Size(18, 17);
            this.chkPagado.TabIndex = 47;
            this.chkPagado.UseVisualStyleBackColor = true;
            this.chkPagado.UseWaitCursor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(1139, 329);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 40);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.UseWaitCursor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbIdDireccion
            // 
            this.cmbIdDireccion.FormattingEnabled = true;
            this.cmbIdDireccion.Location = new System.Drawing.Point(402, 423);
            this.cmbIdDireccion.Name = "cmbIdDireccion";
            this.cmbIdDireccion.Size = new System.Drawing.Size(152, 24);
            this.cmbIdDireccion.TabIndex = 45;
            this.cmbIdDireccion.UseWaitCursor = true;
            this.cmbIdDireccion.SelectedIndexChanged += new System.EventHandler(this.cmbIdDireccion_SelectedIndexChanged);
            // 
            // cmbIdEstadoProyecto
            // 
            this.cmbIdEstadoProyecto.FormattingEnabled = true;
            this.cmbIdEstadoProyecto.Location = new System.Drawing.Point(883, 551);
            this.cmbIdEstadoProyecto.Name = "cmbIdEstadoProyecto";
            this.cmbIdEstadoProyecto.Size = new System.Drawing.Size(190, 24);
            this.cmbIdEstadoProyecto.TabIndex = 44;
            this.cmbIdEstadoProyecto.UseWaitCursor = true;
            // 
            // chkFinanciado
            // 
            this.chkFinanciado.AutoSize = true;
            this.chkFinanciado.Location = new System.Drawing.Point(981, 442);
            this.chkFinanciado.Name = "chkFinanciado";
            this.chkFinanciado.Size = new System.Drawing.Size(18, 17);
            this.chkFinanciado.TabIndex = 43;
            this.chkFinanciado.UseVisualStyleBackColor = true;
            this.chkFinanciado.UseWaitCursor = true;
            // 
            // cmbIdTipoPago
            // 
            this.cmbIdTipoPago.FormattingEnabled = true;
            this.cmbIdTipoPago.Location = new System.Drawing.Point(878, 376);
            this.cmbIdTipoPago.Name = "cmbIdTipoPago";
            this.cmbIdTipoPago.Size = new System.Drawing.Size(190, 24);
            this.cmbIdTipoPago.TabIndex = 42;
            this.cmbIdTipoPago.UseWaitCursor = true;
            // 
            // txtPrecioProyecto
            // 
            this.txtPrecioProyecto.Location = new System.Drawing.Point(878, 325);
            this.txtPrecioProyecto.Name = "txtPrecioProyecto";
            this.txtPrecioProyecto.Size = new System.Drawing.Size(190, 22);
            this.txtPrecioProyecto.TabIndex = 41;
            this.txtPrecioProyecto.UseWaitCursor = true;
            this.txtPrecioProyecto.TextChanged += new System.EventHandler(this.txtPrecioProyecto_TextChanged);
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(399, 530);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(152, 24);
            this.cmbIdCliente.TabIndex = 40;
            this.cmbIdCliente.UseWaitCursor = true;
            // 
            // cmbIdCategoriaProyecto
            // 
            this.cmbIdCategoriaProyecto.FormattingEnabled = true;
            this.cmbIdCategoriaProyecto.Location = new System.Drawing.Point(399, 484);
            this.cmbIdCategoriaProyecto.Name = "cmbIdCategoriaProyecto";
            this.cmbIdCategoriaProyecto.Size = new System.Drawing.Size(152, 24);
            this.cmbIdCategoriaProyecto.TabIndex = 39;
            this.cmbIdCategoriaProyecto.UseWaitCursor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(402, 365);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(152, 22);
            this.txtDescripcion.TabIndex = 38;
            this.txtDescripcion.UseWaitCursor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(402, 324);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 22);
            this.txtNombre.TabIndex = 37;
            this.txtNombre.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(618, 551);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 37);
            this.label12.TabIndex = 36;
            this.label12.Text = "Estado del proyecto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(641, 494);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 37);
            this.label11.TabIndex = 35;
            this.label11.Text = "Pagado";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(641, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 37);
            this.label10.TabIndex = 34;
            this.label10.Text = "Financiado";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(641, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 37);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tipo de pago";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(641, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 37);
            this.label8.TabIndex = 32;
            this.label8.Text = "Precio";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 37);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cliente";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 37);
            this.label6.TabIndex = 30;
            this.label6.Text = "Categoria";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 37);
            this.label5.TabIndex = 29;
            this.label5.Text = "Direccion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 37);
            this.label3.TabIndex = 27;
            this.label3.Text = "Descripccion del proyecto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre del proyecto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseWaitCursor = true;
            // 
            // VerProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1385, 630);
            this.Controls.Add(this.chkPagado);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbIdDireccion);
            this.Controls.Add(this.cmbIdEstadoProyecto);
            this.Controls.Add(this.chkFinanciado);
            this.Controls.Add(this.cmbIdTipoPago);
            this.Controls.Add(this.txtPrecioProyecto);
            this.Controls.Add(this.cmbIdCliente);
            this.Controls.Add(this.cmbIdCategoriaProyecto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VerProyectos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.VerProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPagado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbIdDireccion;
        private System.Windows.Forms.ComboBox cmbIdEstadoProyecto;
        private System.Windows.Forms.CheckBox chkFinanciado;
        private System.Windows.Forms.ComboBox cmbIdTipoPago;
        private System.Windows.Forms.TextBox txtPrecioProyecto;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.ComboBox cmbIdCategoriaProyecto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}