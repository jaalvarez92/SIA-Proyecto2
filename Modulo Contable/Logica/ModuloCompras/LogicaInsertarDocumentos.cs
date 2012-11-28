using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos.ModuloCompras;
using Entidades;
using Entidades.Documentos;
using System.Data.SqlClient;

namespace Logica.ModuloCompras
{
    public static class LogicaInsertarDocumentos
    {

        #region atributos
        public static int IdAsientoActual;
        private static List<String> _ListaCedulas;
        private static Entities _ListaSocios;
        private static List<String> _ListaSociosNombres;
        private static Entities _ListaArticulos;
        private static List<String> _ListaArticulosNombres;
        private static Entities _ListaBodegas;
        private static List<String> _ListaBodegasNombres;
        private static Entities _ListaDocumentosPrevios;
        private static List<int> _ListaDocumentosPreviosNumeros;
        private static Entity _Moneda;
        private static Entities _ListaDocumentoPrevio;
        private static List<String> _ListaDocumentoPrevioString;
        public static int banderaError;
        public static Entity datosActuales;
        #endregion

        #region propiedades
        public static int OrdenCompra
        {
            get { return 1; }
        }

        public static int EntradaMercaderia
        {
            get { return 2; }
        }

        public static int FacturaProvedores
        {
            get { return 3; }
        }

        public static int OrdenVenta
        {
            get { return 4; }
        }

        public static int EntregaMercaderia
        {
            get { return 5; }
        }

        public static int FacturaCliente
        {
            get { return 6; }
        }

        public static int FacturaServicios
        {
            get { return 7; }
        }

        public static int NotaCredito
        {
            get { return 8; }
        }

        public static List<String> ListaCedulas
        {
            get { return _ListaCedulas; }
            set { _ListaCedulas = value; }
        }

        public static Entities ListaSocios
        {
            get { return _ListaSocios; }
            set { _ListaSocios = value; }
        }

        public static List<String> ListaSociosNombres
        {
            get { return _ListaSociosNombres; }
            set { _ListaSociosNombres = value; }
        }

        public static Entities ListaArticulos
        {
            get { return _ListaArticulos; }
            set { _ListaArticulos = value; }
        }

        public static List<String> ListaArticulosNombres
        {
            get { return _ListaArticulosNombres; }
            set { _ListaArticulosNombres = value; }
        }

        public static Entities ListaBodegas
        {
            get { return _ListaBodegas; }
            set { _ListaBodegas = value; }
        }

        public static List<String> ListaBodegasNombres
        {
            get { return _ListaBodegasNombres; }
            set { _ListaBodegasNombres = value; }
        }


        public static Entities ListaDocumentosPrevios
        {
            get { return _ListaDocumentosPrevios; }
            set { _ListaDocumentosPrevios = value; }
        }

        public static List<int> ListaDocumentosPreviosNumeros
        {
            get { return _ListaDocumentosPreviosNumeros; }
            set { _ListaDocumentosPreviosNumeros = value; }
        }
        public static Entity Moneda
        {
            get { return LogicaInsertarDocumentos._Moneda; }
            set { LogicaInsertarDocumentos._Moneda = value; }
        }


        public static Entities ListaDocumentoPrevio
        {
            get { return _ListaDocumentoPrevio; }
            set { _ListaDocumentoPrevio = value; }
        }

        public static List<String> ListaDocumentoPrevioString
        {
            get { return _ListaDocumentoPrevioString; }
            set { _ListaDocumentoPrevioString = value; }
        }

        public static int TipoAsientoEntradaMercaderia
        {
            get { return 4; }
        }

        public static int TipoAsientoFacturaProvedores
        {
            get { return 5; }
        }

        public static int TipoAsientoEntregaMercaderia
        {
            get { return 6; }
        }

        public static int TipoAsientoFacturaCliente
        {
            get { return 8; }
        }

        public static int TipoAsientoFacturaServicios
        {
            get { return 9; }
        }

        public static int TipoAsientoNotaCredito
        {
            get { return 10; }
        }


        #endregion

        #region metodos

        public static int insertarDocumento(int Socio, int TipoDocumento, DateTime Fecha1, DateTime Fecha2, Decimal TotalAI, Decimal Impuestos, int DocumentoPrevio, Boolean Automatico, int IdEmpresa, int IdMoneda)
        {
             datosActuales = new Entity();
            int IdSocio = (int)ListaSocios.ElementAt(Socio).Get("id");
            int IdDocumentoPrevio = (int)(ListaDocumentosPrevios.Get("numero", DocumentoPrevio).Get("id"));
            datosActuales.Set("socio", Socio);
            datosActuales.Set("tipodocumento", TipoDocumento);
            datosActuales.Set("fecha1", Fecha1);
            datosActuales.Set("fecha2", Fecha2);
            datosActuales.Set("totalai", TotalAI);
            datosActuales.Set("impuestos", Impuestos);
            datosActuales.Set("automatico", Automatico);
            datosActuales.Set("idempresa", IdEmpresa);
            datosActuales.Set("idmoneda", IdMoneda);
            Boolean abierto, asiento = false;
            int retorno;
            if (DocumentoPrevio == 0)
            {
                IdDocumentoPrevio = 0;
            }
            else
                IdDocumentoPrevio = (int)(ListaDocumentosPrevios.Get("numero", DocumentoPrevio).Get("id"));
            if (TipoDocumento == FacturaProvedores || TipoDocumento == FacturaCliente || TipoDocumento == NotaCredito || TipoDocumento == FacturaServicios)
            {
                abierto = false;
                asiento = true;
            }
            else
                abierto = true;

            if (TipoDocumento == EntradaMercaderia || TipoDocumento == EntregaMercaderia)
                asiento = true;

            retorno = AccesoDatosCV.ingresarEncabezadoDocumento(IdSocio, TipoDocumento, Fecha1, Fecha2, TotalAI, Impuestos, IdDocumentoPrevio, abierto, Automatico, IdEmpresa, IdMoneda);


            if (asiento)
            {
                int tipoAsiento = 0;

                if (TipoDocumento == EntradaMercaderia)
                    tipoAsiento = TipoAsientoEntradaMercaderia;

                if (TipoDocumento == EntregaMercaderia)
                    tipoAsiento = TipoAsientoEntregaMercaderia;

                if (TipoDocumento == FacturaCliente)
                    tipoAsiento = TipoAsientoFacturaCliente;

                if (TipoDocumento == FacturaProvedores)
                    tipoAsiento = TipoAsientoFacturaProvedores;

                if (TipoDocumento == NotaCredito)
                    tipoAsiento = TipoAsientoNotaCredito;

                if (TipoDocumento == FacturaServicios)
                    tipoAsiento = TipoAsientoFacturaServicios;

                IdAsientoActual = AccesoDatosCV.crearAsientoSinCuentas(tipoAsiento, Fecha1, retorno); //cambiar tipo documento
            }

            return retorno; //ID del documento
        }
                

        public static Boolean insertarLineaDetalleDocumento(int IdDocumento, String Bodega, String Articulo, int Cantidad, Decimal Precio, string Descricpion, Decimal Impuesto, int TipoDocumento, int IdEmpresa, int IdMoneda)
        {
            //revisar maximos y minimos
            int IdBodega = (int)(ListaBodegas.Get("nombre", Bodega).Get("id"));
            int IdArticulo = (int)(ListaArticulos.Get("nombre", Articulo).Get("id"));
            Boolean resultado = false;

            if (TipoDocumento == OrdenCompra)
            {
                return AccesoDatosCV.ingresarLineaDetalleDocumentoOrdenCompra(IdDocumento, IdBodega, IdArticulo, Cantidad, Precio, Descricpion, Impuesto, IdEmpresa, IdMoneda, IdAsientoActual);
            }

            if (TipoDocumento == EntradaMercaderia)
            {
                return AccesoDatosCV.ingresarLineaDetalleDocumentoEntradaMercaderia(IdDocumento, IdBodega, IdArticulo, Cantidad, Precio, Descricpion, Impuesto, IdEmpresa, IdMoneda, IdAsientoActual);
            }

            if (TipoDocumento == FacturaProvedores)
            {
                return AccesoDatosCV.ingresarLineaDetalleDocumentoFacturaProvedores(IdDocumento, IdBodega, IdArticulo, Cantidad, Precio, Descricpion, Impuesto, IdEmpresa, IdMoneda, IdAsientoActual);
            }

            if (TipoDocumento == OrdenVenta)
            {
                return AccesoDatosCV.ingresarLineaDetalleDocumentoOrdenVenta(IdDocumento, IdBodega, IdArticulo, Cantidad, Precio, Descricpion, Impuesto, IdEmpresa, IdMoneda, IdAsientoActual);

            }

            if (TipoDocumento == EntregaMercaderia)
            {
                resultado = AccesoDatosCV.ingresarLineaDetalleDocumentoEntregaMercaderia(IdDocumento, IdBodega, IdArticulo, Cantidad, Precio, Descricpion, Impuesto, IdEmpresa, IdMoneda, IdAsientoActual);
                verificarCantidadStock(IdBodega, IdArticulo, IdEmpresa);
                return resultado;
            }

            if (TipoDocumento == FacturaCliente)
            {
                resultado = AccesoDatosCV.ingresarLineaDetalleDocumentoFacturaCliente(IdDocumento, IdBodega, IdArticulo, Cantidad, Precio, Descricpion, Impuesto, IdEmpresa, IdMoneda, IdAsientoActual);
                verificarCantidadStock(IdBodega, IdArticulo, IdEmpresa);
                return resultado;
            }

            if (TipoDocumento == FacturaServicios)
            {
                return AccesoDatosCV.ingresarLineaDetalleDocumentoFacturaServicios(IdDocumento, IdBodega, IdArticulo, Cantidad, Precio, Descricpion, Impuesto);
            }

            if (TipoDocumento == NotaCredito)
            {
                return AccesoDatosCV.ingresarLineaDetalleDocumentoNotaCredito(IdDocumento, IdBodega, IdArticulo, Cantidad, Precio, Descricpion, Impuesto);
            }

            return false;
        }


        private static void verificarCantidadStock(int Bodega, int Articulo, int IdEmpresa)
        {
            SqlDataReader lectorSQL;
            Documento DocumentoOrden = new Documento();
            DocumentoDetalle DetalleDocumento = new DocumentoDetalle();
                try
                {
                    lectorSQL = AccesoDatosCV.verificarCantidadArticulo(Bodega, Articulo, IdEmpresa, (int)datosActuales.Get("idmoneda"), (int)datosActuales.Get("socio"));
                    if (lectorSQL.HasRows)
                    {
                        banderaError = 0;
                        while (lectorSQL.Read())
                        {
                            DocumentoOrden.TipoDocumento = OrdenCompra;
                            DocumentoOrden.Fecha1 = lectorSQL.GetDateTime(1);
                            DocumentoOrden.TotalAI = lectorSQL.GetDecimal(4);
                            DetalleDocumento.Cantidad = lectorSQL.GetInt32(3);
                            DetalleDocumento.Descripcion = lectorSQL.GetString(2);
                            DetalleDocumento.Precio = lectorSQL.GetDecimal(4);
                                /*NumeroDocumento, Fecha1, Articulo.Descripcion, DetalleDocumentoPorArticuloBodega.Cantidad,
			   DetalleDocumentoPorArticuloBodega.Precio, Documento.Total*/
                        }
                    }
                    else
                        banderaError = 1;
                }
                catch (Exception ex) { return; }
        }


        public static int obtenerNumeroDocumento(int TipoDoc)
        {
            int _NumeroDocumento = 0;
            SqlDataReader lectorSQL;
            try
            {
                lectorSQL = AccesoDatosCV.obtenerNumeroDocumento(TipoDoc);
                if (lectorSQL.Read())
                {
                    banderaError = 0;
                    _NumeroDocumento = lectorSQL.GetInt32(0);
                    lectorSQL.Close();
                }
                else
                    banderaError = 1;

                return _NumeroDocumento;
            }
            catch (Exception ex) { return 0; }
        }

        public static List<String> obtenerProveedores()
        {
            _ListaSocios = new Entities();
            _ListaSociosNombres = new List<String>();

            SqlDataReader lectorSQL;
            int cuenta;
            try
            {
                lectorSQL = AccesoDatosCV.obtenerProveedores();
                if (lectorSQL.HasRows)
                {
                    banderaError = 0;
                    while (lectorSQL.Read())
                    {
                        cuenta = ListaSocios.Count;
                        ListaSocios.Add(new Entity());
                        ListaSocios.ElementAt(cuenta).Set("id", lectorSQL.GetInt32(0));
                        ListaSocios.ElementAt(cuenta).Set("nombre", lectorSQL.GetString(1));
                        ListaSociosNombres.Add(lectorSQL.GetString(1));
                    }
                }
                else
                    banderaError = 1;
            }
            catch (Exception ex) { return null; }
            return ListaSociosNombres;
        }

        public static List<String> obtenerClientes()
        {
            _ListaSocios = new Entities();
            _ListaSociosNombres = new List<String>();

            SqlDataReader lectorSQL;
            int cuenta;
            try
            {
                lectorSQL = AccesoDatosCV.obtenerClientes();
                if (lectorSQL.HasRows)
                {
                    banderaError = 0;
                    while (lectorSQL.Read())
                    {
                        cuenta = ListaSocios.Count;
                        ListaSocios.Add(new Entity());
                        ListaSocios.ElementAt(cuenta).Set("id", lectorSQL.GetInt32(0));
                        ListaSocios.ElementAt(cuenta).Set("nombre", lectorSQL.GetString(1));
                        ListaSociosNombres.Add(lectorSQL.GetString(1));
                    }
                }
                else
                    banderaError = 1;
            }
            catch (Exception ex) { return null; }
            return ListaSociosNombres;
        }

        public static List<String> obtenerArticulos(String pSocio)
        {
            int Socio = (int)(ListaSocios.Get("nombre", pSocio).Get("id"));
            _ListaArticulos = new Entities();
            _ListaArticulosNombres = new List<String>();

            SqlDataReader lectorSQL;
            int cuenta;
            try
            {
                lectorSQL = AccesoDatosCV.obtenerArticulos(Socio);
                if (lectorSQL.HasRows)
                {
                    banderaError = 0;
                    while (lectorSQL.Read())
                    {
                        cuenta = ListaArticulos.Count;
                        ListaArticulos.Add(new Entity());
                        ListaArticulos.ElementAt(cuenta).Set("id", lectorSQL.GetInt32(0));
                        ListaArticulos.ElementAt(cuenta).Set("nombre", lectorSQL.GetString(1));
                        ListaArticulosNombres.Add(lectorSQL.GetString(1));
                    }
                }
                else
                    banderaError = 1;
            }
            catch (Exception ex) { return null; }
            return ListaArticulosNombres;
        }

        public static List<String> obtenerBodegas(String pArticulo)
        {
            int Articulo = (int)(ListaArticulos.Get("nombre", pArticulo).Get("id"));
            _ListaBodegas = new Entities();
            _ListaBodegasNombres = new List<String>();

            SqlDataReader lectorSQL;
            int cuenta;
            try
            {
                lectorSQL = AccesoDatosCV.obtenerBodegas(Articulo);
                if (lectorSQL.HasRows)
                {
                    banderaError = 0;
                    while (lectorSQL.Read())
                    {
                        cuenta = ListaBodegas.Count;
                        ListaBodegas.Add(new Entity());
                        ListaBodegas.ElementAt(cuenta).Set("id", lectorSQL.GetInt32(0));
                        ListaBodegas.ElementAt(cuenta).Set("nombre", lectorSQL.GetString(1));
                        ListaBodegasNombres.Add(lectorSQL.GetString(1));
                    }
                }
                else
                    banderaError = 1;
            }
            catch (Exception ex) { return null; }
            return ListaBodegasNombres;
        }

        public static string obtenerMoneda(String pSocios)
        {
            _Moneda = new Entity();

            int Socio = (int)(ListaSocios.Get("nombre", pSocios).Get("id"));
            SqlDataReader lectorSQL;
            try
            {
                lectorSQL = AccesoDatosCV.obtenerMoneda(Socio);
                if (lectorSQL.Read())
                {
                    banderaError = 0;
                    Moneda.Set("id", lectorSQL.GetInt32(0));
                    Moneda.Set("simbolo", lectorSQL.GetString(1));
                    lectorSQL.Close();
                }
                else
                    banderaError = 1;
            }
            catch (Exception ex) { return null; }
            return Moneda.Get("simbolo").ToString();
        }

        public static int obtenerIdMonedaSocio(String pMoneda)
        {
            int idMonedaSocio = (int)(Moneda.Get("id"));
            return idMonedaSocio;
        }

        public static List<int> obtenerDocumentosPrevios(int pTipoDocumentoPrevio)
        {
            _ListaDocumentosPrevios = new Entities();
            _ListaDocumentosPreviosNumeros = new List<int>();

            SqlDataReader lectorSQL;
            int cuenta;
            try
            {
                lectorSQL = AccesoDatosCV.obtenerDocumentosPrevios(pTipoDocumentoPrevio);
                if (lectorSQL.HasRows)
                {
                    banderaError = 0;
                    while (lectorSQL.Read())
                    {
                        cuenta = ListaDocumentosPrevios.Count;
                        ListaDocumentosPrevios.Add(new Entity());
                        ListaDocumentosPrevios.ElementAt(cuenta).Set("id", lectorSQL.GetInt32(0));
                        ListaDocumentosPrevios.ElementAt(cuenta).Set("numero", lectorSQL.GetInt32(1));
                        ListaDocumentosPreviosNumeros.Add(lectorSQL.GetInt32(1));
                    }
                }
                else
                    banderaError = 1;
            }
            catch (Exception ex) { return null; }
            return ListaDocumentosPreviosNumeros;
        }

        public static List<String> obtenerInfoDocumentoPrevio(int IdDocumentoPrevio, int IdTipoDocumentoPrevio, string IdSocio)
        {
            _ListaDocumentoPrevio = new Entities();
            _ListaDocumentoPrevioString = new List<String>();

            int Socio = (int)(ListaSocios.Get("nombre", IdSocio).Get("id"));

            SqlDataReader lectorSQL;
            int cuenta;
            try
            {
                lectorSQL = AccesoDatosCV.obtenerDocumentosPrevios(IdDocumentoPrevio, IdTipoDocumentoPrevio, Socio);
                if (lectorSQL.HasRows)
                {
                    banderaError = 0;
                    while (lectorSQL.Read())
                    {
                        cuenta = ListaDocumentoPrevio.Count;
                        ListaDocumentoPrevio.Add(new Entity());
                        ListaDocumentoPrevio.ElementAt(cuenta).Set("idarticulo", lectorSQL.GetInt32(0));
                        ListaDocumentoPrevio.ElementAt(cuenta).Set("nombre", lectorSQL.GetString(1));
                        ListaDocumentoPrevio.ElementAt(cuenta).Set("descripcion", lectorSQL.GetString(2));
                        ListaDocumentoPrevio.ElementAt(cuenta).Set("cantidad", lectorSQL.GetInt32(3));
                        ListaDocumentoPrevio.ElementAt(cuenta).Set("simbolo", lectorSQL.GetString(4));
                        ListaDocumentoPrevio.ElementAt(cuenta).Set("precio", lectorSQL.GetDecimal(5));
                        ListaDocumentoPrevio.ElementAt(cuenta).Set("impuesto", lectorSQL.GetDecimal(6));
                        ListaDocumentoPrevio.ElementAt(cuenta).Set("total", lectorSQL.GetDecimal(7));
                        ListaDocumentoPrevio.ElementAt(cuenta).Set("idbodega", lectorSQL.GetInt32(8));
                        ListaDocumentoPrevio.ElementAt(cuenta).Set("bodega", lectorSQL.GetString(9));
                        ListaDocumentoPrevioString.Add(lectorSQL.GetString(1));
                        ListaDocumentoPrevioString.Add(lectorSQL.GetString(2));
                        ListaDocumentoPrevioString.Add(lectorSQL.GetInt32(3).ToString());
                        ListaDocumentoPrevioString.Add(lectorSQL.GetString(4));
                        ListaDocumentoPrevioString.Add(lectorSQL.GetDecimal(5).ToString());
                        ListaDocumentoPrevioString.Add(lectorSQL.GetDecimal(6).ToString());
                        ListaDocumentoPrevioString.Add(lectorSQL.GetDecimal(7).ToString());
                        ListaDocumentoPrevioString.Add(lectorSQL.GetString(9));
                    }
                }
                else
                    banderaError = 1;
            }
            catch (Exception ex) { return null; }
            return ListaDocumentoPrevioString;
        }

        #endregion
    }
}
