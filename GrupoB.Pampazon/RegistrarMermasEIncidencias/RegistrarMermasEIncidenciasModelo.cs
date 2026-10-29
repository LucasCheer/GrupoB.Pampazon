using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GrupoB.Pampazon.RegistrarMermasEIncidencias
{
    internal class RegistrarMermasEIncidenciasModelo
    {

        // Atributos de datos locales (Hardcodeados para el prototipo)
        private List<SKUMerma> listaSKUs = new List<SKUMerma>
        {
            new SKUMerma { CodigoSKU = "SKU-PMP-001", Descripcion = "Lampara LED 10W", InventarioDisponible = 150 },
            new SKUMerma { CodigoSKU = "SKU-PMP-002", Descripcion = "Cuaderno Espiral A4", InventarioDisponible = 80 },
            new SKUMerma { CodigoSKU = "SKU-PMP-003", Descripcion = "Cinta de Embalaje 50m", InventarioDisponible = 200 }
        };

        private readonly List<IncidenciaMerma> listaIncidenciasRegistradas = new List<IncidenciaMerma>();

        // Métodos que alimentan los combos y campos iniciales de la pantalla
        public List<SKUMerma> ObtenerSKUsDePrueba() => listaSKUs;
        public List<string> ObtenerSectores() => new List<string> { "- Seleccionar Sector -", "Almacén", "Picking", "Packing", "Recepción" };
        public List<string> ObtenerEtapas() => new List<string> { "- Seleccionar Etapa -", "Almacenamiento/Estiba", "Picking", "Packing", "Recepción" };
        public List<string> ObtenerTipoCausa() => new List<string> { "- Seleccionar Causa -", "Aplastamiento por estiba", "Caída / Rotura de envase", "Humedad / Filtración", "Envoltorio dañado", "Faltante físico" };

        public string GenerarNuevoNumeroIncidencia() => $"INC-2026-0000{listaIncidenciasRegistradas.Count + 1}";
        public string ObtenerFechaHoraActual() => DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        public string ObtenerOperarioLogueado() => "Op. Juan Pérez (Legajo 4812)";

        // Recibe los datos brutos de la pantalla, ejecuta las validaciones de negocio

        public string RegistrarIncidencia(
            string sector,
            string etapa,
            string coordenada,
            SKUMerma skuSeleccionado,
            string tipoCausa,
            string cantidadTexto,
            string justificacion)
        {
            // Excepción 5.1: Sector obligatorio
            if (string.IsNullOrWhiteSpace(sector) || sector.StartsWith("-"))
            {
                throw new InvalidOperationException("Debe seleccionar un Sector del Depósito.");
            }

            // Excepción 5.2: Etapa operativa obligatoria
            if (string.IsNullOrWhiteSpace(etapa) || etapa.StartsWith("-"))
            {
                throw new InvalidOperationException("Debe seleccionar la Etapa Operativa.");
            }

            // Excepción 5.3: Coordenada en Almacén debe ser numérica XX-XX-XX if (sector == "Almacén")
            if (sector != null && sector.StartsWith("Almacén", StringComparison.OrdinalIgnoreCase))
            {
                // Limpiamos espacios en blanco externos e internos que pueda enviar el control de WinForms
                string coordenadaLimpia = coordenada?.Trim().Replace(" ", "") ?? "";

                if (!Regex.IsMatch(coordenadaLimpia, @"^\\d{2}-\\d{2}-\\d{2}$"))
                {
                    throw new FormatException("La coordenada física debe ser estrictamente numérica con formato 'XX-XX-XX' (ej: 01-12-03).");
                }
            }

            // Excepción 5.4: SKU obligatorio
            if (skuSeleccionado == null) 
            { 
                throw new InvalidOperationException("Debe seleccionar un SKU / Producto."); 
            }

            // Excepción 5.5: Causa obligatoria
            if (string.IsNullOrWhiteSpace(tipoCausa) || tipoCausa.StartsWith("-")) 
            { 
                throw new InvalidOperationException("Debe seleccionar el Tipo / Causa de la Incidencia."); 
            }

            // Excepción 5.6: Cantidad entera positiva
            if (!int.TryParse(cantidadTexto?.Trim(), out int cantidad) || cantidad <= 0) 
            { 
                throw new FormatException("Debe ingresar un número entero positivo para la cantidad afectada."); 
            }

            // Excepción 5.7: Existencia de SKU y suficiencia en inventario
            var skuEncontrado = listaSKUs.FirstOrDefault(s => s.CodigoSKU == skuSeleccionado.CodigoSKU);
            if (skuEncontrado == null) 
            { 
                throw new InvalidOperationException("El SKU seleccionado no existe en el catálogo."); 
            }

            if (cantidad > skuEncontrado.InventarioDisponible) 
            { 
                throw new InvalidOperationException($"La cantidad afectada ({cantidad}) supera el inventario disponible ({skuEncontrado.InventarioDisponible})."); 
            }

            // Excepción 5.8: Longitud mínima de la justificación técnica
            string justificacionLimpia = justificacion?.Trim() ?? "";
            if (string.IsNullOrWhiteSpace(justificacionLimpia) || justificacionLimpia.Length < 10) 
            { 
                throw new InvalidOperationException("Debe ingresar una justificación técnica de al menos 10 caracteres."); 
            }

            // 1 Descuenta el inventario disponible
            skuEncontrado.InventarioDisponible -= cantidad;

            // 2 Crea y guarda la entidad de la incidencia
            string numeroIncidencia = GenerarNuevoNumeroIncidencia();
            IncidenciaMerma nuevaIncidencia = new IncidenciaMerma
            {
                NumeroIncidencia = numeroIncidencia,
                FechaHora = ObtenerFechaHoraActual(),
                OperarioResponsable = ObtenerOperarioLogueado(),
                Sector = sector,
                EtapaOperativa = etapa,
                CoordenadaXYZ = (sector == "Almacén") ? coordenada.Trim() : "N/A",
                SKU = skuEncontrado.CodigoSKU,
                TipoCausa = tipoCausa,
                CantidadAfectada = cantidad,
                JustificacionTecnica = justificacionLimpia,
                Estado = "A Revisión"
            };

            listaIncidenciasRegistradas.Add(nuevaIncidencia);
            
            return numeroIncidencia;
        }
    }
}
