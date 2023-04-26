namespace ProyectoProgra5.Formularios
{
    partial class FrmMDI
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuGestiones = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRolUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.BtntipoDePersona = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROSDEPRESTAMOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.MnuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestiones,
            this.MnuProcesos,
            this.MnuReportes,
            this.MnuSalir,
            this.MnuAcercaDe});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MnuPrincipal.Size = new System.Drawing.Size(904, 36);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuGestiones
            // 
            this.MnuGestiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGestionUsuarios,
            this.gestiónDeToolStripMenuItem,
            this.gestiónDeAutoresToolStripMenuItem,
            this.gestiónDeLibrosToolStripMenuItem,
            this.toolStripSeparator1,
            this.BtnRolUsuario,
            this.BtntipoDePersona});
            this.MnuGestiones.ForeColor = System.Drawing.SystemColors.Control;
            this.MnuGestiones.Name = "MnuGestiones";
            this.MnuGestiones.Size = new System.Drawing.Size(127, 32);
            this.MnuGestiones.Text = "GESTIONES";
            // 
            // BtnGestionUsuarios
            // 
            this.BtnGestionUsuarios.Name = "BtnGestionUsuarios";
            this.BtnGestionUsuarios.Size = new System.Drawing.Size(273, 32);
            this.BtnGestionUsuarios.Text = "Gestión de Usuarios";
            this.BtnGestionUsuarios.Click += new System.EventHandler(this.gestiónDeUsuariosToolStripMenuItem_Click);
            // 
            // gestiónDeToolStripMenuItem
            // 
            this.gestiónDeToolStripMenuItem.Name = "gestiónDeToolStripMenuItem";
            this.gestiónDeToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.gestiónDeToolStripMenuItem.Text = "Gestión de Personas";
            this.gestiónDeToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeToolStripMenuItem_Click);
            // 
            // gestiónDeAutoresToolStripMenuItem
            // 
            this.gestiónDeAutoresToolStripMenuItem.Name = "gestiónDeAutoresToolStripMenuItem";
            this.gestiónDeAutoresToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.gestiónDeAutoresToolStripMenuItem.Text = "Gestión de Autores";
            // 
            // gestiónDeLibrosToolStripMenuItem
            // 
            this.gestiónDeLibrosToolStripMenuItem.Name = "gestiónDeLibrosToolStripMenuItem";
            this.gestiónDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.gestiónDeLibrosToolStripMenuItem.Text = "Gestión de Libros";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(270, 6);
            // 
            // BtnRolUsuario
            // 
            this.BtnRolUsuario.Name = "BtnRolUsuario";
            this.BtnRolUsuario.Size = new System.Drawing.Size(273, 32);
            this.BtnRolUsuario.Text = "Usuario Rol";
            this.BtnRolUsuario.Click += new System.EventHandler(this.gestiónDeUsuarioRolToolStripMenuItem_Click);
            // 
            // BtntipoDePersona
            // 
            this.BtntipoDePersona.Name = "BtntipoDePersona";
            this.BtntipoDePersona.Size = new System.Drawing.Size(273, 32);
            this.BtntipoDePersona.Text = "Tipo de Persona";
            this.BtntipoDePersona.Click += new System.EventHandler(this.tipoDePersonaToolStripMenuItem_Click);
            // 
            // MnuProcesos
            // 
            this.MnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTROSDEPRESTAMOSToolStripMenuItem});
            this.MnuProcesos.ForeColor = System.Drawing.SystemColors.Control;
            this.MnuProcesos.Name = "MnuProcesos";
            this.MnuProcesos.Size = new System.Drawing.Size(123, 32);
            this.MnuProcesos.Text = "PROCESOS";
            // 
            // rEGISTROSDEPRESTAMOSToolStripMenuItem
            // 
            this.rEGISTROSDEPRESTAMOSToolStripMenuItem.Name = "rEGISTROSDEPRESTAMOSToolStripMenuItem";
            this.rEGISTROSDEPRESTAMOSToolStripMenuItem.Size = new System.Drawing.Size(342, 32);
            this.rEGISTROSDEPRESTAMOSToolStripMenuItem.Text = "REGISTROS DE PRESTAMOS";
            this.rEGISTROSDEPRESTAMOSToolStripMenuItem.Click += new System.EventHandler(this.rEGISTROSDEPRESTAMOSToolStripMenuItem_Click);
            // 
            // MnuReportes
            // 
            this.MnuReportes.ForeColor = System.Drawing.SystemColors.Control;
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(116, 32);
            this.MnuReportes.Text = "REPORTES";
            // 
            // MnuSalir
            // 
            this.MnuSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(76, 32);
            this.MnuSalir.Text = "SALIR";
            this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
            // 
            // MnuAcercaDe
            // 
            this.MnuAcercaDe.ForeColor = System.Drawing.SystemColors.Control;
            this.MnuAcercaDe.Name = "MnuAcercaDe";
            this.MnuAcercaDe.Size = new System.Drawing.Size(127, 32);
            this.MnuAcercaDe.Text = "ACERCA DE";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 31);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 25);
            this.toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // LblUsuario
            // 
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(77, 25);
            this.LblUsuario.Text = "Usuario";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MnuPrincipal);
            this.Name = "FrmMDI";
            this.Text = "Sistema Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestiones;
        private System.Windows.Forms.ToolStripMenuItem BtnGestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BtnRolUsuario;
        private System.Windows.Forms.ToolStripMenuItem BtntipoDePersona;
        private System.Windows.Forms.ToolStripMenuItem MnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROSDEPRESTAMOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuAcercaDe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuario;
    }
}