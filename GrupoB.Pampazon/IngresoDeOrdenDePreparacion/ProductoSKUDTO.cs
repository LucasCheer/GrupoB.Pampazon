namespace GrupoB.Pampazon.IngresoDeOrdenDePreparacion
{
    // DTO para representar el producto/SKU
    public class ProductoSKUDTO
    {
        public string SKU { get; set; }
        public string Descripcion { get; set; }
        public int StockDisponible { get; set; }
    }
}
