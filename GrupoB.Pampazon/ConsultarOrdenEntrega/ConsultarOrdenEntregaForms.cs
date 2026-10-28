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
            checkBoxOrdenesConPendientes.Checked = false;
            comboBoxNumeroOrdenEntrega.Items.Clear();
            foreach (string codigoOrden in modelo.ObtenerCodigosOrdenes(false))
            {
                comboBoxNumeroOrdenEntrega.Items.Add(codigoOrden);
            }
            comboBoxNumeroOrdenEntrega.Text = modelo.ObtenerPlaceholder();
            ActualizarListaPedidos(new List<Pedido>());
        }

        private void checkBoxOrdenesConPendientes_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxNumeroOrdenEntrega.Items.Clear();
            List<string> ordenesFiltradas = modelo.ObtenerCodigosOrdenes(checkBoxOrdenesConPendientes.Checked);
            foreach (string codigoOrden in ordenesFiltradas)
            {
                comboBoxNumeroOrdenEntrega.Items.Add(codigoOrden);
            }
            comboBoxNumeroOrdenEntrega.Text = modelo.ObtenerPlaceholder();
            ActualizarListaPedidos(new List<Pedido>());
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            string ordenSeleccionada = comboBoxNumeroOrdenEntrega.Text;

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
            listaPedidos.BeginUpdate();
            listaPedidos.Items.Clear();
            foreach (Pedido p in pedidos)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.NumeroPedido,
                    p.FechaPedido.ToString("dd\\/MM\\/yyyy"),
                    p.Estado.ToString()
                });
                listaPedidos.Items.Add(item);
            }
            listaPedidos.EndUpdate();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}