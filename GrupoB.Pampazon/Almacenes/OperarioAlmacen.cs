using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GrupoB.Pampazon.Almacenes
{
    static class OperarioAlmacen
    {
        public static List<OperarioEntidad> Operario { get; private set; }
        static OperarioAlmacen()
        {
            if (File.Exists(@"Datos\Operario.json"))
            {
                string contenido = File.ReadAllText(@"Datos\Operario.json");
                Operario = JsonSerializer.Deserialize<List<OperarioEntidad>>(contenido) ?? new List<OperarioEntidad>();
            }
            else
            {
                throw new ApplicationException("No se encontró el archivo Operario.json");
            }
        }


        public static void Guardar()
        {
            string contenido = JsonSerializer.Serialize(Operario, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\Operario.json", contenido);
        }
    }
}
