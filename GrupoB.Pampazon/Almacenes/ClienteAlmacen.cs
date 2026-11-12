using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GrupoB.Pampazon.Almacenes
{
    static class ClienteAlmacen
    {
        public static List<ClienteEntidad> Cliente { get; private set; }
        static ClienteAlmacen()
        {
            if (File.Exists(@"Datos\Cliente.json"))
            {
                string contenido = File.ReadAllText(@"Datos\Cliente.json");
                Cliente = JsonSerializer.Deserialize<List<ClienteEntidad>>(contenido) ?? new List<ClienteEntidad>();
            }
            else
            {
                throw new ApplicationException("No se encontró el archivo Cliente.json");
            }
        }


        public static void Guardar()
        {
            string contenido = JsonSerializer.Serialize(Cliente, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\Cliente.json", contenido);
        }
    }
}
