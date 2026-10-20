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
            cboTipoEmbalaje.SelectedItem = "Caja";

            lvProductos.Items.Clear();
            foreach (var producto in modelo.Productos)
            {
                var item = new ListViewItem(producto.Sku);
                item.SubItems.Add(producto.Descripcion);
                item.SubItems.Add(producto.Cantidad.ToString());
                lvProductos.Items.Add(item);
            }

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
        }

        private void lvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
