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

            modelo = new RegistrarMermasEIncidenciasModelo();
            InicializarPantalla();
        }
        private void InicializarPantalla()
        {
            // Carga de datos de lectura y combos desde el modelo
            NumeroIncidenciaText.Text = modelo.GenerarNuevoNumeroIncidencia();
            FechaYHoraText.Text = modelo.ObtenerFechaHoraActual();
            OperarioText.Text = modelo.ObtenerOperarioLogueado();
            OperarioText.ReadOnly = true;
            NumeroIncidenciaText.ReadOnly = true;
            FechaYHoraText.ReadOnly = true;

            SectorDepositoCombo.DataSource = modelo.ObtenerSectores();
            SectorDepositoCombo.SelectedIndex = -1;

            EtapaOperativaCombo.DataSource = modelo.ObtenerEtapas();
            EtapaOperativaCombo.SelectedIndex = -1;

            TipoCausaIncidenciaCombo.DataSource = modelo.ObtenerTipoCausa();
            TipoCausaIncidenciaCombo.SelectedIndex = -1;

            SKUProductoCombo.DataSource = modelo.ObtenerSKUsDePrueba();
            SKUProductoCombo.DisplayMember = "Descripcion";
            SKUProductoCombo.ValueMember = "CodigoSKU";
            SKUProductoCombo.SelectedIndex = -1;

            LimpiarTodo();
        }

        private void SectorDepositoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sector = SectorDepositoCombo.SelectedItem?.ToString(); 
            CoordenadaText.Enabled = (sector == "Almacén"); 
            if (!CoordenadaText.Enabled)
            {
                CoordenadaText.Clear();
            }
        }

        private void ReportarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Extrae los valores directamente de los controles de pantalla
                string sector = SectorDepositoCombo.SelectedItem?.ToString(); 
                string etapa = EtapaOperativaCombo.SelectedItem?.ToString(); 
                string coordenada = CoordenadaText.Text; 
                SKUMerma skuSeleccionado = SKUProductoCombo.SelectedItem as SKUMerma; 
                string tipoCausa = TipoCausaIncidenciaCombo.SelectedItem?.ToString(); 
                string cantidadTexto = CantAfectadaText.Text; 
                string justificacion = JustificacionIncidenciaText.Text;

                string numeroIncidencia = modelo.RegistrarIncidencia(
                    sector,
                    etapa,
                    coordenada,
                    skuSeleccionado,
                    tipoCausa,
                    cantidadTexto,
                    justificacion
                );

                MessageBox.Show($"Incidencia de merma registrada con éxito en estado 'A Revisión'.\\n\\nNúmero Identificador: {numeroIncidencia}",
                    "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e) 
        { 
            this.Close(); 
        }

        private void LimpiarTodo()
        {
            SectorDepositoCombo.SelectedIndex = -1; 
            EtapaOperativaCombo.SelectedIndex = -1; 
            CoordenadaText.Clear(); 
            CoordenadaText.Enabled = false; 
            SKUProductoCombo.SelectedIndex = -1; 
            TipoCausaIncidenciaCombo.SelectedIndex = -1; 
            CantAfectadaText.Clear(); 
            JustificacionIncidenciaText.Clear();

            // Refresca el correlativo y datos del servidor
            NumeroIncidenciaText.Text = modelo.GenerarNuevoNumeroIncidencia(); 
            FechaYHoraText.Text = modelo.ObtenerFechaHoraActual();
        }
    }
}
