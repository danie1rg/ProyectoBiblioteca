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
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string UsuarioNombre { get; set; }

        public string Correo { get; set; }

        public string Contrasena { get; set; }

        public bool Estado { get; set; }

        public UsuarioRol MiUsuarioRol { get; set; }

        public Usuario()
        {
            MiUsuarioRol = new UsuarioRol();
        }

        public bool Agregar()
        {
            bool respuesta = false;

            Conexion MiCnn = new Conexion();

            Crypto MiEncrip = new Crypto();

            string ContrasenniaEncriptada = MiEncrip.EncriptarEnUnSentido(this.Contrasena);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasena", ContrasenniaEncriptada));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@NombreUsuario", this.UsuarioNombre));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioRolID", this.MiUsuarioRol.UsuarioRolId));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioAgregar");

            if (resultado > 0)
            {
                respuesta = true;
            }

            return respuesta;

        }

        public bool ConsultarPorEmail()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@correo", this.Correo));

            DataTable consulta = new DataTable();
            consulta = MiCnn.EjecutarSELECT("SPConsultarPorCorreo");

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

            R = MiCnn.EjecutarSELECT("SPUsuariosListar");

            return R;

        }
        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@verActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPUsuariosListar");

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("ID", this.UsuarioId));


            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
                R = true;

            }

            return R;
        }

        public Usuario ConsultarPorIDRetornaUsuario()
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {
            
                DataRow dr = dt.Rows[0];

                R.UsuarioId = Convert.ToInt32(dr["UsuarioID"]);
                R.UsuarioNombre = Convert.ToString(dr["NombreUsuario"]);

                
                R.Correo = Convert.ToString(dr["Correo"]);


                R.Contrasena = string.Empty;

                //composiciones
                R.MiUsuarioRol.UsuarioRolId = Convert.ToInt32(dr["UsuarioRolID"]);
                R.MiUsuarioRol.Descripcion = Convert.ToString(dr["descripcion"]);

            }


            return R;
        }

        public bool Editar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            Crypto MiEncrip = new Crypto();

            string ContrasenniaEncriptada = MiEncrip.EncriptarEnUnSentido(this.Contrasena);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasena ", ContrasenniaEncriptada));


            MiCnn.ListaDeParametros.Add(new SqlParameter("@NombreUsuario", this.UsuarioNombre));


            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioRolID ", this.MiUsuarioRol.UsuarioRolId));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioEditar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioDesactivar");

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

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioId));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioActivar");

            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }




    }
}
