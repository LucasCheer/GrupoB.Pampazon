using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    public class OP
    {
        public string NumeroOP { get; set; }
        public DateTime FechaRecibida { get; set; }
        public string RazonSocial { get; set; }
        public string Estado { get; set; }
        public List<DetalleOP> Productos { get; set; } = new List<DetalleOP>();


    }
}
