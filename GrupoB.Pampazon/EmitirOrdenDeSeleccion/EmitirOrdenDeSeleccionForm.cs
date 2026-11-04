using GrupoB.Pampazon.EmitirOrdenDeSeleccion;
using System;
using System.Collections;
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

        //Carga ordenes en la lista de ordenes pendientes al iniciar el formulario y 
        //filtro por cliente
        private void EmitirOrdenDeSeleccionForm_Load_1(object sender, EventArgs e)
        {
            this.clienteBox.DisplayMember = "RazonSocial";
            this.clienteBox.ValueMember = "ClienteId";
            this.clienteBox.DataSource = modelo.clientes;

            // Desselecciona el elemento inicial para que quede el campo en blanco
            this.clienteBox.SelectedIndex = -1;

            List<OP> ordenesPendientes = modelo.ObtenerOrdenesPendientes();
            CargarOrdenesEnListView(ordenesPendientes);
        }

        //Funcion que carga las ordenes en la lista de ordenes pendientes
        private void CargarOrdenesEnListView(List<OP> ordenes)
        {
            this.opLIST.Items.Clear();

            // 1. Guardar en un HashSet los IDs de las órdenes que YA están en la lista derecha (seleccionadas)
            HashSet<string> seleccionadas = new HashSet<string>();
            foreach (ListViewItem item in this.opselectLIST.Items)
            {
                if (item.Tag != null)
                {
                    seleccionadas.Add(item.Tag.ToString());
                }
            }

            // 2. Cargar únicamente las órdenes que NO estén ya seleccionadas
            foreach (var orden in ordenes)
            {
                if (!seleccionadas.Contains(orden.NumeroOP))
                {
                    ListViewItem item = new ListViewItem(orden.NumeroOP);
                    item.SubItems.Add(orden.FechaRecibida.ToShortDateString());
                    item.SubItems.Add(orden.RazonSocial);

                    item.Tag = orden.NumeroOP;
                    this.opLIST.Items.Add(item);
                }
            }
        }

        private void emitirOSBTN_Click(object sender, EventArgs e)
        {
            // 1. Validación: comprobar que haya OPs en la lista derecha
            if (this.opselectLIST.Items.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos una orden de preparación a la orden de selección.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                emitirOSBTN.Enabled = false;

                // 2. Extraer los IDs de las OPs en opselectLIST
                List<string> numerosOPSeleccionados = new List<string>();
                foreach (ListViewItem item in this.opselectLIST.Items)
                {
                    if (item.Tag != null)
                    {
                        numerosOPSeleccionados.Add(item.Tag.ToString());
                    }
                }

                // 3. Consolidar la OS usando tu método de LINQ
                OS nuevaOS = modelo.ConsolidarOrdenDeSeleccion(numerosOPSeleccionados);

                // 4. Guardar la OS en el modelo y actualizar los estados de las OPs
                bool guardadoExitoso = modelo.AgregarOS(nuevaOS, numerosOPSeleccionados);

                if (guardadoExitoso)
                {
                    MessageBox.Show(
                        $"La Orden de Selección N° {nuevaOS.NumeroOS} se ha generado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // 5. Limpieza de controles visuales derechos y consolidado
                    this.opselectLIST.Items.Clear();
                    this.opselectdetailsLIST.Items.Clear();
                    this.consoLIST.Items.Clear();
                    this.opDINLBLD.Text = string.Empty;

                    // 6. Recargar la lista de OPs pendientes (las OPs emitidas ya no figurarán)
                    CargarOrdenesEnListView(modelo.ObtenerOrdenesPendientes());
                }
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
                emitirOSBTN.Enabled = true;
            }
        }

        private void opLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listaActual = sender as ListView;

            // 1. Validar que la lista no sea nula y tenga al menos un elemento seleccionado
            if (listaActual == null || listaActual.SelectedItems.Count == 0)
            {
                opdetailsLIST.Items.Clear();
                this.opDINLBLI.Text = string.Empty;
                return;
            }


            // Guardar la OP seleccionada antes de modificar las selecciones
            ListViewItem itemSeleccionado = listaActual.SelectedItems[0];
            string numeroOP = itemSeleccionado.Tag.ToString();

            this.opDINLBLI.Text = numeroOP;
            // Cargar el detalle de la OP seleccionada
            CargarDetalleDeOrden(numeroOP, this.opdetailsLIST);
        }

        private void opselectLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listaActual = sender as ListView;

            // 1. Validar que la lista no sea nula y tenga al menos un elemento seleccionado
            if (listaActual == null || listaActual.SelectedItems.Count == 0)
            {
                opselectdetailsLIST.Items.Clear();
                opDINLBLD.Text = string.Empty;
                return;
            }
            // Guardar la OP seleccionada antes de modificar las selecciones
            ListViewItem itemSeleccionado = listaActual.SelectedItems[0];
            // Extraemos únicamente el ID (NumeroOP) guardado como string
            string numeroOP = itemSeleccionado.Tag.ToString();
            this.opDINLBLD.Text = numeroOP;

            // Se le pide al modelo que busque los detalles pasando solo el ID
            CargarDetalleDeOrden(numeroOP, this.opselectdetailsLIST);
        }

        private void CargarDetalleDeOrden(string numeroOP, ListView listaDestino)
        {
            listaDestino.BeginUpdate();

            try
            {
                listaDestino.Items.Clear();

                // El modelo devuelve la lista de detalles/DTOs
                var detalles = modelo.ObtenerDetallesPorOP(numeroOP);

                foreach (var detalle in detalles)
                {
                    ListViewItem item = new ListViewItem(detalle.SKU);
                    item.SubItems.Add(detalle.Descripcion);
                    item.SubItems.Add(detalle.Cantidad.ToString());
                    item.SubItems.Add(detalle.Modalidad);

                    listaDestino.Items.Add(item);
                }
            }
            finally
            {
                listaDestino.EndUpdate();
            }
        }

        private void quitarBTN_Click(object sender, EventArgs e)
        {
            // Mover de la lista derecha (oplistpendientes) a la izquierda (oplist)
            MoverElementosSeleccionados(this.opselectLIST, this.opLIST);
            // Reset total de la vista derecha
            this.opselectdetailsLIST.Items.Clear();
            this.opDINLBLD.Text = string.Empty;
            ActualizarConsolidado();
        }
        private void agregarBTN_Click(object sender, EventArgs e)
        {
            // Mover de la lista derecha (oplistpendientes) a la izquierda (oplist)
            MoverElementosSeleccionados(this.opLIST, this.opselectLIST);
            this.opdetailsLIST.Items.Clear();
            this.opDINLBLI.Text = string.Empty;
            ActualizarConsolidado();
        }



        private void MoverElementosSeleccionados(ListView origen, ListView destino)
        {
            // Validar si hay al menos un elemento seleccionado
            if (origen.SelectedItems.Count > 0)
            {

                // Recorrer de atrás hacia adelante para evitar saltos de índice al eliminar
                int i = origen.SelectedItems.Count - 1;
                while (i >= 0)
                {
                    ListViewItem itemOriginal = origen.SelectedItems[i];

                    // Clonar el ítem completo con sus subelementos (# OP, Fecha recibida, Cliente)
                    ListViewItem itemClonado = (ListViewItem)itemOriginal.Clone();

                    // Agregar al destino y quitar del origen
                    destino.Items.Add(itemClonado);
                    origen.Items.Remove(itemOriginal);

                    i = i - 1;
                }
            }
        }

        private void buscarBTN_Click_2(object sender, EventArgs e)
        {
            string cliente = clienteBox.Text;
            string numeroOP = opTX.Text.Trim();

            // El modelo resuelve la búsqueda y devuelve la lista filtrada
            var ordenesFiltradas = modelo.ObtenerOpsfiltradas(cliente, numeroOP);
            if (ordenesFiltradas.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron órdenes de preparación con los criterios seleccionados.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            opLIST.Items.Clear();

            CargarOrdenesEnListView(ordenesFiltradas);
        }

        private void agregartodasBTN_Click(object sender, EventArgs e)
        {
            if (opLIST.Items.Count == 0)
            {
                MessageBox.Show(
                    "No hay órdenes de preparación pendientes para agregar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // Seleccionar todas las órdenes de la lista izquierda
            foreach (ListViewItem item in opLIST.Items)
            {
                item.Selected = true;
            }

            // Mover todas las órdenes a la lista derecha
            MoverElementosSeleccionados(opLIST, opselectLIST);


            this.opselectdetailsLIST.Items.Clear();
            this.opDINLBLI.Text = string.Empty;
            ActualizarConsolidado();

        }

        private void limpiarBTN_Click_1(object sender, EventArgs e)
        {
            this.clienteBox.SelectedIndex = -1;
            opTX.Clear();
            CargarOrdenesEnListView(modelo.ObtenerOrdenesPendientes());
        }

        private void quitartodasBTN_Click(object sender, EventArgs e)
        {
            // 1. Validar que existan elementos para quitar en la lista derecha
            if (this.opselectLIST.Items.Count == 0)
            {
                MessageBox.Show(
                    "No hay órdenes de preparación seleccionadas para quitar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // 2. Seleccionar todos los ítems de la lista derecha (opselectLIST)
            foreach (ListViewItem item in this.opselectLIST.Items)
            {
                item.Selected = true;
            }

            // 3. Mover todos los elementos seleccionados de opselectLIST hacia opLIST
            MoverElementosSeleccionados(this.opselectLIST, this.opLIST);

            // 4. Limpiar la lista de detalles de productos para evitar incongruencias
            this.opselectdetailsLIST.Items.Clear();
            this.opDINLBLD.Text = string.Empty;
            ActualizarConsolidado();
        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void ActualizarConsolidado()
        {
            this.consoLIST.BeginUpdate();

            try
            {
                this.consoLIST.Items.Clear();

                // Extraemos los IDs de las OPs presentes en la lista derecha
                List<string> numerosOPSeleccionados = new List<string>();
                foreach (ListViewItem item in this.opselectLIST.Items)
                {
                    if (item.Tag != null)
                    {
                        numerosOPSeleccionados.Add(item.Tag.ToString());
                    }
                }

                // El modelo devuelve el objeto OS consolidado
                OS ordenSeleccion = modelo.ConsolidarOrdenDeSeleccion(numerosOPSeleccionados);

                // Poblamos consoLIST leyendo la lista Productos de la OS
                foreach (var detalle in ordenSeleccion.Productos)
                {
                    ListViewItem item = new ListViewItem(detalle.SKU);

                    // Si necesitas mostrar la descripción en la grilla, se la podés pedir al modelo por SKU
                    string descripcion = modelo.ObtenerDescripcionProducto(detalle.SKU);

                    item.SubItems.Add(descripcion);
                    item.SubItems.Add(detalle.Cantidad.ToString());
                    item.SubItems.Add(detalle.Modalidad);

                    this.consoLIST.Items.Add(item);
                }
            }
            finally
            {
                this.consoLIST.EndUpdate();
            }
        }

        private void consoLIST_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListView listaConsolidada = sender as ListView;

            if (listaConsolidada == null || listaConsolidada.SelectedItems.Count == 0)
            {
                this.opafectadasLIST.Items.Clear();
                return;
            }

            ListViewItem itemSeleccionado = listaConsolidada.SelectedItems[0];

            // SKU está en la 1ra posición (SubItems[0] o Text)
            string sku = itemSeleccionado.Text;

            // Modalidad está en SubItems[3] por el orden de creación en el código
            string modalidad = itemSeleccionado.SubItems.Count > 3 ? itemSeleccionado.SubItems[3].Text : string.Empty;

            List<string> numerosOPSeleccionados = new List<string>();
            foreach (ListViewItem item in this.opselectLIST.Items)
            {
                if (item.Tag != null)
                {
                    numerosOPSeleccionados.Add(item.Tag.ToString());
                }
            }

            // Buscamos las OPs en el modelo
            List<string> opsAfectadas = modelo.ObtenerOpsAfectadasPorProducto(numerosOPSeleccionados, sku, modalidad);

            this.opafectadasLIST.BeginUpdate();
            try
            {
                this.opafectadasLIST.Items.Clear();
                foreach (string numeroOP in opsAfectadas)
                {
                    ListViewItem itemOP = new ListViewItem(numeroOP);
                    this.opafectadasLIST.Items.Add(itemOP);
                }
            }
            finally
            {
                this.opafectadasLIST.EndUpdate();
            }
        }
    }
}
