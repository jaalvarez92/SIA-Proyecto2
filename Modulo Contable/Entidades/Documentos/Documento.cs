using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Documentos
{
    public class Documento
    {
        public int IdSocio { get; set; }
        public int TipoDocumento { get; set; }
        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }
        public decimal TotalAI { get; set; }
        public int DocumentoPrevio { get; set; }
    }
}
