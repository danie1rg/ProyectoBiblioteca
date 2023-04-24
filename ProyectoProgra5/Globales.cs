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

    }
}
