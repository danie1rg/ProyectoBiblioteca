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
        public int ClaveLibro { get; set; }
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
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Titulo", this.Titulo));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CantidadPaginas", this.CantidadPaginas));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveCategoria", this.MiCategoria.ClaveCategoria));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClaveAutor", this.MiAutor.claveAutor));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPLibroAgregar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;

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

        public bool ConsultarPorTituloLibro()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Titulo", this.Titulo));

            DataTable consulta = new DataTable();
            consulta = MiCnn.EjecutarSELECT("SPLibroConsultarPorTitulo");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@filtroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPLibroListar");

            return R;

        }
        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@verActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@filtroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPLibroListar");

            return R;
        }

      

        public Libro ConsultarPorIDRetornaLibro()
        {
            Libro R = new Libro();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Clave", this.ClaveLibro));

      
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPLibroConsultarPorClave");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.ClaveLibro = Convert.ToInt32(dr["ClaveLibro"]);
                R.Titulo = Convert.ToString(dr["Titulo"]);
                R.CantidadPaginas = Convert.ToInt32(dr["CantidadPaginas"]);

               
                R.MiAutor.claveAutor = Convert.ToInt32(dr["ClaveAutor"]);
                R.MiAutor.nombre = Convert.ToString(dr["Nombre"]);

                R.MiCategoria.ClaveCategoria = Convert.ToInt32(dr["ClaveCategoria"]);
                R.MiCategoria.Descripcion = Convert.ToString(dr["Descripcion"]);

            }


            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Clave", this.ClaveLibro));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Titulo", this.Titulo));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Paginas", this.CantidadPaginas));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Categoria", this.MiCategoria.ClaveCategoria));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Autor", this.MiAutor.claveAutor));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPLibroModificar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Eliminar()
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


        public bool Activar()
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
