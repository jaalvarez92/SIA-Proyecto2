using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public static class SociosDA
    {

        public static Entities ObtenerTiposSocios()
        {
            Entity parametros = new Entity();
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_tipos_socios", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }

        public static Entity CrearSocio(String pNombre, String pCodigo, int pIdCuenta, int pIdTipoSocio)
        {
            Entity parametros = new Entity();
            parametros.Set("pNombre", pNombre);
            parametros.Set("pCodigo", pCodigo);
            parametros.Set("pIdCuenta", pIdCuenta);
            parametros.Set("pIdTipoSocio", pIdTipoSocio);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("crear_socio", parametros);
            return resultado;
        }

    }
}
