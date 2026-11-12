using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GrupoB.Pampazon.Almacenes
{
    static class IncidenciaMermaAlmacen
    {
        public static List<IncidenciaMermaEntidad> IncidenciaMerma{ get; private set; }
        static IncidenciaMermaAlmacen()
        {
            if (File.Exists(@"Datos\IncidenciaMerma.json"))
            {
                string contenido = File.ReadAllText(@"Datos\IncidenciaMerma.json");
                IncidenciaMerma = JsonSerializer.Deserialize<List<IncidenciaMermaEntidad>>(contenido) ?? new List<IncidenciaMermaEntidad>();
            }
            else
            {
                throw new ApplicationException("No se encontró el archivo IncidenciaMerma.json");
            }
        }


        public static void Guardar()
        {
            string contenido = JsonSerializer.Serialize(IncidenciaMerma, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\IncidenciaMerma.json", contenido);
        }
    }
}
