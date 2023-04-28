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
    public partial class FrmGestionAutor : Form
    {
        Logica.Models.Autor MiAutorLocal { get; set; }

        private DataTable ListaAutores { get; set; }

        public FrmGestionAutor()
        {
            InitializeComponent();
            MiAutorLocal = new Logica.Models.Autor();
            ListaAutores = new DataTable();
        }

        private void FrmGestionAutor_Load(object sender, EventArgs e)
        {
            CargarListaDeAutores();
        }

        private void CargarListaDeAutores()
        {

            ListaAutores = new DataTable();

            string filtroBusqueda = "";
            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim()) && txtBuscar.Text.Count() >= 3)
            {

                filtroBusqueda = txtBuscar.Text.Trim();
                ListaAutores = MiAutorLocal.Listar(filtroBusqueda);

            }
            else
            {
                ListaAutores = MiAutorLocal.Listar(filtroBusqueda);

            }



            DgLista.DataSource = ListaAutores;

        }

        private void DgvListaAutor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void LimpiarFormulario()
        {
            TxtNombre.Clear();
            TxtNacionalidad.Clear();
            TxtClave.Clear();
            txtBuscar.Clear();
        }

     

        private bool ValidarDatosDigitados()
        {

            bool R = true;


            if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
            {
                MessageBox.Show("Debe digitar un nombre para el autor", "Error de validación", MessageBoxButtons.OK);
                TxtNombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtNacionalidad.Text.Trim()))
            {
                MessageBox.Show("Debe digitar una nacionalidad para el autor", "Error de validación", MessageBoxButtons.OK);
                TxtNacionalidad.Focus();
                return false;

            }



            return R;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                bool Clave;
                bool Nombre;

                MiAutorLocal = new Logica.Models.Autor();

                MiAutorLocal.nombre = TxtNombre.Text.Trim();
                MiAutorLocal.nacionalidad = TxtNacionalidad.Text.Trim();


                Clave = MiAutorLocal.ConsultarPorClaveAutor();
                Nombre = MiAutorLocal.ConsultarPorNombre();

                if (Clave == false && Nombre == false)
                {
                    string msg = string.Format("¿Está seguro que desea agregar al Autor {0}?", MiAutorLocal.nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiAutorLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Autor guardado correctamente", ":D", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaDeAutores();

                        }
                        else
                        {
                            MessageBox.Show("El Autor no se guardó correctamente", ":(", MessageBoxButtons.OK);

                        }


                    }
                }
                else
                {
                    if (Clave)
                    {
                        MessageBox.Show("Ya existe un Autor con la clave digitada", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }

                    if (Nombre)
                    {
                        MessageBox.Show("Ya existe un Autor con el nombre digitado", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }

                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {

                MiAutorLocal.nombre = TxtNombre.Text.Trim();
                MiAutorLocal.nacionalidad = TxtNacionalidad.Text.Trim();

                if (MiAutorLocal.ConsultarPorClaveAutor())
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea modificar el autor?", "???",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiAutorLocal.Editar())
                        {
                            MessageBox.Show("El autor ha sido modificado correctamente", ":D", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeAutores();
                            BtnAgregar.Enabled = true;
                        }


                    }

                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            DgLista.ClearSelection();

            BtnAgregar.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);

        }

      

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeAutores();
        }

        private void TxtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);

        }

     
        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();

        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgLista.SelectedRows.Count == 1)
            {
                LimpiarFormulario();


                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int IdProveedor = Convert.ToInt32(MiFila.Cells["CClaveAutor"].Value);

                MiAutorLocal = new Logica.Models.Autor();

                MiAutorLocal.claveAutor = IdProveedor;

                MiAutorLocal = MiAutorLocal.ConsultarPorIDRetornaAutor();



                if (MiAutorLocal != null && MiAutorLocal.claveAutor > 0)
                {

                    TxtClave.Text = Convert.ToString(MiAutorLocal.claveAutor);

                    TxtNombre.Text = MiAutorLocal.nombre;

                    TxtNacionalidad.Text = MiAutorLocal.nacionalidad;


                    BtnAgregar.Enabled = false;
                }
            }
        }
    }
}
