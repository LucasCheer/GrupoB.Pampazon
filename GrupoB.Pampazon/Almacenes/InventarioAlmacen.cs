using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GrupoB.Pampazon.Almacenes
{
    static class InventarioAlmacen
    {
        public static List<InventarioEntidad> Inventario { get; private set; }
        static InventarioAlmacen()
        {
            if (File.Exists(@"Datos\Inventario.json"))
            {
                string contenido = File.ReadAllText(@"Datos\Inventario.json");
                Inventario = JsonSerializer.Deserialize<List<InventarioEntidad>>(contenido) ?? new List<InventarioEntidad>();
            }
            else
            {
                throw new ApplicationException("No se encontró el archivo Inventario.json");
            }
        }


        public static void Guardar()
        {
            string contenido = JsonSerializer.Serialize(Inventario, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\Inventario.json", contenido);
        }
    }
}
