using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using AccesoDatos;

namespace Logica
{
    public static class MonedaLogica
    {
        public static Entities ObtenerMonedas()
        {
            return MonedaDA.ObtenerMonedas();
        }
    }
}
