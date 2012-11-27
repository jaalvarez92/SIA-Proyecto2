using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica.ModuloInventario;
using Utilitarios;
using Entidades.Documentos;

namespace Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*var res = ArticuloLogica.Instancia.ingresarBodega(1, "Bodega San Pedro", "123");
            var result = ArticuloLogica.Instancia.obtenerBodegas(1);
            var result = ArticuloLogica.Instancia.ingresarArticulo(1, "100213", "Lápices Mongol", "unidad", "Son chinos", Convert.FromBase64String(""), 1);*/
            //var res = ArticuloLogica.Instancia.obtenerArticulosBodega("Bodega San Pedro");
            var orden = new Documento() {
                Fecha1= System.DateTime.Now,
                IdSocio = 2,
                TipoDocumento = 1,
                TotalAI = 1300
            };
            var detalle = new DocumentoDetalle(){
                NumeroDocumento = 22,
                IdArticulo = 1,
                Cantidad = 10,
                Descripcion = "Lapices Mongol",
                IdBodega = 1,
                Impuesto = 13,
                Precio = 130,
                TipoDocumento = 1
 
            };
            Email email = new Email();
            email.EnviarCorreo("caosejo@gmail.com", orden, detalle);

        }
    }
}
