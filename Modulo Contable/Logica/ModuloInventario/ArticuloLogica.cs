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

        public List<Bodega> obtenerBodegas()
        {
            var result = _Data.ExecuteQuery("SP_OBTENER_BODEGAS_EMPRESA", new List<SqlParameter>() { 
                new SqlParameter("@pIdEmpresa",_IdEmpresa)
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
                        Precio = Convert.ToDecimal(fila["Precio"].ToString()),
                        Comprometido = Convert.ToInt32(fila["Comprometido"].ToString()),
                        Stock = Convert.ToInt32(fila["Stock"].ToString()),
                        Solicitado = Convert.ToInt32(fila["Solicitado"].ToString()),
                        Disponible = Convert.ToInt32(fila["Disponible"].ToString()),
                        Costo = Convert.ToDecimal(fila["CostoUnitario"].ToString())
                        
                    });
                }

                return lstArticulos;
            }
            else
            {
                return null;
            }
        }

        public bool ingresarBodega(string pNombre, string pCodigo)
        {
            var result = _Data.ExecuteNonQuery("SP_INGRESAR_BODEGA", new List<SqlParameter>()
            {
                new SqlParameter("@pIdEmpresa",_IdEmpresa),
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

        public bool ingresarArticulo(string pCodigo, string pDescripcion, string pUnidadMedida, string pComentario, byte[] pFoto, int pIdBodega, int pCantidadMinima, int pCantidadMaxima, int pIdSocio)
        {
            var result = _Data.ExecuteNonQuery("SP_INGRESAR_ARTICULO", new List<SqlParameter>()
            {
                new SqlParameter("@pIdEmpresa",_IdEmpresa),
                new SqlParameter("@pCodigo",pCodigo),
                new SqlParameter("@pDescripcion",pDescripcion),
                new SqlParameter("@pUnidadMedida",pUnidadMedida),
                new SqlParameter("@pComentarios",pComentario),
                new SqlParameter("@pFoto",pFoto),
                new SqlParameter("@pIdBodega",pIdBodega),
                new SqlParameter("@pCantidadMinima",pCantidadMinima),
                new SqlParameter("@pCantidadMaxima",pCantidadMaxima),
                new SqlParameter("@pIdSocio",pIdSocio)
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

        public bool existeArticuloEnBodega(int pIdBodega, int pIdArticulo)
        {
            var result = _Data.ExecuteQuery("SP_EXISTE_ARTICULO_BODEGA", new List<SqlParameter>()
            {
                new SqlParameter("@pIdBodega",pIdBodega),
                new SqlParameter("@pIdArticulo",pIdArticulo)
            });

            if (result.Tables[0].Rows[0][0].ToString() == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool asociarArticuloABodega(int pIdBodega, int pCantidadMinima, int pCantidadMaxima, int pIdArticulo)
        {
            
            var result = _Data.ExecuteNonQuery("SP_INGRESAR_ARTICULO_BODEGA", new List<SqlParameter>()
            {
                new SqlParameter("@pIdEmpresa",_IdEmpresa),
                new SqlParameter("@pIdBodega",pIdBodega),
                new SqlParameter("@pCantidadMinima",pCantidadMinima),
                new SqlParameter("@pCantidadMaxima",pCantidadMaxima),
                new SqlParameter("@pIdArticulo",pIdArticulo)
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

        public List<Socio> obtenerSocios()
        {
            var result = _Data.ExecuteQuery("SP_OBTENER_SOCIOS_PROVEEDOR", new List<SqlParameter>() { 
            });

            List<Socio> lstSocios = new List<Socio>();
            if (result != null && result.Tables != null && result.Tables[0] != null && result.Tables[0].Rows != null)
            {
                foreach (DataRow fila in result.Tables[0].Rows)
                {
                    lstSocios.Add(new Socio()
                    {
                        IdSocio = Convert.ToInt32(fila["IdSocio"].ToString()),
                        Codigo = fila["CodigoSocio"].ToString(),
                        Nombre = fila["Nombre"].ToString()
                    });
                }

                return lstSocios;
            }
            else
            {
                return null;
            }
        }

        public List<Articulo> obtenerArticulos()
        {
            var result = _Data.ExecuteQuery("SP_OBTENER_ARTICULOS", new List<SqlParameter>() { 
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
                        Foto = (byte[])fila["Foto"],
                        Precio = Convert.ToDecimal(fila["Precio"].ToString()),
                        Comprometido = Convert.ToInt32(fila["Comprometido"].ToString()),
                        Stock = Convert.ToInt32(fila["Stock"].ToString()),
                        Solicitado = Convert.ToInt32(fila["Solicitado"].ToString()),
                        Disponible = Convert.ToInt32(fila["Disponible"].ToString()),
                        Costo = Convert.ToDecimal(fila["CostoUnitario"].ToString()),
                        IdBodega = Convert.ToInt32(fila["Fk_idBodega"].ToString())

                    });
                }

                return lstArticulos;
            }
            else
            {
                return null;
            }
        }


        #region Singleton
        private static volatile ArticuloLogica instancia;
        private static object syncRoot = new Object();

        private ArticuloLogica() {
            _Data = new DataAccess();
            _IdEmpresa = AccesoDatos.Configuracion.IdEmpresa;
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
        private int _IdEmpresa;

    }
}
