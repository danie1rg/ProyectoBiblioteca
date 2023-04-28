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
    public partial class FrmPrestamosActivos : Form
    {

        private DataTable ListaPrestamos { get; set; }
        PrestamoDetalle MiPrestamoDetalleLocal { get; set; }
        public FrmPrestamosActivos()
        {
            InitializeComponent();
            ListaPrestamos= new DataTable();
            MiPrestamoDetalleLocal = new PrestamoDetalle();
        }
        private void CargarListaDePrestamosDetalles()
        {
            ListaPrestamos = new DataTable();


            string FiltroBusqueda = "";

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda = TxtBuscar.Text.Trim();;

            }
            if (CbActivos.Checked)
            {
                ListaPrestamos = MiPrestamoDetalleLocal.ListarActivos(FiltroBusqueda);
            }
            else {
                ListaPrestamos = MiPrestamoDetalleLocal.ListarInactivos(FiltroBusqueda);
            }

            DtLista.DataSource = ListaPrestamos;

        }

        private void FrmPrestamosActivos_Load(object sender, EventArgs e)
        {
            CargarListaDePrestamosDetalles();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDePrestamosDetalles();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDePrestamosDetalles();
        }
    }
}
