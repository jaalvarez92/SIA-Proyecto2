﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Inventario
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public string Comentario { get; set; }
        public byte[] Foto { get; set; }
        public decimal Precio { get; set; }
        public int IdEmpresa { get; set; }
        public int IdBodega { get; set; }
    }
}
