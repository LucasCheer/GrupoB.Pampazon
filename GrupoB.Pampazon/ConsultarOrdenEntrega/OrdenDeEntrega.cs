using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.ConsultarOrdenEntrega
{
    internal class OrdenDeEntrega
    {
        public string NumeroOrdenDeEntrega { get; set; }
        public OrdenDeEntrega(string numeroOrdenDeEntrega)
        {
            NumeroOrdenDeEntrega = numeroOrdenDeEntrega;
        }
    }
}
