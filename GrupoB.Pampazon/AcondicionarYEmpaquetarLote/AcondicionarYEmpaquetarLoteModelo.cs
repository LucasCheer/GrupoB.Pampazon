namespace GrupoB.Pampazon.AcondicionarYEmpaquetarLote
{
    internal class AcondicionarYEmpaquetarLoteModelo
    {
        public string NumeroOrdenPreparacion { get; } = "OP001";

        public string Cliente { get; } = "TechNew";

        public DateTime FechaRecepcion { get; } = DateTime.Today.AddDays(-5);

        public IReadOnlyList<ProductoParaEmpaquetar> Productos { get; } =
        [
            new("PROD-B", "Monitor 24 Pulgadas", 100)
        ];

        public IReadOnlyList<BultoDePrueba> Bultos { get; } =
        [
            new("BUL-001", "Caja", "25 × PROD-B", 20.00m, "ETQ-001"),
            new("BUL-002", "Caja", "25 × PROD-B", 20.00m, "ETQ-002"),
            new("BUL-003", "Caja", "25 × PROD-B", 20.00m, "ETQ-003"),
            new("BUL-004", "Caja", "25 × PROD-B", 20.00m, "ETQ-004")
        ];
    }

    internal record ProductoParaEmpaquetar(string Sku, string Descripcion, int Cantidad);

    internal record BultoDePrueba(
        string Numero,
        string TipoEmbalaje,
        string Productos,
        decimal Peso,
        string Etiqueta);
}
