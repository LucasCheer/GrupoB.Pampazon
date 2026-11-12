using GrupoB.Pampazon.EmitirOrdenDeSeleccion;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.Almacenes
{
    internal class OrdenDeSeleccionEntidad
    {
        public string NumeroOp { get; set; }
        public DateTime FechaSolicitada { get; set; }
        public string CUITCliente { get; set; }
        public string DNITransportista { get; set; }
        public string NombreEmpresa { get; set; }
        public EstadoOrdenPreparacionEnum Estado { get; set; }
        public List<DetalleOP> Detalle { get; set; } = new List<DetalleOP>();
    }
}
