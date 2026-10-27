using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.ControlarMermasEIncidencias
{
    internal class ControlarMermasEIncidenciasModelo
    {
        private List<IncidenciaMerma> incidenciasEnMemoria;

        public ControlarMermasEIncidenciasModelo()
        {
            CargarIncidenciasDePrueba();
        }

        // Simula la recuperación de incidencias que están en estado "A Revisión"
        private void CargarIncidenciasDePrueba()
        {
            incidenciasEnMemoria = new List<IncidenciaMerma>
            {
                new IncidenciaMerma
                {
                    NumeroIncidencia = "INC-2026-00001",
                    FechaHora = DateTime.Now.AddHours(-3),
                    OperarioReportante = "Op. Juan Pérez (Legajo 4812)",
                    SKUAfectado = new SKUMerma { CodigoSKU = "SKU-PMP-001", Descripcion = "Lámpara LED 10W", InventarioDisponible = 150 },
                    Ubicacion = "01-12-A3",
                    Cantidad = 5,
                    CausaReportada = "Rotura / Daño Físico",
                    JustificacionOperador = "Caja caida desde el pallet durante el traslado con el apilador. Producto roto.",
                    Estado = "A Revisión",
                    DictamenSupervisor = ""
                },
                new IncidenciaMerma
                {
                    NumeroIncidencia = "INC-2026-00002",
                    FechaHora = DateTime.Now.AddHours(-1),
                    OperarioReportante = "Op. María González (Legajo 5102)",
                    SKUAfectado = new SKUMerma { CodigoSKU = "SKU-PMP-002", Descripcion = "Cuaderno Espiral A4", InventarioDisponible = 80 },
                    Ubicacion = "02-05-B1",
                    Cantidad = 2,
                    CausaReportada = "Humedad / Deterioro",
                    JustificacionOperador = "Empaque mojado por filtración cerca de la zona de recepción.",
                    Estado = "A Revisión",
                    DictamenSupervisor = ""
                }
            };
        }

        // Devuelve únicamente las incidencias pendientes de auditar
        public List<IncidenciaMerma> ObtenerIncidenciasPendientes()
        {
            return incidenciasEnMemoria.FindAll(i => i.Estado == "A Revisión");
        }

        // Lógica para Aprobar Baja Definitiva
        public void AprobarBajaDefinitiva(IncidenciaMerma incidencia, string dictamen)
        {
            incidencia.Estado = "Baja Definitiva";
            incidencia.DictamenSupervisor = dictamen;

            // La cantidad ya fue descontada del inventario disponible al registrar la incidencia,
            // por lo que al dar la baja definitiva la cantidad se descarta definitivamente.
        }

        // Lógica para Rechazar y Reintegrar al Inventario Disponible
        public void RechazarYReintegrar(IncidenciaMerma incidencia, string dictamen)
        {
            incidencia.Estado = "Rechazada";
            incidencia.DictamenSupervisor = dictamen;

            // Reintegramos las unidades que estaban en revisión al inventario disponible
            if (incidencia.SKUAfectado != null)
            {
                incidencia.SKUAfectado.InventarioDisponible += incidencia.Cantidad;
            }
        }
    }
}
