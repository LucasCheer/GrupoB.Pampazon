using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using GrupoB.Pampazon.Almacenes;

namespace GrupoB.Pampazon.RegistrarMermasEIncidencias
{
    internal class RegistrarMermasEIncidenciasModelo
    {

        // Atributos de datos locales (Hardcodeados para el prototipo)
        private List<SKUMerma> listaSKUs = new List<SKUMerma>();
        private readonly List<IncidenciaMerma> listaIncidenciasRegistradas = new List<IncidenciaMerma>();

        public RegistrarMermasEIncidenciasModelo() 
        { 
            CargarSKUsDesdeAlmacen(); 
        }

        private void CargarSKUsDesdeAlmacen()
        {
            // Se conecta con InventarioAlmacen.Inventario sin hardcodeo
            if (InventarioAlmacen.Inventario != null)
            {
                listaSKUs = InventarioAlmacen.Inventario
                    .GroupBy(i => i.SKU)
                    .Select(g => new SKUMerma
                    {
                        CodigoSKU = g.Key,
                        Descripcion = $"Producto {g.Key}",
                        InventarioDisponible = g.Sum(x => x.CantidadDisponible)
                    })
                    .ToList();
            }
        }

        public List<SKUMerma> ObtenerSKUsDePrueba() => listaSKUs;

        public List<string> ObtenerSectores()
        {
            var sectores = new List<string> { "- Seleccionar Sector -" };
            sectores.AddRange(Enum.GetNames(typeof(SectorIncidenciaEnum))); 
            return sectores;
        }

        public List<string> ObtenerEtapas()
        {
            var etapas = new List<string> { "- Seleccionar Etapa -" };
            etapas.AddRange(Enum.GetNames(typeof(EtapaOperativaIncidenciaEnum))); 
            return etapas;
        }

        public List<string> ObtenerTipoCausa()
        {
            var causas = new List<string> { "- Seleccionar Causa -" };
            causas.AddRange(Enum.GetNames(typeof(TipoCausaIncidenciaEnum))); 
            return causas;
        }

        public string GenerarNuevoNumeroIncidencia()
        {
            int proximoNumero = (IncidenciaMermaAlmacen.IncidenciaMerma?.Count ?? listaIncidenciasRegistradas.Count) + 1;
            return $"INC-2026-{proximoNumero:D5}";
        }

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
            if (string.IsNullOrWhiteSpace(sector) || sector.StartsWith("-") || !Enum.TryParse<SectorIncidenciaEnum>(sector, true, out var sectorEnum))
            {
                throw new InvalidOperationException("Debe seleccionar un Sector del Depósito.");
            }

            // Excepción 5.2: Etapa operativa obligatoria
            if (string.IsNullOrWhiteSpace(etapa) || etapa.StartsWith("-") || !Enum.TryParse<EtapaOperativaIncidenciaEnum>(etapa, true, out var etapaEnum))
            {
                throw new InvalidOperationException("Debe seleccionar la Etapa Operativa.");
            }

            // Excepción 5.3: Coordenada en Almacén debe tener el formato estricto 'A-XX-XX' (ej: A-01-02)
            if (sectorEnum == SectorIncidenciaEnum.Almacen)
            {
                // Limpiamos espacios en blanco externos e internos que pueda enviar el control de WinForms
                string coordenadaLimpia = (coordenada ?? "").Trim().Replace("_", "").Replace(" ", "");

                if (!Regex.IsMatch(coordenadaLimpia, @"^[a-zA-Z]-\d{2}-\d{2}$"))
                {
                    throw new FormatException("La coordenada física debe tener el formato estricto 'A-XX-XX' (ejemplo: A-01-02).");
                }
            }

            // Excepción 5.4: SKU obligatorio
            if (skuSeleccionado == null) 
            { 
                throw new InvalidOperationException("Debe seleccionar un SKU / Producto."); 
            }

            // Excepción 5.5: Causa obligatoria
            if (string.IsNullOrWhiteSpace(tipoCausa) || tipoCausa.StartsWith("-") || !Enum.TryParse<TipoCausaIncidenciaEnum>(tipoCausa, true, out var tipoCausaEnum)) 
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
            //skuEncontrado.InventarioDisponible -= cantidad;

            // 2 Genera el correlativo y mapea hacia la entidad de Almacenes
            string numeroIncidencia = GenerarNuevoNumeroIncidencia();

            // Instanciamos la entidad oficial usando las variables Enum ya validadas arriba
            var nuevaIncidenciaEntidad = new IncidenciaMermaEntidad
            {
                NumeroIncidencia = numeroIncidencia,
                FechaHora = DateTime.Now,
                LegajoOperario = "LEG-101",
                Sector = sectorEnum,
                EtapaOperativa = etapaEnum,
                CoordenadaXYZ = (sectorEnum == SectorIncidenciaEnum.Almacen)
                                ? (coordenada ?? "").Trim().Replace("_", "").Replace(" ", "")
                                : "N/A",
                SKU = skuEncontrado.CodigoSKU,
                TipoCausa = tipoCausaEnum,
                CantidadAfectada = cantidad,
                JustificacionTecnica = justificacionLimpia,
                Estado = EstadoIncidenciaMermaEnum.ARevision
            };

            // Agregamos únicamente a la lista estática del almacén en memoria
            if (IncidenciaMermaAlmacen.IncidenciaMerma != null) 
            { 
                IncidenciaMermaAlmacen.IncidenciaMerma.Add(nuevaIncidenciaEntidad); 
            }

            return numeroIncidencia;
        }
    }
}
