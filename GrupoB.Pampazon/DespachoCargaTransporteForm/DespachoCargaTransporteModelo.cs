using GrupoB.Pampazon.Almacenes;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GrupoB.Pampazon.DespachoCargaTransporte
{
    internal class DespachoCargaTransporteModelo
    {
        private DespachoDTO despachoActual;

        // Números de las OP que se van a despachar con el transportista consultado
        private List<string> opsADespachar = new List<string>();

        // Constructor sin parámetros para instanciarse correctamente desde el Form
        public DespachoCargaTransporteModelo()
        {
            despachoActual = null;
        }

        /// <summary>
        /// Valida y consulta las cargas asignadas para el DNI del transportista.
        /// Pasos 3, 4 y 5 del Caso de Uso, e implementa excepciones 3.1, 4.1 y 4.2.
        /// </summary>
        public DespachoDTO ConsultarCargas(string dni)
        {
            // Excepción 3.1: DNI en blanco
            if (string.IsNullOrWhiteSpace(dni))
            {
                throw new ArgumentException("Debe ingresar el DNI...");
            }

            // Excepción 4.1: Formato de DNI inválido
            string dniLimpio = dni.Replace("-", "").Trim();
            if (!Regex.IsMatch(dniLimpio, @"^\d{8}$"))
            {
                throw new FormatException("El DNI ingresado no posee un formato válido. Debe contener 8 dígitos numéricos.");
            }

            // Pasos 4 y 5: OP del almacén asignadas a ese transportista que ya tienen Orden de Entrega emitida
            var opsDelTransportista = OrdenDePreparacionAlmacen.OrdenesDePreparacion
                .Where(op => op.DNITransportista == dniLimpio && op.Estado == EstadoOrdenPreparacionEnum.EnDespacho)
                .ToList();

            // Excepción 4.2: Sin cargas asignadas
            if (opsDelTransportista.Count == 0)
            {
                throw new KeyNotFoundException("No se encontraron cargas asignadas para el DNI ingresado.");
            }

            // Cada renglón del detalle de la OP es un bulto a subir al transporte
            List<string> cajas = new List<string>();
            foreach (var op in opsDelTransportista)
            {
                foreach (var detalle in op.Detalle)
                {
                    cajas.Add($"{op.NumeroOP} | {detalle.SKU} x{detalle.CantidadPedida} ({detalle.Modalidad})");
                }
            }

            opsADespachar = opsDelTransportista.Select(op => op.NumeroOP).ToList();

            despachoActual = new DespachoDTO
            {
                TransporteValidado = opsDelTransportista[0].NombreEmpresa,
                ListaCajas = cajas
            };
            return despachoActual;
        }

        /// <summary>
        /// Registra la carga física, actualiza estados y genera remito.
        /// Pasos 8 al 14 del Caso de Uso, e implementa excepción 9.1.
        /// </summary>
        public bool RegistrarCarga(bool cajasEntregadas)
        {
            // Excepción 9.1: Casilla no marcada
            if (!cajasEntregadas)
            {
                throw new InvalidOperationException("Debe marcar la casilla de confirmación antes de registrar la carga.");
            }

            if (despachoActual == null)
            {
                throw new InvalidOperationException("No hay datos de carga consultados previamente para registrar.");
            }

            // Pasos 10 a 12: las OP cargadas pasan a 'Finalizada' en OrdenDePreparacionAlmacen
            foreach (var numeroOP in opsADespachar)
            {
                var opEntidad = OrdenDePreparacionAlmacen.OrdenesDePreparacion
                    .FirstOrDefault(o => o.NumeroOP == numeroOP);

                if (opEntidad != null)
                {
                    opEntidad.Estado = EstadoOrdenPreparacionEnum.Finalizada;
                }
            }

            // Las Órdenes de Entrega emitidas cuyas OP ya se despacharon todas pasan a 'Finalizada'
            foreach (var oe in OrdenDeEntregaAlmacen.OrdenesDeEntrega
                .Where(oe => oe.Estado == EstadoOrdenEntregaEnum.Emitida && oe.OrdenesPreparacion.Any(n => opsADespachar.Contains(n))))
            {
                bool todasDespachadas = oe.OrdenesPreparacion.All(n =>
                    OrdenDePreparacionAlmacen.OrdenesDePreparacion
                        .Any(o => o.NumeroOP == n && o.Estado == EstadoOrdenPreparacionEnum.Finalizada));

                if (todasDespachadas)
                {
                    oe.Estado = EstadoOrdenEntregaEnum.Finalizada;
                }
            }

            return true;
        }

        public void LimpiarDatos()
        {
            despachoActual = null;
            opsADespachar.Clear();
        }
    }
}