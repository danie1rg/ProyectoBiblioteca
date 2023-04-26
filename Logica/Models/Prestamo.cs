using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Prestamo
    {
        public int ClavePrestamo { get; set; }

        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public bool Estado { get; set; }

        public Usuario MiUsuario { get; set;}

        public Persona MiPersona { get; set; }


        

        public Prestamo() {
            MiUsuario  = new Usuario();
            MiPersona = new Persona();
        }

        public bool Agregar() 
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@clavePersona",MiPersona.ClavePersona));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioID", MiUsuario.UsuarioId));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@fechaDevolucion", FechaDevolucion));

            Object retorno = MiCnn.EjecutarSELECTEscalar("SPPrestamoAgregar");


            int IDCreada;

            if (retorno != null)
            {
                try
                {
                    IDCreada = Convert.ToInt32(retorno.ToString());

                }
                catch (Exception)
                {

                    throw;
                }

            }


            return R;



        }


    }
}
