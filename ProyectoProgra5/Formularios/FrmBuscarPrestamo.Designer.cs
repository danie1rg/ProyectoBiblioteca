namespace ProyectoProgra5.Formularios
{
    partial class FrmBuscarPrestamo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Button BtnAceptar;
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CClavePrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CfechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BtnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CClavePrestamo,
            this.CfechaPrestamo,
            this.CfechaDevolucion});
            this.DgvLista.Location = new System.Drawing.Point(22, 12);
            this.DgvLista.MultiSelect = false;
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(509, 329);
            this.DgvLista.TabIndex = 2;
            this.DgvLista.VirtualMode = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Brown;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(393, 398);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(138, 40);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnAceptar.ForeColor = System.Drawing.Color.White;
            BtnAceptar.Location = new System.Drawing.Point(22, 398);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new System.Drawing.Size(138, 40);
            BtnAceptar.TabIndex = 5;
            BtnAceptar.Text = "Seleccionar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // CClavePrestamo
            // 
            this.CClavePrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CClavePrestamo.DataPropertyName = "ClavePrestamo";
            this.CClavePrestamo.HeaderText = "Cód.Prestamo";
            this.CClavePrestamo.Name = "CClavePrestamo";
            this.CClavePrestamo.ReadOnly = true;
            this.CClavePrestamo.Width = 154;
            // 
            // CfechaPrestamo
            // 
            this.CfechaPrestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CfechaPrestamo.DataPropertyName = "fechaPrestamo";
            this.CfechaPrestamo.HeaderText = "Fecha Préstamo";
            this.CfechaPrestamo.Name = "CfechaPrestamo";
            this.CfechaPrestamo.ReadOnly = true;
            // 
            // CfechaDevolucion
            // 
            this.CfechaDevolucion.DataPropertyName = "fechaDevolucion";
            this.CfechaDevolucion.HeaderText = "Fecha Devolución";
            this.CfechaDevolucion.Name = "CfechaDevolucion";
            this.CfechaDevolucion.ReadOnly = true;
            this.CfechaDevolucion.Width = 180;
            // 
            // FrmBuscarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DgvLista);
            this.Name = "FrmBuscarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda Préstamo";
            this.Load += new System.EventHandler(this.FrmBuscarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CClavePrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CfechaDevolucion;
    }
}