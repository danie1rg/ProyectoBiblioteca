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
    public class Categoria
    {
        public int ClaveCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
           
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPCategoriaAgregar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion conexion = new Conexion();

            R = conexion.EjecutarSELECT("SPCategoriaListar");

            return R;
        }

        public bool ConsultarPorClaveCategoria()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Clave", this.ClaveCategoria));


            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPCategoriaConsultarPorClave");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;

            }

            return R;
        }

        public bool ConsultarPorGenero()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Genero", this.ClaveCategoria));


            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPCategoriaConsultarPorGenero");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPCategoriaModificar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }


        public Categoria ConsultarPorIDRetornaCategoria()
        {
            Categoria R = new Categoria();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Clave", this.ClaveCategoria));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPCategoriaConsultarPorClave");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.ClaveCategoria = Convert.ToInt32(dr["ClaveCategoria"]);
                R.Descripcion = Convert.ToString(dr["Descripcion"]); 

            }
            return R;
        }


    }

}
