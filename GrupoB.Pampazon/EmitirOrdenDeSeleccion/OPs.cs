using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    internal class OPs
    {
        public string NumeroOP { get; set; }
        public DateTime FechaRecibida { get; set; }
        public int ClienteID { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
