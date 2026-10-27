using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoB.Pampazon.ConsultarOrdenEntrega
{
    public partial class ConsultarOrdenEntregaForms : Form
    {
        private readonly ConsultarOrdenEntregaModelo modelo = new();

        public ConsultarOrdenEntregaForms()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            checkBox1.Checked = false;
            comboBox1.Items.Clear();
            foreach (string codigoOrden in modelo.ObtenerCodigosOrdenes(false))
            {
                comboBox1.Items.Add(codigoOrden);
            }
            comboBox1.Text = modelo.ObtenerPlaceholder();
            ActualizarListaPedidos(new List<Pedido>());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            List<string> ordenesFiltradas = modelo.ObtenerCodigosOrdenes(checkBox1.Checked);
            foreach (string codigoOrden in ordenesFiltradas)
            {
                comboBox1.Items.Add(codigoOrden);
            }
            comboBox1.Text = modelo.ObtenerPlaceholder();
            ActualizarListaPedidos(new List<Pedido>());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ordenSeleccionada = comboBox1.Text;

            if (string.IsNullOrWhiteSpace(ordenSeleccionada) || ordenSeleccionada == modelo.ObtenerPlaceholder())
            {
                MessageBox.Show(
                    "Debe seleccionar un número de orden de entrega válido.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            List<Pedido> pedidos = modelo.ObtenerPedidosPorOrden(ordenSeleccionada);
            if (pedidos.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron pedidos para la orden de entrega indicada.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            ActualizarListaPedidos(pedidos);
        }

        private void ActualizarListaPedidos(List<Pedido> pedidos)
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();
            foreach (Pedido p in pedidos)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.NumeroPedido,
                    p.FechaPedido.ToString("dd\\/MM\\/yyyy"),
                    p.Estado.ToString()
                });
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}