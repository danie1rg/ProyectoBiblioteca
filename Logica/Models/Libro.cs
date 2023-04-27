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
    public class Libro
    {
        public string ClaveLibro { get; set; }
        public string Titulo { get; set; }
        public int CantidadPaginas { get; set; }
        public bool Activo { get; set; }
        public Autor MiAutor { get; set; }
        public Categoria MiCategoria { get; set; }

        public Libro() 
        {
            MiAutor = new Autor();
            MiCategoria = new Categoria();
        }
        public bool Agregar()
        {
            bool respuesta = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveLibro", this.ClaveLibro));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Titulo", this.Titulo));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveCategoria", this.MiCategoria.ClaveCategoria));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveAutor", this.MiAutor.claveAutor));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPLibroAgregar");

            if (resultado > 0)
            {
                respuesta = true;
            }

            return respuesta;

        }

        public bool ConsultarPorClaveLibro()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Clave", this.ClaveLibro));

            DataTable consulta = new DataTable();
            consulta = MiCnn.EjecutarSELECT("SPLibroConsultarPorClave");

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

      

        public Libro ConsultarPorIDRetornaUsuario()
        {
            Libro R = new Libro();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Clave", this.ClaveLibro));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPLibroConsultarPorClave");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.ClaveLibro = Convert.ToString(dr["ClaveLibro"]);
                R.Titulo = Convert.ToString(dr["Titulo"]);


                R.CantidadPaginas = Convert.ToInt32(dr["CantidadPaginas"]);

                //composiciones
                R.MiAutor.claveAutor = Convert.ToString(dr["ClaveAutor"]);
                R.MiAutor.nombre = Convert.ToString(dr["Nombre"]);

                R.MiCategoria.ClaveCategoria = Convert.ToString(dr["ClaveCategoria"]);
                R.MiCategoria.Descripcion = Convert.ToString(dr["Descripcion"]);

            }


            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@Titulo", this.Titulo));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CantidadPaginas", this.CantidadPaginas));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveCategoria", this.MiCategoria.ClaveCategoria));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveAutor", this.MiAutor.claveAutor));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveLibro", this.ClaveLibro));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPLibroEditar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool DesactivarUsuario()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Clave", this.ClaveLibro));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPLibroDesactivar");

            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }


        public bool ActivarUsuario()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Clave", this.ClaveLibro));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPLibroActivar");

            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }

      


    }

}
