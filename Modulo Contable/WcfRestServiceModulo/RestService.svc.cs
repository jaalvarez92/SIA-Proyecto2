using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades.Documentos;
using Entidades.Inventario;
using Logica.ModuloInventario;

namespace WcfRestServiceEncuestas
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class RestService : IRestService
    {
        public bool insertarDocumento(Documento pDocumento)
        {
            //return LogicaInsertarDocumentos.insertarDocumento(IdSocio, TipoDocumento, Fecha1, Fecha2, TotalAI, Impuestos, DocumentoPrevio, false);
            return true;
        }

        public bool insertarDocumentoDetalle(DocumentoDetalle pDocumentoDetalle)
        {
            //return LogicaInsertarDocumentos.insertarLineaDetalleDocumento(NumeroDocumento, IdBodega, Articulo, Cantidad, Precio, Descricpion, Impuesto, TipoDocumento);
            return true;
        }

        public List<Articulo> obtenerArticulos()
        {
            return ArticuloLogica.Instancia.obtenerArticulos();
        }


        public List<String> obtenerArticulos2()
        {
            return ArticuloLogica.Instancia.obtenerArticulos2();
        }


        public Articulo obtenerArticuloXNombre(String pNombre)
        {
            return ArticuloLogica.Instancia.obtenerArticuloXNombre(pNombre.Replace('-',' '));
        }
        

        public string holaMundo()
        {
            return "Hola Mundo";
        }



    }
}
