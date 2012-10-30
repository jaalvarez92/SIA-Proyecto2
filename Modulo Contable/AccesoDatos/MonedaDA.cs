using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public static class MonedaDA
    {

        public static Entities ObtenerMonedas()
        {
            Entity parametros = new Entity();
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_monedas", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }
    }
}
