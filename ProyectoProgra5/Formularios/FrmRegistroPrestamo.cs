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
        public FrmRegistroPrestamo()
        {
            InitializeComponent();

            MiPrestamoLocal = new Prestamo();
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
        }


        private bool ValidarCompra()
        {
            bool R = true;

            
             if (string.IsNullOrEmpty(TxtPersona.Text.Trim()))
                {
                    MessageBox.Show("Se debe seleccionar un cliente", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
           

            return R;
        }



                
        private void BtnCrearPrestamo_Click(object sender, EventArgs e)
        {

            if (ValidarCompra()) 
            {
                MiPrestamoLocal.MiUsuario.UsuarioId = Globales.MiUsuarioGlobal.UsuarioId;
                MiPrestamoLocal.FechaDevolucion = DtimerDevolucion.Value;


                bool ok = MiPrestamoLocal.Agregar();

                if (ok)
                {
                    MessageBox.Show("Prestamo creado correctamente", ":)", MessageBoxButtons.OK);

                    
                }
                LimpiarForm();

            }

        }



    }
}
