using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.ControlarMermasEIncidencias
{
    public class IncidenciaMerma
    {
        public string NumeroIncidencia { get; set; }
        public DateTime FechaHora { get; set; }
        public string OperarioReportante { get; set; }
        public SKUMerma SKUAfectado { get; set; }
        public string Ubicacion { get; set; }
        public int Cantidad { get; set; }
        public string CausaReportada { get; set; }
        public string JustificacionOperador { get; set; }
        public string Estado { get; set; } // "A Revisión", "Baja Definitiva", "Rechazada"
        public string DictamenSupervisor { get; set; }
    }
}
