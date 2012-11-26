using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;
using System.Web.Services;

namespace ProveedoresWA.Controllers
{
    public class Consultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //_Logica = new LogicaUsuarios();
        }

        [WebMethod]
        public Entity AutenticarSocio(String pUsuario, String pPassword)
        {
            WSWA.WebServiceWA web_service = new WSWA.WebServiceWA();
            Object[] resultado = web_service.AutenticarSocio(pUsuario, pPassword);
            if (resultado != null)
            {
                Entity socio = new Entity();
                socio.Set("idsocio", resultado[0]);
                socio.Set("nombre", resultado[1]);
                return socio;
            }
            return null;
        }

    }
}