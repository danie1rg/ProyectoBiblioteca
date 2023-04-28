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
    public partial class FrmPrestamoDetalle : Form
    {
        public Logica.Models.PrestamoDetalle MiPrestamoD { get; set; }
        

        public DataTable ListaPrestamoD { get; set; }

        public FrmPrestamoDetalle()
        {
            InitializeComponent();

            MiPrestamoD = new Logica.Models.PrestamoDetalle();
            ListaPrestamoD = new DataTable();

        }

        private void FrmPrestamoDetalle_Load(object sender, EventArgs e)
        {
            CargarListaDePrestamoDetalle();
            ActivarAgregar();
            LimpiarFormulario();

        }

        private void CargarListaDePrestamoDetalle()
        {

            ListaPrestamoD = new DataTable();


            if (CboxActivos.Checked)
            {
                ListaPrestamoD = MiPrestamoD.ListarActivos();
            }
            else
            {
                ListaPrestamoD = MiPrestamoD.ListarInactivos();
            }

            DgvLista.DataSource = ListaPrestamoD;


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvLista.ClearSelection();
        }

        private void DgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarFormulario();

            DataGridViewRow MiFila = DgvLista.SelectedRows[0];


            int Id = Convert.ToInt32(MiFila.Cells["CID"].Value);

            MiPrestamoD = new Logica.Models.PrestamoDetalle();

            MiPrestamoD.ID = Id;


            ActivarEliminar();
        }


        private void LimpiarFormulario()
        {
            TxtLibro.Clear();
            TxtPrestamo.Clear();

        }
        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;

        }

        private void ActivarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEliminar.Enabled = true;

        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();

            DgvLista.ClearSelection();

            ActivarAgregar();
        }
        private bool ValidarDatosDigitados()
        {
            bool R = true;


            if (string.IsNullOrEmpty(TxtLibro.Text.Trim()))
            {
                MessageBox.Show("Debe eleccionar un libro", "Error de validación", MessageBoxButtons.OK);
                return false;
            }

            if (string.IsNullOrEmpty(TxtPrestamo.Text.Trim()))
            {
                MessageBox.Show("Debe seleccionar un prestamo", "Error de validación", MessageBoxButtons.OK);
                return false;

            }

            return R;
        }

        private void BtnBuscarLibro_Click(object sender, EventArgs e)
        {
            Form FrmLibro = new FrmBuscarLibro();

            DialogResult respuesta = FrmLibro.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                TxtLibro.Text = MiPrestamoD.Milibro.Titulo;

            }

        }

        private void BtnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            Form FrmPrestamo = new FrmBuscarPrestamo();

            DialogResult respuesta = FrmPrestamo.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                TxtPrestamo.Text = Convert.ToString(MiPrestamoD.MiPrestamo.ClavePrestamo);

            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                MiPrestamoD.Agregar();
                MessageBox.Show("Compra creada correctamente", ":D", MessageBoxButtons.OK);
                LimpiarFormulario();


            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiPrestamoD.ID > 0 && MiPrestamoD.ConsultarPorClavePrestamoDetalle())
            {

                if (CboxActivos.Checked)
                {
                    //Desactivar usuario
                    DialogResult r = MessageBox.Show("¿Está seguro que desea eliminar el prestamo detalle?", "???",
                        MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiPrestamoD.DesactivarPrestamoDetalle())
                        {
                            MessageBox.Show("El usuario ha sido eliminado satisfactoriamente", ":D", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDePrestamoDetalle();
                        }

                    }

                }
                else
                {
                    //Activar usuario tarea
                    DialogResult r = MessageBox.Show("¿Está seguro que desea activar el prestamo detalle?", "???",
                        MessageBoxButtons.YesNo
                     , MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiPrestamoD.ActivarPrestamoDetalle())
                        {
                            MessageBox.Show("El prestamo detalle ha sido activado satisfactoriamente", ":D",
                                MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDePrestamoDetalle();
                        }

                    }

                }



            }
        }

        private void CboxActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDePrestamoDetalle();

            if (CboxActivos.Checked)
            {
                BtnEliminar.Text = "ELIMINAR";
            }
            else
            {
                BtnEliminar.Text = "ACTIVAR";
            }

        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();

            DgvLista.ClearSelection();

            ActivarAgregar();
        }

        private void TxtLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);

        }

        private void TxtPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);

        }

        
    }
}

