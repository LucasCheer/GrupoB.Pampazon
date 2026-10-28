using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GrupoB.Pampazon.IngresoDeOrdenDePreparacion
{
    public partial class IngresoDeOrdenDePreparacionForm : Form
    {
        private IngresoDeOrdenDePreparacionModelo modelo;

        public IngresoDeOrdenDePreparacionForm()
        {
            InitializeComponent();
            modelo = new IngresoDeOrdenDePreparacionModelo();
            InicializarPantalla();
        }

        private void InicializarPantalla()
        {
            // Paso 2: Cargar fecha actual por defecto en Fecha Solicitada
            FechaSolicitadaDateTimePicker.Value = DateTime.Now;
            CantDisponibleText.ReadOnly = true;

            // Cargar modalidades (Fulfillment, Palet Cerrado, Consolidado)
            ModalidadCombo.Items.Clear();
            ModalidadCombo.Items.Add("Fulfillment");
            ModalidadCombo.Items.Add("Palet Cerrado");
            ModalidadCombo.Items.Add("Consolidado");

            // Cargar Lista de Clientes Activos (Paso 3)
            ClienteCombo.DataSource = modelo.ObtenerClientesActivos();
            ClienteCombo.SelectedIndex = -1;

            LimpiarSeccionProducto();
            ActualizarGrillaDetalle();
        }

        private void ClienteCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClienteCombo.SelectedItem != null)
            {
                string clienteSeleccionado = ClienteCombo.SelectedItem.ToString();
                List<ProductoSKUDTO> skus = modelo.ObtenerSKUsPorCliente(clienteSeleccionado);

                SKUCombo.DataSource = null;
                SKUCombo.DataSource = skus;
                SKUCombo.DisplayMember = "SKU";
                SKUCombo.ValueMember = "SKU";
                SKUCombo.SelectedIndex = -1;

                // Completa el CUIT del cliente seleccionado
                CUITClienteText.Text = modelo.ObtenerCuitPorCliente(clienteSeleccionado);

                CantDisponibleText.Clear();
            }
            else
            {
                // Sin cliente seleccionado: no deben quedar SKUs ni CUIT de otro cliente
                SKUCombo.DataSource = null;
                CUITClienteText.Clear();
                CantDisponibleText.Clear();
            }
        }

        private void SKUCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SKUCombo.SelectedItem is ProductoSKUDTO producto)
            {
                // Paso 8: Muestra Cantidad Disponible en racks
                CantDisponibleText.Text = producto.StockDisponible.ToString();
            }
            else
            {
                CantDisponibleText.Clear();
            }
        }

        // Evento del botón 'Agregar a la Orden' (AgregarALaOrdenBtn)
        private void AgregarALaOrdenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoSKUDTO productoSeleccionado = SKUCombo.SelectedItem as ProductoSKUDTO;
                string cantidadTexto = CantAPedirText.Text;
                string modalidad = ModalidadCombo.SelectedItem?.ToString();

                // Validar y agregar al modelo (Pasos 11 y 12)
                modelo.AgregarProductoDetalle(productoSeleccionado, cantidadTexto, modalidad);

                // Paso 12: Actualizar ListView y limpiar sección de producto
                ActualizarGrillaDetalle();
                LimpiarSeccionProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento del botón 'Quitar'
        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            if (DetallesDeProductosListView.SelectedIndices.Count > 0)
            {
                int index = DetallesDeProductosListView.SelectedIndices[0];
                modelo.QuitarProductoDetalle(index);
                ActualizarGrillaDetalle();
            }
            else
            {
                MessageBox.Show("Seleccione una línea del detalle para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Evento del botón 'Ingresar Orden de Preparación' (IngresarOPBtn)
        private void IngresarOPBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = ClienteCombo.SelectedItem?.ToString();
                string cuit = CUITClienteText.Text;
                string transporte = TransporteText.Text;
                string dniTransportista = DNITransportistaText.Text;

                // Pasos 14, 15 y 16
                string numeroOP = modelo.RegistrarOrdenPreparacion(cliente, cuit, transporte, dniTransportista);

                MessageBox.Show(
                    $"Orden de Preparación registrada con éxito en estado 'Pendiente'.\n\nNúmero Identificador: {numeroOP}",
                    "Operación Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Limpiar pantalla completa
                LimpiarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento del botón 'Cancelar'
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarGrillaDetalle()
        {
            DetallesDeProductosListView.Items.Clear();
            foreach (var item in modelo.DetalleProductos)
            {
                ListViewItem lvi = new ListViewItem(item.SKU);
                lvi.SubItems.Add(item.Descripcion);
                lvi.SubItems.Add(item.CantidadPedida.ToString());
                lvi.SubItems.Add(item.Modalidad);
                DetallesDeProductosListView.Items.Add(lvi);
            }
        }

        private void LimpiarSeccionProducto()
        {
            SKUCombo.SelectedIndex = -1;
            CantDisponibleText.Clear();
            CantAPedirText.Clear();
            ModalidadCombo.SelectedIndex = -1;
        }

        private void LimpiarTodo()
        {
            ClienteCombo.SelectedIndex = -1;
            CUITClienteText.Clear();
            TransporteText.Clear();
            DNITransportistaText.Clear();
            FechaSolicitadaDateTimePicker.Value = DateTime.Now;
            LimpiarSeccionProducto();
            modelo.LimpiarTodo();
            ActualizarGrillaDetalle();
        }
    }
}