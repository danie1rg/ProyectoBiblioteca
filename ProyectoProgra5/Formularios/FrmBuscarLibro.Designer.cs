namespace ProyectoProgra5.Formularios
{
    partial class FrmBuscarLibro
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
            System.Windows.Forms.Button BtnAceptar;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CClaveLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            BtnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = System.Drawing.Color.SeaGreen;
            BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnAceptar.ForeColor = System.Drawing.Color.White;
            BtnAceptar.Location = new System.Drawing.Point(83, 398);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new System.Drawing.Size(138, 40);
            BtnAceptar.TabIndex = 5;
            BtnAceptar.Text = "Seleccionar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CClaveLibro,
            this.CTitulo,
            this.CCantidadPaginas});
            this.DgvLista.Location = new System.Drawing.Point(12, 12);
            this.DgvLista.MultiSelect = false;
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(776, 329);
            this.DgvLista.TabIndex = 2;
            this.DgvLista.VirtualMode = true;
            // 
            // CClaveLibro
            // 
            this.CClaveLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CClaveLibro.DataPropertyName = "ClaveLibro";
            this.CClaveLibro.HeaderText = "Cód.Libro";
            this.CClaveLibro.Name = "CClaveLibro";
            this.CClaveLibro.ReadOnly = true;
            this.CClaveLibro.Width = 117;
            // 
            // CTitulo
            // 
            this.CTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CTitulo.DataPropertyName = "Titulo";
            this.CTitulo.HeaderText = "Titulo";
            this.CTitulo.Name = "CTitulo";
            this.CTitulo.ReadOnly = true;
            // 
            // CCantidadPaginas
            // 
            this.CCantidadPaginas.DataPropertyName = "CantidadPaginas";
            this.CCantidadPaginas.HeaderText = "Páginas";
            this.CCantidadPaginas.Name = "CCantidadPaginas";
            this.CCantidadPaginas.ReadOnly = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(591, 384);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(138, 40);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmBuscarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DgvLista);
            this.Name = "FrmBuscarLibro";
            this.Text = "FrmBuscarLibro";
            this.Load += new System.EventHandler(this.FrmBuscarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CClaveLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadPaginas;
    }
}