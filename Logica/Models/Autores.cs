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
    public class Autor
    {
        public int claveAutor { get; set; }
        public string nombre { get; set; }
        public string nacionalidad { get; set; }

        public bool Activo { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nacionalidad", this.nacionalidad));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPAutorAgregar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable Listar(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion conexion = new Conexion();

            conexion.ListaDeParametros.Add(new SqlParameter("@filtroBusqueda", pFiltroBusqueda));

            R = conexion.EjecutarSELECT("SPAutorListar");

            return R;
        }

        public bool ConsultarPorClaveAutor()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Clave", this.claveAutor));


            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPAutorConsultarPorClave");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;

            }

            return R;
        }

        public bool ConsultarPorNombre()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.nombre));


            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPAutorConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;

            }

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nacionalidad", this.nacionalidad));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPAutorModificar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }


        public Autor ConsultarPorIDRetornaAutor()
        {
            Autor R = new Autor();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Clave", this.claveAutor));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPAutorConsultarPorClave");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.claveAutor = Convert.ToInt32(dr["ClaveAutor"]);
                R.nombre = Convert.ToString(dr["Nombre"]);
                R.nacionalidad = Convert.ToString(dr["Nacionalidad"]);

            }
            return R;
        }




    }

}
