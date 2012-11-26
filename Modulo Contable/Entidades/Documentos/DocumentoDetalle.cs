using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Documentos
{
    public class DocumentoDetalle
    {
        public int NumeroDocumento { get; set; }
        public int IdBodega { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public decimal Impuesto { get; set; }
        public int TipoDocumento { get; set; }
    }
}
