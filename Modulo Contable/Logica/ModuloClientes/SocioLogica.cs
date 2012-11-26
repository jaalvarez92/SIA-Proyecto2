using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using AccesoDatos;

namespace Logica.ModuloClientes
{
    public static class SocioLogica
    {

        public static Object[] AutenticarSocio(String pUsuario, String pPassword)
        {
            Entities result = SociosDA.AutenticarSocio(pUsuario, pPassword);
            if (result.Count == 0)
            {
                return null;
            }
            return new Object[] { (int)result[0].Get("idsocio"), (String)result[0].Get("nombre") };
        }

        public static Entities ObtenerTiposSocios()
        {
            return SociosDA.ObtenerTiposSocios();
        }

        public static Boolean CrearSocio(String pNombre, String pCodigo, int pIdCuenta, int pIdTipoSocio)
        {
            Entity result = SociosDA.CrearSocio(pNombre, pCodigo, pIdCuenta, pIdTipoSocio);
            return (Boolean)result.Get("estado");
        }

        public static Entities ObtenerSocio(String pCodigo)
        {
            return SociosDA.ObtenerSocio(pCodigo);
        }

        public static Entities ObtenerDocumentosAbiertosSocio(int pIdSocio)
        {
            return SociosDA.ObtenerDocumentosAbiertosSocio(pIdSocio);
        }
    }
}
