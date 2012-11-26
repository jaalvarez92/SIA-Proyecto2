using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using AccesoDatos.ModuloCompras;

namespace Logica.ModuloCompras
{
    public static class ComprasLogica
    {
        public static Entities ObtenerOrdenesCompraAutomaticasXSocio(int pIdSocio)
        {
            return ComprasDA.ObtenerOrdenesCompraAutomaticasXSocio(pIdSocio);
        } 
    }
}
