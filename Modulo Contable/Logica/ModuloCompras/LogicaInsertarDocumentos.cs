using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos.ModuloCompras;
using Entidades;
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
        public static int banderaError;

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

        #endregion

        #region metodos


        public static int insertarDocumento(int Socio, int TipoDocumento, DateTime Fecha1, DateTime Fecha2, Decimal TotalAI, Decimal Impuestos, int DocumentoPrevio, Boolean Automatico, int IdEmpresa, int IdMoneda)
        {
            int IdSocio = (int)ListaSocios.ElementAt(Socio).Get("id");
            int IdDocumentoPrevio = (int)(ListaDocumentosPrevios.Get("numero", DocumentoPrevio).Get("id"));
            Boolean abierto, asiento = false;
            int retorno;
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
                IdAsientoActual = AccesoDatosCV.crearAsientoSinCuentas();

            return retorno; //ID del documento
        }

        public static Boolean insertarLineaDetalleDocumento(int IdDocumento, String Bodega, String Articulo, int Cantidad, Decimal Precio, string Descricpion, Decimal Impuesto, int TipoDocumento, int IdEmpresa, int IdMoneda)
        {
            //revisar maximos y minimos
            int IdBodega = (int)(ListaBodegas.Get("nombre", Bodega).Get("id"));
            int IdArticulo = (int)(ListaArticulos.Get("nombre", Articulo).Get("id"));

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
                return AccesoDatosCV.ingresarLineaDetalleDocumentoEntregaMercaderia(IdDocumento, IdBodega, IdArticulo, Cantidad, Precio, Descricpion, Impuesto, IdEmpresa, IdMoneda, IdAsientoActual);
            }

            if (TipoDocumento == FacturaCliente)
            {
                return AccesoDatosCV.ingresarLineaDetalleDocumentoFacturaCliente(IdDocumento, IdBodega, IdArticulo, Cantidad, Precio, Descricpion, Impuesto, IdEmpresa, IdMoneda, IdAsientoActual);
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

        public static int obtenerMoneda(String pArticulo)
        {
            int Articulo = (int)(ListaArticulos.Get("nombre", pArticulo).Get("id"));
            SqlDataReader lectorSQL;
            int _Moneda = 0;
            try
            {
                lectorSQL = AccesoDatosCV.obtenerMonedas(Articulo);
                if (lectorSQL.Read())
                {
                    banderaError = 0;
                    _Moneda = lectorSQL.GetInt32(0);
                    lectorSQL.Close();
                }
                else
                    banderaError = 1;
            }
            catch (Exception ex) { return 0; }
            return _Moneda;
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

        #endregion
    }
}
