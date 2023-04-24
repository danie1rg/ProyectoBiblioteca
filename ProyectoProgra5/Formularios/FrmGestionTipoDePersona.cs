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
    public partial class FrmGestionTipoDePersona : Form
    {

        private Logica.Models.TipoDePersona MiTipoDePersona { get; set; }

        private DataTable ListarTipo { get; set; }
        public FrmGestionTipoDePersona()
        {
            InitializeComponent();

            ListarTipo = new DataTable();
            MiTipoDePersona = new Logica.Models.TipoDePersona();
        }

        private void FrmGestionTipoDePersona_Load(object sender, EventArgs e)
        {
            CargarListaDeTipos();
            ActivarAgregar();
        }

        private void CargarListaDeTipos()
        {
            ListarTipo = new DataTable();

            ListarTipo = MiTipoDePersona.Listar();

            DtVista.DataSource = ListarTipo;

        }

        private bool ValidarDatosDigitados()
        {
            bool R = true;
            if (string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
            {
                MessageBox.Show("Debe de digitar una descripción para el tipo de persona", "Error de validación", MessageBoxButtons.OK);
                TxtDescripcion.Focus();
                return false;
            }

            return R;

        }

        private void LimpiarForm()
        {
            TxtDescripcion.Clear();
            TxtCod.Clear();
        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MiTipoDePersona = new Logica.Models.TipoDePersona();

            MiTipoDePersona.Descripcion = TxtDescripcion.Text.Trim();



            string msg = string.Format("¿Está seguro que desea agregar al tipo de persona {0}?", MiTipoDePersona.Descripcion);

            DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                bool ok = MiTipoDePersona.Agregar();

                if (ok)
                {
                    MessageBox.Show("Guardado correctamente!", ":)", MessageBoxButtons.OK);

                    LimpiarForm();

                    CargarListaDeTipos();
                }
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                MiTipoDePersona.Descripcion = TxtDescripcion.Text.Trim();


                if (MiTipoDePersona.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de modificar el tipo de persona?", "???",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiTipoDePersona.Editar())
                        {
                            MessageBox.Show("Tipo de persona ha sido modificado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            ActivarAgregar();
                            CargarListaDeTipos();
                        }
                    }

                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar();
            DtVista.ClearSelection();
        }

        private void DtVista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtVista.SelectedRows.Count == 1)
            {
                DataGridViewRow Mifila = DtVista.SelectedRows[0];

                int IdUsuario = Convert.ToInt32(Mifila.Cells["CTipoPersonaID"].Value);

                MiTipoDePersona = new Logica.Models.TipoDePersona();

                MiTipoDePersona.TipoPersonaId= IdUsuario;

                MiTipoDePersona = MiTipoDePersona.ConsultarPorIDRetornaUsuarioRol();

                if (MiTipoDePersona != null && MiTipoDePersona.TipoPersonaId > 0)
                {
                    TxtDescripcion.Text = MiTipoDePersona.Descripcion;
                    TxtCod.Text = Convert.ToString(MiTipoDePersona.TipoPersonaId);

                    ActivarEditarEliminar();
                }

            }
        }
    }
}
