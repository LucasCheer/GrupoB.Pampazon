using GrupoB.Pampazon.EmitirOrdenDeSeleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrupoB.Pampazon
{
    public partial class EmitirOrdenDeSeleccionForm : Form
    {
        private readonly EmitirOrdenDeSeleccionModelo modelo = new();

        public EmitirOrdenDeSeleccionForm()
        {
            InitializeComponent();
        }

        private void EmitirOrdenDeSeleccionForm_Load_1(object sender, EventArgs e)
        {
            this.clienteBox.DisplayMember = "RazonSocial";
            this.clienteBox.ValueMember = "ClienteId";
            this.clienteBox.DataSource = modelo.clientes;

            // Desselecciona el elemento inicial para que quede el campo en blanco
            this.clienteBox.SelectedIndex = -1;

            CargarOrdenesEnListView(modelo.ops);
        }

        private void CargarOrdenesEnListView(IEnumerable<OPs> ordenes)
        {
            this.opLIST.Items.Clear();
            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(orden.NumeroOP);
                item.SubItems.Add(orden.FechaRecibida.ToShortDateString());
                item.SubItems.Add(orden.RazonSocial);
                item.SubItems.Add(orden.ProductoSKU);
                item.SubItems.Add(orden.Cantidad.ToString());

                // Guardamos el objeto OP completo en la propiedad Tag para no perder sus datos
                item.Tag = orden;

                this.opLIST.Items.Add(item);
            }
        }

        private void limpiarBTN_Click(object sender, EventArgs e)
        {
            this.clienteBox.SelectedIndex = -1;
            CargarOrdenesEnListView(modelo.ops);
        }

        private void buscarBTN_Click(object sender, EventArgs e)
        {
            if (this.clienteBox.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente para filtrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ordenesFiltradas = modelo.ops.Where(o => o.RazonSocial == this.clienteBox.Text);
            CargarOrdenesEnListView(ordenesFiltradas);
        }

        private void agregaraOSBTN_Click(object sender, EventArgs e)
        {
            for (int i = opLIST.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem itemSeleccionado = opLIST.SelectedItems[i];

                // Recuperar la entidad OP asociada a la fila
                OPs opOriginal = itemSeleccionado.Tag as OPs;

                string op = itemSeleccionado.Text;
                string producto = itemSeleccionado.SubItems[3].Text;
                string cantidadStr = itemSeleccionado.SubItems[4].Text;

                string sku = "SKU-" + producto.Replace(" ", "").ToUpper();
                string descripcion = producto;
                string cantidad = cantidadStr;
                string ubicacion = "A-01-05";
                string opAsociada = op;

                ListViewItem itemExistente = null;
                foreach (ListViewItem itemConsolidado in osLIST.Items)
                {
                    if (itemConsolidado.Text == sku)
                    {
                        itemExistente = itemConsolidado;
                        break;
                    }
                }

                if (itemExistente != null)
                {
                    // Si el SKU ya existe en osLIST: actualizar cantidades y OPs asociadas
                    int cantidadActual = int.Parse(itemExistente.SubItems[2].Text);
                    int cantidadSumar = int.Parse(cantidad);
                    itemExistente.SubItems[2].Text = (cantidadActual + cantidadSumar).ToString();

                    string opsActuales = itemExistente.SubItems[4].Text;
                    if (!opsActuales.Contains(opAsociada))
                    {
                        itemExistente.SubItems[4].Text = opsActuales + ", " + opAsociada;
                    }

                    // Agregar la OP a la lista guardada en Tag
                    if (opOriginal != null)
                    {
                        var listaGuardada = itemExistente.Tag as List<OPs>;
                        listaGuardada?.Add(opOriginal);
                    }
                }
                else
                {
                    // Si NO existe: Crear nueva fila en osLIST
                    ListViewItem nuevoItem = new ListViewItem(sku);
                    nuevoItem.SubItems.Add(descripcion);
                    nuevoItem.SubItems.Add(cantidad);
                    nuevoItem.SubItems.Add(ubicacion);
                    nuevoItem.SubItems.Add(opAsociada);

                    // Guardamos una lista con la OP dentro del Tag de la nueva fila
                    var listaOPs = new List<OPs>();
                    if (opOriginal != null) listaOPs.Add(opOriginal);
                    nuevoItem.Tag = listaOPs;

                    osLIST.Items.Add(nuevoItem);
                }

                // 1. Remover de opLIST
                opLIST.Items.Remove(itemSeleccionado);

                // 2. Remover del modelo
                if (opOriginal != null)
                {
                    modelo.ops.Remove(opOriginal);
                }
            }
            if (this.allCHCK.Checked)
            {
                this.allCHCK.Checked = false;
            }
        }


        private void quitardeOSBTN_Click_1(object sender, EventArgs e)
        {
            if (osLIST.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un elemento del consolidado para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = osLIST.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem itemConsolidado = osLIST.SelectedItems[i];

                // Recuperar todas las OPs asociadas guardadas en Tag
                List<OPs> opsAsociadas = itemConsolidado.Tag as List<OPs>;

                if (opsAsociadas != null)
                {
                    foreach (var opRestaurar in opsAsociadas)
                    {
                        // 1. Devolver la OP al modelo
                        modelo.ops.Add(opRestaurar);
                    }
                }

                // 2. Eliminar el ítem consolidado de osLIST
                osLIST.Items.Remove(itemConsolidado);
            }

            // 3. Refrescar la lista de arriba respetando el filtro actual (si lo hay)
            if (this.clienteBox.SelectedIndex != -1 && this.clienteBox.SelectedValue != null)
            {
                var ordenesFiltradas = modelo.ops.Where(o => o.RazonSocial == this.clienteBox.Text);
                CargarOrdenesEnListView(ordenesFiltradas);
            }
            else
            {
                CargarOrdenesEnListView(modelo.ops);
            }
        }

        private void allCHCK_CheckedChanged(object sender, EventArgs e)
        {
            bool seleccionar = this.allCHCK.Checked;

            opLIST.BeginUpdate(); // Evita el parpadeo visual al seleccionar muchos ítems
            foreach (ListViewItem item in opLIST.Items)
            {
                item.Selected = seleccionar;
            }
            opLIST.EndUpdate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void generarOSBTN_Click_1(object sender, EventArgs e)
        {
            if (this.osLIST.Items.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos un producto a la orden.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2. Procesar la generación de la orden
            try
            {
                // Deshabilitar el botón temporalmente para evitar doble clic
                generarOSBTN.Enabled = false;


                MessageBox.Show(
                    "La orden de selección se ha generado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );



            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al generar la orden: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                // Volver a habilitar el botón
                generarOSBTN.Enabled = true;
            }
        }
    }
}