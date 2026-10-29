using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    internal class EmitirOrdenDeSeleccionModelo
    {
        public List<Cliente> clientes = new List<Cliente>
        {
            new Cliente{ClienteID = 1,RazonSocial = "TechNew"},
            new Cliente{ClienteID = 2,RazonSocial = "Materiales S.A."},
            new Cliente{ClienteID = 3,RazonSocial = "Energia S.R.L"}
        };

        public List<OP> ops = new List<OP>
{
    new OP{NumeroOP = "OP001",FechaRecibida = DateTime.Now.AddDays(-5),RazonSocial = "TechNew",Productos = new List<DetalleOP>
        {
            new DetalleOP { SKU = "ELEC-MEM-8GB-01", Descripcion = "Memoria RAM 8GB DDR4", Cantidad = 100 },
            new DetalleOP { SKU = "ELEC-PRO-I7-02", Descripcion = "Procesador Intel i7 12va Gen", Cantidad = 50 },
            new DetalleOP { SKU = "ELEC-SSD-512-03", Descripcion = "Disco Sólido NVMe 512GB", Cantidad = 30 }
        },Estado = "Pendiente"
    },
    new OP{NumeroOP = "OP002",FechaRecibida = DateTime.Now.AddDays(-3),RazonSocial = "Materiales S.A.",
        Productos = new List<DetalleOP>
        {
            new DetalleOP { SKU = "HERR-TAL-18V-01", Descripcion = "Taladro Percutor 18V", Cantidad = 200 },
            new DetalleOP { SKU = "HERR-AMM-450-02", Descripcion = "Amoladora Angular 4.5\"", Cantidad = 80 }
        },Estado = "Pendiente"
    },
    new OP{NumeroOP = "OP003",FechaRecibida = DateTime.Now.AddDays(-1),RazonSocial = "Energia S.R.L",
        Productos = new List<DetalleOP>
        {
            new DetalleOP { SKU = "CAB-COB-04MM-05", Descripcion = "Rollo Cable Cobre 4mm (100m)", Cantidad = 150 },
            new DetalleOP { SKU = "ELEC-KEY-MEC-01", Descripcion = "Teclado Mecánico Español", Cantidad = 45 }
        },Estado = "Finalizada"
    },
        new OP{NumeroOP = "OP006",FechaRecibida = DateTime.Now.AddDays(-3),RazonSocial = "A S.A",
        Productos = new List<DetalleOP>
        {
            new DetalleOP { SKU = "HERR-TAL-18V-01", Descripcion = "Taladro Percutor 18V", Cantidad = 200 },
            new DetalleOP { SKU = "HERR-AMM-450-02", Descripcion = "Amoladora Angular 4.5\"", Cantidad = 80 }
        },Estado = "Pendiente"
    },


};

        public List <OS> os = new List<OS>()
        {

        };
        public List<detalleOS> detalleOS = new List<detalleOS>();

        public List<Producto> productos = new List<Producto>
        {
            new Producto{SKU = "ELEC-MEM-8GB-01",Descripcion = "Memoria RAM 8GB DDR4",Categoria = "Electrónica",PrecioUnitario = 45.00m,UbicacionAlmacen = "A-01-02"},
            new Producto{SKU = "ELEC-PRO-I7-02",Descripcion = "Procesador Intel i7 12va Gen",Categoria = "Electrónica",PrecioUnitario = 320.00m,UbicacionAlmacen = "A-01-05"},
            new Producto{SKU = "ELEC-SSD-512-03",Descripcion = "Disco Sólido NVMe 512GB",Categoria = "Electrónica",PrecioUnitario = 65.00m,UbicacionAlmacen = "A-02-01"},
            new Producto{SKU = "HERR-TAL-18V-01",Descripcion = "Taladro Percutor 18V",Categoria = "Herramientas",PrecioUnitario = 120.00m,UbicacionAlmacen = "B-04-03"},
            new Producto{SKU = "HERR-AMM-450-02",Descripcion = "Amoladora Angular 4.5\"",Categoria = "Herramientas",PrecioUnitario = 85.00m,UbicacionAlmacen = "B-04-08"    },
            new Producto{SKU = "CAB-COB-04MM-05",Descripcion = "Rollo Cable Cobre 4mm (100m)",Categoria = "Materiales",PrecioUnitario = 95.00m,UbicacionAlmacen = "C-02-01"},
            new Producto{SKU = "ELEC-KEY-MEC-01",Descripcion = "Teclado Mecánico Español",Categoria = "Electrónica",PrecioUnitario = 55.00m,UbicacionAlmacen = "A-03-04"}
        };

        internal bool AgregarOS(string SKU, int cantidad)
        {

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            detalleOS.Add(new detalleOS { SKU = SKU, Cantidad = cantidad });

            //aca pueden ir otras validaciones de negocio.
            //....


            return true; //para indicar que está todo bien
        }



    }
}