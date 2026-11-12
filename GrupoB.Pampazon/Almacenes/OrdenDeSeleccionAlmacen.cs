using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GrupoB.Pampazon.Almacenes
{
    static class OrdenDeSeleccionAlmacen
    {
        public static List<OrdenDeSeleccionEntidad> OrdenDeSeleccion { get; private set; }
        static OrdenDeSeleccionAlmacen()
        {
            if (File.Exists(@"Datos\OrdenDeSeleccion.json"))
            {
                string contenido = File.ReadAllText(@"Datos\OrdenDeSeleccion.json");
                OrdenDeSeleccion = JsonSerializer.Deserialize<List<OrdenDeSeleccionEntidad>>(contenido) ?? new List<OrdenDeSeleccionEntidad>();
            }
            else
            {
                throw new ApplicationException("No se encontró el archivo OrdenDeSeleccion.json");
            }
        }


        public static void Guardar()
        {
            string contenido = JsonSerializer.Serialize(OrdenDeSeleccion, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\OrdenDeSeleccion.json", contenido);
        }
    }
}
