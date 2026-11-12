using GrupoB.Pampazon.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrupoB.Pampazon.EmitirOrdenDeSeleccion
{
    internal class EmitirOrdenDeSeleccionModelo
    {
        public List<Cliente> clientes = new List<Cliente>();

        public List<OP> ops = new List<OP>();
        

        public List<OS> os = new List<OS>();


        public List<Producto> productos = new List<Producto>();
        public EmitirOrdenDeSeleccionModelo()
        {
            CargarClientes();
            CargarProductos();
        }

        public List<Cliente> CargarClientes()
        {
            var clientesEntidad = ClienteAlmacen.Cliente;

            clientes = clientesEntidad
                .Select(c => new Cliente
                {
                    CUITCliente = c.CUITCliente,
                    RazonSocial = c.RazonSocial
                })
                .ToList();

            return clientes;
        }
        public List<Producto> CargarProductos()
        {
            // Consultamos la lista estática del almacén (verificá si se llama Productos o Producto)
            var productosEntidad = ProductoAlmacen.Producto;

            // Mapeamos a instancias nuevas de Producto (DTO) para no devolver referencias a la entidad
            productos = productosEntidad
                .Select(p => new Producto
                {
                    SKU = p.SKU,
                    Descripcion = p.Descripcion
                })
                .ToList();

            return productos;
        }
        public bool AgregarOS(OS nuevaOS, List<string> numerosOPSeleccionadas)
        {
            if (nuevaOS == null || numerosOPSeleccionadas == null || numerosOPSeleccionadas.Count == 0)
            {
                return false;
            }

            // 1. Generar número correlativo mirando el almacén real
            int proximoNumero = OrdenDeSeleccionAlmacen.OrdenDeSeleccion.Count + 1;
            nuevaOS.NumeroOS = $"OS-2026-{proximoNumero:D4}";
            nuevaOS.FechaRecibida = DateTime.Now;
            nuevaOS.OrdenesPreparacion = numerosOPSeleccionadas.Select(n => n.Trim()).ToList();

            // 2. Mapear y guardar la nueva OrdenDeSeleccionEntidad en el almacén
            var nuevaOSEntidad = new OrdenDeSeleccionEntidad
            {
                NumeroOS = nuevaOS.NumeroOS,
                FechaEmision = nuevaOS.FechaRecibida,
                Estado = EstadoOrdenSeleccionEnum.Emitida,
                OrdenesPreparacion = new List<string>(nuevaOS.OrdenesPreparacion),
                DetalleOS = nuevaOS.Productos.Select(p => new Almacenes.DetalleOS
                {
                    SKU = p.SKU,
                    Cantidad = p.Cantidad,
                    Modalidad = Enum.TryParse<ModalidadEnum>(p.Modalidad, true, out var mod)
                        ? mod
                        : ModalidadEnum.Pallet
                }).ToList()
            };
            OrdenDeSeleccionAlmacen.OrdenDeSeleccion.Add(nuevaOSEntidad);

            // Mantenemos sincronizada la lista local del modelo
            os.Add(nuevaOS);

            // 3. Actualizar el estado de las entidades reales en OrdenDePreparacionAlmacen
            foreach (var numeroOP in numerosOPSeleccionadas)
            {
                string numLimpio = numeroOP.Trim();

                // Actualizamos en el almacén
                var opEntidad = OrdenDePreparacionAlmacen.OrdenesDePreparacion
                    .FirstOrDefault(o => o.NumeroOP.Equals(numLimpio, StringComparison.OrdinalIgnoreCase));

                if (opEntidad != null)
                {
                    opEntidad.Estado = EstadoOrdenPreparacionEnum.EnSeleccion;
                }

                // Actualizamos en la lista local 'ops' para los filtros inmediatos
                var opLocal = ops.FirstOrDefault(o => o.NumeroOP.Equals(numLimpio, StringComparison.OrdinalIgnoreCase));
                if (opLocal != null)
                {
                    opLocal.Estado = "En selección";
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
            var opEntidad = OrdenDePreparacionAlmacen.OrdenesDePreparacion;
            var clientesEntidad = ClienteAlmacen.Cliente;
            List<OP> pendientes = new List<OP>();

            foreach (var entidad in opEntidad)
            {
                if (entidad.Estado == EstadoOrdenPreparacionEnum.Pendiente)
                {
                    // Buscamos la Razón Social por CUIT
                    var clienteEncontrado = clientesEntidad
                        .FirstOrDefault(c => c.CUITCliente == entidad.CUITCliente);

                    // Mapeamos a instancias nuevas de OP y DetalleOP (cero referencias compartidas)
                    pendientes.Add(new OP
                    {
                        NumeroOP = entidad.NumeroOP,
                        FechaRecibida = entidad.FechaSolicitada,
                        RazonSocial = clienteEncontrado != null ? clienteEncontrado.RazonSocial : entidad.CUITCliente,
                        Estado = "Pendiente",
                        Productos = entidad.Detalle != null
                            ? entidad.Detalle.Select(d => new DetalleOP
                            {
                                SKU = d.SKU,
                                Descripcion = ObtenerDescripcionProducto(d.SKU),
                                Cantidad = d.Cantidad,
                                Modalidad = d.Modalidad.ToString()
                            }).ToList()
                            : new List<DetalleOP>()
                    });
                }
            }

            // Actualizamos la lista interna 'ops' para que los filtros, detalles y consolidación funcionen con estos datos
            ops = pendientes;
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