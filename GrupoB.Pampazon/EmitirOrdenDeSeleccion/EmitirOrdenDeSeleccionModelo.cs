using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    internal class EmitirOrdenDeSeleccionModelo
    {
        public List<Cliente> clientes = new List<Cliente>
        {
            new Cliente
            {
                ClienteID = 1,
                RazonSocial = "TechNew"
            },
            new Cliente
            {
                ClienteID = 2,
                RazonSocial = "Materiales S.A."
            },
            new Cliente
            {
                ClienteID = 3,
                RazonSocial = "Energia S.R.L"
            }
        };

        public List<OPs> ops = new List<OPs>
        {
            new OPs { NumeroOP = "OP001", FechaRecibida = DateTime.Now.AddDays(-5), RazonSocial = "TechNew", ProductoSKU = "PROD-B", Cantidad = 100 },
            new OPs { NumeroOP = "OP001", FechaRecibida = DateTime.Now.AddDays(-5), RazonSocial = "TechNew", ProductoSKU = "PROD-B", Cantidad = 100 },
            new OPs { NumeroOP = "OP002", FechaRecibida = DateTime.Now.AddDays(-3), RazonSocial = "Materiales S.A.", ProductoSKU = "PROD-C", Cantidad = 200 },
            new OPs { NumeroOP = "OP003", FechaRecibida = DateTime.Now.AddDays(-1), RazonSocial = "Energia S.R.L", ProductoSKU = "PROD-D", Cantidad = 150 }
        };

        public List<Producto> productos = new List<Producto>
        {
            new Producto { SKU = "PROD-A", Descripcion = "Teclado Mecánico", Ubicacion = "A-01-01" },
            new Producto { SKU = "PROD-B", Descripcion = "Monitor 24 Pulgadas", Ubicacion = "A-02-05" },
            new Producto { SKU = "PROD-C", Descripcion = "Caja de Herramientas", Ubicacion = "B-01-10" },
            new Producto { SKU = "PROD-D", Descripcion = "Batería Gel 12V 100Ah", Ubicacion = "C-05-01" }
        };
    }
}