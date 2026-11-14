using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using GrupoB.Pampazon.Almacenes;

namespace GrupoB.Pampazon.ControlarMermasEIncidencias
{
    internal class ControlarMermasEIncidenciasModelo
    {
        public List<IncidenciaMerma> ObtenerIncidenciasPendientes()
        {
            var incidenciasPendientes = new List<IncidenciaMerma>();

            if (IncidenciaMermaAlmacen.IncidenciaMerma != null)
            {
                // 1. Filtrar únicamente las incidencias que están en estado ARevision
                var entidadesPendientes = IncidenciaMermaAlmacen.IncidenciaMerma
                    .Where(i => i.Estado == EstadoIncidenciaMermaEnum.ARevision).ToList();

                foreach (var entidad in entidadesPendientes)
                {
                    // 2. Buscar datos del operario reportante en OperarioAlmacen
                    var operario = OperarioAlmacen.Operario ?
                        .FirstOrDefault(o => string.Equals(o.Legajo, entidad.LegajoOperario, StringComparison.OrdinalIgnoreCase));

                    string nombreOperario = operario != null
                        ? $"Op. {operario.Nombre} {operario.Apellido} ({operario.Legajo})"
                        : $"Op. Legajo {entidad.LegajoOperario}";

                    // 3. Buscar datos del producto y calcular stock disponible en InventarioAlmacen
                    var producto = ProductoAlmacen.Producto ?
                        .FirstOrDefault(p => string.Equals(p.SKU, entidad.SKU, StringComparison.OrdinalIgnoreCase));

                    int stockDisponible = InventarioAlmacen.Inventario != null
                        ? InventarioAlmacen.Inventario
                        .Where(inv => string.Equals(inv.SKU, entidad.SKU, StringComparison.OrdinalIgnoreCase))
                        .Sum(inv => inv.CantidadDisponible) : 0;

                    string descProducto = producto != null ? producto.Descripcion : $"Producto {entidad.SKU}";

                    var skuObj = new SKUMerma
                    {
                        CodigoSKU = entidad.SKU,
                        Descripcion = $"{entidad.SKU} - {descProducto}",
                        InventarioDisponible = stockDisponible
                    };

                    // 4. Mapear a la clase de vista IncidenciaMerma que consume el Formulario
                    incidenciasPendientes.Add(new IncidenciaMerma
                    {
                        NumeroIncidencia = entidad.NumeroIncidencia,
                        FechaHora = entidad.FechaHora,
                        OperarioReportante = nombreOperario,
                        SKUAfectado = skuObj,
                        Ubicacion = entidad.CoordenadaXYZ,
                        Cantidad = entidad.CantidadAfectada,
                        CausaReportada = entidad.TipoCausa.ToString(),
                        JustificacionOperador = entidad.JustificacionTecnica,
                        Estado = "A Revisión"
                    });
                }
            }

            return incidenciasPendientes;

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

            // Buscar la entidad real en el almacén por su número correlativo de incidencia
            var entidadAlmacen = IncidenciaMermaAlmacen.IncidenciaMerma ?
                .FirstOrDefault(i => i.NumeroIncidencia == incidencia.NumeroIncidencia);

            if (entidadAlmacen != null)
            {
                // Se actualiza el estado en el almacén estático global
                entidadAlmacen.Estado = EstadoIncidenciaMermaEnum.BajaDefinitiva;
            }

            incidencia.Estado = "Baja Definitiva";
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

            // Buscar la entidad real en el almacén por su número correlativo de incidencia
            var entidadAlmacen = IncidenciaMermaAlmacen.IncidenciaMerma ?
                .FirstOrDefault(i => i.NumeroIncidencia == incidencia.NumeroIncidencia);

            if (entidadAlmacen != null)
            {
                // Se actualiza el estado en el almacén estático global
                entidadAlmacen.Estado = EstadoIncidenciaMermaEnum.Recahzada;
            }

            incidencia.Estado = "Rechazada";

        }
    }
}
