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
            new Cliente{ClienteID = 3,RazonSocial = "A S.A"}
        };

        public List<OP> ops = new List<OP>
        {
            new OP{NumeroOP = "OP001",FechaRecibida = DateTime.Now.AddDays(-5),RazonSocial = "TechNew",Productos = new List<DetalleOP>
                {
                    new DetalleOP { SKU = "ELEC-MEM-8GB-01", Descripcion = "Memoria RAM 8GB DDR4", Cantidad = 100,Modalidad = "Fullfilment" },
                    new DetalleOP { SKU = "ELEC-PRO-I7-02", Descripcion = "Procesador Intel i7 12va Gen", Cantidad = 50,Modalidad = "Fullfilment" },
                    new DetalleOP { SKU = "ELEC-SSD-512-03", Descripcion = "Disco Sólido NVMe 512GB", Cantidad = 30,Modalidad = "Fullfilment" }
                },Estado = "Pendiente"
            },
            new OP{NumeroOP = "OP002",FechaRecibida = DateTime.Now.AddDays(-3),RazonSocial = "Materiales S.A.",
                Productos = new List<DetalleOP>
                {
                    new DetalleOP { SKU = "HERR-TAL-18V-01", Descripcion = "Taladro Percutor 18V", Cantidad = 2,Modalidad = "Pallet" },
                    new DetalleOP { SKU = "HERR-AMM-450-02", Descripcion = "Amoladora Angular 4.5\"", Cantidad = 4,Modalidad = "Pallet" }
                },Estado = "Pendiente"
            },
            new OP{NumeroOP = "OP003",FechaRecibida = DateTime.Now.AddDays(-1),RazonSocial = "Energia S.R.L",
                Productos = new List<DetalleOP>
                {
                    new DetalleOP { SKU = "CAB-COB-04MM-05", Descripcion = "Rollo Cable Cobre 4mm (100m)", Cantidad = 150,Modalidad = "Fullfilment" },
                    new DetalleOP { SKU = "ELEC-KEY-MEC-01", Descripcion = "Teclado Mecánico Español", Cantidad = 45,Modalidad = "Fullfilment" }
                },Estado = "Finalizada"
            },
            new OP{NumeroOP = "OP006",FechaRecibida = DateTime.Now.AddDays(-3),RazonSocial = "A S.A",
            Productos = new List<DetalleOP>
            {
                new DetalleOP { SKU = "HERR-TAL-18V-01", Descripcion = "Taladro Percutor 18V", Cantidad = 20,Modalidad = "Fullfilment" },
                new DetalleOP { SKU = "HERR-AMM-450-02", Descripcion = "Amoladora Angular 4.5\"", Cantidad = 10,Modalidad = "Fullfilment" }
            },Estado = "Pendiente"
            },
            new OP{NumeroOP = "OP010",FechaRecibida = DateTime.Now.AddDays(-3),RazonSocial = "A S.A",
            Productos = new List<DetalleOP>
            {
                new DetalleOP { SKU = "HERR-TAL-18V-01", Descripcion = "Taladro Percutor 18V", Cantidad = 3,Modalidad = "Pallet" }
                
            },Estado = "Pendiente"
            }
        };

        public List<OS> os = new List<OS>();


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

        public bool AgregarOS(OS nuevaOS, List<string> numerosOPSeleccionadas)
        {
            if (nuevaOS == null || numerosOPSeleccionadas == null || numerosOPSeleccionadas.Count == 0)
            {
                return false;
            }

            // 1. Generar número correlativo dinámico (ej: OS001, OS002...)
            int proximoNumero = os.Count + 1;
            nuevaOS.NumeroOS = $"OS{proximoNumero:D3}";
            nuevaOS.FechaRecibida = DateTime.Now;
            nuevaOS.Estado = "Emitida";

            // 2. Asociar explícitamente la lista de OPs a la OS
            nuevaOS.OrdenesPreparacion = new List<string>(numerosOPSeleccionadas);

            // 3. Guardar la OS en la lista interna del modelo
            os.Add(nuevaOS);

            // 4. Cambiar el estado de las OPs seleccionadas para quitarlas de pendientes
            foreach (var numeroOP in numerosOPSeleccionadas)
            {
                var op = ops.FirstOrDefault(o => o.NumeroOP.Equals(numeroOP.Trim(), StringComparison.OrdinalIgnoreCase));
                if (op != null)
                {
                    op.Estado = "En selección"; // Cambia el estado para que ObtenerOrdenesPendientes() ya no la devuelva
                }
            }

            return true;
        }

        public List<OP> ObtenerOpsfiltradas(string cliente, string numeroOP)
        {
            string filtroCliente = cliente?.Trim() ?? string.Empty;

            // Extraer solo los números ingresados por el usuario (ej: "001" -> 1)
            string digitosIngresados = new string((numeroOP ?? "").Where(char.IsDigit).ToArray());

            return ops
                .Where(op =>
                    // 1. Filtrar únicamente órdenes en estado Pendiente
                    op.Estado == "Pendiente" &&

                    // 2. Filtrar por cliente si se especificó uno
                    (string.IsNullOrEmpty(filtroCliente) ||
                     op.RazonSocial.Equals(filtroCliente, StringComparison.OrdinalIgnoreCase)) &&

                    // 3. Comparación numérica exacta ignorando las letras "OP"
                    (string.IsNullOrEmpty(digitosIngresados) ||
                     new string(op.NumeroOP.Where(char.IsDigit).ToArray())
                         .TrimStart('0')
                         .Equals(digitosIngresados.TrimStart('0')))
                )
                .ToList();
        }

        public List<OP> ObtenerOrdenesPendientes()
        {
            // El modelo consulta al almacén y filtra antes de entregar la lista

            List<OP> pendientes = new List<OP>();

            foreach (var orden in ops)
            {
                if (orden.Estado == "Pendiente")
                {
                    pendientes.Add(orden);
                }
            }

            return pendientes;
        }

        public List<DetalleOP> ObtenerDetallesPorOP(string numeroOP)
        {
            var op = ops.FirstOrDefault(o => o.NumeroOP.Trim().Equals(numeroOP.Trim(), StringComparison.OrdinalIgnoreCase));

            // Devolvemos una nueva lista para no exponer la colección interna de la entidad
            return op != null ? op.Productos.ToList() : new List<DetalleOP>();
        }

        public OS ConsolidarOrdenDeSeleccion(List<string> numerosOP)
        {
            OS nuevaOS = new OS { FechaRecibida = DateTime.Now, Productos = new List<DetalleOS>(), Estado = "Pendiente" };

            if (numerosOP == null || numerosOP.Count == 0)
            {
                return nuevaOS;
            }

            // Buscamos las OPs seleccionadas
            var opsSeleccionadas = ops
                .Where(o => numerosOP.Contains(o.NumeroOP.Trim(), StringComparer.OrdinalIgnoreCase))
                .ToList();

            // Agrupamos por la combinación de SKU y Modalidad
            nuevaOS.Productos = opsSeleccionadas
                .SelectMany(o => o.Productos)
                .GroupBy(p => new { p.SKU, p.Modalidad })
                .Select(g => new DetalleOS
                {
                    SKU = g.Key.SKU,
                    Modalidad = g.Key.Modalidad,
                    Cantidad = g.Sum(p => p.Cantidad)
                })
                .ToList();

            return nuevaOS;
        }

        public string ObtenerDescripcionProducto(string sku)
        {
            var prod = productos.FirstOrDefault(p => p.SKU.Trim().Equals(sku.Trim(), StringComparison.OrdinalIgnoreCase));
            return prod != null ? prod.Descripcion : "";
        }

        public List<string> ObtenerOpsAfectadasPorProducto(List<string> numerosOPSeleccionadas, string sku, string modalidad)
        {
            if (numerosOPSeleccionadas == null || numerosOPSeleccionadas.Count == 0 || string.IsNullOrEmpty(sku))
            {
                return new List<string>();
            }

            return ops
                .Where(o => numerosOPSeleccionadas.Contains(o.NumeroOP.Trim(), StringComparer.OrdinalIgnoreCase))
                .Where(o => o.Productos.Any(p => p.SKU.Equals(sku.Trim(), StringComparison.OrdinalIgnoreCase) &&
                                                p.Modalidad.Equals(modalidad.Trim(), StringComparison.OrdinalIgnoreCase)))
                .Select(o => o.NumeroOP)
                .ToList();
        }








    }
}