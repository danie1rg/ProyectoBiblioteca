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
    public partial class FrmGestionDeUsuarios : Form
    {

        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        private DataTable ListaUsuarios { get; set; }
        public FrmGestionDeUsuarios()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();
        }
        
        private void FrmGestionDeUsuarios_Load(object sender, EventArgs e)
        {

            CargarListaRoles();
            CargarListaDeUsuarios();

            ActivarAgregar();

        }
        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void CargarListaDeUsuarios()
        {
            ListaUsuarios = new DataTable();
            string FiltroBusqueda = "";

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }

            if (CbActivos.Checked)
            {
                //si en cuatro de busqueda hay más de dos caracteres se filtra la lista

                ListaUsuarios = MiUsuarioLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaUsuarios = MiUsuarioLocal.ListarInactivos(FiltroBusqueda);
            }

            DtVista.DataSource = ListaUsuarios;

        }

        private void CargarListaRoles() 
        {
            Logica.Models.UsuarioRol MiRol = new Logica.Models.UsuarioRol();
            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbUsuarioRol.ValueMember = "ID";
                CbUsuarioRol.DisplayMember = "Descripcion";
                CbUsuarioRol.DataSource = dt;
                CbUsuarioRol.SelectedIndex = -1;
            }
        }

        private void LimpiarForm() 
        {
            TxtCodUsuario.Clear();
            TxtNombre.Clear();
            TxtEmail.Clear();
            TxtContrasenna.Clear();
            CbUsuarioRol.SelectedIndex = -1;
        }

   
        private bool ValidarDatosDigitados(bool OmitirPassword = false) 
        {
            bool r = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) && !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                CbUsuarioRol.SelectedIndex > -1)
            {
                if (OmitirPassword)
                {
                    r = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtContrasenna.Text.Trim()))
                    {
                        r = true;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(TxtContrasenna.Text.Trim()))
                        {
                            MessageBox.Show("Debe de digitar una contraseña para el usuario", "Error de validación", MessageBoxButtons.OK);
                            TxtContrasenna.Focus();
                            return false;
                        }
                    }
                }

            }
            else
            {
                if (string.IsNullOrEmpty(TxtNombre.Text.Trim())) 
                {
                    MessageBox.Show("Debe de digitar un nombre para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("Debe de digitar un correo para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;
                }

                if (CbUsuarioRol.SelectedIndex == -1) 
                {
                    MessageBox.Show("Debe de digitar un rol para el usuario", "Error de validación", MessageBoxButtons.OK);
                    CbUsuarioRol.Focus();
                    return false;
                }


            }

            return r;

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados()) 
            {
                bool EmailOK;

                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.UsuarioNombre = TxtNombre.Text.Trim();
                MiUsuarioLocal.Correo = TxtEmail.Text.Trim();
                MiUsuarioLocal.Contrasena = TxtContrasenna.Text.Trim();
                MiUsuarioLocal.MiUsuarioRol.UsuarioRolId = Convert.ToInt32(CbUsuarioRol.SelectedValue);

                EmailOK = MiUsuarioLocal.ConsultarPorEmail();

                if (EmailOK == false) 
                {
                    string msg = string.Format("¿Está seguro que desea agregar al usuario {0}?", MiUsuarioLocal.UsuarioNombre);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Usuario guardado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();

                            CargarListaDeUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no se pudo guardar correctamente!", ":(", MessageBoxButtons.OK);
                        }


                    }
                }
                else
                {
                   
                    if (EmailOK)
                    {
                        MessageBox.Show("Ya existe un usuario con el correo digitada", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }

                }

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados(true)) 
            {
                MiUsuarioLocal.UsuarioNombre = TxtNombre.Text.Trim();
                MiUsuarioLocal.Correo = TxtEmail.Text.Trim();
                MiUsuarioLocal.Contrasena = TxtContrasenna.Text.Trim();
                MiUsuarioLocal.MiUsuarioRol.UsuarioRolId = Convert.ToInt32(CbUsuarioRol.SelectedValue);

                if (MiUsuarioLocal.ConsultarPorID()) 
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de modificar el usuario?", "???",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Editar())
                        {
                            MessageBox.Show("Usuario ha sido modificado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            ActivarAgregar();
                            CargarListaDeUsuarios();
                        }
                    }

                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MiUsuarioLocal.UsuarioId > 0 && MiUsuarioLocal.ConsultarPorID())
            {
                if (CbActivos.Checked)
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar al usuario?", "???",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.DesactivarUsuario())
                        {
                            MessageBox.Show("Usuario ha sido eliminado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            ActivarAgregar();
                            CargarListaDeUsuarios();
                        }
                    }
                }
                else
                {
                    if (MiUsuarioLocal.ActivarUsuario())
                    {
                        MessageBox.Show("Usuario ha sido activado correctamente!", ":)", MessageBoxButtons.OK);

                        LimpiarForm();
                        ActivarAgregar();
                        CargarListaDeUsuarios();
                    }

                }

            }


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDeUsuarios();

            if (CbActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
            }
            else
            {
                BtnEliminar.Text = "Activar" +
                    "";
            }

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeUsuarios();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();

            ActivarAgregar();

            DtVista.ClearSelection();
        }

        private void DtVista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtVista.SelectedRows.Count == 1) 
            {
                DataGridViewRow Mifila = DtVista.SelectedRows[0];

                int IdUsuario = Convert.ToInt32(Mifila.Cells["CUsuarioID"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.UsuarioId = IdUsuario;

                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioId > 0) 
                {
                    TxtCodUsuario.Text = Convert.ToString(MiUsuarioLocal.UsuarioId);
                    TxtNombre.Text = MiUsuarioLocal.UsuarioNombre;
                    TxtEmail.Text = MiUsuarioLocal.Correo;

                    CbUsuarioRol.SelectedValue = MiUsuarioLocal.MiUsuarioRol.UsuarioRolId;

                    ActivarEditarEliminar();
                }

            }
        }

        private void TxtContrasenna_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e,true);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()))
            {
                if (!Validaciones.ValidarEmail(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("El formato del correo es incorrecto", "Error de validación", MessageBoxButtons.OK);
                    TxtEmail.Focus();


                }
            }
        }
    }
}
