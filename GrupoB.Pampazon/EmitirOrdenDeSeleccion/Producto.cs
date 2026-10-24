using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    public class Producto
    {
        public string SKU { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string UbicacionAlmacen { get; set; } // Formato de pasillo/estantería (X-Y-Z)
    }
}
