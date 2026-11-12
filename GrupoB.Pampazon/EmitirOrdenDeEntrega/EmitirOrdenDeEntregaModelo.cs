using GrupoB.Pampazon.Almacenes;
using GrupoB.Pampazon.EmitirOrdenDeSeleccion;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.EmitirOrdenDeEntrega
{
    internal class EmitirOrdenDeEntregaModelo
    {

        public List<OP> ops = new List<OP>();

        private readonly List<OE> ordenesEntrega = new List<OE>();
        public List<OP> ObtenerOrdenesPendientesDespacho()
        {
            // 1. Consultamos las entidades de los almacenes static
            var opEntidad = OrdenDePreparacionAlmacen.OrdenesDePreparacion;
            var clientes = ClienteAlmacen.Cliente;
            List<OP> pendientes = new List<OP>();

            foreach (var entidad in opEntidad)
            {
                // 2. Filtramos por el enum correspondiente
                if (entidad.Estado == EstadoOrdenPreparacionEnum.PendienteDespacho)
                {
                    // Buscamos el cliente que coincida con el CUIT de la orden
                    var clienteEncontrado = clientes.FirstOrDefault(c => c.CUITCliente == entidad.CUITCliente);

                    // 3. Mapeamos de OrdenDePreparacionEntidad -> OP (sin tocar la firma)
                    pendientes.Add(new OP
                    {
                        NumeroOP = entidad.NumeroOP,
                        FechaEmision = entidad.FechaSolicitada,
                        // Si lo encuentra devuelve la Razón Social; si no, muestra el CUIT como respaldo
                        RazonSocial = clienteEncontrado != null ? clienteEncontrado.RazonSocial : entidad.CUITCliente
                    });
                }
            }

            ops = pendientes;
            return pendientes;
        }

        public string EmitirOrdenDeEntrega(List<string> numerosOPSeleccionadas)
        {
            if (numerosOPSeleccionadas == null || numerosOPSeleccionadas.Count == 0)
            {
                throw new InvalidOperationException("Debe seleccionar al menos una Orden de Preparación.");
            }

            // 1. Correlativo calculado sobre el almacén real para no repetir números existentes
            int proximoNumero = OrdenDeEntregaAlmacen.OrdenesDeEntrega.Count + 1;
            string numeroOEGenerado = $"OE{proximoNumero:D3}";

            // 2. Creamos y persistimos la entidad en OrdenDeEntregaAlmacen
            var nuevaOEEntidad = new OrdenDeEntregaEntidad
            {
                NumeroOE = numeroOEGenerado,
                FechaEmision = DateTime.Now,
                Estado = "Emitida",
                // Nueva instancia de lista para evitar referencias compartidas con el Form
                OrdenesPreparacion = numerosOPSeleccionadas.Select(n => n.Trim()).ToList()
            };
            OrdenDeEntregaAlmacen.OrdenesDeEntrega.Add(nuevaOEEntidad);

            // Mantenemos actualizada la lista local del modelo (con objetos OE propios, sin referencia a la entidad)
            ordenesEntrega.Add(new OE
            {
                NumeroOE = nuevaOEEntidad.NumeroOE,
                FechaEmision = nuevaOEEntidad.FechaEmision,
                Estado = nuevaOEEntidad.Estado,
                OrdenesPreparacion = new List<string>(nuevaOEEntidad.OrdenesPreparacion)
            });

            // 3. Actualizamos el estado de las entidades reales en OrdenDePreparacionAlmacen
            foreach (var numeroOP in numerosOPSeleccionadas)
            {
                string numLimpio = numeroOP.Trim();

                var opEntidad = OrdenDePreparacionAlmacen.OrdenesDePreparacion
                    .FirstOrDefault(o => o.NumeroOP.Equals(numLimpio, StringComparison.OrdinalIgnoreCase));

                if (opEntidad != null)
                {
                    opEntidad.Estado = EstadoOrdenPreparacionEnum.EnDespacho;
                }
            }

            return numeroOEGenerado;
        }

    }
}
