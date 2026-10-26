using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GrupoB.Pampazon.RegistrarMermasEIncidencias
{
    internal class RegistrarMermasEIncidenciasModelo
    {
        public List<SKUMerma> ObtenerSKUsDePrueba()
        {
            return new List<SKUMerma>
            {
                new SKUMerma { CodigoSKU = "SKU-PMP-001", Descripcion = "Aceite de Girasol 1L", StockDisponible = 150 },
                new SKUMerma { CodigoSKU = "SKU-PMP-002", Descripcion = "Harina de Trigo 0000 1kg", StockDisponible = 80 },
                new SKUMerma { CodigoSKU = "SKU-PMP-003", Descripcion = "Fideos Tallarines 500g", StockDisponible = 200 }
            };
        }

        public List<string> ObtenerSectores()
        {
            return new List<string> { "- Seleccionar Etapa -", "Almacenamiento/Estiba", "Picking", "Packing", "Recepción" };
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
            return "INC-2026-00001";
        }

        public string ObtenerFechaHoraActual()
        {
            return DateTime.Now.ToString("dd/MM/yy HH:mm");
        }

        public string ObtenerOperarioLogueado()
        {
            return "Op. Juan Pérez (Legajo 4812)";
        }
    }
}
