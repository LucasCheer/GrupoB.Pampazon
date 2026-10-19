using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    // Entidad Cliente con su propio catálogo de SKUs
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string RazonSocial { get; set; }
        public List<Producto> CatálogoSKUs { get; set; } = new List<Producto>();
    }
}
