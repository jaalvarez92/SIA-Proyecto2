using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica.ModuloInventario;

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
            var res = ArticuloLogica.Instancia.obtenerArticulosBodega("Bodega San Pedro");
        }
    }
}
