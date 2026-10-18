using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    internal class EmitirOrdenDeSeleccionModelo
    {
        public List<Cliente> clientes = new List<Cliente>
        {
            new Cliente { Id = 1, Descripcion = "TechNew" },
            new Cliente { Id = 2, Descripcion = "Materiales S.A." },
            new Cliente { Id = 3, Descripcion = "Energia S.R.L" }
        };

        public List<OPs> ops = new List<OPs>
        {
            new OPs { NumeroOP = "OP001", FechaRecibida = DateTime.Now.AddDays(-5), ClienteID = 1, Producto = "Producto A", Cantidad = 100 },
            new OPs { NumeroOP = "OP001", FechaRecibida = DateTime.Now.AddDays(-5), ClienteID = 1, Producto = "Producto X", Cantidad = 100 },
            new OPs { NumeroOP = "OP002", FechaRecibida = DateTime.Now.AddDays(-3), ClienteID = 2, Producto = "Producto B", Cantidad = 200 },
            new OPs { NumeroOP = "OP003", FechaRecibida = DateTime.Now.AddDays(-1), ClienteID = 3, Producto = "Producto C", Cantidad = 150 }
        };
    }
}
