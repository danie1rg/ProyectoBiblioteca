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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarPersona = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DtimerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.TxtPersona = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCrearPrestamo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.BtnCrearPrestamo.Location = new System.Drawing.Point(125, 595);
            this.BtnCrearPrestamo.Name = "BtnCrearPrestamo";
            this.BtnCrearPrestamo.Size = new System.Drawing.Size(530, 37);
            this.BtnCrearPrestamo.TabIndex = 1;
            this.BtnCrearPrestamo.Text = "Crear Prestamo";
            this.BtnCrearPrestamo.UseVisualStyleBackColor = true;
            this.BtnCrearPrestamo.Click += new System.EventHandler(this.BtnCrearPrestamo_Click);
            // 
            // FrmRegistroPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 658);
            this.Controls.Add(this.BtnCrearPrestamo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmRegistroPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Prestamo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}