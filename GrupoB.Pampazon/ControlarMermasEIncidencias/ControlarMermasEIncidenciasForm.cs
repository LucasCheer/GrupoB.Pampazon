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
        private IncidenciaMerma incidenciaSeleccionada;
        public ControlarMermasEIncidenciasForm()
        {
            InitializeComponent();

            // Vinculamos los eventos a sus respectivos métodos
            this.Load += ControlarMermasEIncidenciasForm_Load;
            IncidenciasPendientesListView.SelectedIndexChanged += IncidenciasPendientesListView_SelectedIndexChanged;

            AprobarBtn.Click += AprobarBtn_Click;
            RechazarBtn.Click += RechazarBtn_Click;
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
                item.SubItems.Add(inc.SKUAfectado?.ToString());
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
                // Recuperamos el objeto guardado en la propiedad Tag
                incidenciaSeleccionada = (IncidenciaMerma)IncidenciasPendientesListView.SelectedItems[0].Tag;

                if (incidenciaSeleccionada != null)
                {
                    JustificacionOperadorText.Text = incidenciaSeleccionada.JustificacionOperador;
                    JustificacionAuditoriaText.Text = ""; // Limpia para redactar la auditoría
                }
            }
        }

        // Botón: APROBAR BAJA DEFINITIVA
        private void AprobarBtn_Click(object sender, EventArgs e)
        {
            if (incidenciaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una incidencia de la lista superior.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(JustificacionAuditoriaText.Text))
            {
                MessageBox.Show("Debe ingresar el dictamen / justificación de la auditoría.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            modelo.AprobarBajaDefinitiva(incidenciaSeleccionada, JustificacionAuditoriaText.Text.Trim());

            MessageBox.Show($"Incidencia {incidenciaSeleccionada.NumeroIncidencia} aprobada para 'Baja Definitiva'.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresca el ListView (la incidencia desaparece)
            CargarGrillaIncidencias();
        }

        // Botón: RECHAZAR / REINTEGRAR
        private void RechazarBtn_Click(object sender, EventArgs e)
        {
            if (incidenciaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una incidencia de la lista superior.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(JustificacionAuditoriaText.Text))
            {
                MessageBox.Show("Debe ingresar el dictamen o motivo de rechazo.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            modelo.RechazarYReintegrar(incidenciaSeleccionada, JustificacionAuditoriaText.Text.Trim());

            MessageBox.Show($"Incidencia {incidenciaSeleccionada.NumeroIncidencia} rechazada. Las {incidenciaSeleccionada.Cantidad} unidades se reintegraron al inventario disponible.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresca el ListView
            CargarGrillaIncidencias();
        }
        private void LimpiarCampos()
        {
            incidenciaSeleccionada = null;
            JustificacionOperadorText.Text = "";
            JustificacionAuditoriaText.Text = "";
        }
    }
}
