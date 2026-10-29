using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoB.Pampazon.ControlarMermasEIncidencias
{
    public partial class ControlarMermasEIncidenciasForm : Form
    {
        private readonly ControlarMermasEIncidenciasModelo modelo = new();
        
        public ControlarMermasEIncidenciasForm()
        {
            InitializeComponent();
            modelo = new ControlarMermasEIncidenciasModelo();

            CargarGrillaIncidencias();
        }

        private void ControlarMermasEIncidenciasForm_Load(object sender, EventArgs e)
        {
            CargarGrillaIncidencias();
        }

        // Carga el ListView recorriendo la lista e insertando cada elemento
        private void CargarGrillaIncidencias()
        {
            IncidenciasPendientesListView.Items.Clear();
            var lista = modelo.ObtenerIncidenciasPendientes();

            foreach (var inc in lista)
            {
                var item = new ListViewItem(inc.NumeroIncidencia);
                item.SubItems.Add(inc.FechaHora.ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add(inc.OperarioReportante);
                item.SubItems.Add(inc.SKUAfectado != null ? $"{inc.SKUAfectado.CodigoSKU} - {inc.SKUAfectado.Descripcion}" : "");
                item.SubItems.Add(inc.Ubicacion);
                item.SubItems.Add(inc.Cantidad.ToString());
                item.SubItems.Add(inc.CausaReportada);

                // Guardamos el objeto completo en Tag para recuperarlo al hacer clic
                item.Tag = inc;
                IncidenciasPendientesListView.Items.Add(item);
            }

            LimpiarCampos();
        }

        // Evento SelectedIndexChanged del ListView
        private void IncidenciasPendientesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IncidenciasPendientesListView.SelectedItems.Count > 0)
            {
                var inc = IncidenciasPendientesListView.SelectedItems[0].Tag as IncidenciaMerma; 
                if (inc != null)
                {
                    JustificacionOperadorText.Text = inc.JustificacionOperador;
                }
            }
            else
            {
                JustificacionOperadorText.Clear();
            }
        }

        // Botón: APROBAR BAJA DEFINITIVA
        private void AprobarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IncidenciaMerma incidenciaSeleccionada = null; 
                if (IncidenciasPendientesListView.SelectedItems.Count > 0)
                {
                    incidenciaSeleccionada = IncidenciasPendientesListView.SelectedItems[0].Tag as IncidenciaMerma;
                }

                string dictamen = JustificacionAuditoriaText.Text; 

                modelo.AprobarIncidencia(incidenciaSeleccionada, dictamen); 

                MessageBox.Show($"Incidencia {incidenciaSeleccionada.NumeroIncidencia} aprobada con éxito para Baja Definitiva.",
                    "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrillaIncidencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón: RECHAZAR / REINTEGRAR
        private void RechazarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IncidenciaMerma incidenciaSeleccionada = null; 
                if (IncidenciasPendientesListView.SelectedItems.Count > 0)
                {
                    incidenciaSeleccionada = IncidenciasPendientesListView.SelectedItems[0].Tag as IncidenciaMerma;
                }

                string dictamen = JustificacionAuditoriaText.Text; 

                modelo.RechazarIncidencia(incidenciaSeleccionada, dictamen); 
                
                MessageBox.Show($"Incidencia {incidenciaSeleccionada.NumeroIncidencia} rechazada.",
                    "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrillaIncidencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimpiarCampos()
        {
            JustificacionOperadorText.Text = "";
            JustificacionAuditoriaText.Text = "";
        }
    }
}
