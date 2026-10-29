using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.RegistrarMermasEIncidencias
{
    internal class RegistrarMermasEIncidenciasModelo
    {

        private List<SKUMerma> listaSKUs = new List<SKUMerma>
            {
                new SKUMerma { CodigoSKU = "SKU-PMP-001", Descripcion = "Lampara LED 10W", InventarioDisponible = 150 },
                new SKUMerma { CodigoSKU = "SKU-PMP-002", Descripcion = "Cuaderno Espiral A4", InventarioDisponible = 80 },
                new SKUMerma { CodigoSKU = "SKU-PMP-003", Descripcion = "Cinta de Embalaje 50m", InventarioDisponible = 200 }
            };

        public List<SKUMerma> ObtenerSKUsDePrueba()
        {
            return listaSKUs;
        }

        //Lista privada en memoria para guardar las incidencias reportadas
        private readonly List<IncidenciaMerma> listaIncidenciasRegistradas = new List<IncidenciaMerma>();

        public List<string> ObtenerSectores()
        {
            return new List<string> { "- Seleccionar Sector -", "Almacén", "Preparación", "Descarga", "Despacho" };
        }
        
        public List<string> ObtenerEtapas()
        {
            return new List<string> { "- Seleccionar Etapa -", "Almacenamiento/Estiba", "Picking", "Packing", "Recepción" };
        }

        public List<string> ObtenerTipoCausa()
        {
            return new List<string>
            {
                "- Seleccionar Causa -",
                "Aplastamiento por estiba",
                "Caída / Rotura de envase",
                "Humedad / Filtración",
                "Envoltorio dañado",
                "Faltante físico"
            };
        }

        public string GenerarNuevoNumeroIncidencia()
        {
            return $"INC-2026-0000{listaIncidenciasRegistradas.Count + 1}";
        }

        public string ObtenerFechaHoraActual()
        {
            return DateTime.Now.ToString("dd/MM/yy HH:mm");
        }

        public string ObtenerOperarioLogueado()
        {
            return "Op. Juan Pérez (Legajo 4812)";
        }

        public bool RegistrarIncidencia(IncidenciaMerma nuevaIncidencia)
        {
            // 1 Aplica la lógica sobre sus datos locales: descuenta el inventario disponible
            var skuEncontrado = listaSKUs.FirstOrDefault(s => s.CodigoSKU == nuevaIncidencia.SKU);
            if (skuEncontrado != null)
            {
                skuEncontrado.InventarioDisponible -= nuevaIncidencia.CantidadAfectada;
            }

            // 2 Guarda la incidencia en su lista local
            nuevaIncidencia.Estado = "A Revisión";
            listaIncidenciasRegistradas.Add(nuevaIncidencia);

            return true;
        }
    }
}
