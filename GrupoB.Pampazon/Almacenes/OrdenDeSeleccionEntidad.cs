using GrupoB.Pampazon.EmitirOrdenDeSeleccion;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.Almacenes
{
    internal class OrdenDeSeleccionEntidad
    {
        public string NumeroOS { get; set; }
        public DateTime FechaEmision { get; set; }
        public EstadoOrdenSeleccionEnum Estado { get; set; }
        public List<DetalleOS> DetalleOS { get; set; } = new List<DetalleOS>();
        public List<string> OrdenesPreparacion { get; set; } = new List<string>();
        public string LegajoOperario { get; set; }
    }
}
