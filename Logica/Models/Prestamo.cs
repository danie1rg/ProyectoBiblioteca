using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Prestamo
    {
        public int ClavePrestamo { get; set; }

        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public bool Estado { get; set; }

        public Usuario MiUsuario { get; set; }

        public Persona MiPersona { get; set; }


        public List<PrestamoDetalle> ListaPrestamoDetalles { get; set; }




        public Prestamo()
        {
            MiUsuario = new Usuario();
            MiPersona = new Persona();
            ListaPrestamoDetalles = new List<PrestamoDetalle>();
        }


        public DataTable CargarEsquemaDetalle()
        {
            DataTable dt = new DataTable();

            Conexion MiCnn = new Conexion();

            dt = MiCnn.EjecutarSELECT("SPPrestamoDetalleEsquema", true);

            //como estamos cargando el esquema, tambien viene la indicación del pk
            //se debe anular esa opcion

            dt.PrimaryKey = null;

            return dt;
        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@clavePersona", MiPersona.ClavePersona));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioID", MiUsuario.UsuarioId));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@fechaDevolucion", FechaDevolucion));

            Object retorno = MiCnn.EjecutarSELECTEscalar("SPPrestamoAgregar");


            int IDCreada;

            if (retorno != null)
            {
                try
                {
                    IDCreada = Convert.ToInt32(retorno.ToString());
                    this.ClavePrestamo = IDCreada;


                    foreach (PrestamoDetalle item in ListaPrestamoDetalles) 
                    {
                        Conexion MiCnnDetalle = new Conexion();

                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@ClavePrestamo", this.ClavePrestamo));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@ClaveLibro", item.Milibro.ClaveLibro));
                        MiCnnDetalle.EjecutarInsertUpdateDelete("SPPrestamoDetallesAgregar");



                    }
                    R = true;

                }
                catch (Exception)
                {

                    throw;
                }

            }


            return R;



        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion conexion = new Conexion();

            R = conexion.EjecutarSELECT("SPListarPrestamoS");

            return R;
        }

    }
}
