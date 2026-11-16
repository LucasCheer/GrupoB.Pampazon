using GrupoB.Pampazon.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrupoB.Pampazon.ConsultarOrdenEntrega
{
    internal class ConsultarOrdenEntregaModelo
    {
        private readonly Dictionary<string, List<Pedido>> ordenesEntrega;

        public ConsultarOrdenEntregaModelo()
        {
            ordenesEntrega = new Dictionary<string, List<Pedido>>();

            if (OrdenDeEntregaAlmacen.OrdenesDeEntrega != null)
            {
                var opsAlmacen = OrdenDePreparacionAlmacen.OrdenesDePreparacion ?? new List<OrdenDePreparacionEntidad>();

                foreach (var oeEntidad in OrdenDeEntregaAlmacen.OrdenesDeEntrega)
                {
                    List<Pedido> pedidosDeLaOE = new List<Pedido>();

                    if (oeEntidad.OrdenesPreparacion != null)
                    {
                        foreach (string numeroOP in oeEntidad.OrdenesPreparacion)
                        {
                            string numLimpio = numeroOP.Trim();

                            var opEntidad = opsAlmacen.FirstOrDefault(o =>
                                o.NumeroOP.Equals(numLimpio, StringComparison.OrdinalIgnoreCase));

                            DateOnly fechaPedido = opEntidad != null
                                ? DateOnly.FromDateTime(opEntidad.FechaEmision)
                                : DateOnly.FromDateTime(oeEntidad.FechaEmision);

                            bool estaEntregado = oeEntidad.Estado == EstadoOrdenEntregaEnum.Finalizada
                                                 || (opEntidad != null && (int)opEntidad.Estado > (int)EstadoOrdenPreparacionEnum.EnDespacho);

                            EstadoEnum estadoPedido = estaEntregado
                                ? EstadoEnum.Entregado
                                : EstadoEnum.Pendiente;

                            string codigoPedido = opEntidad != null ? opEntidad.NumeroOP : numLimpio;

                            pedidosDeLaOE.Add(new Pedido(codigoPedido, fechaPedido, estadoPedido));
                        }
                    }

                    ordenesEntrega[oeEntidad.NumeroOE] = pedidosDeLaOE;
                }
            }
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
            if (!string.IsNullOrEmpty(codigoOrden) && ordenesEntrega.TryGetValue(codigoOrden, out List<Pedido>? pedidos))
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


