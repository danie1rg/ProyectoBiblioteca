using Logica.Models;
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
    public partial class FrmGestionUsuarioRol : Form
    {
        private DataTable ListaRolUsuarios { get; set; }

        private Logica.Models.UsuarioRol MiUsuarioRolLocal { get; set; }
        public FrmGestionUsuarioRol()
        {
            InitializeComponent();

            ListaRolUsuarios= new DataTable();

            MiUsuarioRolLocal = new Logica.Models.UsuarioRol();

        }

        private void FrmGestionUsuarioRol_Load(object sender, EventArgs e)
        {
            CargarListaDeUsuariosRol();

            ActivarAgregar();
        }

        private void CargarListaDeUsuariosRol()
        {
            ListaRolUsuarios = new DataTable();

            ListaRolUsuarios = MiUsuarioRolLocal.Listar();

            DtVista.DataSource = ListaRolUsuarios;

        }

        private bool ValidarDatosDigitados()
        {
            bool R = true;
                if (string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
                {
                    MessageBox.Show("Debe de digitar una descripción para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtDescripcion.Focus();
                    return false;
                }

            return R;

        }

        private void LimpiarForm()
        {
           TxtDescripcion.Clear();
           TxtCod.Clear();
        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
        }

        private void DtVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtVista.SelectedRows.Count == 1)
            {
                DataGridViewRow Mifila = DtVista.SelectedRows[0];

                int IdUsuario = Convert.ToInt32(Mifila.Cells["CID"].Value);

                MiUsuarioRolLocal = new Logica.Models.UsuarioRol();

                MiUsuarioRolLocal.UsuarioRolId = IdUsuario;

                MiUsuarioRolLocal = MiUsuarioRolLocal.ConsultarPorIDRetornaUsuarioRol(); 

                if (MiUsuarioRolLocal != null && MiUsuarioRolLocal.UsuarioRolId > 0)
                {
                    TxtDescripcion.Text = MiUsuarioRolLocal.Descripcion;
                    TxtCod.Text = Convert.ToString(MiUsuarioRolLocal.UsuarioRolId);

                    ActivarEditarEliminar();
                }

            }
        }

  
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                MiUsuarioRolLocal.Descripcion = TxtDescripcion.Text.Trim();


                if (MiUsuarioRolLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de modificar el usuario rol?", "???",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioRolLocal.Editar())
                        {
                            MessageBox.Show("Usuario Rol ha sido modificado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            ActivarAgregar();
                            CargarListaDeUsuariosRol();
                        }
                    }

                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MiUsuarioRolLocal = new Logica.Models.UsuarioRol();

            MiUsuarioRolLocal.Descripcion = TxtDescripcion.Text.Trim();
  

          
            string msg = string.Format("¿Está seguro que desea agregar al usuario rol {0}?", MiUsuarioRolLocal.Descripcion);

            DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                bool ok = MiUsuarioRolLocal.Agregar();

                if (ok)
                {
                    MessageBox.Show("Usuario Rol guardado correctamente!", ":)", MessageBoxButtons.OK);

                    LimpiarForm();

                    CargarListaDeUsuariosRol();
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar();
            DtVista.ClearSelection();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
