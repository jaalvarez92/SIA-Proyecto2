using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Entidades;
using AccesoDatos;

namespace Logica
{
    public static class GrupoLogica
    {
        public static Entities ObtenerEmpresasGrupo()
        {
            return GrupoDA.ObtenerEmpresasGrupo();
        }

        public static Boolean CrearEmpresaGrupo(String pNombre, String pEsquema, int pCedula, String pLogotipo, String pMonedaLocal, String pMonedaSistema)
        {
            FileStream fs = new FileStream(pLogotipo, FileMode.Open);
            byte[] archivo= new byte[fs.Length];
            fs.Read(archivo, 0, int.Parse(fs.Length.ToString()));
            fs.Close();
            ManejadorBaseDatos.Instancia.EjecutarScript(pEsquema);
            ManejadorBaseDatos.Instancia.EjecutarInserts(pEsquema, 1);
            Entity result = GrupoDA.CrearEmpresaGrupo(pNombre, pEsquema, pCedula, archivo, pMonedaLocal, pMonedaSistema);
            ManejadorBaseDatos.Instancia.EjecutarInserts(pEsquema,2);
            return (Boolean)result.Get("estado");
        }

        public static Boolean AgregarPeriodoContable(DateTime pFechaInicioC, DateTime pFechaFinalC, DateTime pFechaInicioD,
            DateTime pFechaFinalD, DateTime pFechaInicioV, DateTime pFechaFinalV)
        {
            Boolean resultado= true;
            Entity result_crear_periodo = GrupoDA.AgregarPeriodoContable(pFechaInicioC, pFechaFinalC, pFechaInicioD, pFechaFinalD, pFechaInicioV, pFechaFinalV);
            if ((Boolean)result_crear_periodo.Get("estado")){
                Entities tabla = (Entities)result_crear_periodo.Get("table");
                int id_periodo = int.Parse(tabla[0].Get("IdPeriodoContable").ToString());
                Entity result_asignar_periodo = GrupoDA.AsignarPeriodoContable(id_periodo);
                return ((Boolean) result_asignar_periodo.Get("estado"));
            }
            else
                resultado=false;
            return resultado;
        }

        public static Entity ObtenerInformacionEmpresa()
        {
            return GrupoDA.ObtenerEmpresaGrupo()[0];
        }

    }
}
