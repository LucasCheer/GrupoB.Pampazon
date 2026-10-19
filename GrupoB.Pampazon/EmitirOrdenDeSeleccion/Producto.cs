using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    public class Producto
    {
            public string SKU { get; set; }          // Clave única (ej: "PROD-A")
            public string Descripcion { get; set; }
            public string Ubicacion { get; set; }    // Posición en almacén (X-Y-Z)
        
    }
}
