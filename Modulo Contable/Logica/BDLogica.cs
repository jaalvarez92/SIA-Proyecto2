using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using System.Data;

namespace Logica
{
    public class BDLogica
    {

        public void EjecutarScript(String pEsquema)
        {
            ManejadorBaseDatos.Instancia.EjecutarScript(pEsquema);
        }
        public DataSet ObtenerReportes(String pNombreSP)
        {            
            return ManejadorBaseDatos.Instancia.obtenerDataSet(pNombreSP);
        }

        public DataSet RealizarCierre(string pNombreSP)
        {
            return ManejadorBaseDatos.Instancia.obtenerDataSet(pNombreSP);
        }
    }
}
