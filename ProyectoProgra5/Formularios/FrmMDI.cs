using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
