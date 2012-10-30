using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public static class CuentaDA
    {
        #region Métodos
        public static int ObtenerCatalogoContable()
        {
            Entity parametros = new Entity();
            parametros.Set("pIdEmpresa", Configuracion.IdEmpresa);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_catalogo_contable", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            Entity catalogo = resultado_table.Get("Fk_IdEmpresa", Configuracion.IdEmpresa);
            return (int)catalogo.Get("idcatalogo_contable");
        }

        public static Entities ObtenerTiposCuenta()
        {
            Entity parametros = new Entity();
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_tipos_cuenta", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }

        public static Entities ObtenerCuentas()
        {
            Entity parametros = new Entity();
            parametros.Set("pIdCatalogoContable", ObtenerCatalogoContable());
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_cuentas", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }

        public static Entity CrearCuenta(String pCodigo, String pNombre, String pNombreExtranjero, int pEsTitulo,
                                         int pIdTipoCuenta, int pIdCuentaPadre, int pIdMoneda)
        {
            Entity parametros = new Entity();


            parametros.Set("pCodigo", pCodigo);
            parametros.Set("pNombre", pNombre);
            parametros.Set("pNombreExtranjero", pNombreExtranjero);
            parametros.Set("pEsTitulo", pEsTitulo);
            parametros.Set("pIdTipoCuenta", pIdTipoCuenta);
            parametros.Set("pIdCuentaPadre", pIdCuentaPadre);
            parametros.Set("pIdMoneda", pIdMoneda);
            parametros.Set("pIdCatalogoContable", ObtenerCatalogoContable());
            if (pIdCuentaPadre.Equals(0))
            {
                parametros.Set("pIdCuentaPadre", null);
            }
            if (pIdMoneda.Equals(0))
            {
                parametros.Set("pIdMoneda", null);
            }
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("crear_cuenta", parametros);
            return resultado;
        }


        public static Entity EliminarCuenta(int pIdCuenta)
        {
            Entity parametros = new Entity();
            parametros.Set("pIdCuenta", pIdCuenta);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("eliminar_cuenta", parametros);
            return resultado;
        }

        #endregion 
    }
}
