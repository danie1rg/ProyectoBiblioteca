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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void BtnVer_MouseDown(object sender, MouseEventArgs e)
        {
            Txtpass.UseSystemPasswordChar = false;
        }

        private void BtnVer_MouseUp(object sender, MouseEventArgs e)
        {
            Txtpass.UseSystemPasswordChar = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(Txtpass.Text.Trim()))
            {
                string usuario = TxtEmail.Text.Trim();
                string contrasennia = Txtpass.Text.Trim();

                Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ValidarUsuario(usuario, contrasennia);

                if (Globales.MiUsuarioGlobal.UsuarioId > 0)
                {
                    //si la validación es correcta el Id debería tener un valor mayor a cero

                    Globales.MiFormPrincipal.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectas...", "Error de validación", MessageBoxButtons.OK);

                    Txtpass.Focus();
                    Txtpass.SelectAll();

                }

            }
            else
            {
                MessageBox.Show("Faltan datos requeridos!", "Error de validación", MessageBoxButtons.OK);
            }

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.MiFormPrincipal.Show();
            this.Show();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.Alt && e.KeyCode == Keys.A)
            {
                //si presionamos shit + alt + a
                BtnIngresoDirecto.Visible = true;

            }

        }
    }
}
