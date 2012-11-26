using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace AccesoDatos.ModuloCompras
{
    public static class ComprasDA
    {
        public static Entities ObtenerOrdenesCompraAutomaticasXSocio(int pIdSocio)
        {
            Entity parametros = new Entity();
            parametros.Set("pIdSocio", pIdSocio);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_ordenes_compra_x_socio", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }
    }
}
