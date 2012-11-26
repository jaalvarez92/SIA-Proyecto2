using System;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Logica;
using Entidades;
using Logica.ModuloClientes;

namespace WebServiceWA
{
    public class ERPAsientos : IERPWA
    {

        public Entity AutenticarSocio(String pUsuario, String pPassword)
        {
            return SocioLogica.AutenticarSocio(pUsuario, pPassword);
        }

        public int ingresarCuentasAsiento(int pIdAsiento, int pIdCuenta, decimal pMontoLocal, decimal pMontoSistema, bool pDebeHaber)
        {
            AsientoLogica.IngresarLineaAsiento(pIdAsiento, pIdCuenta, pMontoLocal, pMontoSistema, pDebeHaber);
            return 1;
        }
    }
}
