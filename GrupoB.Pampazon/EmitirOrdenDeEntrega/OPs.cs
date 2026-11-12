using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeEntrega
{
    public class OP
    {
        public string NumeroOP { get; set; }
        public DateTime FechaEmision { get; set; } //Cambió por redefinición en diagrama de clases - Revisión 11/11/2026
        public string RazonSocial { get; set; }
        public string Estado { get; set; }


    }
}
