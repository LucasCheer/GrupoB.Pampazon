using GrupoB.Pampazon.Almacenes;

namespace GrupoB.Pampazon.AcondicionarYEmpaquetarLote
{
    internal class AcondicionarYEmpaquetarLoteModelo
    {
        private readonly OrdenDePreparacionEntidad? orden = OrdenDePreparacionAlmacen.OrdenesDePreparacion
            .FirstOrDefault(op => op.Estado == EstadoOrdenPreparacionEnum.EnPreparacion);

        public string NumeroOrdenPreparacion => orden?.NumeroOP ?? "";
        public string Cliente => orden == null ? "" :
            ClienteAlmacen.Cliente.FirstOrDefault(c => c.CUITCliente == orden.CUITCliente)?.RazonSocial ?? orden.CUITCliente;
        public DateTime? FechaRecepcion => orden?.FechaEmision;
        public IReadOnlyList<ProductoParaEmpaquetar> Productos => orden?.Detalle.Select(d =>
            new ProductoParaEmpaquetar(d.SKU,
                ProductoAlmacen.Producto.FirstOrDefault(p => p.SKU == d.SKU)?.Descripcion ?? d.SKU,
                d.Cantidad)).ToList() ?? new List<ProductoParaEmpaquetar>();

        public bool ConfirmarLotePreparado()
        {
            if (orden == null || Productos.Count == 0)
                throw new InvalidOperationException("No hay una orden de preparación con mercadería para empaquetar.");
            if (orden.Estado != EstadoOrdenPreparacionEnum.EnPreparacion)
                throw new InvalidOperationException("El lote ya fue confirmado como preparado.");

            orden.Estado = EstadoOrdenPreparacionEnum.PendienteDespacho;
            return true;
        }
    }

    internal record ProductoParaEmpaquetar(string Sku, string Descripcion, int Cantidad);
}
