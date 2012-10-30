using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using AccesoDatos;

namespace Logica
{
    public class TipoCambioLogica
    {
        public static Entity ObtenerTipoCambio(int pIdMonedaBase, int pIdMonedaCambio, DateTime pFecha)
        {
            return TipoCambioDA.ObtenerTipoCambio(pIdMonedaBase, pIdMonedaCambio, pFecha.Date);
        }

        public static Boolean IngresarTipoCambio(int pIdMonedaBase, int pIdMonedaCambio, decimal pValor)
        {
            Entity result = TipoCambioDA.IngresarTipoCambio(pIdMonedaBase, pIdMonedaCambio, pValor);
            return (Boolean)result.Get("estado");
        }

    }
}
