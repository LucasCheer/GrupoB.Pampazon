using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.CumplimentarOrdenDeSeleccion
{
    internal class CumplimentarOrdenDeSeleccionModelo
    {
        private readonly List<ProductoHojaRuta> productos =
        [
            new(1, "CEM-01", "Bolsa Cemento 35kg", 50, "14-10-01"),
            new(2, "CEM-02", "Bolsa Cal 25kg", 20, "12-43-02")
        ];

        private bool hojaRutaCargada;
        private bool ordenFinalizada;

        public string NumeroOrdenSeleccion { get; } = "PICK-5000";

        public string OperarioAsignado { get; } = "Juan Pérez";

        public IReadOnlyList<ProductoHojaRuta> CargarHojaRuta(string numeroOrden)
        {
            if (string.IsNullOrWhiteSpace(numeroOrden))
            {
                throw new InvalidOperationException("Debe seleccionar una orden de selección.");
            }

            if (numeroOrden != NumeroOrdenSeleccion)
            {
                throw new KeyNotFoundException("No se encontró la orden de selección indicada.");
            }

            hojaRutaCargada = true;
            return productos;
        }

        public bool FinalizarOrdenSeleccion()
        {
            if (!hojaRutaCargada)
            {
                throw new InvalidOperationException("Debe cargar la hoja de ruta antes de finalizar la orden.");
            }

            if (productos.Count == 0)
            {
                throw new InvalidOperationException("La orden de selección no contiene productos.");
            }

            if (ordenFinalizada)
            {
                throw new InvalidOperationException("La orden de selección ya fue finalizada.");
            }

            ordenFinalizada = true;
            return true;
        }
    }

    internal record ProductoHojaRuta(
        int Orden,
        string SKU,
        string Descripcion,
        int Cantidad,
        string Coordenada);
}
