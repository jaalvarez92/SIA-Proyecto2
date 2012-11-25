using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.Services;
/*
using Libreria.Administrativo;
using ProyectoDiseno.Logica;
*/

namespace ProveedoresWA.Controllers
{
    public class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //_Logica = new LogicaUsuarios();
        }

        [WebMethod]
        public static bool Autenticar(string pUsuario, string pPassword)
        {
            /*
            var usuario = _Logica.AutenticarUsuario(pUsuario, pPassword);
            if (usuario!=null)
            {
                HttpContext.Current.Session["usuario"] = usuario;
            }
            return usuario;
             * */
            return true;
        }

        [WebMethod]
        public static void EscogerRol(string pNombreRol)
        {
            ///_Logica.EscogerRol(pNombreRol);
        }

        //private static LogicaUsuarios _Logica;
    }
}