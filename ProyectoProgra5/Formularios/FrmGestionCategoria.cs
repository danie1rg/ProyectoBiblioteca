using Logica.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra5.Formularios
{
    public partial class FrmGestionCategoria : Form
    {
        Logica.Models.Categoria MiCategoriaLocal { get; set; }

        private DataTable ListaCategoria { get; set; }
        public FrmGestionCategoria()
        {
            InitializeComponent();
            MiCategoriaLocal = new Logica.Models.Categoria();
            ListaCategoria = new DataTable();
        }

      

        private void FrmGestionCategoria_Load(object sender, EventArgs e)
        {
            CargarListaDeCategorias();
        }

        private void CargarListaDeCategorias()
        {

            ListaCategoria = new DataTable();
            ListaCategoria = MiCategoriaLocal.Listar();
            DgvListaCategoria.DataSource = ListaCategoria;

        }

        private void LimpiarFormulario()
        {
            txtClave.Clear();
            TxtGenero.Clear();
          
        }


        private bool ValidarDatosDigitados()
        {

            bool R = true;


            if (string.IsNullOrEmpty(TxtGenero.Text.Trim()))
            {
                MessageBox.Show("Debe digitar un género para la categoría", "Error de validación", MessageBoxButtons.OK);
                TxtGenero.Focus();
                return false;
            }

            return R;

        }

       
     

      
        private void DgvListaCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaCategoria.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaCategoria.SelectedRows[0];

                int IdClave = Convert.ToInt32(MiFila.Cells["CClaveCategoria"].Value);

                MiCategoriaLocal = new Logica.Models.Categoria();

                MiCategoriaLocal.ClaveCategoria = IdClave;

                MiCategoriaLocal = MiCategoriaLocal.ConsultarPorIDRetornaCategoria();


                if (MiCategoriaLocal != null && MiCategoriaLocal.ClaveCategoria > 0)
                {
                    txtClave.Text = Convert.ToString(MiCategoriaLocal.ClaveCategoria);

                    TxtGenero.Text = MiCategoriaLocal.Descripcion;

                    BtnAgregar.Enabled = false;


                }

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TxtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);

        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                bool Clave;
                bool Nombre;

                MiCategoriaLocal = new Logica.Models.Categoria();

                MiCategoriaLocal.Descripcion = TxtGenero.Text.Trim();



                Clave = MiCategoriaLocal.ConsultarPorClaveCategoria();
                Nombre = MiCategoriaLocal.ConsultarPorGenero();

                if (Clave == false && Nombre == false)
                {
                    string msg = string.Format("¿Está seguro que desea agregar el género {0}?", MiCategoriaLocal.Descripcion);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiCategoriaLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Categoría guardada correctamente", ":D", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaDeCategorias();

                        }
                        else
                        {
                            MessageBox.Show("La Categoría no se guardó correctamente", ":(", MessageBoxButtons.OK);

                        }


                    }
                }
                else
                {
                    if (Clave)
                    {
                        MessageBox.Show("Ya existe un género con la clave digitada", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }

                    if (Nombre)
                    {
                        MessageBox.Show("Ya existe un género con el nombre digitado", "Error de validación", MessageBoxButtons.OK);
                        return;
                    }

                }
            }
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();

            DgvListaCategoria.ClearSelection();

            BtnAgregar.Enabled = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {

                MiCategoriaLocal.Descripcion = TxtGenero.Text.Trim();

                if (MiCategoriaLocal.ConsultarPorClaveCategoria())
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea modificar esta categoría?", "???",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiCategoriaLocal.Editar())
                        {
                            MessageBox.Show("La categoría ha sido modificado correctamente", ":D", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            CargarListaDeCategorias();
                        }


                    }
                }
            }
        }
    }
}
