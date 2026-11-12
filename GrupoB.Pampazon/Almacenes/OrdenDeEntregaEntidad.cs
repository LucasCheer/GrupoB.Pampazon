using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.Almacenes
{
    internal class OrdenDeEntregaEntidad
    {
        public string NumeroOE { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Estado { get; set; }
        public List<string> OrdenesPreparacion { get; set; }
    }
}
