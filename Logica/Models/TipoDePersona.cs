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
    public class TipoDePersona
    {
        public int TipoPersonaId { get; set; }

        public string Descripcion { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();

            R = MiCnn.EjecutarSELECT("SPPersonaTipoListar");

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("ID", this.TipoPersonaId));


            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPTipoPersonaPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;

            }

            return R;
        }

        public TipoDePersona ConsultarPorIDRetornaUsuarioRol()
        {
            TipoDePersona R = new TipoDePersona();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.TipoPersonaId));


            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPTipoPersonaPorID");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.TipoPersonaId = Convert.ToInt32(dr["TipoPersonaID"]);
                R.Descripcion = Convert.ToString(dr["descripcion"]);


            }


            return R;
        }


        public bool Agregar()
        {
            bool respuesta = false;

            Conexion MiCnn = new Conexion();



            MiCnn.ListaDeParametros.Add(new SqlParameter("@descripcion", this.Descripcion));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("STipoPersonaAgregar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.TipoPersonaId));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPTipoPersonaEditar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

    }
}
