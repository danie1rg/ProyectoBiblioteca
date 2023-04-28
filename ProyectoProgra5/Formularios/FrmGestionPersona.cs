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
    public partial class FrmGestionPersona : Form
    {
        private Logica.Models.Persona MiPersonaLocal { get; set; }

        private DataTable ListaPersonas { get; set; }
        public FrmGestionPersona()
        {
            InitializeComponent();
            ListaPersonas= new DataTable();
            MiPersonaLocal = new Persona();

            ActivarAgregar();
        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void CargarListaTipos()
        {
            Logica.Models.TipoDePersona MiTipoPersona = new Logica.Models.TipoDePersona();
            DataTable dt = new DataTable();
            dt = MiTipoPersona.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbTipoPersona.ValueMember = "TipoPersonaID";
                CbTipoPersona.DisplayMember = "descripcion";
                CbTipoPersona.DataSource = dt;
                CbTipoPersona.SelectedIndex = -1;
            }
        }

        private void CargarListaDePersonas()
        {
            ListaPersonas = new DataTable();
            string FiltroBusqueda = "";

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();
            }

            if (CbActivos.Checked)
            {

                ListaPersonas = MiPersonaLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaPersonas = MiPersonaLocal.ListarInactivos(FiltroBusqueda);
            }

            DtVista.DataSource = ListaPersonas;

        }

        private void FrmGestionPersona_Load(object sender, EventArgs e)
        {
            CargarListaTipos();
            CargarListaDePersonas();
        }

        private bool ValidarDatosDigitados()
        {
            bool r = true;

          
             if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe de digitar un nombre para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;
                }

            if (string.IsNullOrEmpty(TxtApellido.Text.Trim()))
            {
                MessageBox.Show("Debe de digitar un apellido para el usuario", "Error de validación", MessageBoxButtons.OK);
                TxtApellido.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
            {
                MessageBox.Show("Debe de digitar una cedula para el usuario", "Error de validación", MessageBoxButtons.OK);
                TxtCedula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtDireccion.Text.Trim()))
            {
                MessageBox.Show("Debe de digitar una dirección para el usuario", "Error de validación", MessageBoxButtons.OK);
                TxtDireccion.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
            {
                MessageBox.Show("Debe de digitar un télefono para el usuario", "Error de validación", MessageBoxButtons.OK);
                TxtTelefono.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("Debe de digitar un correo para el usuario", "Error de validación", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;
                }

            if (CbTipoPersona.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe de digitar un rol para el usuario", "Error de validación", MessageBoxButtons.OK);
                    CbTipoPersona.Focus();
                    return false;
                }

            return r;

        }

        private void LimpiarForm()
        {
            TxtPersonaID.Clear();
            TxtNombre.Clear();
            TxtEmail.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtApellido.Clear();
            TxtCedula.Clear();
            CbTipoPersona.SelectedIndex = -1;
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                bool EmailOK;
                bool CedulaOK;

                MiPersonaLocal = new Logica.Models.Persona();

                MiPersonaLocal.Nombre = TxtNombre.Text.Trim();
                MiPersonaLocal.Email = TxtEmail.Text.Trim();
                MiPersonaLocal.Apellido = TxtApellido.Text.Trim();
                MiPersonaLocal.Cedula = TxtCedula.Text.Trim();
                MiPersonaLocal.FechaNacimiento = DtFechaNac.Value;
                MiPersonaLocal.Direccion = TxtDireccion.Text.Trim();
                MiPersonaLocal.Telefono = TxtTelefono.Text.Trim();
                MiPersonaLocal.MiTipoDePersona.TipoPersonaId = Convert.ToInt32(CbTipoPersona.SelectedValue);

                EmailOK = MiPersonaLocal.ConsultarPorEmail();
                CedulaOK = MiPersonaLocal.ConsultarPorCedula();

                if (EmailOK == false && CedulaOK == false)
                {
                    string msg = string.Format("¿Está seguro que desea agregar la persona {0}?", MiPersonaLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiPersonaLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("La persona guardada correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();

                            CargarListaDePersonas();
                        }
                        else
                        {
                            MessageBox.Show("La persona no se pudo guardar correctamente!", ":(", MessageBoxButtons.OK);
                        }


                    }
                }
                else
                {

                    if (EmailOK)
                    {
                        MessageBox.Show("Ya existe una persona con el correo digitada", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }

                    if (CedulaOK)
                    {
                        MessageBox.Show("Ya existe una persona con la cédula digitada", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }

                }

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtVista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtVista.SelectedRows.Count == 1)
            {
                DataGridViewRow Mifila = DtVista.SelectedRows[0];

                int IdPersona = Convert.ToInt32(Mifila.Cells["CclavePersona"].Value);

                MiPersonaLocal = new Logica.Models.Persona();

                MiPersonaLocal.ClavePersona = IdPersona;

                MiPersonaLocal = MiPersonaLocal.ConsultarPorIDRetornaPersona();

                if (MiPersonaLocal != null && MiPersonaLocal.ClavePersona > 0)
                {
                    TxtPersonaID.Text = Convert.ToString(MiPersonaLocal.ClavePersona);
                    TxtNombre.Text = MiPersonaLocal.Nombre;
                    TxtApellido.Text = MiPersonaLocal.Apellido;
                    TxtEmail.Text = MiPersonaLocal.Email;
                    TxtCedula.Text = MiPersonaLocal.Cedula;
                    TxtDireccion.Text = MiPersonaLocal.Direccion;
                    TxtTelefono.Text = MiPersonaLocal.Telefono;
                    DtFechaNac.Value = MiPersonaLocal.FechaNacimiento;
                    CbTipoPersona.SelectedValue = MiPersonaLocal.MiTipoDePersona.TipoPersonaId;

                    ActivarEditarEliminar();
                }

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();

            ActivarAgregar();

            DtVista.ClearSelection();
        }

        private void CbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDePersonas();

            if (CbActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
            }
            else
            {
                BtnEliminar.Text = "Activar";
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDePersonas();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                

                MiPersonaLocal.Nombre = TxtNombre.Text.Trim();
                MiPersonaLocal.Email = TxtEmail.Text.Trim();
                MiPersonaLocal.Apellido = TxtApellido.Text.Trim();
                MiPersonaLocal.Cedula = TxtCedula.Text.Trim();
                MiPersonaLocal.FechaNacimiento = DtFechaNac.Value;
                MiPersonaLocal.Direccion = TxtDireccion.Text.Trim();
                MiPersonaLocal.Telefono = TxtTelefono.Text.Trim();
                MiPersonaLocal.MiTipoDePersona.TipoPersonaId = Convert.ToInt32(CbTipoPersona.SelectedValue);

                if (MiPersonaLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de modificar {0}?", "???",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiPersonaLocal.Editar())
                        {
                            MessageBox.Show("La persona ha sido modificado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            ActivarAgregar();
                            CargarListaDePersonas();
                        }
                    }

                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiPersonaLocal.ClavePersona > 0 && MiPersonaLocal.ConsultarPorID())
            {
                if (CbActivos.Checked)
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar a la persona?", "???",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiPersonaLocal.DesactivarPersona())
                        {
                            MessageBox.Show("La persona ha sido eliminado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            ActivarAgregar();
                            CargarListaDePersonas();
                        }
                    }
                }
                else
                {
                    if (MiPersonaLocal.ActivarPersona())
                    {
                        MessageBox.Show("La persona ha sido activado correctamente!", ":)", MessageBoxButtons.OK);

                        LimpiarForm();
                        ActivarAgregar();
                        CargarListaDePersonas();
                    }

                }

            }



        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
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
