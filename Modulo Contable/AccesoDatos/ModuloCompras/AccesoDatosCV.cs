using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using AccesoDatosInventario;

namespace AccesoDatos.ModuloCompras
{
    public static class AccesoDatosCV
    {
        #region metodos

        public static int ingresarEncabezadoDocumento(int IdSocio, int TipoDocumento, DateTime Fecha1, DateTime Fecha2, Decimal TotalAI, Decimal Impuestos, int DocumentoPrevio, Boolean Abierto, Boolean Automatico, int IdEmpresa, int IdMoneda)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            int valorRetorno;
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_INSERTAR_ENCABEZADO", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdSocio", SqlDbType.Int);
                param.Value = IdSocio;
                param = execproc.Parameters.Add("@Fecha1", SqlDbType.Date);
                param.Value = Fecha1;
                param = execproc.Parameters.Add("@Fecha2", SqlDbType.Date);
                param.Value = Fecha2;
                param = execproc.Parameters.Add("@IdTipoDocumento", SqlDbType.Int);
                param.Value = TipoDocumento;
                param = execproc.Parameters.Add("@TotalAntesImp", SqlDbType.Decimal);
                param.Precision = 20;
                param.Scale = 4;
                param.Value = TotalAI;
                param = execproc.Parameters.Add("@Impuestos", SqlDbType.Decimal);
                param.Precision = 20;
                param.Scale = 4;
                param.Value = Impuestos;
                param = execproc.Parameters.Add("@Total", SqlDbType.Decimal);
                param.Precision = 20;
                param.Scale = 4;
                param.Value = TotalAI + Impuestos;
                param = execproc.Parameters.Add("@Abierto", SqlDbType.Bit);
                param.Value = Abierto;
                param = execproc.Parameters.Add("@idDocumentoPrevio", SqlDbType.Int);
                param.Value = DocumentoPrevio;
                param = execproc.Parameters.Add("@Automatico", SqlDbType.Bit);
                param.Value = Automatico;
                param = execproc.Parameters.Add("@IdEmpresa", SqlDbType.Int);
                param.Value = IdEmpresa;
                param = execproc.Parameters.Add("@IdMoneda", SqlDbType.Int);
                param.Value = IdMoneda;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
                execproc.Connection.Close();
                return salvaTandas();
            }
            catch (Exception sqle) { return -1; }
        }

        public static int salvaTandas() 
        {
            AccesoDatosInventario.DataAccess acceso = new DataAccess();
            DataSet data = acceso.ExecuteQuery("SP_SALVA_TANDAS",new List<SqlParameter>());
            return int.Parse(data.Tables[0].Rows[0][0].ToString());

             /*SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            int valorRetorno;
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand(, DataConnection);
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                SqlDataReader LECTOR = execproc.ExecuteReader();
                int idOut = LECTOR.GetInt32(0);
                //valorRetorno = (int)execproc.Parameters["@IdDocumento"].Value;
                return idOut;
            }
            catch (Exception sqle) { return -1; }*/
        }

        public static Boolean ingresarLineaDetalleDocumentoOrdenCompra(int IdDocumento, int IdBodega, int Articulo, int Cantidad, Decimal Precio, string Descricpion, Decimal Impuesto, int IdEmpresa, int IdMoneda, int IdAsiento)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            try
            {
                SqlCommand execproc = new SqlCommand("SP_INSERTAR_DETALLE_ORDEN_COMPRA", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@NumeroDocumento", SqlDbType.Int); //Es el id del documento solo q se quedo el nombre asi x si alguien ya lo uso y no se le caiga luego
                param.Value = IdDocumento;
                param = execproc.Parameters.Add("@IdArticulo", SqlDbType.Int);
                param.Value = Articulo;
                param = execproc.Parameters.Add("@IdBodega", SqlDbType.Int);
                param.Value = IdBodega;
                param = execproc.Parameters.Add("@Cantidad", SqlDbType.Int);
                param.Value = Cantidad;
                param = execproc.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
                param.Value = Descricpion;
                param = execproc.Parameters.Add("@Precio", SqlDbType.Decimal);
                param.Value = Precio;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@Impuestos", SqlDbType.Decimal);
                param.Value = Impuesto;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@IdEmpresa", SqlDbType.Int);
                param.Value = IdEmpresa;
                param = execproc.Parameters.Add("@IdMoneda", SqlDbType.Int);
                param.Value = IdMoneda;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
            }
            catch (Exception sqle) { return false; }
            return true;
        }

        public static Boolean ingresarLineaDetalleDocumentoEntradaMercaderia(int IdDocumento, int IdBodega, int Articulo, int Cantidad, Decimal Precio, string Descricpion, Decimal Impuesto, int IdEmpresa, int IdMoneda, int IdAsiento)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            try
            {
                SqlCommand execproc = new SqlCommand("SP_INSERTAR_DETALLE_ENTRADA_MERCADERIA", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdDocumento", SqlDbType.Int);
                param.Value = IdDocumento;
                param = execproc.Parameters.Add("@IdArticulo", SqlDbType.Int);
                param.Value = Articulo;
                param = execproc.Parameters.Add("@IdBodega", SqlDbType.Int);
                param.Value = IdBodega;
                param = execproc.Parameters.Add("@Cantidad", SqlDbType.Int);
                param.Value = Cantidad;
                param = execproc.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
                param.Value = Descricpion;
                param = execproc.Parameters.Add("@Precio", SqlDbType.Decimal);
                param.Value = Precio;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@Impuestos", SqlDbType.Decimal);
                param.Value = Impuesto;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@IdAsiento", SqlDbType.Decimal);
                param.Value = IdAsiento;
                param = execproc.Parameters.Add("@IdEmpresa", SqlDbType.Decimal);
                param.Value = IdEmpresa;
                param = execproc.Parameters.Add("@IdMoneda", SqlDbType.Int);
                param.Value = IdMoneda;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
            }
            catch (Exception sqle) { return false; }
            return true;
        }

        public static Boolean ingresarLineaDetalleDocumentoFacturaProvedores(int IdDocumento, int IdBodega, int Articulo, int Cantidad, Decimal Precio, string Descricpion, Decimal Impuesto, int IdEmpresa, int IdMoneda, int IdAsiento)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            try
            {
                SqlCommand execproc = new SqlCommand("SP_CREAR_FACTURA_PROVEEDORES", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdDocumento", SqlDbType.Int);
                param.Value = IdDocumento;
                param = execproc.Parameters.Add("@IdArticulo", SqlDbType.Int);
                param.Value = Articulo;
                param = execproc.Parameters.Add("@IdBodega", SqlDbType.Int);
                param.Value = IdBodega;
                param = execproc.Parameters.Add("@Cantidad", SqlDbType.Int);
                param.Value = Cantidad;
                param = execproc.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
                param.Value = Descricpion;
                param = execproc.Parameters.Add("@Precio", SqlDbType.Decimal);
                param.Value = Precio;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@Impuestos", SqlDbType.Decimal);
                param.Value = Impuesto;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@idAsiento", SqlDbType.Int);
                param.Value = IdAsiento;
                param = execproc.Parameters.Add("@idEmpresa", SqlDbType.Int);
                param.Value = IdEmpresa;
                param = execproc.Parameters.Add("@idmonedaArticulo", SqlDbType.Int);
                param.Value = IdMoneda;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
            }
            catch (Exception sqle) { return false; }
            return true;
        }

        public static Boolean ingresarLineaDetalleDocumentoOrdenVenta(int IdDocumento, int IdBodega, int Articulo, int Cantidad, Decimal Precio, string Descricpion, Decimal Impuesto, int IdEmpresa, int IdMoneda, int IdAsiento)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            try
            {
                SqlCommand execproc = new SqlCommand("SP_INSERTAR_DETALLE_ORDEN_VENTA", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@NumeroDocumento", SqlDbType.Int); //Es el id del documento solo q se quedo el nombre asi x si alguien ya lo uso y no se le caiga luego
                param.Value = IdDocumento;
                param = execproc.Parameters.Add("@IdArticulo", SqlDbType.Int);
                param.Value = Articulo;
                param = execproc.Parameters.Add("@IdBodega", SqlDbType.Int);
                param.Value = IdBodega;
                param = execproc.Parameters.Add("@Cantidad", SqlDbType.Int);
                param.Value = Cantidad;
                param = execproc.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
                param.Value = Descricpion;
                param = execproc.Parameters.Add("@Precio", SqlDbType.Decimal);
                param.Value = Precio;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@Impuestos", SqlDbType.Decimal);
                param.Value = Impuesto;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@IdEmpresa", SqlDbType.Int);
                param.Value = IdEmpresa;
                param = execproc.Parameters.Add("@IdMoneda", SqlDbType.Int);
                param.Value = IdMoneda;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
            }
            catch (Exception sqle) { return false; }
            return true;
        }

        public static Boolean ingresarLineaDetalleDocumentoEntregaMercaderia(int IdDocumento, int IdBodega, int Articulo, int Cantidad, Decimal Precio, string Descricpion, Decimal Impuesto, int IdEmpresa, int IdMoneda, int IdAsiento)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            try
            {
                SqlCommand execproc = new SqlCommand("SP_INSERTAR_DETALLE_ENTREGA_MERCADERIA", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdDocumento", SqlDbType.Int);
                param.Value = IdDocumento;
                param = execproc.Parameters.Add("@IdArticulo", SqlDbType.Int);
                param.Value = Articulo;
                param = execproc.Parameters.Add("@IdBodega", SqlDbType.Int);
                param.Value = IdBodega;
                param = execproc.Parameters.Add("@Cantidad", SqlDbType.Int);
                param.Value = Cantidad;
                param = execproc.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
                param.Value = Descricpion;
                param = execproc.Parameters.Add("@Precio", SqlDbType.Decimal);
                param.Value = Precio;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@Impuestos", SqlDbType.Decimal);
                param.Value = Impuesto;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@IdAsiento", SqlDbType.Decimal);
                param.Value = IdAsiento;
                param = execproc.Parameters.Add("@IdEmpresa", SqlDbType.Decimal);
                param.Value = IdEmpresa;
                param = execproc.Parameters.Add("@IdMoneda", SqlDbType.Int);
                param.Value = IdMoneda;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
            }
            catch (Exception sqle) { return false; }
            return true;
        }

        public static Boolean ingresarLineaDetalleDocumentoFacturaCliente(int IdDocumento, int IdBodega, int Articulo, int Cantidad, Decimal Precio, string Descricpion, Decimal Impuesto, int IdEmpresa, int IdMoneda, int IdAsiento)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            try
            {
                SqlCommand execproc = new SqlCommand("SP_CREAR_FACTURA_CLIENTES", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdDocumento", SqlDbType.Int);
                param.Value = IdDocumento;
                param = execproc.Parameters.Add("@IdArticulo", SqlDbType.Int);
                param.Value = Articulo;
                param = execproc.Parameters.Add("@IdBodega", SqlDbType.Int);
                param.Value = IdBodega;
                param = execproc.Parameters.Add("@Cantidad", SqlDbType.Int);
                param.Value = Cantidad;
                param = execproc.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
                param.Value = Descricpion;
                param = execproc.Parameters.Add("@Precio", SqlDbType.Decimal);
                param.Value = Precio;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@Impuestos", SqlDbType.Decimal);
                param.Value = Impuesto;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@idAsiento", SqlDbType.Int);
                param.Value = IdAsiento;
                param = execproc.Parameters.Add("@idEmpresa", SqlDbType.Int);
                param.Value = IdEmpresa;
                param = execproc.Parameters.Add("@idMoneda", SqlDbType.Int);
                param.Value = IdMoneda;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
            }
            catch (Exception sqle) { return false; }
            return true;
        }

        public static Boolean ingresarLineaDetalleDocumentoFacturaServicios(int IdDocumento,String Descricpion, int IdCuenta, Decimal Total, int IdAsiento, int IdEmpresa)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            try
            {
                SqlCommand execproc = new SqlCommand("SP_INSERTAR_DETALLE_FACTURA_SERVICIOS", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdDocumento", SqlDbType.Int);
                param.Value = IdDocumento;
                param = execproc.Parameters.Add("@Descripcion", SqlDbType.VarChar,100);
                param.Value = Descricpion;
                param = execproc.Parameters.Add("@IdCuenta", SqlDbType.Int);
                param.Value = IdCuenta;
                param = execproc.Parameters.Add("@Monto", SqlDbType.Decimal);
                param.Value = Total;
                param.Precision = 20;
                param.Scale = 4;
                param = execproc.Parameters.Add("@IdAsiento", SqlDbType.Int);
                param.Value = IdAsiento;
                param = execproc.Parameters.Add("@IdEmpresa", SqlDbType.Int);
                param.Value = IdEmpresa;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
            }
            catch (Exception sqle) { return false; }
            return true;
        }

        public static Boolean ingresarLineaDetalleDocumentoNotaCredito(int IdDocumento, int IdBodega, int Articulo, int Cantidad, Decimal Precio, string Descricpion, Decimal Impuesto)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            try
            {
                SqlCommand execproc = new SqlCommand("SP_INSERTAR_DETALLE_NOTA_CREDITO", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdSocio", SqlDbType.Int);
            }
            catch (Exception sqle) { return false; }
            return true;
        }

        public static int crearAsientoSinCuentas(int IdTipoAsiento, DateTime FechaDoc, int NumDoc)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            int valorRetorno;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_CREAR_ASIENTO_SINCUENTAS", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@pIdTipoAsiento", SqlDbType.Int);
                param.Value = IdTipoAsiento;
                param = execproc.Parameters.Add("@pFechaContabilizado", SqlDbType.DateTime);
                param.Value = DateTime.Now;
                param = execproc.Parameters.Add("@pFechaDocumento", SqlDbType.DateTime);
                param.Value = FechaDoc;
                param = execproc.Parameters.Add("@pReferencia1", SqlDbType.VarChar, 100);
                param.Value = NumDoc;
                param = execproc.Parameters.Add("@pReferencia2", SqlDbType.VarChar, 100);
                param.Value = "";
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
                execproc.Connection.Close();
                return salvaTandas2();
            }
            catch (Exception sqle) { return -1; }
        }

        private static int salvaTandas2()
        {
            AccesoDatosInventario.DataAccess acceso = new DataAccess();
            DataSet data = acceso.ExecuteQuery("SP_SALVADA", new List<SqlParameter>());
            return int.Parse(data.Tables[0].Rows[0][0].ToString());
        }



        public static SqlDataReader obtenerNumeroDocumento(int TipoDoc)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_OBTENER_TIPO_DOCUMENTO", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@idTipo", SqlDbType.Int);
                param.Value = TipoDoc;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                lectorSQL = execproc.ExecuteReader();
            }
            catch (Exception sqle) { lectorSQL = null; }
            return lectorSQL;
        }

        public static SqlDataReader obtenerProveedores()
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_OBTENER_PROVEEDORES", DataConnection);
                /*SqlParameter param = execproc.Parameters.Add("@pIdEmpresa", SqlDbType.Int);
                param.Value = ;//id de la empresa*/
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                lectorSQL = execproc.ExecuteReader();
            }

            catch (Exception sqle) { lectorSQL = null; }
            return lectorSQL;
        }


        public static SqlDataReader obtenerClientes()
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_OBTENER_CLIENTES", DataConnection);/*
                SqlParameter param = execproc.Parameters.Add("@pIdEmpresa", SqlDbType.Int);
                param.Value = ;//id de la empresa*/
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                lectorSQL = execproc.ExecuteReader();
            }

            catch (Exception sqle) { lectorSQL = null; }
            return lectorSQL;
        }

        public static SqlDataReader obtenerArticulos(int pSocio)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_OBTENER_ARTICULOS_SOCIOS", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@idSocio", SqlDbType.Int);
                param.Value = pSocio;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                lectorSQL = execproc.ExecuteReader();
            }

            catch (Exception sqle) { lectorSQL = null; }
            return lectorSQL;
        }

        public static SqlDataReader obtenerBodegas(int pArticulo)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_OBTENER_BODEGAS", DataConnection);
                SqlParameter param = execproc.Parameters.Add("idArticulo", SqlDbType.Int);
                param.Value = pArticulo;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                lectorSQL = execproc.ExecuteReader();
            }

            catch (Exception sqle) { lectorSQL = null; }
            return lectorSQL;
        }


        public static SqlDataReader obtenerMoneda(int pSocio)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_OBTENER_MONEDAS_SOCIO", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdSocio", SqlDbType.Int);
                param.Value = pSocio;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                lectorSQL = execproc.ExecuteReader();
            }

            catch (Exception sqle) { lectorSQL = null; }
            return lectorSQL;
        }

        public static SqlDataReader obtenerDocumentosPrevios(int pTipoDocumentoPrevio)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_OBTENER_NUMERO_DOCUMENTOS_PREVIOS", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@pIdTipoDocumentoPrevio", SqlDbType.Int);
                param.Value = pTipoDocumentoPrevio;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                lectorSQL = execproc.ExecuteReader();
            }

            catch (Exception sqle) { lectorSQL = null; }
            return lectorSQL;
        }


        public static SqlDataReader obtenerDocumentosPrevios(int IdDocumentoPrevio, int IdTipoDocumentoPrevio, int IdSocio)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_OBTENER_INFO_DOCUMENTO_PREVIO", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@NumeroDocumentoPrevio", SqlDbType.Int);
                param.Value = IdDocumentoPrevio;
                param = execproc.Parameters.Add("@IdTipoDocumento", SqlDbType.Int);
                param.Value = IdTipoDocumentoPrevio;
                param = execproc.Parameters.Add("@IdSocio", SqlDbType.Int);
                param.Value = IdSocio;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                lectorSQL = execproc.ExecuteReader();
            }

            catch (Exception sqle) { lectorSQL = null; }
            return lectorSQL;
        }

        public static SqlDataReader obtenerCuentas()
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            SqlDataReader lectorSQL;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_OBTENER_CUENTAS_CV", DataConnection);
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                lectorSQL = execproc.ExecuteReader();
            }

            catch (Exception sqle) { lectorSQL = null; }
            return lectorSQL;
        }

        #endregion


        public static DataRow verificarCantidadArticulo(int Bodega, int Articulo, int IdEmpresa, int IdMoneda, int IdSocio)
        {

            AccesoDatosInventario.DataAccess acceso = new DataAccess();
            DataSet data = acceso.ExecuteQuery("SP_SALVADA", new List<SqlParameter>() {
                new SqlParameter("@IdBodega",Bodega),
                new SqlParameter("@IdArticulo",Articulo),
                new SqlParameter("@IdEmpresa",IdEmpresa),
                new SqlParameter("@IdMoneda",IdMoneda),
                new SqlParameter("@IdSocio",IdSocio)

            });
            return data.Tables[data.Tables.Count -1].Rows[0];

              /*  SqlCommand execproc = new SqlCommand("SP_VERIFICAR_CANTIDAD_ARTICULO", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdBodega", SqlDbType.Int);
                param.Value = Bodega;
                param = execproc.Parameters.Add("@IdArticulo", SqlDbType.Int);
                param.Value = Articulo;
                param = execproc.Parameters.Add("@IdEmpresa", SqlDbType.Int);
                param.Value = IdEmpresa;
                param = execproc.Parameters.Add("@IdMoneda", SqlDbType.Int);
                param.Value = IdMoneda;
                param = execproc.Parameters.Add("@IdSocio", SqlDbType.Int);
                param.Value = IdSocio;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                lectorSQL = execproc.ExecuteReader();*/
        }

        public static Boolean convertirOrdenAFactura(int IdDocumento)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            try
            {
                SqlCommand execproc = new SqlCommand("SP_CONVERTIR_ORDEN_FACTURA", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdDocumento", SqlDbType.Int);
                param.Value = IdDocumento;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
            }

            catch (Exception sqle) { return false; }
            return true;
        }
    }
}
