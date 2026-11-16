using GrupoB.Pampazon.Almacenes;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GrupoB.Pampazon.IngresoDeOrdenDePreparacion
{
    public class IngresoDeOrdenDePreparacionModelo
    {
        private List<DetalleOrdenDTO> detalleProductos;

        // CUIT del cliente seleccionado: se usa para volver a consultar el stock en InventarioAlmacen
        private string cuitClienteActual = string.Empty;

        // Texto que muestra el combo de modalidad del formulario -> valor de ModalidadEnum que se guarda en la OP.
        // "Consolidado" también aparece en el combo, pero ModalidadEnum no tiene un valor para esa modalidad.
        private readonly Dictionary<string, ModalidadEnum> modalidades = new Dictionary<string, ModalidadEnum>
        {
            { "Palet Cerrado", ModalidadEnum.Pallet },
            { "Fulfillment", ModalidadEnum.Fullfilment }
        };

        public List<DetalleOrdenDTO> DetalleProductos => detalleProductos;

        public IngresoDeOrdenDePreparacionModelo()
        {
            detalleProductos = new List<DetalleOrdenDTO>();
        }

        public string ObtenerCuitPorCliente(string cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente))
                return string.Empty;

            // Buscamos el cliente por razón social en ClienteAlmacen
            var clienteEncontrado = ClienteAlmacen.Cliente.FirstOrDefault(c => c.RazonSocial == cliente);
            return clienteEncontrado != null ? clienteEncontrado.CUITCliente : string.Empty;
        }

        public List<string> ObtenerClientesActivos()
        {
            // Clientes del almacén ordenados por razón social
            return ClienteAlmacen.Cliente
                .Select(c => c.RazonSocial)
                .OrderBy(r => r)
                .ToList();
        }

        public List<ProductoSKUDTO> ObtenerSKUsPorCliente(string cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente))
                throw new ArgumentException("Debe seleccionar un cliente.");

            string cuit = ObtenerCuitPorCliente(cliente);
            cuitClienteActual = cuit;
            if (string.IsNullOrEmpty(cuit))
                return new List<ProductoSKUDTO>();

            List<ProductoSKUDTO> skus = new List<ProductoSKUDTO>();

            // SKUs que el cliente tiene en InventarioAlmacen (un SKU puede estar en varias coordenadas)
            foreach (var grupo in InventarioAlmacen.Inventario
                .Where(i => i.CUITCliente == cuit && i.CantidadDisponible > 0)
                .GroupBy(i => i.SKU))
            {
                // La descripción sale de ProductoAlmacen (nomenclador de SKUs)
                var producto = ProductoAlmacen.Producto.FirstOrDefault(p => p.SKU == grupo.Key);

                skus.Add(new ProductoSKUDTO
                {
                    SKU = grupo.Key,
                    Descripcion = producto != null ? producto.Descripcion : grupo.Key,
                    StockDisponible = grupo.Sum(i => i.CantidadDisponible)
                });
            }

            return skus;
        }

        public void ValidarCabecera(string cliente, string cuit, string transporte, string dniTransportista)
        {
            // Excepción 3.1
            if (string.IsNullOrWhiteSpace(cliente))
                throw new InvalidOperationException("Debe seleccionar un cliente.");

            // Excepción 5.1: CUIT de 11 dígitos numéricos
            string cuitLimpio = cuit?.Replace("-", "").Trim() ?? "";
            if (!Regex.IsMatch(cuitLimpio, @"^\d{11}$"))
                throw new FormatException("CUIT inválido (debe tener 11 dígitos / formato XXXXXXXXXXX).");

            // Excepción 6.1: Transporte en blanco
            if (string.IsNullOrWhiteSpace(transporte))
                throw new InvalidOperationException("Debe ingresar el nombre del transporte.");

            // Excepción 6.2: DNI Transportista de 8 dígitos numéricos
            string dniLimpio = dniTransportista?.Replace("-", "").Trim() ?? "";
            if (!Regex.IsMatch(dniLimpio, @"^\d{8}$"))
                throw new FormatException("Longitud de DNI inválida (debe tener 8 dígitos y solo contener números).");
        }

        public DetalleOrdenDTO AgregarProductoDetalle(ProductoSKUDTO producto, string cantidadTexto, string modalidad)
        {
            // Excepción 11.1
            if (producto == null)
                throw new InvalidOperationException("Debe seleccionar un SKU.");

            // Excepción 11.2: Cantidad entera positiva y no superior al stock disponible
            if (!int.TryParse(cantidadTexto, out int cantidadPedida) || cantidadPedida <= 0)
                throw new FormatException("Debe ingresar un número entero positivo para la cantidad.");

            // La cantidad disponible se consulta en InventarioAlmacen al momento de validar
            int stockDisponible = ConsultarStockDisponible(cuitClienteActual, producto.SKU);
            if (cantidadPedida > stockDisponible)
                throw new InvalidOperationException($"La cantidad supera el stock disponible ({stockDisponible}).");

            // Excepción 11.3
            if (string.IsNullOrWhiteSpace(modalidad))
                throw new InvalidOperationException("Debe seleccionar una modalidad.");

            // La modalidad tiene que existir en ModalidadEnum para poder guardarse en la OP
            if (!modalidades.ContainsKey(modalidad))
                throw new InvalidOperationException($"La modalidad '{modalidad}' no está disponible. Seleccione Palet Cerrado o Fulfillment.");

            // Excepción 12.1: Acumular o verificar duplicados
            var itemExistente = detalleProductos.Find(d => d.SKU == producto.SKU);
            if (itemExistente != null)
            {
                if (itemExistente.CantidadPedida + cantidadPedida > stockDisponible)
                    throw new InvalidOperationException($"La cantidad acumulada supera el stock disponible ({stockDisponible}).");

                itemExistente.CantidadPedida += cantidadPedida;
                itemExistente.Modalidad = modalidad;
                return itemExistente;
            }

            var nuevoDetalle = new DetalleOrdenDTO
            {
                SKU = producto.SKU,
                Descripcion = producto.Descripcion,
                CantidadPedida = cantidadPedida,
                Modalidad = modalidad
            };

            detalleProductos.Add(nuevoDetalle);
            return nuevoDetalle;
        }

        public void QuitarProductoDetalle(int index)
        {
            if (index >= 0 && index < detalleProductos.Count)
            {
                detalleProductos.RemoveAt(index);
            }
        }

        public string RegistrarOrdenPreparacion(string cliente, string cuit, string transporte, string dniTransportista)
        {
            // Paso 15: Validar cabecera y grilla de detalle
            ValidarCabecera(cliente, cuit, transporte, dniTransportista);

            // Excepción 15.1
            if (detalleProductos.Count == 0)
                throw new InvalidOperationException("Debe agregar al menos un producto.");

            // Antes de guardar, se vuelve a controlar cada línea contra el stock de InventarioAlmacen
            // Mismo formato de CUIT que el guardado en ClienteAlmacen e InventarioAlmacen
            string cuitCliente = cuit.Trim();
            foreach (var linea in detalleProductos)
            {
                int stockDisponible = ConsultarStockDisponible(cuitCliente, linea.SKU);
                if (linea.CantidadPedida > stockDisponible)
                    throw new InvalidOperationException($"La cantidad del SKU {linea.SKU} supera el stock disponible ({stockDisponible}).");
            }

            // Paso 16: Generar correlativo sobre el almacén real para no repetir números existentes
            string numeroOP = GenerarNumeroOP();

            // Creamos la entidad y la agregamos a OrdenDePreparacionAlmacen (se persiste al cerrar la aplicación)
            var nuevaOP = new OrdenDePreparacionEntidad
            {
                NumeroOP = numeroOP,
                FechaEmision = DateTime.Now,
                CUITCliente = cuit.Trim(),
                DNITransportista = dniTransportista.Replace("-", "").Trim(),
                NombreEmpresa = transporte.Trim(),
                Estado = EstadoOrdenPreparacionEnum.Pendiente,
                Detalle = detalleProductos.Select(d => new DetalleOP
                {
                    SKU = d.SKU,
                    Cantidad = d.CantidadPedida,
                    Modalidad = modalidades[d.Modalidad]
                }).ToList()
            };
            OrdenDePreparacionAlmacen.OrdenesDePreparacion.Add(nuevaOP);

            // Limpiar datos internos para nueva orden
            detalleProductos.Clear();

            return numeroOP;
        }

        private int ConsultarStockDisponible(string cuit, string sku)
        {
            // Suma la cantidad disponible del SKU del cliente en todas sus coordenadas
            return InventarioAlmacen.Inventario
                .Where(i => i.CUITCliente == cuit && i.SKU == sku)
                .Sum(i => i.CantidadDisponible);
        }

        private string GenerarNumeroOP()
        {
            // Formato de los datos existentes: OP-AAAA-NNNN
            string prefijo = $"OP-{DateTime.Now.Year}-";
            int ultimoNumero = 0;

            foreach (var op in OrdenDePreparacionAlmacen.OrdenesDePreparacion)
            {
                if (op.NumeroOP != null && op.NumeroOP.StartsWith(prefijo)
                    && int.TryParse(op.NumeroOP.Substring(prefijo.Length), out int numero)
                    && numero > ultimoNumero)
                {
                    ultimoNumero = numero;
                }
            }

            return $"{prefijo}{ultimoNumero + 1:D4}";
        }

        public void LimpiarTodo()
        {
            detalleProductos.Clear();
        }
    }
}