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
    public class UsuarioRol
    {
        public int UsuarioRolId { get; set; }
        public string Descripcion { get; set; }

        public UsuarioRol() 
        { }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();

            R = MiCnn.EjecutarSELECT("SPUsuarioRolListar");

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("ID", this.UsuarioRolId));


            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioRolPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;

            }

            return R;
        }

        public UsuarioRol ConsultarPorIDRetornaUsuarioRol()
        {
            UsuarioRol R = new UsuarioRol();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioRolId));

 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioRolPorID");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.UsuarioRolId = Convert.ToInt32(dr["UsuarioRolID"]);
                R.Descripcion = Convert.ToString(dr["descripcion"]);


            }


            return R;
        }


        public bool Agregar()
        {
            bool respuesta = false;

            Conexion MiCnn = new Conexion();

          

            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.Descripcion));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioRolAgregar");

            if (resultado > 0)
            {
                respuesta = true;
            }

            return respuesta;

        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.Descripcion));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioRolId));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioRolEditar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }


    }
}
