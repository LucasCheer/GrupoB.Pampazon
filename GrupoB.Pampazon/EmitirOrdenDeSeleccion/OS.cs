using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    internal class OS
    {
        public string NumeroOS { get; set; }
        public DateTime FechaRecibida { get; set; }
        public string Estado { get; set; }
        public List<DetalleOS> Productos { get; set; } = new List<DetalleOS>();
        public List<string> OrdenesPreparacion { get; set; } = new List<string>();
    }
}
