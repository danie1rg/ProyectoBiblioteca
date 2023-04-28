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
    public partial class FrmBuscarPrestamo : Form
    {
        DataTable ListaP { get; set; }
        Prestamo MiPrestamo { get; set; }   
        public FrmBuscarPrestamo()
        {
            InitializeComponent();

            MiPrestamo = new Prestamo();
            ListaP = new DataTable();
        }

        private void FrmBuscarPrestamo_Load(object sender, EventArgs e)
        {
            ListaP = new DataTable();
            ListaP = MiPrestamo.Listar();
            DgvLista.DataSource = ListaP;

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {

                DataGridViewRow row = DgvLista.SelectedRows[0];

                int Clave = Convert.ToInt32(row.Cells["CClavePrestamo"].Value);

                DateTime fechaP = Convert.ToDateTime(row.Cells["CfechaPrestamo"].Value);

                DateTime fechaD = Convert.ToDateTime(row.Cells["CfechaDevolucion"].Value);


                Globales.MiPrestamoDetalle.MiPrestamoD.MiPrestamo.ClavePrestamo = Clave ;
                Globales.MiPrestamoDetalle.MiPrestamoD.MiPrestamo.FechaPrestamo = fechaP;
                Globales.MiPrestamoDetalle.MiPrestamoD.MiPrestamo.FechaDevolucion = fechaD;


                DialogResult = DialogResult.OK;

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
