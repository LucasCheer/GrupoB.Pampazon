using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.Almacenes
{
    internal class IncidenciaMermaEntidad
    {
        public string NumeroIncidencia { get; set; }
        public DateTime FechaHora { get; set; }
        public SectorIncidenciaEnum Sector { get; set; }
        public EtapaOperativaIncidenciaEnum EtapaOperativa { get; set; }
        public string SKU { get; set; }
        public TipoCausaIncidenciaEnum TipoCausa { get; set; }
        public int CantidadAfectada { get; set; }
        public string JustificacionTecnica { get; set; }
        public EstadoIncidenciaMermaEnum Estado { get; set; }
        public string CoordenadaXYZ { get; set; }
        public string LegajoOperario { get; set; }
    }
}
