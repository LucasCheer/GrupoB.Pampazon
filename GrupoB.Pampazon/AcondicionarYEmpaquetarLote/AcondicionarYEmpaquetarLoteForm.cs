namespace GrupoB.Pampazon.AcondicionarYEmpaquetarLote
{
    public partial class AcondicionarYEmpaquetarLoteForm : Form
    {
        private readonly AcondicionarYEmpaquetarLoteModelo modelo = new();

        public AcondicionarYEmpaquetarLoteForm()
        {
            InitializeComponent();
            CargarDatosDePrueba();
        }

        private void CargarDatosDePrueba()
        {
            txtOrdenPreparacion.Text = modelo.NumeroOrdenPreparacion;
            txtCliente.Text = modelo.Cliente;
            txtFecha.Text = modelo.FechaRecepcion.ToShortDateString();
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
    }
}
