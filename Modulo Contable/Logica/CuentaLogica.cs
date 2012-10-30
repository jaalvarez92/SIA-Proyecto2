using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using AccesoDatos;

namespace Logica
{
    public static class CuentaLogica
    {
        #region Métodos
        public static Entities ObtenerTiposCuenta()
        {
            return CuentaDA.ObtenerTiposCuenta();
        }

        public static Entities ObtenerCuentas()
        {
            return CuentaDA.ObtenerCuentas();
        }

        public static Boolean CrearCuenta(String pCodigo, String pNombre, String pNombreExtranjero, Boolean pEsTitulo,
                                         int pIdTipoCuenta, int pIdCuentaPadre, int pIdMoneda)
        {
            int esTitulo = 0;
            if (pEsTitulo) esTitulo = 1;
            Entity result = CuentaDA.CrearCuenta(pCodigo, pNombre, pNombreExtranjero, esTitulo, pIdTipoCuenta, pIdCuentaPadre, pIdMoneda);
            return (Boolean)result.Get("estado");
        }


        public static Boolean EliminarCuenta(int pIdCuenta)
        {
            Entity result = CuentaDA.EliminarCuenta(pIdCuenta);
            return (Boolean)result.Get("estado");
        }
        #endregion

    }
}
