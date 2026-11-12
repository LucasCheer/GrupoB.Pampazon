using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GrupoB.Pampazon.Almacenes
{
    static class OrdenDeEntregaAlmacen
    {
        public static List<OrdenDeEntregaEntidad> OrdenesDeEntrega { get; private set; }
        static OrdenDeEntregaAlmacen() 
        { 
            if(File.Exists(@"Datos\OrdenDeEntrega.json"))
            {
                string contenido = File.ReadAllText(@"Datos\OrdenDeEntrega.json");
                OrdenesDeEntrega = JsonSerializer.Deserialize<List<OrdenDeEntregaEntidad>>(contenido) ?? new List<OrdenDeEntregaEntidad>();
            }
            else
            {
                throw new ApplicationException("No se encontró el archivo OrdenDeEntrega.json");
            }
        }


        public static void Guardar()
        {
            string contenido = JsonSerializer.Serialize(OrdenesDeEntrega, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\OrdenDeEntrega.json", contenido);
        }

    }
}
