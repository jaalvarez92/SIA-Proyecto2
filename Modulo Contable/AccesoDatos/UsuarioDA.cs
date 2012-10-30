using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public static class UsuarioDA
    {
        public static Boolean LogIn(String pNombreUsuario, String pContrasena)
        {
            Entity parametros = new Entity();
            byte[] contrasena = System.Text.Encoding.ASCII.GetBytes(pContrasena);
            parametros.Set("pNombreUsuario", pNombreUsuario);
            parametros.Set("pContrasena",  contrasena);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("autenticar_usuario", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            if (resultado_table.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
