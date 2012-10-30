using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServiceGenerarAsiento
{
    [ServiceContract]
    public interface IERPAsientos
    {

        [OperationContract]
        int ingresarNuevoAsiento(DateTime pFechaDocumento);

        [OperationContract]
        int ingresarCuentasAsiento(int pIdAsiento, int pIdCuenta, decimal pMontoLocal, decimal pMontoSistema, bool pDebeHaber);
    }
}
