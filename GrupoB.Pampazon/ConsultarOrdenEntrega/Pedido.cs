using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.ConsultarOrdenEntrega
{
    internal class Pedido
    {
        public string NumeroPedido { get; set; }
        public DateOnly FechaPedido { get; set; }
        public EstadoEnum Estado { get; set; }

        public Pedido(string numeroPedido, DateOnly fechaPedido, EstadoEnum estado)
        {
            NumeroPedido = numeroPedido;
            FechaPedido = fechaPedido;
            Estado = estado;
        }
    }
}