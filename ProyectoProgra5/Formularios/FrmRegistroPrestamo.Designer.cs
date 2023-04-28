namespace ProyectoProgra5.Formularios
{
    partial class FrmRegistroPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroPrestamo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarPersona = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DtimerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.TxtPersona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCrearPrestamo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgListaLibros = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.CClaveLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListaLibros)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscarPersona);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtimerDevolucion);
            this.groupBox1.Controls.Add(this.TxtPersona);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(728, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestamo";
            // 
            // BtnBuscarPersona
            // 
            this.BtnBuscarPersona.Location = new System.Drawing.Point(518, 45);
            this.BtnBuscarPersona.Name = "BtnBuscarPersona";
            this.BtnBuscarPersona.Size = new System.Drawing.Size(123, 36);
            this.BtnBuscarPersona.TabIndex = 4;
            this.BtnBuscarPersona.Text = "Buscar...";
            this.BtnBuscarPersona.UseVisualStyleBackColor = true;
            this.BtnBuscarPersona.Click += new System.EventHandler(this.BtnBuscarPersona_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Devolución";
            // 
            // DtimerDevolucion
            // 
            this.DtimerDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtimerDevolucion.Location = new System.Drawing.Point(256, 113);
            this.DtimerDevolucion.Name = "DtimerDevolucion";
            this.DtimerDevolucion.Size = new System.Drawing.Size(170, 34);
            this.DtimerDevolucion.TabIndex = 2;
            this.DtimerDevolucion.Value = new System.DateTime(2023, 4, 26, 0, 0, 0, 0);
            // 
            // TxtPersona
            // 
            this.TxtPersona.Location = new System.Drawing.Point(111, 47);
            this.TxtPersona.Name = "TxtPersona";
            this.TxtPersona.Size = new System.Drawing.Size(401, 34);
            this.TxtPersona.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // BtnCrearPrestamo
            // 
            this.BtnCrearPrestamo.BackColor = System.Drawing.Color.Lime;
            this.BtnCrearPrestamo.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnCrearPrestamo.Location = new System.Drawing.Point(125, 595);
            this.BtnCrearPrestamo.Name = "BtnCrearPrestamo";
            this.BtnCrearPrestamo.Size = new System.Drawing.Size(530, 37);
            this.BtnCrearPrestamo.TabIndex = 1;
            this.BtnCrearPrestamo.Text = "Crear Prestamo";
            this.BtnCrearPrestamo.UseVisualStyleBackColor = false;
            this.BtnCrearPrestamo.Click += new System.EventHandler(this.BtnCrearPrestamo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.DtgListaLibros);
            this.groupBox2.Location = new System.Drawing.Point(14, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestamo Detalle";
            // 
            // DtgListaLibros
            // 
            this.DtgListaLibros.AllowUserToAddRows = false;
            this.DtgListaLibros.AllowUserToDeleteRows = false;
            this.DtgListaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListaLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CClaveLibro,
            this.CTitulo});
            this.DtgListaLibros.Location = new System.Drawing.Point(15, 72);
            this.DtgListaLibros.MultiSelect = false;
            this.DtgListaLibros.Name = "DtgListaLibros";
            this.DtgListaLibros.ReadOnly = true;
            this.DtgListaLibros.RowHeadersVisible = false;
            this.DtgListaLibros.RowHeadersWidth = 51;
            this.DtgListaLibros.RowTemplate.Height = 24;
            this.DtgListaLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgListaLibros.Size = new System.Drawing.Size(689, 211);
            this.DtgListaLibros.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(721, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel1.Text = "Agregar Libro";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(101, 24);
            this.toolStripLabel2.Text = "Eliminar Libro";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // CClaveLibro
            // 
            this.CClaveLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CClaveLibro.DataPropertyName = "claveLibro";
            this.CClaveLibro.HeaderText = "Cód. Libro";
            this.CClaveLibro.MinimumWidth = 6;
            this.CClaveLibro.Name = "CClaveLibro";
            this.CClaveLibro.ReadOnly = true;
            // 
            // CTitulo
            // 
            this.CTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CTitulo.DataPropertyName = "Titulo";
            this.CTitulo.HeaderText = "Título";
            this.CTitulo.MinimumWidth = 6;
            this.CTitulo.Name = "CTitulo";
            this.CTitulo.ReadOnly = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // FrmRegistroPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnCrearPrestamo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmRegistroPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Prestamo";
            this.Load += new System.EventHandler(this.FrmRegistroPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListaLibros)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscarPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtimerDevolucion;
        private System.Windows.Forms.TextBox TxtPersona;
        private System.Windows.Forms.Button BtnCrearPrestamo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridView DtgListaLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn CClaveLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTitulo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}