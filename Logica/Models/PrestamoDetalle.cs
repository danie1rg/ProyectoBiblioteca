using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Logica.Models
{

    public class PrestamoDetalle
    {
        public int ID { get; set; }
        public bool Activo { get; set; }
        public Libro Milibro { get; set; }
        public Prestamo MiPrestamo { get; set; }

        public PrestamoDetalle()
        {
            Milibro = new Libro();
            MiPrestamo = new Prestamo();
        }



        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveLibro", this.Milibro.ClaveLibro));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClavePrestamo", this.MiPrestamo.ClavePrestamo));

            Object resultado = MiCnn.EjecutarSELECTEscalar("SPPrestamoDetallesAgregar");

            int IDCreada;

            IDCreada = Convert.ToInt32(resultado.ToString());

            if (IDCreada > 0)
            {
                R = true;
            }

            return R;

        }



        public bool ConsultarPorClavePrestamoDetalle()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ID));

            DataTable consulta = new DataTable();

            consulta = MiCnn.EjecutarSELECT("SPPrestamoDetalleConsultarClave");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }
            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@verActivos", true));


            R = MiCnn.EjecutarSELECT("SPPrestamoDetalleListar");

            return R;

        }
        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@verActivos", false));

            R = MiCnn.EjecutarSELECT("SPPrestamoDetalleListar");

            return R;
        }





        public bool DesactivarPrestamoDetalle()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ID));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPPrestamoDetalleDesactivar");

            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }


        public bool ActivarPrestamoDetalle()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ID));



            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPPrestamoDetalleActivar");

            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }

    }
}






  

