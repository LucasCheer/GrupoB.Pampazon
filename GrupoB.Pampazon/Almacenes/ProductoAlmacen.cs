using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GrupoB.Pampazon.Almacenes
{
    static class ProductoAlmacen
    {
        public static List<ProductoEntidad> Producto{ get; private set; }
        static ProductoAlmacen()
        {
            if (File.Exists(@"Datos\Producto.json"))
            {
                string contenido = File.ReadAllText(@"Datos\Producto.json");
                Producto = JsonSerializer.Deserialize<List<ProductoEntidad>>(contenido) ?? new List<ProductoEntidad>();
            }
            else
            {
                throw new ApplicationException("No se encontró el archivo Producto.json");
            }
        }


        public static void Guardar()
        {
            string contenido = JsonSerializer.Serialize(Producto, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\Producto.json", contenido);
        }
    }
}
