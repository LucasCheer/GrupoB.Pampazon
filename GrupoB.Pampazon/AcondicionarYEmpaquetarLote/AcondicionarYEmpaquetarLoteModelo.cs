namespace GrupoB.Pampazon.AcondicionarYEmpaquetarLote
{
    internal class AcondicionarYEmpaquetarLoteModelo
    {
        private readonly List<ProductoParaEmpaquetar> productos =
        [
            new("PROD-B", "Monitor 24 Pulgadas", 100),
            new("PROD-C", "Teclado mecánico", 40),
            new("PROD-D", "Mouse inalámbrico", 60)
        ];

        private readonly List<BultoDePrueba> bultos = [];

        public string NumeroOrdenPreparacion { get; } = "OP001";

        public string Cliente { get; } = "TechNew";

        public DateTime FechaRecepcion { get; } = DateTime.Today.AddDays(-5);

        public IReadOnlyList<ProductoParaEmpaquetar> Productos => productos;

        public IReadOnlyList<BultoDePrueba> Bultos => bultos;

        public BultoDePrueba AgregarBulto(
            ProductoParaEmpaquetar producto,
            string tipoEmbalaje,
            decimal peso)
        {
            if (!productos.Contains(producto))
            {
                throw new InvalidOperationException("El SKU ya fue empaquetado.");
            }

            var bulto = new BultoDePrueba(
                $"BUL-{bultos.Count + 1:000}",
                tipoEmbalaje,
                producto.Sku,
                producto.Cantidad,
                peso,
                "Sin generar");

            bultos.Add(bulto);
            productos.Remove(producto);

            return bulto;
        }
    }

    internal record ProductoParaEmpaquetar(string Sku, string Descripcion, int Cantidad);

    internal record BultoDePrueba(
        string Numero,
        string TipoEmbalaje,
        string Sku,
        int Cantidad,
        decimal Peso,
        string Etiqueta)
    {
        public string Productos => $"{Cantidad} × {Sku}";
    }
}
