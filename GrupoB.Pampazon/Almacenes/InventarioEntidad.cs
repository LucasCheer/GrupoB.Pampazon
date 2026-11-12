using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.Almacenes
{
    internal class InventarioEntidad
    {
        public string CUITCliente { get; set; }
        public string SKU { get; set; }
        public int CantidadDisponible { get; set; }
        public string UbicacionAlmacen { get; set; }
    }
}
