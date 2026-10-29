using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.ControlarMermasEIncidencias
{
    internal class ControlarMermasEIncidenciasModelo
    {
        private readonly List<IncidenciaMerma> listaIncidenciasPendientes = new List<IncidenciaMerma>
        {
            new IncidenciaMerma
            {
                NumeroIncidencia = "INC-2026-00001", 
                FechaHora = DateTime.Now, 
                OperarioReportante = "Op. Juan Pérez (Legajo 4812)", 
                SKUAfectado = new SKUMerma { CodigoSKU = "SKU-PMP-001", Descripcion = "Lámpara LED 10W", InventarioDisponible = 150 }, 
                Ubicacion = "01-12-03", Cantidad = 5, 
                CausaReportada = "Aplastamiento por estiba",
                JustificacionOperador = "Empaque mojado por filtración cerca de la zona de recepción.", 
                Estado = "A Revisión"
            },
            new IncidenciaMerma
            {
                NumeroIncidencia = "INC-2026-00002", 
                FechaHora = DateTime.Now, 
                OperarioReportante = "Op. María González (Legajo 3102)", 
                SKUAfectado = new SKUMerma { CodigoSKU = "SKU-PMP-002", Descripcion = "Cuaderno Espiral A4", InventarioDisponible = 80 }, 
                Ubicacion = "N/A", 
                Cantidad = 2, 
                CausaReportada = "Caída / Rotura de envase", 
                JustificacionOperador = "Caja caída desde el pallet durante el traslado con el apilador.", 
                Estado = "A Revisión"
            }
        };

        public List<IncidenciaMerma> ObtenerIncidenciasPendientes() 
        { 
            return listaIncidenciasPendientes; 
        }

        public void AprobarIncidencia(IncidenciaMerma incidencia, string dictamenSupervisor)
        {
            if (incidencia == null) 
            { 
                throw new InvalidOperationException("Debe seleccionar una incidencia de la lista para auditar."); 
            }

            string dictamenLimpio = dictamenSupervisor?.Trim() ?? ""; 
            if (string.IsNullOrWhiteSpace(dictamenLimpio) || dictamenLimpio.Length < 10)
            {
                throw new InvalidOperationException("Debe ingresar un dictamen / justificación de auditoría de al menos 10 caracteres.");
            }

            incidencia.Estado = "Baja Definitiva"; 
            incidencia.DictamenSupervisor = dictamenLimpio; 
            listaIncidenciasPendientes.Remove(incidencia);
        }

        public void RechazarIncidencia(IncidenciaMerma incidencia, string dictamenSupervisor)
        {
            if (incidencia == null) 
            { 
                throw new InvalidOperationException("Debe seleccionar una incidencia de la lista para auditar."); 
            }

            string dictamenLimpio = dictamenSupervisor?.Trim() ?? ""; 
            if (string.IsNullOrWhiteSpace(dictamenLimpio) || dictamenLimpio.Length < 10)
            {
                throw new InvalidOperationException("Debe ingresar un dictamen / justificación de auditoría de al menos 10 caracteres.");

            }

            incidencia.Estado = "Rechazada"; 
            incidencia.DictamenSupervisor = dictamenLimpio; 
            listaIncidenciasPendientes.Remove(incidencia);
        }
    }
}
