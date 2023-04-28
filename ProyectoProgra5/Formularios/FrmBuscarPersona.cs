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
    public partial class FrmBuscarPersona : Form
    {

        DataTable DtListarPersonas { get; set; }

        Persona MiPersonaLocal { get; set; }

        public FrmBuscarPersona()
        {
            InitializeComponent();
            MiPersonaLocal= new Persona();
            DtListarPersonas = new DataTable();

        }

        private void FrmBuscarPersona_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista()
        {
            DtListarPersonas = new DataTable();

            DtListarPersonas = MiPersonaLocal.ListarActivos(TxtBuscar.Text.Trim());

            DtLista.DataSource = DtListarPersonas;

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text.Count() > 2 || string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                LlenarLista();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DtLista.SelectedRows.Count == 1)
            {

                DataGridViewRow row = DtLista.SelectedRows[0];

                int IdProveedor = Convert.ToInt32(row.Cells["CclavePersona"].Value);

                string NombreProveedor = Convert.ToString(row.Cells["Cnombre"].Value);


                Globales.MiFormRegistroPrestamo.MiPrestamoLocal.MiPersona.Nombre = NombreProveedor;
                Globales.MiFormRegistroPrestamo.MiPrestamoLocal.MiPersona.ClavePersona = IdProveedor;

                DialogResult = DialogResult.OK;

            }
        }
    }
}
