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
            this.BtnBuscarLibro = new System.Windows.Forms.Button();
            this.BtnBuscarPrestamo = new System.Windows.Forms.Button();
            this.TxtPrestamo = new System.Windows.Forms.TextBox();
            this.TxtLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboxActivos = new System.Windows.Forms.CheckBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CClavePrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscarLibro);
            this.groupBox1.Controls.Add(this.BtnBuscarPrestamo);
            this.groupBox1.Controls.Add(this.TxtPrestamo);
            this.groupBox1.Controls.Add(this.TxtLibro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // BtnBuscarLibro
            // 
            this.BtnBuscarLibro.Location = new System.Drawing.Point(606, 44);
            this.BtnBuscarLibro.Name = "BtnBuscarLibro";
            this.BtnBuscarLibro.Size = new System.Drawing.Size(105, 31);
            this.BtnBuscarLibro.TabIndex = 2;
            this.BtnBuscarLibro.Text = "Buscar";
            this.BtnBuscarLibro.UseVisualStyleBackColor = true;
            this.BtnBuscarLibro.Click += new System.EventHandler(this.BtnBuscarLibro_Click);
            // 
            // BtnBuscarPrestamo
            // 
            this.BtnBuscarPrestamo.Location = new System.Drawing.Point(606, 115);
            this.BtnBuscarPrestamo.Name = "BtnBuscarPrestamo";
            this.BtnBuscarPrestamo.Size = new System.Drawing.Size(105, 31);
            this.BtnBuscarPrestamo.TabIndex = 2;
            this.BtnBuscarPrestamo.Text = "Buscar";
            this.BtnBuscarPrestamo.UseVisualStyleBackColor = true;
            this.BtnBuscarPrestamo.Click += new System.EventHandler(this.BtnBuscarPrestamo_Click);
            // 
            // TxtPrestamo
            // 
            this.TxtPrestamo.Location = new System.Drawing.Point(119, 120);
            this.TxtPrestamo.Name = "TxtPrestamo";
            this.TxtPrestamo.Size = new System.Drawing.Size(423, 26);
            this.TxtPrestamo.TabIndex = 1;
            this.TxtPrestamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrestamo_KeyPress);
            // 
            // TxtLibro
            // 
            this.TxtLibro.Location = new System.Drawing.Point(119, 46);
            this.TxtLibro.Name = "TxtLibro";
            this.TxtLibro.Size = new System.Drawing.Size(423, 26);
            this.TxtLibro.TabIndex = 1;
            this.TxtLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLibro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prestamo";
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
            this.CboxActivos.CheckedChanged += new System.EventHandler(this.CboxActivos_CheckedChanged);
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
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(652, 641);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(153, 39);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(363, 641);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(153, 39);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Detalles del Préstamo";
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CTitulo,
            this.CClavePrestamo,
            this.CfechaPrestamo,
            this.CfechaDevolucion});
            this.DgvLista.Location = new System.Drawing.Point(46, 354);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(759, 268);
            this.DgvLista.TabIndex = 10;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellClick);
            this.DgvLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvLista_DataBindingComplete);
            // 
            // CID
            // 
            this.CID.DataPropertyName = "ID";
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
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
            this.CClavePrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CClavePrestamo.DataPropertyName = "ClavePrestamo";
            this.CClavePrestamo.HeaderText = "Clave Préstamo";
            this.CClavePrestamo.Name = "CClavePrestamo";
            this.CClavePrestamo.ReadOnly = true;
            this.CClavePrestamo.Width = 140;
            // 
            // CfechaPrestamo
            // 
            this.CfechaPrestamo.DataPropertyName = "fechaPrestamo";
            this.CfechaPrestamo.HeaderText = "Fecha Préstamo";
            this.CfechaPrestamo.Name = "CfechaPrestamo";
            this.CfechaPrestamo.ReadOnly = true;
            this.CfechaPrestamo.Width = 140;
            // 
            // CfechaDevolucion
            // 
            this.CfechaDevolucion.DataPropertyName = "fechaDevolucion";
            this.CfechaDevolucion.HeaderText = "Fecha Devolución";
            this.CfechaDevolucion.Name = "CfechaDevolucion";
            this.CfechaDevolucion.ReadOnly = true;
            this.CfechaDevolucion.Width = 140;
            // 
            // FrmPrestamoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 692);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.CboxActivos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrestamoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamo Detalles";
            this.Load += new System.EventHandler(this.FrmPrestamoDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscarPrestamo;
        private System.Windows.Forms.TextBox TxtLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CboxActivos;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnBuscarLibro;
        private System.Windows.Forms.TextBox TxtPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CClavePrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfechaDevolucion;
    }
}