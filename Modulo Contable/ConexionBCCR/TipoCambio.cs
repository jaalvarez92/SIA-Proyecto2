using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionBCCR.wsIndicadoresEconomicos;

namespace ConexionBCCR
{
    public class TipoCambio
    {
        private wsIndicadoresEconomicosSoapClient clienteBCCR;

        private static readonly TipoCambio instancia = new TipoCambio();

        private TipoCambio() {
            clienteBCCR = new wsIndicadoresEconomicosSoapClient();
        }

        public static TipoCambio Instancia
        {
            get 
            {
                return instancia; 
            }
        }
        /// <summary>
        /// Obtiene el tipo de cambio a la venta de la fecha especificada
        /// </summary>
        /// <param name="pFechaTipoCambio"></param>
        /// <returns>Tipo de cambio o -1 en caso de error</returns>
        public decimal obtenerTipoCambioVenta(DateTime pFechaTipoCambio)
        {
            try
            {
                System.Data.DataSet resultWS = clienteBCCR.ObtenerIndicadoresEconomicos("318", String.Format("{0:dd/MM/yyyy}", pFechaTipoCambio), String.Format("{0:dd/MM/yyyy}", pFechaTipoCambio), "ClienteSIA", "n");
                return Convert.ToDecimal(resultWS.Tables[0].Rows[0][2]);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// Obtiene el tipo de cambio a la compra de la fecha especificada
        /// </summary>
        /// <param name="pFechaTipoCambio"></param>
        /// <returns>Tipo de cambio o -1 en caso de error</returns>
        public decimal obtenerTipoCambioCompra(DateTime pFechaTipoCambio)
        {
            try
            {
                System.Data.DataSet resultWS = clienteBCCR.ObtenerIndicadoresEconomicos("317", String.Format("{0:dd/MM/yyyy}", pFechaTipoCambio), String.Format("{0:dd/MM/yyyy}", pFechaTipoCambio), "ClienteSIA", "n");
                return Convert.ToDecimal(resultWS.Tables[0].Rows[0][2]);
            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}
