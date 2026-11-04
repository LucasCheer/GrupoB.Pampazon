using GrupoB.Pampazon.EmitirOrdenDeSeleccion;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeEntrega
{
    internal class EmitirOrdenDeEntregaModelo
    {

        public List<OP> ops = new List<OP>
        {
            new OP{NumeroOP = "OP001",FechaRecibida = DateTime.Now.AddDays(-5),RazonSocial = "TechNew",Estado = "Pendiente"},
            new OP{NumeroOP = "OP002",FechaRecibida = DateTime.Now.AddDays(-3),RazonSocial = "Materiales S.A.",Estado = "Pendiente"},
            new OP{NumeroOP = "OP003",FechaRecibida = DateTime.Now.AddDays(-1),RazonSocial = "Energia S.R.L",Estado = "Finalizada"},
            new OP{NumeroOP = "OP006",FechaRecibida = DateTime.Now.AddDays(-3),RazonSocial = "A S.A",Estado = "Pendiente de despacho"},
            new OP{NumeroOP = "OP010",FechaRecibida = DateTime.Now.AddDays(-3),RazonSocial = "A S.A",Estado = "Pendiente de despacho"}
        };

        private readonly List<OE> ordenesEntrega = new List<OE>();
        public List<OP> ObtenerOrdenesPendientesDespacho()
        {
            // El modelo consulta al almacén y filtra antes de entregar la lista

            List<OP> pendientes = new List<OP>();

            foreach (var orden in ops)
            {
                if (orden.Estado == "Pendiente de despacho")
                {
                    pendientes.Add(orden);
                }
            }

            return pendientes;
        }

        public string EmitirOrdenDeEntrega(List<string> numerosOPSeleccionadas)
        {
            if (numerosOPSeleccionadas == null || numerosOPSeleccionadas.Count == 0)
                throw new InvalidOperationException("Debe seleccionar al menos una Orden de Preparación.");

            // Correlativo OE001, OE002...
            int proximoNumero = ordenesEntrega.Count + 1;
            string numeroOEGenerado = $"OE{proximoNumero:D3}";

            OE nuevaOE = new OE
            {
                NumeroOE = numeroOEGenerado,
                FechaEmision = DateTime.Now,
                Estado = "Emitida",
                OrdenesPreparacion = new List<string>(numerosOPSeleccionadas)
            };

            ordenesEntrega.Add(nuevaOE);

            // Cambiar el estado de las OPs procesadas
            foreach (var numeroOP in numerosOPSeleccionadas)
            {
                var op = ops.FirstOrDefault(o => o.NumeroOP.Equals(numeroOP.Trim(), StringComparison.OrdinalIgnoreCase));
                if (op != null)
                {
                    op.Estado = "En despacho"; // Transición de estado según el flujo logístico
                }
            }

            return numeroOEGenerado;
        }

    }
}
