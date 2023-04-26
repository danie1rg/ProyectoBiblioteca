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

        DataTable DtListaP { get; set; }

        Persona MiPersonaLocal { get; set; }
        public FrmBuscarPersona()
        {
            InitializeComponent();

            DtListaP = new DataTable();
            MiPersonaLocal= new Persona();
        }

        private void FrmBuscarPersona_Load(object sender, EventArgs e)
        {
            LlenarListaP();
        }


        private void LlenarListaP() 
        {
            DtListaP = new DataTable();
            DtListaP = MiPersonaLocal.ListarActivos(TxtBuscar.Text.Trim());

            DtListaVista.DataSource = DtListaP;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (TxtBuscar.Text.Count() > 2 || string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                LlenarListaP();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DtListaVista.SelectedRows.Count == 1)
            {

                DataGridViewRow row = DtListaVista.SelectedRows[0];

                int Id = Convert.ToInt32(row.Cells["CclavePersona"].Value);

                string Nombre = Convert.ToString(row.Cells["Cnombre"].Value);


                Globales.MiFormRegistroPrestamo.MiPrestamoLocal.MiPersona.Nombre = Nombre;
                Globales.MiFormRegistroPrestamo.MiPrestamoLocal.MiPersona.ClavePersona = Id;

                DialogResult = DialogResult.OK;

            }
        }
    }
}
