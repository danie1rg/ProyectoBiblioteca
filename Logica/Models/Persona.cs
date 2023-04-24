using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Persona
    {
        public int ClavePersona { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public TipoDePersona MiTipoDePersona { get; set; }

        public bool Estado { get; set; }

        public Persona() {
            MiTipoDePersona= new TipoDePersona();
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@correo", this.Email));

            DataTable consulta = new DataTable();
            consulta = MiCnn.EjecutarSELECT("SPPersonaConsultarPorCorreo");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }
            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@cedula", this.Cedula));

            DataTable consulta = new DataTable();
            consulta = MiCnn.EjecutarSELECT("SPPersonaConsultarPorCedula");

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

            R = MiCnn.EjecutarSELECT("SPPersonasListar");

            return R;

        }
        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@verActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPPersonasListar");

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("ID", this.ClavePersona));


            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPPersonaConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;

            }

            return R;
        }

        public Persona ConsultarPorIDRetornaPersona()
        {
            Persona R = new Persona();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ClavePersona));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPPersonaConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {

                DataRow dr = dt.Rows[0];

                R.ClavePersona = Convert.ToInt32(dr["clavePersona"]);
                R.Cedula = Convert.ToString(dr["cedula"]);
                R.MiTipoDePersona.TipoPersonaId = Convert.ToInt32(dr["TipoPersonaID"]);
                R.Nombre = Convert.ToString(dr["nombre"]);
                R.Apellido = Convert.ToString(dr["apellido"]);
                R.Email = Convert.ToString(dr["email"]);
                R.Telefono = Convert.ToString(dr["Telefono"]);
                R.Direccion = Convert.ToString(dr["Direccion"]);
                R.FechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"]);


            }


            return R;
        }

        public bool Agregar()
        {
            bool respuesta = false;

            Conexion MiCnn = new Conexion();

           
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Apellido", this.Apellido));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Email));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaNacimiento", this.FechaNacimiento));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));


            MiCnn.ListaDeParametros.Add(new SqlParameter("@TipoPersonaID", this.MiTipoDePersona.TipoPersonaId));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPPersonaAgregar");

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

            Crypto MiEncrip = new Crypto();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Apellido", this.Apellido));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Email));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaNacimiento", this.FechaNacimiento));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@TipoPersonaID", this.MiTipoDePersona.TipoPersonaId));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ClavePersona));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPPersonaModificar");

            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool DesactivarPersona()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ClavePersona));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPPersonaDesactivar");

            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }


        public bool ActivarPersona()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ClavePersona));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPPersonaActivar");

            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }




    }
}
