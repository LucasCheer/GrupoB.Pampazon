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

        private bool loteConfirmado;

        public string NumeroOrdenPreparacion { get; } = "OP001";

        public string Cliente { get; } = "TechNew";

        public DateTime FechaRecepcion { get; } = DateTime.Today.AddDays(-5);

        public IReadOnlyList<ProductoParaEmpaquetar> Productos => productos;

        public bool ConfirmarLotePreparado()
        {
            if (productos.Count == 0)
            {
                throw new InvalidOperationException("La orden de preparación no contiene mercadería para empaquetar.");
            }

            if (loteConfirmado)
            {
                throw new InvalidOperationException("El lote ya fue confirmado como preparado.");
            }

            loteConfirmado = true;
            return true;
        }
    }

    internal record ProductoParaEmpaquetar(string Sku, string Descripcion, int Cantidad);
}
