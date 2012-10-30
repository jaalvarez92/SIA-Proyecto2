using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public class TipoCambioDA
    {
        public static Entity ObtenerTipoCambio(int pIdMonedaBase, int pIdMonedaCambio, DateTime pFecha)
        {
            Entity parametros = new Entity();
            parametros.Set("pmonedabase", pIdMonedaBase);
            parametros.Set("pmonedacambio", pIdMonedaCambio);
            parametros.Set("pfecha", pFecha);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_tipo_cambio", parametros);
            return resultado;
        }

        public static Entity IngresarTipoCambio(int pIdMonedaBase, int pIdMonedaCambio, decimal pValor)
        {
            Entity parametros = new Entity();
            parametros.Set("pidmonedabase", pIdMonedaBase);
            parametros.Set("pidmonedacambio", pIdMonedaCambio);
            parametros.Set("pvalor", pValor);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("ingresar_tipo_cambio", parametros);
            return resultado;
        }
    }
}
