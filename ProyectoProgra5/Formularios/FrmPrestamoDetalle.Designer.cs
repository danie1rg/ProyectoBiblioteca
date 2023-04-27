namespace ProyectoProgra5.Formularios
{
    partial class FrmPrestamoDetalle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLibro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.DgvPrestamo = new System.Windows.Forms.DataGridView();
            this.CboxActivos = new System.Windows.Forms.CheckBox();
            this.BtnAgregarPrestamo = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CClavePrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCantidad);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtLibro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libro";
            // 
            // TxtLibro
            // 
            this.TxtLibro.Location = new System.Drawing.Point(119, 46);
            this.TxtLibro.Name = "TxtLibro";
            this.TxtLibro.Size = new System.Drawing.Size(423, 26);
            this.TxtLibro.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(119, 108);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 26);
            this.TxtCantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notas";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Location = new System.Drawing.Point(119, 170);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(423, 50);
            this.TxtNotas.TabIndex = 6;
            // 
            // DgvPrestamo
            // 
            this.DgvPrestamo.AllowUserToAddRows = false;
            this.DgvPrestamo.AllowUserToDeleteRows = false;
            this.DgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCantidad,
            this.CTitulo,
            this.CClavePrestamo,
            this.CfechaPrestamo,
            this.CfechaDevolucion});
            this.DgvPrestamo.Location = new System.Drawing.Point(46, 329);
            this.DgvPrestamo.Name = "DgvPrestamo";
            this.DgvPrestamo.ReadOnly = true;
            this.DgvPrestamo.Size = new System.Drawing.Size(759, 289);
            this.DgvPrestamo.TabIndex = 1;
            // 
            // CboxActivos
            // 
            this.CboxActivos.AutoSize = true;
            this.CboxActivos.Checked = true;
            this.CboxActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxActivos.Location = new System.Drawing.Point(622, 290);
            this.CboxActivos.Name = "CboxActivos";
            this.CboxActivos.Size = new System.Drawing.Size(183, 24);
            this.CboxActivos.TabIndex = 7;
            this.CboxActivos.Text = "Ver Presamos Activos";
            this.CboxActivos.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarPrestamo
            // 
            this.BtnAgregarPrestamo.Location = new System.Drawing.Point(55, 282);
            this.BtnAgregarPrestamo.Name = "BtnAgregarPrestamo";
            this.BtnAgregarPrestamo.Size = new System.Drawing.Size(153, 39);
            this.BtnAgregarPrestamo.TabIndex = 8;
            this.BtnAgregarPrestamo.Text = "Prestamo";
            this.BtnAgregarPrestamo.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(46, 641);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(153, 39);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(354, 641);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(153, 39);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(652, 641);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(153, 39);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // CCantidad
            // 
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            // 
            // CTitulo
            // 
            this.CTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CTitulo.DataPropertyName = "Titulo";
            this.CTitulo.HeaderText = "Libro";
            this.CTitulo.Name = "CTitulo";
            this.CTitulo.ReadOnly = true;
            // 
            // CClavePrestamo
            // 
            this.CClavePrestamo.DataPropertyName = "ClavePrestamo";
            this.CClavePrestamo.HeaderText = "Prestamo";
            this.CClavePrestamo.Name = "CClavePrestamo";
            this.CClavePrestamo.ReadOnly = true;
            // 
            // CfechaPrestamo
            // 
            this.CfechaPrestamo.DataPropertyName = "CfechaPrestamo";
            this.CfechaPrestamo.HeaderText = "Fecha Préstamo";
            this.CfechaPrestamo.Name = "CfechaPrestamo";
            this.CfechaPrestamo.ReadOnly = true;
            this.CfechaPrestamo.Width = 150;
            // 
            // CfechaDevolucion
            // 
            this.CfechaDevolucion.DataPropertyName = "CfechaDevolucion";
            this.CfechaDevolucion.HeaderText = "Fecha Devolución";
            this.CfechaDevolucion.Name = "CfechaDevolucion";
            this.CfechaDevolucion.ReadOnly = true;
            this.CfechaDevolucion.Width = 150;
            // 
            // FrmPrestamoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregarPrestamo);
            this.Controls.Add(this.CboxActivos);
            this.Controls.Add(this.DgvPrestamo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrestamoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamo Detalles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPrestamo;
        private System.Windows.Forms.CheckBox CboxActivos;
        private System.Windows.Forms.Button BtnAgregarPrestamo;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CClavePrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfechaDevolucion;
    }
}