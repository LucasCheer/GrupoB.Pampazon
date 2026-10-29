using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoB.Pampazon.CumplimentarOrdenDeSeleccion
{
    public partial class CumplimentarOrdenDeSeleccionForm : Form
    {
        private readonly CumplimentarOrdenDeSeleccionModelo modelo = new();

        public CumplimentarOrdenDeSeleccionForm()
        {
            InitializeComponent();
            CargarHojaRutaBtn.Click += CargarHojaRutaBtn_Click;
            ProductosHojaRutaListView.SelectedIndexChanged += ProductosHojaRutaListView_SelectedIndexChanged;
            FinalizarBtn.Click += FinalizarBtn_Click;
            CancelarBtn.Click += CancelarBtn_Click;
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            OrdenSeleccionCombo.Items.Clear();
            OrdenSeleccionCombo.Items.Add(modelo.NumeroOrdenSeleccion);
            OrdenSeleccionCombo.SelectedIndex = 0;

            OperarioAsignadoText.Clear();
            ProductosHojaRutaListView.Items.Clear();
            CoordenadasListView.Items.Clear();
            FinalizarBtn.Enabled = false;
        }

        private void CargarHojaRutaBtn_Click(object? sender, EventArgs e)
        {
            try
            {
                string numeroOrden = OrdenSeleccionCombo.SelectedItem?.ToString() ?? "";
                IReadOnlyList<ProductoHojaRuta> productos = modelo.CargarHojaRuta(numeroOrden);

                OperarioAsignadoText.Text = modelo.OperarioAsignado;
                CargarProductos(productos);
                CoordenadasListView.Items.Clear();
                FinalizarBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void CargarProductos(IReadOnlyList<ProductoHojaRuta> productos)
        {
            ProductosHojaRutaListView.Items.Clear();

            foreach (ProductoHojaRuta producto in productos)
            {
                var item = new ListViewItem(producto.Orden.ToString());
                item.SubItems.Add(producto.SKU);
                item.SubItems.Add(producto.Descripcion);
                item.SubItems.Add(producto.Cantidad.ToString());
                item.Tag = producto;
                ProductosHojaRutaListView.Items.Add(item);
            }
        }

        private void ProductosHojaRutaListView_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CoordenadasListView.Items.Clear();

            if (ProductosHojaRutaListView.SelectedItems.Count == 1 &&
                ProductosHojaRutaListView.SelectedItems[0].Tag is ProductoHojaRuta producto)
            {
                CoordenadasListView.Items.Add(producto.Coordenada);
            }
        }

        private void FinalizarBtn_Click(object? sender, EventArgs e)
        {
            try
            {
                if (modelo.FinalizarOrdenSeleccion())
                {
                    MessageBox.Show(
                        $"La Orden de Selección {modelo.NumeroOrdenSeleccion} fue cumplimentada correctamente.",
                        "Operación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validación requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void CancelarBtn_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
