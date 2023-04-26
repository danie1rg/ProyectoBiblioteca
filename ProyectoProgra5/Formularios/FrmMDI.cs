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

        private void rEGISTROSDEPRESTAMOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.MiFormRegistroPrestamo.Visible)
            {
                Globales.MiFormRegistroPrestamo = new FrmRegistroPrestamo();

                Globales.MiFormRegistroPrestamo.Show();
            }
        }
    }
}
