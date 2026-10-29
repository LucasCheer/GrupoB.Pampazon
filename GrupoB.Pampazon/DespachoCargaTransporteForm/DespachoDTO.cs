using System.Collections.Generic;

namespace GrupoB.Pampazon.DespachoCargaTransporte
{
    // DTO para transportar los datos a la interfaz
    public class DespachoDTO
    {
        public string TransporteValidado { get; set; }
        public List<string> ListaCajas { get; set; } = new List<string>();
        public int TotalCajas => ListaCajas.Count;
    }
}
