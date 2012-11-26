using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;
using System.Web.Services;
using Logica.ModuloClientes;
using Logica.ModuloCompras;

namespace ProveedoresWA.Controllers
{
    public class Consultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //_Logica = new LogicaUsuarios();
        }

        /*
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
        }*/
        

        [WebMethod]
        public static Object[] AutenticarSocio(string pUsuario, string pPassword)
        {
            return SocioLogica.AutenticarSocio(pUsuario, pPassword);
        }


        [WebMethod]
        public static Object[] ObtenerOrdenesCompraAutomaticasXSocio(string pIdSocio)
        {
            Entities ordenes = ComprasLogica.ObtenerOrdenesCompraAutomaticasXSocio(int.Parse(pIdSocio));
            List<Object[]> resultado = new List<Object[]>();
            foreach (Entity e in ordenes)
            {
                resultado.Add(new Object[] { e.Get("fecha1"), e.Get("NumeroDocumento"), e.Get("Descripcion"), e.Get("Stock"), e.Get("CantidadMaxima"), e.Get("CantidadMinima"), e.Get("total") });
            }
            return resultado.ToArray();
        }
    }
}