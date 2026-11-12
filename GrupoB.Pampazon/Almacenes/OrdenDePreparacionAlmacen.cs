using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GrupoB.Pampazon.Almacenes
{
    static class OrdenDePreparacionAlmacen
    {
        public static List<OrdenDePreparacionEntidad> OrdenesDePreparacion { get; private set; }
        static OrdenDePreparacionAlmacen()
        {
            if (File.Exists(@"Datos\OrdenDePreparacion.json"))
            {
                string contenido = File.ReadAllText(@"Datos\OrdenDePreparacion.json");
                OrdenesDePreparacion = JsonSerializer.Deserialize<List<OrdenDePreparacionEntidad>>(contenido) ?? new List<OrdenDePreparacionEntidad>();
            }
            else
            {
                throw new ApplicationException("No se encontró el archivo OrdenDePreparacion.json");
            }
        }


        public static void Guardar()
        {
            string contenido = JsonSerializer.Serialize(OrdenesDePreparacion, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\OrdenDePreparacion.json", contenido);
        }
    }
}
