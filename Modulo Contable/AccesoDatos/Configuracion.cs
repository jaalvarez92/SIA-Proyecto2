using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace AccesoDatos
{
    static class Configuracion
    {

        #region Constantes
        private const string CADENA_CONEXION = "ConnectionString";
        private const string DA_FILE = "DAFile";
        private const string ID_EMPRESA = "Empresa";
        private const string ESQUEMA = "Esquema";
        #endregion

        #region Atributos
        private static string _stringConexion = string.Empty;
        private static string _daFile = string.Empty;
        private static int _idEmpresa = 0;
        private static string _esquema = string.Empty;
        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene el connection string especificado en el App.Config
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(Configuracion._stringConexion))
                {
                    Configuracion._stringConexion =
                        ConfigurationManager.ConnectionStrings[CADENA_CONEXION].ConnectionString;
                }

                return Configuracion._stringConexion;
            }
        }


        /// <summary>
        /// Obtiene la ruta del archivo de data access especificada en el App.Config
        /// </summary>
        public static string DaFile
        {
            get
            {
                if (string.IsNullOrEmpty(Configuracion._daFile))
                {
                    Configuracion._daFile =
                        ConfigurationManager.AppSettings[DA_FILE];
                }

                return Configuracion._daFile;
            }
        }



        public static string Esquema
        {
            get
            {
                /*/if (string.IsNullOrEmpty(Configuracion._esquema))
                {
                    Configuracion._esquema =
                        ConfigurationManager.AppSettings[ESQUEMA];
                }*/

                return ConfigurationManager.AppSettings[ESQUEMA];
            }
        }

        /// <summary>
        /// Obtiene el nombre de la empresa en la cual se está logueado
        /// </summary>
        public static int IdEmpresa
        {
            get
            {
               Configuracion._idEmpresa =
                     int.Parse(ConfigurationManager.AppSettings[ID_EMPRESA]);   
                return Configuracion._idEmpresa;
            }
        }
    }

        #endregion 
}
