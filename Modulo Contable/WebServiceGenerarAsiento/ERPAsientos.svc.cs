using System;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Logica;

namespace WebServiceGenerarAsiento
{
    public class ERPAsientos : IERPAsientos
    {

        public int ingresarNuevoAsiento(DateTime pFechaDocumento)
        {
            return AsientoLogica.IngresarAsiento(pFechaDocumento); ;
        }

        public int ingresarCuentasAsiento(int pIdAsiento, int pIdCuenta, decimal pMontoLocal, decimal pMontoSistema, bool pDebeHaber)
        {
            AsientoLogica.IngresarLineaAsiento(pIdAsiento, pIdCuenta, pMontoLocal, pMontoSistema, pDebeHaber);
            return 1;
        }
    }
}
