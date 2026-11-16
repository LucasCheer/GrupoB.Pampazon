using GrupoB.Pampazon.Almacenes;

namespace GrupoB.Pampazon.CumplimentarOrdenDeSeleccion
{
    internal class CumplimentarOrdenDeSeleccionModelo
    {
        private OrdenDeSeleccionEntidad? ordenActual;
        private List<ProductoHojaRuta> productos = new();

        public string NumeroOrdenSeleccion => ordenActual?.NumeroOS ?? "";
        public string OperarioAsignado { get; private set; } = "";

        public List<string> ObtenerOrdenesEmitidas() => OrdenDeSeleccionAlmacen.OrdenDeSeleccion
            .Where(o => o.Estado == EstadoOrdenSeleccionEnum.Emitida)
            .Select(o => o.NumeroOS).ToList();

        public IReadOnlyList<ProductoHojaRuta> CargarHojaRuta(string numeroOrden)
        {
            if (string.IsNullOrWhiteSpace(numeroOrden))
                throw new InvalidOperationException("Debe seleccionar una orden de selección.");

            ordenActual = OrdenDeSeleccionAlmacen.OrdenDeSeleccion.FirstOrDefault(o =>
                o.NumeroOS == numeroOrden && o.Estado == EstadoOrdenSeleccionEnum.Emitida)
                ?? throw new KeyNotFoundException("No se encontró una orden de selección emitida con ese número.");

            var operario = OperarioAlmacen.Operario.FirstOrDefault(o => o.Legajo == ordenActual.LegajoOperario);
            OperarioAsignado = operario != null ? $"{operario.Nombre} {operario.Apellido}" : ordenActual.LegajoOperario ?? "";
            var clientes = OrdenDePreparacionAlmacen.OrdenesDePreparacion
                .Where(op => ordenActual.OrdenesPreparacion.Contains(op.NumeroOP))
                .Select(op => op.CUITCliente).ToHashSet();
            productos = ordenActual.DetalleOS.Select((detalle, indice) => new ProductoHojaRuta(
                indice + 1, detalle.SKU,
                ProductoAlmacen.Producto.FirstOrDefault(p => p.SKU == detalle.SKU)?.Descripcion ?? detalle.SKU,
                detalle.Cantidad,
                InventarioAlmacen.Inventario.Where(i => i.SKU == detalle.SKU && clientes.Contains(i.CUITCliente))
                    .Select(i => i.CoordenadaXYZ).Distinct().ToList())).ToList();
            return productos;
        }

        public bool FinalizarOrdenSeleccion()
        {
            if (ordenActual == null)
                throw new InvalidOperationException("Debe cargar la hoja de ruta antes de finalizar la orden.");
            if (productos.Count == 0)
                throw new InvalidOperationException("La orden de selección no contiene productos.");
            if (ordenActual.Estado != EstadoOrdenSeleccionEnum.Emitida)
                throw new InvalidOperationException("La orden de selección ya fue finalizada.");

            ordenActual.Estado = EstadoOrdenSeleccionEnum.Finalizada;
            foreach (var op in OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(op =>
                ordenActual.OrdenesPreparacion.Contains(op.NumeroOP) && op.Estado == EstadoOrdenPreparacionEnum.EnSeleccion))
                op.Estado = EstadoOrdenPreparacionEnum.EnPreparacion;
            return true;
        }
    }

    internal record ProductoHojaRuta(int Orden, string SKU, string Descripcion, int Cantidad, IReadOnlyList<string> Coordenadas);
}
