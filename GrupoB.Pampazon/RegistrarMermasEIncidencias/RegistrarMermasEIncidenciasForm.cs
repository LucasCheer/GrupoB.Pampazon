using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoB.Pampazon.RegistrarMermasEIncidencias
{
    public partial class RegistrarMermasEIncidenciasForm : Form
    {
        private readonly RegistrarMermasEIncidenciasModelo modelo = new();
        public RegistrarMermasEIncidenciasForm()
        {
            InitializeComponent();

            SectorDepositoCombo.SelectedIndexChanged += SectorDepositoCombo_SelectedIndexChanged;
            ReportarBtn.Click += ReportarBtn_Click;
            CancelarBtn.Click += CancelarBtn_Click;

            CargarDatosIniciales();
        }

        private void RegistrarMermasEIncidenciasForm_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            // 1. Cargar datos inmutables de cabecera
            NumeroIncidenciaText.Text = modelo.GenerarNuevoNumeroIncidencia();
            FechaYHoraText.Text = modelo.ObtenerFechaHoraActual();
            OperarioText.Text = modelo.ObtenerOperarioLogueado();

            // 2. Cargar listas desplegables
            SectorDepositoCombo.DataSource = modelo.ObtenerSectores();
            EtapaOperativaCombo.DataSource = modelo.ObtenerEtapas();
            TipoCausaIncidenciaCombo.DataSource = modelo.ObtenerTipoCausa();

            SKUProductoCombo.DataSource = modelo.ObtenerSKUsDePrueba();

            // 3. Regla inicial: Coordenada deshabilitada por defecto
            CoordenadaText.Enabled = false;
            CoordenadaText.Text = "";
            CantAfectadaText.Text = "";
            JustificacionIncidenciaText.Text = "";
        }

        // Regla: La Coordenada X-Y-Z solo se habilita si el Sector es "Almacén"
        private void SectorDepositoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sectorSeleccionado = SectorDepositoCombo.SelectedItem != null ? SectorDepositoCombo.SelectedItem.ToString() : "";

            if (sectorSeleccionado == "Almacén")
            {
                CoordenadaText.Enabled = true;
            }
            else
            {
                CoordenadaText.Enabled = false;
                CoordenadaText.Text = ""; // Se limpia al cambiar a otro sector
            }
        }

        // Actualiza el inventario disponible al cambiar de SKU
        private void SKUProductoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No requiere actualizar ningún TextBox de stock en la UI.
            // La validación contra el stock disponible se hace internamente al hacer clic en Reportar.
        }

        // Botón Principal: Validar e Ingresar Incidencia
        private void ReportarBtn_Click(object sender, EventArgs e)
        {
            if (SectorDepositoCombo.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar un sector del depósito.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (EtapaOperativaCombo.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar una etapa operativa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CoordenadaText.Enabled)
            {
                string coordenada = CoordenadaText.Text.Trim();

                if (string.IsNullOrWhiteSpace(coordenada))
                {
                    MessageBox.Show("Debe ingresar la coordenada física X-Y-Z para el sector Almacén.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Valida estrictamente el formato XX-XX-XX
                if (!System.Text.RegularExpressions.Regex.IsMatch(coordenada, @"^[A-Za-z0-9]{2}-[A-Za-z0-9]{2}-[A-Za-z0-9]{2}$"))
                {
                    MessageBox.Show("El formato de la coordenada es inválido. Debe ser estrictamente XX-XX-XX (ejemplo: 12-34-56).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (SKUProductoCombo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto SKU.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TipoCausaIncidenciaCombo.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar el tipo / causa de la incidencia.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad;
            if (!int.TryParse(CantAfectadaText.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad afectada debe ser un número entero mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SKUMerma sku = (SKUMerma)SKUProductoCombo.SelectedItem;
            if (cantidad > sku.InventarioDisponible)
            {
                MessageBox.Show($"La cantidad afectada ({cantidad}) no puede superar el stock disponible ({sku.InventarioDisponible}).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(JustificacionIncidenciaText.Text) || JustificacionIncidenciaText.Text.Trim().Length < 10)
            {
                MessageBox.Show("Debe ingresar una justificación técnica de al menos 10 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Incidencia {NumeroIncidenciaText.Text} registrada con éxito.\\nLas {cantidad} unidades del SKU {sku.CodigoSKU} han pasado a estado 'En Cuarentena'.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarDatosIniciales();
        }

        // Botón Cancelar: Cierra la ventana sin pedir confirmación
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
