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

        public static Entities ObtenerTiposSocios()
        {
            return SociosDA.ObtenerTiposSocios();
        }

        public static Boolean CrearSocio(String pNombre, String pCodigo, int pIdCuenta, int pIdTipoSocio)
        {
            Entity result = SociosDA.CrearSocio(pNombre, pCodigo, pIdCuenta, pIdTipoSocio);
            return (Boolean)result.Get("estado");
        }
    }
}
