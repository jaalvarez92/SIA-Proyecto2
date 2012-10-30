using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using AccesoDatos;
using System.Globalization;

namespace Logica
{
    public static class AsientoLogica
    {
        public static Entities ObtenerAsientos(DateTime FechaInicio, DateTime FechaFinal)
        {
            
            return AsientoDA.ObtenerAsientos(FechaInicio, FechaFinal);
        }

        public static int IngresarAsiento(DateTime pFechaDocumento) 
        {
            return AsientoDA.IngresarAsiento(pFechaDocumento);
        }

        public static Entity IngresarLineaAsiento(int pIdAsiento, int pIdCuenta, decimal pMontoLocal, decimal pMontoSistema, bool pDebeHaber)
        {
            return AsientoDA.IngresarLineaAsiento(pIdAsiento,pIdCuenta,pMontoLocal,pMontoSistema,pDebeHaber);
        }

        public static Entity NulificarAsiento(int pCodigoAsiento)
        {
            return AsientoDA.NulificarAsiento(pCodigoAsiento);
        }
    }
}
