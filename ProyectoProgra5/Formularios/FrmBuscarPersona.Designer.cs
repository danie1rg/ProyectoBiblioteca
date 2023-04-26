namespace ProyectoProgra5.Formularios
{
    partial class FrmBuscarPersona
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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DtListaVista = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.Ccedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CclavePersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtListaVista)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(12, 45);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(573, 30);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // DtListaVista
            // 
            this.DtListaVista.AllowUserToAddRows = false;
            this.DtListaVista.AllowUserToDeleteRows = false;
            this.DtListaVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtListaVista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ccedula,
            this.Cnombre,
            this.Capellido,
            this.Cdescripcion,
            this.Cemail,
            this.CTelefono,
            this.CDireccion,
            this.CclavePersona});
            this.DtListaVista.Location = new System.Drawing.Point(12, 101);
            this.DtListaVista.MultiSelect = false;
            this.DtListaVista.Name = "DtListaVista";
            this.DtListaVista.ReadOnly = true;
            this.DtListaVista.RowHeadersVisible = false;
            this.DtListaVista.RowHeadersWidth = 51;
            this.DtListaVista.RowTemplate.Height = 24;
            this.DtListaVista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtListaVista.Size = new System.Drawing.Size(716, 268);
            this.DtListaVista.TabIndex = 1;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.Lime;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSeleccionar.Location = new System.Drawing.Point(600, 406);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(128, 45);
            this.BtnSeleccionar.TabIndex = 2;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Location = new System.Drawing.Point(457, 406);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(128, 45);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.Capellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Capellido.DataPropertyName = "apellido";
            this.Capellido.HeaderText = "Apellido";
            this.Capellido.MinimumWidth = 6;
            this.Capellido.Name = "Capellido";
            this.Capellido.ReadOnly = true;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.DataPropertyName = "descripcion";
            this.Cdescripcion.HeaderText = "Tipo";
            this.Cdescripcion.MinimumWidth = 6;
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.ReadOnly = true;
            this.Cdescripcion.Width = 125;
            // 
            // Cemail
            // 
            this.Cemail.DataPropertyName = "email";
            this.Cemail.HeaderText = "Email";
            this.Cemail.MinimumWidth = 6;
            this.Cemail.Name = "Cemail";
            this.Cemail.ReadOnly = true;
            this.Cemail.Visible = false;
            this.Cemail.Width = 125;
            // 
            // CTelefono
            // 
            this.CTelefono.DataPropertyName = "Telefono";
            this.CTelefono.HeaderText = "Telefono";
            this.CTelefono.MinimumWidth = 6;
            this.CTelefono.Name = "CTelefono";
            this.CTelefono.ReadOnly = true;
            this.CTelefono.Visible = false;
            this.CTelefono.Width = 125;
            // 
            // CDireccion
            // 
            this.CDireccion.DataPropertyName = "Direccion";
            this.CDireccion.HeaderText = "Dir";
            this.CDireccion.MinimumWidth = 6;
            this.CDireccion.Name = "CDireccion";
            this.CDireccion.ReadOnly = true;
            this.CDireccion.Visible = false;
            this.CDireccion.Width = 125;
            // 
            // CclavePersona
            // 
            this.CclavePersona.DataPropertyName = "clavePersona";
            this.CclavePersona.HeaderText = "Cód.";
            this.CclavePersona.MinimumWidth = 6;
            this.CclavePersona.Name = "CclavePersona";
            this.CclavePersona.ReadOnly = true;
            this.CclavePersona.Visible = false;
            this.CclavePersona.Width = 125;
            // 
            // FrmBuscarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 463);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.DtListaVista);
            this.Controls.Add(this.TxtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBuscarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Persona";
            this.Load += new System.EventHandler(this.FrmBuscarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtListaVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DtListaVista;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CclavePersona;
    }
}