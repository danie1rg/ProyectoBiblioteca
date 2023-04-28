using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra5
{
    public class Globales
    {
        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmGestionDeUsuarios MiFormGestionUsuarios = new Formularios.FrmGestionDeUsuarios();

        public static Formularios.FrmGestionPersona MiGestionPersona = new Formularios.FrmGestionPersona();

        public static Formularios.FrmGestionUsuarioRol MiGestionRolUsuario = new Formularios.FrmGestionUsuarioRol();

        public static Formularios.FrmGestionTipoDePersona MiGestionTipoDePersona = new Formularios.FrmGestionTipoDePersona();

        public static Formularios.FrmGestionAutor MiGestionAutor = new Formularios.FrmGestionAutor();

        public static Formularios.FrmGestionCategoria MiGestionCategoria = new Formularios.FrmGestionCategoria();

        public static Formularios.FrmGestionLibro MiGestionLibro = new Formularios.FrmGestionLibro();

        //public static Formularios.FrmPrestamoDetalle MiPrestamoDetalle = new Formularios.FrmPrestamoDetalle();

        public static Formularios.FrmRegistroPrestamo MiFormRegistroPrestamo = new Formularios.FrmRegistroPrestamo();

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        public static Formularios.FrmPrestamosActivos MiPrestamoDetalleActivos = new Formularios.FrmPrestamosActivos();

        public static Formularios.FrmInformacion MiInformacion = new Formularios.FrmInformacion();  

        public static Formularios.FrmListarPrestamosPorHoy MiPrestamoHoy = new Formularios.FrmListarPrestamosPorHoy();


    }
}
