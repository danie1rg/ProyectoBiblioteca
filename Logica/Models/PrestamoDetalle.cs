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
    public class PrestamoDetalle
    {
        public int cantidad;
        public string clavePrestamo;
        public string claveLibro;
        public string Notas;
        public Libro Milibro;
        public Prestamo MiPrestamo;

        private PrestamoDetalle() 
        {
            Milibro = new Libro();
            MiPrestamo = new Prestamo();
        }



        public bool Agregar()
        {
            bool respuesta = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveLibro", this.Milibro.ClaveLibro));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClavePrestamo", this.MiPrestamo.ClavePrestamo));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.Notas));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cantidad", this.cantidad));

            int resultado = MiCnn.EjecutarSELECTEscalar("SPPrestamoDetallesAgregar");

            if (resultado > 0)
            {
                respuesta = true;
            }

            return respuesta;

        }

        public bool ConsultarPorClaveLibroPrestamo()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClavePrestamo", this.MiPrestamo.ClavePrestamo));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveLibro", this.Milibro.ClaveLibro));


            DataTable consulta = new DataTable();
            consulta = MiCnn.EjecutarSELECT("SPPrestamoDetalleConsultarClave");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }
            return R;
        }

        public DataTable ListarActivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@verActivos", true));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPLibroListar");

            return R;

        }
        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@verActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPLibroListar");

            return R;
        }



        public PrestamoDetalle ConsultarPorIDRetornaPrestamoDetalle()
        {
            PrestamoDetalle R = new PrestamoDetalle();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveLibro", this.Milibro.ClaveLibro));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClavePrestamo", this.MiPrestamo.ClavePrestamo));


       
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPLibroConsultarPorClave");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.Milibro.ClaveLibro = Convert.ToString(dr["ClaveLibro"]);
                R.MiPrestamo.ClavePrestamo = Convert.ToInt32(dr["ClavePrestamo"]);
                R.Notas = Convert.ToString(dr["Notas"]);
                R.cantidad = Convert.ToInt32(dr["Cantidad"]);
            }


            return R;
        }

     

        public bool DesactivarPrestamoDetalle()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveLibro", this.Milibro.ClaveLibro));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClavePrestamo", this.MiPrestamo.ClavePrestamo));


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


            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveLibro", this.Milibro.ClaveLibro));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClavePrestamo", this.MiPrestamo.ClavePrestamo));


            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPPrestamoDetalleActivar");

            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }






    }

}
