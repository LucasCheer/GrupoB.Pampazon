using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    internal class OS
    {
        public string NumeroOS { get; set; }
        public DateTime FechaRecibida { get; set; }
        public List<detalleOS> Productos { get; set; } = new List<detalleOS>();
    }
}
