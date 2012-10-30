using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PruebaPDF
{
    public class CapaDatos
    {
        SqlConnection connection = new SqlConnection("Data Source = VIVI\\ERICKBRESOL; Initial Catalog = PruebaPDF; Trusted_Connection = True;");
        SqlCommand cmd = new SqlCommand();

        public DataSet getDataSet(string storeProcedure, string parametro)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();

                string consultaSQL = storeProcedure;

                if (parametro != null)//si parametro es null, implica que el SP no tiene parametros               
                    consultaSQL += "'" + parametro + "'";

                connection.Open();
                SqlCommand command = new SqlCommand(consultaSQL, connection);
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
                connection.Close();
            }

        }
    }
}
