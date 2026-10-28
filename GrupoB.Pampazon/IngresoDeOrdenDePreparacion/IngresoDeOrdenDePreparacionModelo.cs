using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GrupoB.Pampazon.IngresoDeOrdenDePreparacion
{
    // DTO para representar cada ítem/línea de producto en la grilla de detalle
    public class DetalleOrdenDTO
    {
        public string SKU { get; set; }
        public string Descripcion { get; set; }
        public int CantidadPedida { get; set; }
        public string Modalidad { get; set; }
    }

    // DTO para representar el producto/SKU
    public class ProductoSKUDTO
    {
        public string SKU { get; set; }
        public string Descripcion { get; set; }
        public int StockDisponible { get; set; }
    }

    public class IngresoDeOrdenDePreparacionModelo
    {
        private List<DetalleOrdenDTO> detalleProductos;
        private Dictionary<string, List<ProductoSKUDTO>> catalogoClientes;

        public List<DetalleOrdenDTO> DetalleProductos => detalleProductos;

        public IngresoDeOrdenDePreparacionModelo()
        {
            detalleProductos = new List<DetalleOrdenDTO>();
            CargarCatalogoMock();
        }

        /// <summary>
        /// Datos mock de clientes y sus SKUs con stock disponible en racks
        /// </summary>
        private void CargarCatalogoMock()
        {
            catalogoClientes = new Dictionary<string, List<ProductoSKUDTO>>
            {
                {
                    "Empresa Alfa S.A.", new List<ProductoSKUDTO>
                    {
                        new ProductoSKUDTO { SKU = "SKU-101", Descripcion = "Caja de Galletitas 500g", StockDisponible = 150 },
                        new ProductoSKUDTO { SKU = "SKU-102", Descripcion = "Pack Aceite de Girasol 1L", StockDisponible = 80 }
                    }
                },
                {
                    "Logística Beta S.R.L.", new List<ProductoSKUDTO>
                    {
                        new ProductoSKUDTO { SKU = "SKU-201", Descripcion = "Bolsa Detergente 5kg", StockDisponible = 50 },
                        new ProductoSKUDTO { SKU = "SKU-202", Descripcion = "Caja Jabón Líquido 3L", StockDisponible = 200 }
                    }
                }
            };
        }

        public List<string> ObtenerClientesActivos()
        {
            return new List<string>(catalogoClientes.Keys);
        }

        public List<ProductoSKUDTO> ObtenerSKUsPorCliente(string cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente))
                throw new ArgumentException("Debe seleccionar un cliente.");

            if (catalogoClientes.ContainsKey(cliente))
                return catalogoClientes[cliente];

            return new List<ProductoSKUDTO>();
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

            if (cantidadPedida > producto.StockDisponible)
                throw new InvalidOperationException($"La cantidad supera el stock disponible ({producto.StockDisponible}).");

            // Excepción 11.3
            if (string.IsNullOrWhiteSpace(modalidad))
                throw new InvalidOperationException("Debe seleccionar una modalidad.");

            // Excepción 12.1: Acumular o verificar duplicados
            var itemExistente = detalleProductos.Find(d => d.SKU == producto.SKU);
            if (itemExistente != null)
            {
                if (itemExistente.CantidadPedida + cantidadPedida > producto.StockDisponible)
                    throw new InvalidOperationException($"La cantidad acumulada supera el stock disponible ({producto.StockDisponible}).");

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

            // Paso 16: Generar correlativo
            Random rnd = new Random();
            string numeroOP = $"OP-{DateTime.Now:yyyyMMdd}-{rnd.Next(1000, 9999)}";

            // Limpiar datos internos para nueva orden
            detalleProductos.Clear();

            return numeroOP;
        }

        public void LimpiarTodo()
        {
            detalleProductos.Clear();
        }
    }
}