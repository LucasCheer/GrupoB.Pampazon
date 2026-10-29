namespace GrupoB.Pampazon.AcondicionarYEmpaquetarLote
{
    public partial class AcondicionarYEmpaquetarLoteForm : Form
    {
        private readonly AcondicionarYEmpaquetarLoteModelo modelo = new();

        public AcondicionarYEmpaquetarLoteForm()
        {
            InitializeComponent();
            btnConfirmarLote.Click += btnConfirmarLote_Click;
            btnCancelar.Click += btnCancelar_Click;
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            txtOrdenPreparacion.Text = modelo.NumeroOrdenPreparacion;
            txtCliente.Text = modelo.Cliente;
            txtFecha.Text = modelo.FechaRecepcion.ToString("dd/MM/yyyy");
            CargarProductosPendientes();
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
        }

        private void btnConfirmarLote_Click(object? sender, EventArgs e)
        {
            try
            {
                if (modelo.ConfirmarLotePreparado())
                {
                    MessageBox.Show(
                        $"El lote de la Orden de Preparación {modelo.NumeroOrdenPreparacion} fue acondicionado y empaquetado correctamente.",
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

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
