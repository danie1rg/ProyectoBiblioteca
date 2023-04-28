using Logica.Models;
using System;
using System.Windows.Forms;

namespace ProyectoProgra5.Formularios
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormGestionUsuarios.Visible)
            {
                Globales.MiFormGestionUsuarios = new FrmGestionDeUsuarios();

                Globales.MiFormGestionUsuarios.Show();
            }
        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            string InfoUsuario = string.Format("{0}  ({1})",
                                               Globales.MiUsuarioGlobal.UsuarioNombre,
                                               Globales.MiUsuarioGlobal.MiUsuarioRol.Descripcion);

            LblUsuario.Text = InfoUsuario;

            switch (Globales.MiUsuarioGlobal.MiUsuarioRol.UsuarioRolId)
            {
                case 1:
                    break;
                case 2:
                    BtnGestionUsuarios.Visible = false;
                    BtnRolUsuario.Visible = false;
                    BtntipoDePersona.Visible = false;
                    break;
            }
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestiónDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiGestionPersona.Visible)
            {
                Globales.MiGestionPersona = new  FrmGestionPersona();

                Globales.MiGestionPersona.Show();
            }

        }

        private void gestiónDeUsuarioRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiGestionRolUsuario.Visible)
            {
                Globales.MiGestionRolUsuario = new FrmGestionUsuarioRol();

                Globales.MiGestionRolUsuario.Show();
            }

        }

        private void tipoDePersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiGestionTipoDePersona.Visible)
            {
                Globales.MiGestionTipoDePersona = new FrmGestionTipoDePersona();

                Globales.MiGestionTipoDePersona.Show();
            }
        }

        private void gestiónDeAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiGestionAutor.Visible)
            {
                Globales.MiGestionAutor = new FrmGestionAutor();
                Globales.MiGestionAutor.Show();
            }
        }

        private void gestiónDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiGestionLibro.Visible)
            {
                Globales.MiGestionLibro = new FrmGestionLibro();

                Globales.MiGestionLibro.Show();
            }
        }

        
        /*
        private void gestionPrestamoDetalletoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!Globales.MiPrestamoDetalle.Visible)
            {
                Globales.MiPrestamoDetalle = new FrmPrestamoDetalle();

                Globales.MiPrestamoDetalle.Show();
            }
        } */

        private void gestionCategoriatoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Globales.MiGestionCategoria.Visible)
            {
                Globales.MiGestionCategoria = new FrmGestionCategoria();

                Globales.MiGestionCategoria.Show();
            }
        }

        private void rEGISTROSDEPRESTAMOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormRegistroPrestamo.Visible)
            {
                Globales.MiFormRegistroPrestamo = new FrmRegistroPrestamo();

                Globales.MiFormRegistroPrestamo.Show();
            }
        }

        private void listaDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiPrestamoDetalleActivos.Visible)
            {
                Globales.MiPrestamoDetalleActivos = new FrmPrestamosActivos();

                Globales.MiPrestamoDetalleActivos.Show();
            }
        }

        private void MnuAcercaDe_Click(object sender, EventArgs e)
        {
            if (!Globales.MiInformacion.Visible)
            {
                Globales.MiInformacion = new FrmInformacion();

                Globales.MiInformacion.Show();
            }

        }

        private void listaDePrestamosHoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiPrestamoHoy.Visible)
            {
                Globales.MiPrestamoHoy = new FrmListarPrestamosPorHoy();

                Globales.MiPrestamoHoy.Show();
            }
        }
    }
}
