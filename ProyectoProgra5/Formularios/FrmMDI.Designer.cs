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
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gestiónDeUsuarioRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROSDEPRESTAMOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPrincipal.SuspendLayout();
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
            this.gestiónDeUsuariosToolStripMenuItem,
            this.gestiónDeToolStripMenuItem,
            this.gestiónDeAutoresToolStripMenuItem,
            this.gestiónDeLibrosToolStripMenuItem,
            this.toolStripSeparator1,
            this.gestiónDeUsuarioRolToolStripMenuItem,
            this.tipoDePersonaToolStripMenuItem});
            this.MnuGestiones.ForeColor = System.Drawing.SystemColors.Control;
            this.MnuGestiones.Name = "MnuGestiones";
            this.MnuGestiones.Size = new System.Drawing.Size(127, 32);
            this.MnuGestiones.Text = "GESTIONES";
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            this.gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            this.gestiónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.gestiónDeUsuariosToolStripMenuItem.Text = "Gestión de Usuarios";
            this.gestiónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeUsuariosToolStripMenuItem_Click);
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
            // gestiónDeUsuarioRolToolStripMenuItem
            // 
            this.gestiónDeUsuarioRolToolStripMenuItem.Name = "gestiónDeUsuarioRolToolStripMenuItem";
            this.gestiónDeUsuarioRolToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.gestiónDeUsuarioRolToolStripMenuItem.Text = "Usuario Rol";
            this.gestiónDeUsuarioRolToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeUsuarioRolToolStripMenuItem_Click);
            // 
            // tipoDePersonaToolStripMenuItem
            // 
            this.tipoDePersonaToolStripMenuItem.Name = "tipoDePersonaToolStripMenuItem";
            this.tipoDePersonaToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.tipoDePersonaToolStripMenuItem.Text = "Tipo de Persona";
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
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 566);
            this.Controls.Add(this.MnuPrincipal);
            this.Name = "FrmMDI";
            this.Text = "Sistema Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestiones;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuarioRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROSDEPRESTAMOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuAcercaDe;
    }
}