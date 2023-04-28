namespace ProyectoProgra5.Formularios
{
    partial class FrmListarPrestamosPorHoy
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DtListar = new System.Windows.Forms.DataGridView();
            this.CclavePrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CclaveLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtListar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Location = new System.Drawing.Point(15, 388);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(119, 50);
            this.BtnEliminar.TabIndex = 0;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // DtListar
            // 
            this.DtListar.AllowUserToAddRows = false;
            this.DtListar.AllowUserToDeleteRows = false;
            this.DtListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CclavePrestamo,
            this.CclaveLibro,
            this.CfechaPrestamo,
            this.CfechaDevolucion,
            this.Ccedula,
            this.Cnombre,
            this.Capellido,
            this.Ctitulo});
            this.DtListar.Location = new System.Drawing.Point(12, 20);
            this.DtListar.MultiSelect = false;
            this.DtListar.Name = "DtListar";
            this.DtListar.ReadOnly = true;
            this.DtListar.RowHeadersVisible = false;
            this.DtListar.RowHeadersWidth = 51;
            this.DtListar.RowTemplate.Height = 24;
            this.DtListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtListar.Size = new System.Drawing.Size(1108, 352);
            this.DtListar.TabIndex = 1;
            this.DtListar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtListar_CellClick);
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
            // CclaveLibro
            // 
            this.CclaveLibro.DataPropertyName = "claveLibro";
            this.CclaveLibro.HeaderText = "claveLibro";
            this.CclaveLibro.MinimumWidth = 6;
            this.CclaveLibro.Name = "CclaveLibro";
            this.CclaveLibro.ReadOnly = true;
            this.CclaveLibro.Visible = false;
            this.CclaveLibro.Width = 125;
            // 
            // CfechaPrestamo
            // 
            this.CfechaPrestamo.DataPropertyName = "fechaPrestamo";
            this.CfechaPrestamo.HeaderText = "Prestamo";
            this.CfechaPrestamo.MinimumWidth = 6;
            this.CfechaPrestamo.Name = "CfechaPrestamo";
            this.CfechaPrestamo.ReadOnly = true;
            this.CfechaPrestamo.Width = 125;
            // 
            // CfechaDevolucion
            // 
            this.CfechaDevolucion.DataPropertyName = "fechaDevolucion";
            this.CfechaDevolucion.HeaderText = "fechaDevolucion";
            this.CfechaDevolucion.MinimumWidth = 6;
            this.CfechaDevolucion.Name = "CfechaDevolucion";
            this.CfechaDevolucion.ReadOnly = true;
            this.CfechaDevolucion.Width = 125;
            // 
            // Ccedula
            // 
            this.Ccedula.DataPropertyName = "cedula";
            this.Ccedula.HeaderText = "cedula";
            this.Ccedula.MinimumWidth = 6;
            this.Ccedula.Name = "Ccedula";
            this.Ccedula.ReadOnly = true;
            this.Ccedula.Width = 125;
            // 
            // Cnombre
            // 
            this.Cnombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cnombre.DataPropertyName = "nombre";
            this.Cnombre.HeaderText = "nombre";
            this.Cnombre.MinimumWidth = 6;
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            // 
            // Capellido
            // 
            this.Capellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Capellido.DataPropertyName = "apellido";
            this.Capellido.HeaderText = "Apellido";
            this.Capellido.MinimumWidth = 6;
            this.Capellido.Name = "Capellido";
            this.Capellido.ReadOnly = true;
            // 
            // Ctitulo
            // 
            this.Ctitulo.DataPropertyName = "titulo";
            this.Ctitulo.HeaderText = "Titulo";
            this.Ctitulo.MinimumWidth = 6;
            this.Ctitulo.Name = "Ctitulo";
            this.Ctitulo.ReadOnly = true;
            this.Ctitulo.Width = 125;
            // 
            // FrmListarPrestamosPorHoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.DtListar);
            this.Controls.Add(this.BtnEliminar);
            this.Name = "FrmListarPrestamosPorHoy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución de Prestamos de Hoy";
            this.Load += new System.EventHandler(this.FrmListarPrestamosPorHoy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView DtListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CclavePrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CclaveLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctitulo;
    }
}