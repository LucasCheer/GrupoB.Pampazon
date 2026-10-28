using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GrupoB.Pampazon.DespachoCargaTransporte
{
    // DTO para transportar los datos a la interfaz
    public class DespachoDTO
    {
        public string TransporteValidado { get; set; }
        public List<string> ListaCajas { get; set; } = new List<string>();
        public int TotalCajas => ListaCajas.Count;
    }

    internal class DespachoCargaTransporteModelo
    {
        private DespachoDTO despachoActual;

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

            // Datos de prueba para validar la pantalla (Pasos 4 y 5)
            if (dniLimpio == "12345678")
            {
                despachoActual = new DespachoDTO
                {
                    TransporteValidado = "Logística Rápida S.A.",
                    ListaCajas = new List<string> { "MER-1000-1", "MER-1000-2", "BLT-1001-1" }
                };
                return despachoActual;
            }
            else
            {
                // Excepción 4.2: Sin cargas asignadas
                throw new KeyNotFoundException("No se encontraron cargas asignadas para el DNI ingresado.");
            }
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

            // Pasos 10, 11, 12, 13: Registrar fecha/hora salida, cambiar estado a 'Despachado', generar remito
            return true;
        }

        public void LimpiarDatos()
        {
            despachoActual = null;
        }
    }
}