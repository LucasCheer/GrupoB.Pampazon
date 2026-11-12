using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoB.Pampazon.EmitirOrdenDeEntrega
{
    public partial class EmitirOrdenDeEntregaForm : Form
    {
        private readonly EmitirOrdenDeEntregaModelo modelo = new();

        public EmitirOrdenDeEntregaForm()
        {
            InitializeComponent();
        }

        private void EmitirOrdenDeEntregaForm_Load(object sender, EventArgs e)
        {
            CargarGrillaPendientes();
        }

        private void CargarGrillaPendientes()
        {
            List<OP> ordenesPendientesDespacho = modelo.ObtenerOrdenesPendientesDespacho();
            CargarOrdenesEnListView(ordenesPendientesDespacho);
        }

        private void CargarOrdenesEnListView(List<OP> ordenesPendientesDespacho)
        {
            this.OPLIST.Items.Clear(); // Limpiamos la grilla antes de cargar

            foreach (var orden in ordenesPendientesDespacho)
            {
                ListViewItem item = new ListViewItem(orden.NumeroOP);
                item.SubItems.Add(orden.FechaEmision.ToString("dd/MM/yyyy"));

                // ASIGNACIÓN CLAVE: Se asigna el ID/Número de OP al Tag
                item.Tag = orden.NumeroOP;

                OPLIST.Items.Add(item);
            }
        }

        private void EmitirOrdenBTN_Click(object sender, EventArgs e)
        {
            if (this.OPLIST.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una Orden de Preparación de la lista.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                EmitirOrdenBTN.Enabled = false;

                List<string> numerosOPSeleccionados = new List<string>();
                foreach (ListViewItem item in this.OPLIST.SelectedItems)
                {
                    if (item.Tag != null)
                    {
                        numerosOPSeleccionados.Add(item.Tag.ToString());
                    }
                }

                // Generar la OE en el modelo
                string numeroOE = modelo.EmitirOrdenDeEntrega(numerosOPSeleccionados);

                MessageBox.Show(
                    $"La Orden de Entrega N° {numeroOE} se ha generado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Refrescar la grilla post-emisión (las OPs emitidas saldrán de la lista)
                CargarGrillaPendientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al generar la orden de entrega: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                EmitirOrdenBTN.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}