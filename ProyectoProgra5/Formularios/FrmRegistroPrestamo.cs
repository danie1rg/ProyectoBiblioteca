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
    public partial class FrmRegistroPrestamo : Form
    {
        public Prestamo MiPrestamoLocal { get; set; }

        public DataTable ListaLibros { get; set; }
        public FrmRegistroPrestamo()
        {
            InitializeComponent();

            MiPrestamoLocal = new Prestamo();
            ListaLibros = new DataTable();
        }

        private void BtnBuscarPersona_Click(object sender, EventArgs e)
        {
            Form FormBuscarPersona = new FrmBuscarPersona();

            DialogResult respuesta = FormBuscarPersona.ShowDialog();

            if (respuesta == DialogResult.OK)
            {

                TxtPersona.Text = MiPrestamoLocal.MiPersona.Nombre;

            }

        }

        private void LimpiarForm()
        {
            TxtPersona.Clear();

            ListaLibros = new DataTable();

            ListaLibros = MiPrestamoLocal.CargarEsquemaDetalle();

            DtgListaLibros.DataSource = ListaLibros;
        }


        private bool ValidarCompra()
        {
            bool R = true;

            
             if (string.IsNullOrEmpty(TxtPersona.Text.Trim()))
                {
                    MessageBox.Show("Se debe seleccionar un cliente", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
            if (DtgListaLibros.Rows.Count == 0)
            {
                MessageBox.Show("Debe de haber un libro", "Error de validación", MessageBoxButtons.OK);
                return false;
            }


            return R;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (DtgListaLibros.Rows.Count < 3)
            {
                Form FrmAgregarLibro = new FrmBuscarLibro();

                DialogResult respuesta = FrmAgregarLibro.ShowDialog();

                if (respuesta == DialogResult.OK)
                {
                    DtgListaLibros.DataSource = ListaLibros;
                }
            }
            else {
                MessageBox.Show("Solo se puede prestar dos libros", "Error de validación", MessageBoxButtons.OK);
            }
            
        }



        private void BtnCrearPrestamo_Click(object sender, EventArgs e)
        {

            if (ValidarCompra()) 
            {
                MiPrestamoLocal.MiUsuario.UsuarioId = Globales.MiUsuarioGlobal.UsuarioId;
                MiPrestamoLocal.FechaDevolucion = DtimerDevolucion.Value;

                ListaVisual();

                if (MiPrestamoLocal.Agregar())
                {
                    MessageBox.Show("Prestamo creado correctamente", ":)", MessageBoxButtons.OK);

                    foreach (DataRow fila in ListaLibros.Rows) 
                    {
                        Libro MiLibro = new Libro();
                        int id = Convert.ToInt32(fila["claveLibro"]);
                        MiLibro.ClaveLibro = id;
                        if (MiLibro.ClaveLibro > 0) 
                        {
                            MiLibro.Eliminar();
                        }

                    }

                }
                LimpiarForm();


            }

        }

        private void FrmRegistroPrestamo_Load(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void ListaVisual() 
        {
            foreach (DataRow fila in ListaLibros.Rows)
            {
                PrestamoDetalle nuevoDetalle = new PrestamoDetalle();

                nuevoDetalle.Milibro.ClaveLibro = Convert.ToInt32(fila["claveLibro"]);

                MiPrestamoLocal.ListaPrestamoDetalles.Add(nuevoDetalle);

            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (DtgListaLibros.SelectedRows.Count == 1)  
            {
                DataGridViewRow MiFila = DtgListaLibros.SelectedRows[0];
                DialogResult respuesta = MessageBox.Show("¿Esta seguro de eliminar este libro?", "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    DtgListaLibros.Rows.Remove(MiFila);
                    DtgListaLibros.DataSource = ListaLibros;
                }
            }
        }


    }
}
