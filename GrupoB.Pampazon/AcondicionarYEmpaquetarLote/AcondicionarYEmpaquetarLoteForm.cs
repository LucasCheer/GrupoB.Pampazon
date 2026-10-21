namespace GrupoB.Pampazon.AcondicionarYEmpaquetarLote
{
    public partial class AcondicionarYEmpaquetarLoteForm : Form
    {
        private readonly AcondicionarYEmpaquetarLoteModelo modelo = new();

        public AcondicionarYEmpaquetarLoteForm()
        {
            InitializeComponent();
            btnAgregarBulto.Click += btnAgregarBulto_Click;
            CargarDatosDePrueba();
        }

        private void CargarDatosDePrueba()
        {
            txtOrdenPreparacion.Text = modelo.NumeroOrdenPreparacion;
            txtCliente.Text = modelo.Cliente;
            txtFecha.Text = modelo.FechaRecepcion.ToShortDateString();
            cboTipoEmbalaje.SelectedItem = "Caja";

            CargarProductosPendientes();
            CargarBultos();
        }

        private void CargarProductosPendientes()
        {
            lvProductos.Items.Clear();
            foreach (var producto in modelo.Productos)
            {
                var item = new ListViewItem(producto.Sku);
                item.SubItems.Add(producto.Descripcion);
                item.SubItems.Add(producto.Cantidad.ToString());
                item.Tag = producto;
                lvProductos.Items.Add(item);
            }

            btnAgregarBulto.Enabled = false;
        }

        private void CargarBultos()
        {
            lvBultos.Items.Clear();
            foreach (var bulto in modelo.Bultos)
            {
                var item = new ListViewItem(bulto.Numero);
                item.SubItems.Add(bulto.TipoEmbalaje);
                item.SubItems.Add(bulto.Productos);
                item.SubItems.Add($"{bulto.Peso:0.00} kg");
                item.SubItems.Add(bulto.Etiqueta);
                lvBultos.Items.Add(item);
            }

            btnConfirmarLote.Enabled = modelo.Productos.Count == 0 && modelo.Bultos.Count > 0;
        }

        private void lvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAgregarBulto.Enabled = lvProductos.SelectedItems.Count == 1;
        }

        private void btnAgregarBulto_Click(object? sender, EventArgs e)
        {
            if (lvProductos.SelectedItems.Count != 1 ||
                lvProductos.SelectedItems[0].Tag is not ProductoParaEmpaquetar producto)
            {
                MessageBox.Show(
                    "Seleccione un SKU para agregar al bulto.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cboTipoEmbalaje.SelectedItem is not string tipoEmbalaje)
            {
                MessageBox.Show(
                    "Seleccione un tipo de embalaje.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (nudPeso.Value <= 0)
            {
                MessageBox.Show(
                    "El peso debe ser mayor que cero.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            modelo.AgregarBulto(producto, tipoEmbalaje, nudPeso.Value);

            CargarProductosPendientes();
            CargarBultos();

            MessageBox.Show(
                $"Se agregó todo el SKU {producto.Sku} al bulto.",
                "Bulto agregado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
