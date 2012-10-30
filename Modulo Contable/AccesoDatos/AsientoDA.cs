using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Globalization;

namespace AccesoDatos
{
    public static class AsientoDA
    {
        public static Entities ObtenerAsientos(DateTime FechaInicio, DateTime FechaFinal)
        {
            Entity parametros = new Entity();
            parametros.Set("p_Fecha_inicio", FechaInicio);
            parametros.Set("p_Fecha_fin", FechaFinal);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("consultar_asiento", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }

        public static int IngresarAsiento(DateTime pFechaDocumento) {
            Entity parametros = new Entity();
            parametros.Set("pFechaContabilizado", DateTime.Now);
            parametros.Set("pFechaDocumento", pFechaDocumento);
            parametros.Set("pIdTipoAsiento", 1);
            parametros.Set("pReferencia1", "");
            parametros.Set("pReferencia2", "");
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("crear_asiento_sin_cuentas", parametros);
            Entities tabla_resultado = (Entities)resultado.Get("table");
            Entity resultadoId = tabla_resultado[0];
            int idAsiento = int.Parse(resultadoId.Get("idasiento").ToString());
            return idAsiento;
        }


        public static Entity IngresarLineaAsiento(int pIdAsiento,int pIdCuenta,decimal pMontoLocal,decimal pMontoSistema, bool pDebeHaber)
        {
            Entity parametros = new Entity();
            parametros.Set("pIdAsiento", pIdAsiento);
            parametros.Set("pIdCuenta", pIdCuenta);
            parametros.Set("pMonto_Local", pMontoLocal);
            parametros.Set("pMonto_Sistema", pMontoSistema);
            parametros.Set("pDebe_Haber", pDebeHaber);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("agregar_cuenta_a_asiento", parametros);
            return resultado;
        }

        public static Entity NulificarAsiento(int pCodigoAsiento)
        {
            Entity parametros = new Entity();
            parametros.Set("pCodigoAsiento", pCodigoAsiento);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("nulificar_asiento", parametros);
            return resultado;
        }

    }
}
