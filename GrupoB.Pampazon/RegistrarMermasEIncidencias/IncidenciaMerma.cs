using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.RegistrarMermasEIncidencias
{
    public class IncidenciaMerma
    {
        public string NumeroIncidencia { get; set; }
        public string FechaHora { get; set; }
        public string OperarioResponsable { get; set; }
        public string Sector { get; set; }
        public string EtapaOperativa { get; set; }
        public string CoordenadaXYZ { get; set; }
        public string SKU { get; set; }
        public string TipoCausa { get; set; }
        public int CantidadAfectada { get; set; }
        public string JustificacionTecnica { get; set; }
        public string Estado { get; set; }
    }
}
