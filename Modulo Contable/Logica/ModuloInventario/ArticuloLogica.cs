using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades.Inventario;
using AccesoDatosInventario;
using System.Data.SqlClient;
using System.Data;

namespace Logica.ModuloInventario
{
    public class ArticuloLogica
    {

        public List<Bodega> obtenerBodegas(int pIdEmpresa)
        {
            var result = _Data.ExecuteQuery("SP_OBTENER_BODEGAS", new List<SqlParameter>() { 
                new SqlParameter("@pIdEmpresa",pIdEmpresa)
            });

            List<Bodega> lstBodegas = new List<Bodega>();
            if (result != null && result.Tables != null && result.Tables[0] != null && result.Tables[0].Rows != null)
            {
                foreach (DataRow fila in result.Tables[0].Rows)
                {
                    lstBodegas.Add(new Bodega()
                    {
                        IdBodega = Convert.ToInt32(fila["IdBodega"].ToString()),
                        Codigo = fila["Codigo"].ToString(),
                        Nombre = fila["Nombre"].ToString()
                    });
                }

                return lstBodegas;
            }
            else
            {
                return null;
            }       
        }


        public List<Articulo> obtenerArticulosBodega(string pNombreBodega)
        {
            var result = _Data.ExecuteQuery("SP_OBTENER_ARTICULOS_BODEGA_NOMBRE", new List<SqlParameter>() { 
                new SqlParameter("@pNombreBodega",pNombreBodega)
            });

            List<Articulo> lstArticulos = new List<Articulo>();
            if (result != null && result.Tables != null && result.Tables[0] != null && result.Tables[0].Rows != null)
            {
                foreach (DataRow fila in result.Tables[0].Rows)
                {
                    lstArticulos.Add(new Articulo()
                    {
                        IdArticulo = Convert.ToInt32(fila["IdArticulo"].ToString()),
                        Codigo = fila["Codigo"].ToString(),
                        Descripcion = fila["Descripcion"].ToString(),
                        UnidadMedida = fila["UnidadMedida"].ToString(),
                        Comentario = fila["Comentarios"].ToString(),
                        Foto = (byte[]) fila["Foto"],
                        Precio = Convert.ToDecimal(fila["Precio"].ToString())
                        
                    });
                }

                return lstArticulos;
            }
            else
            {
                return null;
            }
        }

        public bool ingresarBodega(int pIdEmpresa, string pNombre, string pCodigo)
        {
            var result = _Data.ExecuteNonQuery("SP_INGRESAR_BODEGA", new List<SqlParameter>()
            {
                new SqlParameter("@pIdEmpresa",pIdEmpresa),
                new SqlParameter("@pNombre",pNombre),
                new SqlParameter("@pCodigo",pCodigo)
            });
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ingresarArticulo(int pIdEmpresa, string pCodigo, string pDescripcion, string pUnidadMedida, string pComentario, byte[] pFoto, int pIdBodega)
        {
            var result = _Data.ExecuteNonQuery("SP_INGRESAR_ARTICULO", new List<SqlParameter>()
            {
                new SqlParameter("@pIdEmpresa",pIdEmpresa),
                new SqlParameter("@pCodigo",pCodigo),
                new SqlParameter("@pDescripcion",pDescripcion),
                new SqlParameter("@pUnidadMedida",pUnidadMedida),
                new SqlParameter("@pComentarios",pComentario),
                new SqlParameter("@pFoto",pFoto),
                new SqlParameter("@pIdBodega",pIdBodega)
            });
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #region Singleton
        private static volatile ArticuloLogica instancia;
        private static object syncRoot = new Object();

        private ArticuloLogica() {
            _Data = new DataAccess();
        }

        public static ArticuloLogica Instancia
        {
            get 
            {
                if (instancia == null) 
                {
                lock (syncRoot) 
                {
                    if (instancia == null)
                        instancia = new ArticuloLogica();
                }
                }

                return instancia;
            }
        }
        #endregion

        private DataAccess _Data;

    }
}
