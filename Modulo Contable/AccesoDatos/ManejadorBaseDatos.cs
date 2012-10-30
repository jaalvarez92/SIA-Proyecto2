using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Entidades;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.SqlServer.Server;

namespace AccesoDatos
{
    public class ManejadorBaseDatos
    {
        /// <summary>
        /// Contiene todos los entity para ejecutar sp
        /// </summary>
        private Entities _StoredProcedures = null;
        /// <summary>
        /// Contiene el connection string
        /// </summary>
        private String _ConnectionString = null;

        private static ManejadorBaseDatos _Instancia;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        private ManejadorBaseDatos() {
            this._StoredProcedures = new XMLLoader().loadXML(Configuracion.DaFile);
            this._ConnectionString = Configuracion.ConnectionString;
        }


        public static ManejadorBaseDatos Instancia
        {
            get
            {
                if (_Instancia == null)
                {
                    _Instancia = new ManejadorBaseDatos();
                }
                return _Instancia;
            }
        }


        /// <summary>
        /// Ejecuta un stored procedure
        /// </summary>
        /// <param name="pNombre">Nombre del sp</param>
        /// <param name="pParametros">Parametros del sp</param>
        /// <returns>Entity con el resultado de la ejecución del sp</returns>
        public Entity EjecutarSP(String pNombre, Entity pParametros){

            Entity sp = _StoredProcedures.Get("Nombre", pNombre);
            Entities parametros = (Entities)sp.Get("Parametros");

            foreach (Entity parametro in parametros)
            {
                if (parametro.Get("Tipo").Equals("input"))
                {
                    parametro.Set("Valor", pParametros.Get((string)parametro.Get("Nombre")));
                }
            }

            sp.Set("Parametros", parametros);
            return EjecutarSPAux(sp);
        }



        /// <summary>
        /// Ejecuta un stored procedure
        /// </summary>
        /// <param name="pNombre">Nombre del sp</param>
        /// <param name="pParametros">Parametros del sp</param>
        /// <param name="pEsquema">Esquema</param>
        /// <returns>Entity con el resultado de la ejecución del sp</returns>
        public Entity EjecutarSP(String pNombre, Entity pParametros, String pEsquema)
        {

            Entity sp = _StoredProcedures.Get("Nombre", pNombre);
            Entities parametros = (Entities)sp.Get("Parametros");

            foreach (Entity parametro in parametros)
            {
                if (parametro.Get("Tipo").Equals("input"))
                {
                    parametro.Set("Valor", pParametros.Get((string)parametro.Get("Nombre")));
                }
            }

            sp.Set("Parametros", parametros);
            return EjecutarSPAux(sp, pEsquema);
        }

        /// <summary>
        /// Ejecuta un sp apartir de un objeto entity
        /// </summary>
        /// <param name="pSP">entity que contiene informacion del sp</param>
        /// <returns>entity con el resultado de la ejecución del sp</returns>
        public Entity EjecutarSPAux(Entity pSP)
        {
            Entity resultado = new Entity();
            SqlConnection conexion;
            try
            {
                conexion = new SqlConnection(_ConnectionString);
                conexion.Open();
                String nombreSP = Configuracion.Esquema+"."+(String)pSP.Get("SP");
                Entities parametros = (Entities)pSP.Get("Parametros");
                Boolean retornaDatos = (Boolean)pSP.Get("Retorna");

                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand sp = new SqlCommand();
                sp.Connection = conexion;
                sp.CommandType = System.Data.CommandType.StoredProcedure;
                sp.CommandText = nombreSP;

                foreach (Entity parametro in parametros)
                {
                    SqlParameter sqlParametro = new SqlParameter((String)parametro.Get("Nombre"), parametro.Get("Valor"));
                    if (sqlParametro.Value==null)
                    {
                        sqlParametro.Value = DBNull.Value;
                    }
                    if (((String)parametro.Get("Tipo")).Equals("Input"))
                    {
                        sqlParametro.Direction = System.Data.ParameterDirection.Input;
                    }
                    else if (((String)parametro.Get("Tipo")).Equals("Output"))
                    {
                        sqlParametro.Direction = System.Data.ParameterDirection.Output;
                    }
                    sp.Parameters.Add(sqlParametro);
                }

                if (retornaDatos)
                {
                    adapter.SelectCommand = sp;
                    
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    foreach (DataTable table in dataset.Tables)
                    {
                        Entities result = new Entities();
                        foreach (DataRow row in table.Rows)
                        {
                            Entity fila = new Entity();
                            for (int i = 0; i < (row.ItemArray.Length); i++)
                            {
                                fila.Set(row.Table.Columns[i].ColumnName, row.ItemArray[i]);
                            }
                            result.Add(fila);
                        }
                        resultado.Set(table.TableName, result);
                    }

                }
                else
                {
                    sp.ExecuteNonQuery();
                }
                resultado.Set("Estado", true);
                resultado.Set("Error", "");
                conexion.Close();
            }
            catch (SqlException e)
            {
                resultado.Set("Estado", false);
                resultado.Set("Error", e.Message);
            }
            
            return resultado;
        }



        /// <summary>
        /// Ejecuta un sp apartir de un objeto entity
        /// </summary>
        /// <param name="pSP">entity que contiene informacion del sp</param>
        /// <returns>entity con el resultado de la ejecución del sp</returns>
        public Entity EjecutarSPAux(Entity pSP, String pEsquema)
        {
            Entity resultado = new Entity();
            SqlConnection conexion;
            try
            {
                conexion = new SqlConnection(_ConnectionString);
                conexion.Open();
                String nombreSP = pEsquema+"."+(String)pSP.Get("SP");
                Entities parametros = (Entities)pSP.Get("Parametros");
                Boolean retornaDatos = (Boolean)pSP.Get("Retorna");

                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand sp = new SqlCommand();
                sp.Connection = conexion;
                sp.CommandType = System.Data.CommandType.StoredProcedure;
                sp.CommandText = nombreSP;

                foreach (Entity parametro in parametros)
                {
                    SqlParameter sqlParametro = new SqlParameter((String)parametro.Get("Nombre"), parametro.Get("Valor"));
                    if (sqlParametro.Value == null)
                    {
                        sqlParametro.Value = DBNull.Value;
                    }
                    if (((String)parametro.Get("Tipo")).Equals("Input"))
                    {
                        sqlParametro.Direction = System.Data.ParameterDirection.Input;
                    }
                    else if (((String)parametro.Get("Tipo")).Equals("Output"))
                    {
                        sqlParametro.Direction = System.Data.ParameterDirection.Output;
                    }
                    sp.Parameters.Add(sqlParametro);
                }

                if (retornaDatos)
                {
                    adapter.SelectCommand = sp;

                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    foreach (DataTable table in dataset.Tables)
                    {
                        Entities result = new Entities();
                        foreach (DataRow row in table.Rows)
                        {
                            Entity fila = new Entity();
                            for (int i = 0; i < (row.ItemArray.Length); i++)
                            {
                                fila.Set(row.Table.Columns[i].ColumnName, row.ItemArray[i]);
                            }
                            result.Add(fila);
                        }
                        resultado.Set(table.TableName, result);
                    }

                }
                else
                {
                    sp.ExecuteNonQuery();
                }
                resultado.Set("Estado", true);
                resultado.Set("Error", "");
                conexion.Close();
            }
            catch (SqlException e)
            {
                resultado.Set("Estado", false);
                resultado.Set("Error", e.Message);
            }

            return resultado;
        }

        /// <summary>
        /// Replaces text in a file.
        /// </summary>
        /// <param name="filePath">Path of the text file.</param>
        /// <param name="searchText">Text to search for.</param>
        /// <param name="replaceText">Text to replace the search text.</param>
        static public void ReplaceInFile(string filePath, string filePathDestiny, string searchText, string replaceText)
        {
            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, searchText, replaceText);

            StreamWriter writer = new StreamWriter(filePathDestiny,false);
            writer.Write(content);
            writer.Close();
        }


        public void EjecutarScript(String pEsquema)
        {
            ReplaceInFile("Script_NuevaEmpresa.sql", "Script_NuevaEmpresa2.sql", "jcewc", pEsquema);
            
            FileInfo file = new FileInfo(@"Script_NuevaEmpresa2.sql");
            string script = file.OpenText().ReadToEnd();

            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);
            SqlConnection Connection = new SqlConnection(Configuracion.ConnectionString);

            Connection.Open();
            foreach (string commandString in commandStrings)
            {
                if (commandString.Trim() != "")
                {
                    new SqlCommand(commandString, Connection).ExecuteNonQuery();
                }
            }
            Connection.Close();
        }

        public void EjecutarInserts(String pEsquema,int pScript)
        {
            FileInfo file;
            if (pScript ==1){
                ReplaceInFile("Inserts.sql", "Inserts2.sql", "jcewc", pEsquema);

                file = new FileInfo(@"Inserts2.sql");
            }
            else
            {
                ReplaceInFile("Inserts1.sql", "Inserts12.sql", "jcewc", pEsquema);

                file = new FileInfo(@"Inserts12.sql");
            }
            string script = file.OpenText().ReadToEnd();

            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                     RegexOptions.Multiline | RegexOptions.IgnoreCase);
            SqlConnection Connection = new SqlConnection(Configuracion.ConnectionString);

            Connection.Open();
            foreach (string commandString in commandStrings)
            {
                if (commandString.Trim() != "")
                {
                    new SqlCommand(commandString, Connection).ExecuteNonQuery();
                }
            }
            Connection.Close();
        }

        public DataSet obtenerDataSet(string storeProcedure)
        {
            SqlConnection Connection = new SqlConnection(Configuracion.ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string consultaSQL = storeProcedure;

            try
            {                                                         
                    consultaSQL += " '" + Configuracion.IdEmpresa + "'";
                Connection.Open();
                SqlCommand command = new SqlCommand(consultaSQL, Connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                return ds;

            }
            catch
            {
                return null;
            }
            finally
            {
                Connection.Close();
            }

        }
    }
}
