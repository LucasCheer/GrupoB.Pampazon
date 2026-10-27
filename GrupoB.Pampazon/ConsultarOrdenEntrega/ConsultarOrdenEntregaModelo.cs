using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.ConsultarOrdenEntrega
{
    internal class ConsultarOrdenEntregaModelo
    {
        private readonly Dictionary<string, List<Pedido>> ordenesEntrega;

        public ConsultarOrdenEntregaModelo()
        {
            ordenesEntrega = new Dictionary<string, List<Pedido>>
            {
                { "OE-1000-1", ObtenerPedidosOrden1000() },
                { "OE-2000-1", ObtenerPedidosOrden2000() },
                { "OE-3000-1", ObtenerPedidosOrden3000() }
            };
        }

        public List<Pedido> ObtenerPedidosOrden1000()
        {
            return new List<Pedido>
            {
                new Pedido("OP-001", new DateOnly(2024, 6, 1), EstadoEnum.Entregado),
                new Pedido("OP-002", new DateOnly(2024, 6, 2), EstadoEnum.Pendiente),
                new Pedido("OP-003", new DateOnly(2024, 6, 3), EstadoEnum.Entregado)
            };
        }

        public List<Pedido> ObtenerPedidosOrden2000()
        {
            return new List<Pedido>
            {
                new Pedido("OP-004", new DateOnly(2024, 6, 4), EstadoEnum.Pendiente),
                new Pedido("OP-005", new DateOnly(2024, 6, 5), EstadoEnum.Entregado)
            };
        }

        public List<Pedido> ObtenerPedidosOrden3000()
        {
            return new List<Pedido>
            {
                new Pedido("OP-006", new DateOnly(2024, 6, 6), EstadoEnum.Entregado),
                new Pedido("OP-007", new DateOnly(2024, 6, 7), EstadoEnum.Entregado),
                new Pedido("OP-008", new DateOnly(2024, 6, 8), EstadoEnum.Entregado)
            };
        }

        public List<string> ObtenerCodigosOrdenes(bool soloConPendientes)
        {
            List<string> resultado = new List<string>();

            foreach (KeyValuePair<string, List<Pedido>> orden in ordenesEntrega)
            {
                if (!soloConPendientes)
                {
                    resultado.Add(orden.Key);
                    continue;
                }

                foreach (Pedido pedido in orden.Value)
                {
                    if (pedido.Estado == EstadoEnum.Pendiente)
                    {
                        resultado.Add(orden.Key);
                        break;
                    }
                }
            }

            return resultado;
        }

        public List<Pedido> ObtenerPedidosPorOrden(string codigoOrden)
        {
            if (ordenesEntrega.TryGetValue(codigoOrden, out List<Pedido>? pedidos))
            {
                return pedidos;
            }

            return new List<Pedido>();
        }

        public string ObtenerPlaceholder()
        {
            return "-----";
        }
    }
}