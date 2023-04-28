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
    public partial class FrmBuscarLibro : Form
    {
        DataTable DtLista { get; set; }

        Libro MiLibro { get; set; }
        public FrmBuscarLibro()
        {
            InitializeComponent();

            DtLista = new DataTable();
            MiLibro = new Libro();
        }

        private void FrmBuscarLibro_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista()
        {
            DtLista = new DataTable();

            DtLista = MiLibro.ListarActivos(TxtBuscar.Text.Trim());

            DgvLista.DataSource = DtLista;

            DgvLista.ClearSelection();

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {

                DataGridViewRow row = DgvLista.SelectedRows[0];

                int clave = Convert.ToInt32(row.Cells["CClaveLibro"].Value);

                string titulo = Convert.ToString(row.Cells["CTitulo"].Value);

                int paginas = Convert.ToInt32(row.Cells["CCantidadPaginas"].Value);


                DataRow MiFila = Globales.MiFormRegistroPrestamo.ListaLibros.NewRow();

                MiFila["ClaveLibro"] = clave;
                MiFila["Titulo"] = titulo;

                //pasar las variables al objeto de compra del formulario de registro de compra
                //Globales.MiPrestamoDetalle.MiPrestamoD.Milibro.ClaveLibro = clave;
                //Globales.MiPrestamoDetalle.MiPrestamoD.Milibro.Titulo = titulo;
                //Globales.MiPrestamoDetalle.MiPrestamoD.Milibro.CantidadPaginas = paginas;
                Globales.MiFormRegistroPrestamo.ListaLibros.Rows.Add(MiFila);

                DialogResult = DialogResult.OK;

            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text.Count() > 2 || string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                LlenarLista();
            }
        }
    }
}
