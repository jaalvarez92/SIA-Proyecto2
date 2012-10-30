using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public static class GrupoDA
    {
        #region Métodos
        public static Entities ObtenerEmpresasGrupo()
        {
            Entity parametros = new Entity();
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_empresas_grupo", parametros, "dbo");
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }

        public static Entity CrearEmpresaGrupo(String pNombre, String pEsquema, int pCedula, byte[] pLogotipo, String pMonedaLocal, String pMonedaSistema)
        {
            Entity parametros = new Entity();
            parametros.Set("pNombre", pNombre);
            parametros.Set("pEsquema", pEsquema);
            parametros.Set("pCedulaJuridica", pCedula);
            parametros.Set("pLogotipo", pLogotipo);
            parametros.Set("pMonedaLocal", pMonedaLocal);
            parametros.Set("pMonedaSistema", pMonedaSistema);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("crear_empresa", parametros, pEsquema);
            return resultado;
        }

        public static Entity AgregarPeriodoContable(DateTime pFechaInicioC, DateTime pFechaFinalC, DateTime pFechaInicioD,
            DateTime pFechaFinalD, DateTime pFechaInicioV, DateTime pFechaFinalV)
        {
            Entity parametros = new Entity();
            parametros.Set("pFechaInicioC", pFechaInicioC);
            parametros.Set("pFechaFinC", pFechaFinalC);
            parametros.Set("pFechaInicioD", pFechaInicioD);
            parametros.Set("pFechaFinD", pFechaFinalD);
            parametros.Set("pFechaInicioV", pFechaInicioV);
            parametros.Set("pFechaFinV", pFechaFinalV);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("crear_periodo_contable", parametros);
            return resultado;
        }

        public static Entity AsignarPeriodoContable(int pIdPeriodoContable)
        {
            Entity parametros = new Entity();
            parametros.Set("pIdPeriodoContable", pIdPeriodoContable);
            parametros.Set("pIdEmpresa", Configuracion.IdEmpresa);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("asignar_periodo_contable", parametros);
            return resultado;
        }

        public static Entities ObtenerEmpresaGrupo()
        {
            Entity parametros = new Entity();
            parametros.Set("pIdEmpresa", Configuracion.IdEmpresa);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("obtener_empresa_grupo", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }
        #endregion
    }
}
