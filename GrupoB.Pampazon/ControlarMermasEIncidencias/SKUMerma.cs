using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.ControlarMermasEIncidencias
{
    public class SKUMerma
    {
        public string CodigoSKU { get; set; }
        public string Descripcion { get; set; }
        public int InventarioDisponible { get; set; }

        public override string ToString()
        {
            return $"{CodigoSKU} - {Descripcion}";
        }
    }
}
