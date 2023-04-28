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
    public partial class FrmGestionLibro : Form
    {
     
        private Logica.Models.Libro MiLibroLocal { get; set; }

        private DataTable ListaLibros { get; set; }

        public FrmGestionLibro()
        {
            InitializeComponent();
            MiLibroLocal = new Logica.Models.Libro();
  
            ListaLibros = new DataTable();
        }


        private void FrmGestionLibro_Load(object sender, EventArgs e)
        {
            CargarListaDeLibros();
            CargarListaCategoria();
            CargarListaAutores();
            ActivarAgregar();

        }


        private void CargarListaDeLibros()
        {

            ListaLibros = new DataTable();

            string filtroBusqueda = "";

            if (!string.IsNullOrEmpty(txtBuscar.Text.Trim()) && txtBuscar.Text.Count() >= 3)
            {

                filtroBusqueda = txtBuscar.Text.Trim();

            }
            if (CboxVerActivos.Checked)
            {
                ListaLibros = MiLibroLocal.ListarActivos(filtroBusqueda);

            }
            else
            {
                ListaLibros = MiLibroLocal.ListarInactivos(filtroBusqueda);

            }

            DgLista.DataSource = ListaLibros;

        }

        private void CargarListaAutores()
        {
            Logica.Models.Autor MiRol = new Logica.Models.Autor();

            DataTable dt = new DataTable();

            dt = MiRol.ListarRol();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbAutores.ValueMember = "ID";
                CbAutores.DisplayMember = "Descrip";
                CbAutores.DataSource = dt;
                CbAutores.SelectedIndex = -1;


            }
        }

        private void CargarListaCategoria()
        {
            Logica.Models.Categoria MiRol = new Logica.Models.Categoria();

            DataTable dt = new DataTable();

            dt = MiRol.ListarRol();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbCategoria.ValueMember = "ID";
                CbCategoria.DisplayMember = "Descrip";
                CbCategoria.DataSource = dt;
                CbCategoria.SelectedIndex = -1;

            }
        }


        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnEliminar.Enabled = false;
        }


        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void LimpiarFormulario()
        {
            txtBuscar.Clear();
            TxtLibroId.Clear();
            TxtTitulo.Clear();
            TxtPaginas.Clear();
          

            CbAutores.SelectedIndex = -1;
            CbCategoria.SelectedIndex = -1;

        }

     
        private bool ValidarDatosDigitados()
        {
            bool R = true;


            if (string.IsNullOrEmpty(TxtPaginas.Text.Trim()))
            {
                MessageBox.Show("Debe digitar un numero de páginas para el libro", "Error de validación", MessageBoxButtons.OK);
                TxtLibroId.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtTitulo.Text.Trim()))
            {
                MessageBox.Show("Debe digitar una titulo para el libro", "Error de validación", MessageBoxButtons.OK);
                TxtTitulo.Focus();
                return false;

            }

            if (CbAutores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un autor", "Error de validación", MessageBoxButtons.OK);
                CbAutores.Focus();
                return false;
            }


            if (CbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría", "Error de validación", MessageBoxButtons.OK);
                CbCategoria.Focus();
                return false;
            }
            return R;

        }



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeLibros();
        }

      

        private void TxtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);

        }

      

        private void TxtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);

        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                bool Titulo;

                MiLibroLocal = new Logica.Models.Libro();

                MiLibroLocal.Titulo = TxtTitulo.Text.Trim();
                MiLibroLocal.CantidadPaginas = Convert.ToInt32(TxtPaginas.Text.Trim());

                MiLibroLocal.MiAutor.claveAutor = Convert.ToInt32(CbAutores.SelectedValue);
                MiLibroLocal.MiCategoria.ClaveCategoria = Convert.ToInt32(CbCategoria.SelectedValue);

                Titulo = MiLibroLocal.ConsultarPorTituloLibro();

                if ( Titulo == false)
                {

                    string msg = string.Format("¿Está seguro que desea agregar libro {0}?", MiLibroLocal.Titulo);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiLibroLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Usuario guardado correctamente", ":D", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaDeLibros();

                        }
                        else
                        {
                            MessageBox.Show("El Usuario no guardó correctamente", ":(", MessageBoxButtons.OK);
                        }

                    }


                }
                else
                {

                    if (Titulo)
                    {
                        MessageBox.Show("Ya existe un usuario con el titulo digitado", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }
                }

            }
        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {

                MiLibroLocal.Titulo = TxtTitulo.Text.Trim();
                MiLibroLocal.CantidadPaginas = Convert.ToInt32(TxtPaginas.Text.Trim());

                MiLibroLocal.MiAutor.claveAutor = Convert.ToInt32(CbAutores.SelectedValue);
                MiLibroLocal.MiCategoria.ClaveCategoria = Convert.ToInt32(CbCategoria.SelectedValue);

                if (MiLibroLocal.ConsultarPorClaveLibro())
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea modificar el usuario?", "???",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiLibroLocal.Editar())
                        {
                            MessageBox.Show("El usuario ha sido modificado correctamente", ":D", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeLibros();
                        }


                    }

                }

            }

        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MiLibroLocal.ClaveLibro > 0 && MiLibroLocal.ConsultarPorClaveLibro())
            {

                if (CboxVerActivos.Checked)
                {
                    DialogResult r = MessageBox.Show("¿Está seguro que desea eliminar el libro?", "???", MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiLibroLocal.Eliminar())
                        {
                            MessageBox.Show("El libro ha sido eliminado satisfactoriamente", ":D", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeLibros();
                        }

                    }

                }
                else
                {
                    DialogResult r = MessageBox.Show("¿Está seguro que desea activar el usuario?", "???", MessageBoxButtons.YesNo
                     , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiLibroLocal.Activar())
                        {
                            MessageBox.Show("El usuario ha sido activado satisfactoriamente", ":D", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeLibros();
                        }

                    }

                }



            }

        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();

            DgLista.ClearSelection();

            ActivarAgregar();
        }



        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgLista.SelectedRows.Count == 1)
            {

                LimpiarFormulario();

                DataGridViewRow MiFila = DgLista.SelectedRows[0];


                int Idlibro = Convert.ToInt32(MiFila.Cells["CClaveLibro"].Value);

                MiLibroLocal = new Logica.Models.Libro();

                MiLibroLocal.ClaveLibro = Idlibro;


                MiLibroLocal = MiLibroLocal.ConsultarPorIDRetornaLibro();


                if (MiLibroLocal != null && MiLibroLocal.ClaveLibro > 0)
                {
                    TxtLibroId.Text = Convert.ToString(MiLibroLocal.ClaveLibro);

                    TxtTitulo.Text = MiLibroLocal.Titulo;

                    TxtPaginas.Text = Convert.ToString(MiLibroLocal.CantidadPaginas);


                    CbAutores.SelectedValue = Convert.ToString(MiLibroLocal.MiAutor.claveAutor);
                    CbCategoria.SelectedValue = Convert.ToString(MiLibroLocal.MiCategoria.ClaveCategoria);


                    ActivarEditarEliminar();

                }
            }
        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();

        }

        private void CboxVerActivos_CheckedChanged_1(object sender, EventArgs e)
        {
            CargarListaDeLibros();

            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "ELIMINAR";
            }
            else
            {
                BtnEliminar.Text = "ACTIVAR";
                BtnModificar.Enabled = false;
            }
        }
    }
    
    
}
