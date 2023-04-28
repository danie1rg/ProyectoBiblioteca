namespace ProyectoProgra5.Formularios
{
    partial class FrmPrestamosActivos
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
            this.DtLista = new System.Windows.Forms.DataGridView();
            this.Ccedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CclavePrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLibrosPrestamos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CclaveLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CbActivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtLista)).BeginInit();
            this.SuspendLayout();
            // 
            // DtLista
            // 
            this.DtLista.AllowUserToAddRows = false;
            this.DtLista.AllowUserToDeleteRows = false;
            this.DtLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ccedula,
            this.Cnombre,
            this.Capellido,
            this.CTelefono,
            this.CFechaPrestamo,
            this.CfechaDevolucion,
            this.CclavePrestamo,
            this.CLibrosPrestamos,
            this.Ctitulo,
            this.CclaveLibro});
            this.DtLista.Location = new System.Drawing.Point(12, 114);
            this.DtLista.MultiSelect = false;
            this.DtLista.Name = "DtLista";
            this.DtLista.ReadOnly = true;
            this.DtLista.RowHeadersVisible = false;
            this.DtLista.RowHeadersWidth = 51;
            this.DtLista.RowTemplate.Height = 24;
            this.DtLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtLista.Size = new System.Drawing.Size(1247, 427);
            this.DtLista.TabIndex = 0;
            // 
            // Ccedula
            // 
            this.Ccedula.DataPropertyName = "cedula";
            this.Ccedula.HeaderText = "Cédula";
            this.Ccedula.MinimumWidth = 6;
            this.Ccedula.Name = "Ccedula";
            this.Ccedula.ReadOnly = true;
            this.Ccedula.Width = 125;
            // 
            // Cnombre
            // 
            this.Cnombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cnombre.DataPropertyName = "nombre";
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.MinimumWidth = 6;
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            // 
            // Capellido
            // 
            this.Capellido.DataPropertyName = "apellido";
            this.Capellido.HeaderText = "Apellido";
            this.Capellido.MinimumWidth = 6;
            this.Capellido.Name = "Capellido";
            this.Capellido.ReadOnly = true;
            this.Capellido.Width = 125;
            // 
            // CTelefono
            // 
            this.CTelefono.DataPropertyName = "Telefono";
            this.CTelefono.HeaderText = "Télefono";
            this.CTelefono.MinimumWidth = 6;
            this.CTelefono.Name = "CTelefono";
            this.CTelefono.ReadOnly = true;
            this.CTelefono.Width = 125;
            // 
            // CFechaPrestamo
            // 
            this.CFechaPrestamo.DataPropertyName = "fechaPrestamo";
            this.CFechaPrestamo.HeaderText = "Prestamo";
            this.CFechaPrestamo.MinimumWidth = 6;
            this.CFechaPrestamo.Name = "CFechaPrestamo";
            this.CFechaPrestamo.ReadOnly = true;
            this.CFechaPrestamo.Width = 125;
            // 
            // CfechaDevolucion
            // 
            this.CfechaDevolucion.DataPropertyName = "fechaDevolucion";
            this.CfechaDevolucion.HeaderText = "Devolución";
            this.CfechaDevolucion.MinimumWidth = 6;
            this.CfechaDevolucion.Name = "CfechaDevolucion";
            this.CfechaDevolucion.ReadOnly = true;
            this.CfechaDevolucion.Width = 125;
            // 
            // CclavePrestamo
            // 
            this.CclavePrestamo.DataPropertyName = "clavePrestamo";
            this.CclavePrestamo.HeaderText = "clavePrestamo";
            this.CclavePrestamo.MinimumWidth = 6;
            this.CclavePrestamo.Name = "CclavePrestamo";
            this.CclavePrestamo.ReadOnly = true;
            this.CclavePrestamo.Visible = false;
            this.CclavePrestamo.Width = 125;
            // 
            // CLibrosPrestamos
            // 
            this.CLibrosPrestamos.DataPropertyName = "LibrosPrestamos";
            this.CLibrosPrestamos.HeaderText = "Cantidad de Libros";
            this.CLibrosPrestamos.MinimumWidth = 6;
            this.CLibrosPrestamos.Name = "CLibrosPrestamos";
            this.CLibrosPrestamos.ReadOnly = true;
            this.CLibrosPrestamos.Width = 125;
            // 
            // Ctitulo
            // 
            this.Ctitulo.DataPropertyName = "titulo";
            this.Ctitulo.HeaderText = "Libro";
            this.Ctitulo.MinimumWidth = 6;
            this.Ctitulo.Name = "Ctitulo";
            this.Ctitulo.ReadOnly = true;
            this.Ctitulo.Width = 125;
            // 
            // CclaveLibro
            // 
            this.CclaveLibro.DataPropertyName = "claveLibro";
            this.CclaveLibro.HeaderText = "Clave libro";
            this.CclaveLibro.MinimumWidth = 6;
            this.CclaveLibro.Name = "CclaveLibro";
            this.CclaveLibro.ReadOnly = true;
            this.CclaveLibro.Visible = false;
            this.CclaveLibro.Width = 125;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(12, 52);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(915, 30);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(1099, 572);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(143, 52);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Cancelar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // CbActivos
            // 
            this.CbActivos.AutoSize = true;
            this.CbActivos.Checked = true;
            this.CbActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbActivos.Location = new System.Drawing.Point(1020, 50);
            this.CbActivos.Name = "CbActivos";
            this.CbActivos.Size = new System.Drawing.Size(196, 29);
            this.CbActivos.TabIndex = 4;
            this.CbActivos.Text = "Prestamos Activos";
            this.CbActivos.UseVisualStyleBackColor = true;
            this.CbActivos.CheckedChanged += new System.EventHandler(this.CbActivos_CheckedChanged);
            // 
            // FrmPrestamosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 648);
            this.Controls.Add(this.CbActivos);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.DtLista);
            this.Controls.Add(this.TxtBuscar);
            this.Name = "FrmPrestamosActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.FrmPrestamosActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtLista;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CclavePrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLibrosPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CclaveLibro;
        private System.Windows.Forms.CheckBox CbActivos;
    }
}