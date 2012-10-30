using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using AccesoDatos;

namespace Logica.ModuloClientes
{
    public static class SocioBL
    {

        public static Entities ObtenerTiposSocios()
        {
            return SociosDA.ObtenerTiposSocios();
        }
    }
}
