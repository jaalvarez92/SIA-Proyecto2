using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;

namespace Logica
{
    public static class UsuarioLogica
    {
        #region Métodos
        public static Boolean LogIn(String pNombreUsuario, String pContrasena)
        {
            return UsuarioDA.LogIn(pNombreUsuario, pContrasena);
        }
        #endregion
    }

}
