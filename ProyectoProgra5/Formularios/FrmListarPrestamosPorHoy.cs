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
    public partial class FrmListarPrestamosPorHoy : Form
    {

        DataTable ListaPrestamosHoy { get; set; }

        PrestamoDetalle MiPrestamoDetalle { get; set; }
        public FrmListarPrestamosPorHoy()
        {
            InitializeComponent();

            ListaPrestamosHoy= new DataTable();
            MiPrestamoDetalle= new PrestamoDetalle();   
        }

        private void FrmListarPrestamosPorHoy_Load(object sender, EventArgs e)
        {
            CargarPrestamosHoy();

        }
        private void CargarPrestamosHoy()
        {
            ListaPrestamosHoy = new DataTable();

            ListaPrestamosHoy = MiPrestamoDetalle.ListarHoy();

            DtListar.DataSource = ListaPrestamosHoy;

        }

        private void ActivarEliminar()
        {
            BtnEliminar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            bool ok = MiPrestamoDetalle.DesactivarPrestamoDetalle();
            if (ok) 
            {
                MessageBox.Show("El prestamo ha sido cancelado correctamente!", ":)", MessageBoxButtons.OK);
                MiPrestamoDetalle.Milibro.Activar();
                CargarPrestamosHoy();
            }

        }

        private void DtListar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtListar.SelectedRows.Count == 1) 
            {
                DataGridViewRow Mifila = DtListar.SelectedRows[0];

                MiPrestamoDetalle= new Logica.Models.PrestamoDetalle();
                int ClavePrestamo = Convert.ToInt32(Mifila.Cells["CclavePrestamo"].Value);
                int ClaveLibro = Convert.ToInt32(Mifila.Cells["CclaveLibro"].Value);

                MiPrestamoDetalle.Milibro.ClaveLibro = ClaveLibro;
                MiPrestamoDetalle.MiPrestamo.ClavePrestamo = ClavePrestamo;

                if (MiPrestamoDetalle != null) 
                {
                    ActivarEliminar();
                }

            }

        }
    }
}
