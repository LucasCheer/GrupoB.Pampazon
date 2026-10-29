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
}
