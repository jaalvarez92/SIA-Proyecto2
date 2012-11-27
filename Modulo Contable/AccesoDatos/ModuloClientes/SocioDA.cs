using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public static class SociosDA
    {

        public static Entities AutenticarSocio(String pUsuario, String pPassword)
        {
            Entity parametros = new Entity();
            parametros.Set("pUsuario", pUsuario);
            parametros.Set("pPassword", pPassword);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("autenticar_socio", parametros);
            return (Entities)resultado.Get("table");
        }

        public static Entities ObtenerTiposSocios()
        {
            Entity parametros = new Entity();
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_tipos_socios", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }

        public static Entity CrearSocio(String pNombre, String pCodigo, int pIdCuenta, int pIdTipoSocio)
        {
            Entity parametros = new Entity();
            parametros.Set("pNombre", pNombre);
            parametros.Set("pCodigo", pCodigo);
            parametros.Set("pIdCuenta", pIdCuenta);
            parametros.Set("pIdTipoSocio", pIdTipoSocio);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("crear_socio", parametros);
            return resultado;
        }


        public static Entity CrearProveedor(String pNombre, String pCodigo, int pIdCuenta, int pIdTipoSocio, String pNombreUsuario, String pPassword, String pCorreo)
        {
            Entity parametros = new Entity();
            parametros.Set("pNombre", pNombre);
            parametros.Set("pCodigo", pCodigo);
            parametros.Set("pIdCuenta", pIdCuenta);
            parametros.Set("pIdTipoSocio", pIdTipoSocio);
            parametros.Set("pNombreUsuario", pNombreUsuario);
            parametros.Set("pPassword", pPassword);
            parametros.Set("pCorreo", pCorreo);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("crear_proveedor", parametros);
            return resultado;
        }


        public static Entities ObtenerSocio(String pCodigo)
        {
            Entity parametros = new Entity();
            parametros.Set("pCodigo", pCodigo);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_socio", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }

        public static Entities ObtenerDocumentosAbiertosSocio(int pIdSocio)
        {
            Entity parametros = new Entity();
            parametros.Set("pIdSocio", pIdSocio);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_documentos_abiertos_socio", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }

    }
}
