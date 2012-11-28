using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos.ModuloCompras
{
    public static class AccesoDatosCV
    {
        #region metodos

        public static int ingresarEncabezadoDocumento(int IdSocio, int TipoDocumento, DateTime Fecha1, DateTime Fecha2, Decimal TotalAI, Decimal Impuestos, int DocumentoPrevio, Boolean Abierto, Boolean Automatico, int IdEmpresa, int IdMoneda)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            int valorRetorno;
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
                param = execproc.Parameters.Add("@ValorRetorno", SqlDbType.Int);
                param.Direction = ParameterDirection.ReturnValue;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
                valorRetorno = (int)execproc.Parameters["@ValorRetorno"].Value;
            }
            catch (Exception sqle) { valorRetorno = -1; }
            return valorRetorno;
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
            }
            catch (Exception sqle) { return false; }
            return true;
        }

        public static Boolean ingresarLineaDetalleDocumentoFacturaServicios(int IdDocumento, int IdBodega, int Articulo, int Cantidad, Decimal Precio, string Descricpion, Decimal Impuesto)
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            try
            {
                SqlCommand execproc = new SqlCommand("SP_INSERTAR_DETALLE_FACTURA_SERVICIOS", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@IdSocio", SqlDbType.Int);
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

        public static int crearAsientoSinCuentas()
        {
            SqlConnection DataConnection = new SqlConnection(AccesoDatos._Connection);
            int valorRetorno;
            try
            {
                SqlCommand execproc = new SqlCommand("SP_CREAR_ASIENTO_SINCUENTAS", DataConnection);
                SqlParameter param = execproc.Parameters.Add("@ValorRetorno", SqlDbType.Int);
                param.Direction = ParameterDirection.ReturnValue;
                execproc.CommandType = CommandType.StoredProcedure;
                execproc.Connection.Open();
                execproc.ExecuteReader();
                valorRetorno = (int)execproc.Parameters["@ValorRetorno"].Value;
            }
            catch (Exception sqle) { valorRetorno = -1; }
            return valorRetorno;
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

        #endregion

    }
}
