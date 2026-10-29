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

            CargarOrdenesEnListView(modelo.ops);
        }

        //Funcion que carga las ordenes en la lista de ordenes pendientes
        private void CargarOrdenesEnListView(List<OP> ordenes)
        {
            this.opLIST.Items.Clear();
            foreach (var orden in ordenes)
            {
                if (orden.Estado == "Pendiente")
                {
                    ListViewItem item = new ListViewItem(orden.NumeroOP);
                    item.SubItems.Add(orden.FechaRecibida.ToShortDateString());
                    item.SubItems.Add(orden.RazonSocial);


                    // Guardamos el objeto OP completo en la propiedad Tag para no perder sus datos
                    item.Tag = orden;
                    this.opLIST.Items.Add(item);
                }
            }
        }


        private void generarOSBTN_Click_1(object sender, EventArgs e)
        {
            if (this.opdetailsLIST.Items.Count == 0)
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
                emitirOSBTN.Enabled = false;


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
                return;
            }


            // Guardar la OP seleccionada antes de modificar las selecciones
            ListViewItem itemSeleccionado = listaActual.SelectedItems[0];
            OP opSeleccionada = itemSeleccionado.Tag as OP;

            this.opDINLBLI.Text = opSeleccionada.NumeroOP;
            // Cargar el detalle de la OP seleccionada
            CargarDetalleDeOrden(opSeleccionada, this.opdetailsLIST);
        }

        private void opselectLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listaActual = sender as ListView;

            // 1. Validar que la lista no sea nula y tenga al menos un elemento seleccionado
            if (listaActual == null || listaActual.SelectedItems.Count == 0)
            {

                opselectdetailsLIST.Items.Clear();
                return;
            }
            // Guardar la OP seleccionada antes de modificar las selecciones
            ListViewItem itemSeleccionado = listaActual.SelectedItems[0];
            OP opSeleccionada = itemSeleccionado.Tag as OP;
            this.opDINLBLD.Text= opSeleccionada.NumeroOP;
            // Cargar el detalle de la OP seleccionada
            CargarDetalleDeOrden(opSeleccionada, this.opselectdetailsLIST);
        }

        private void CargarDetalleDeOrden(OP op, ListView listaDestino)
        {
            listaDestino.BeginUpdate();

            try
            {
                listaDestino.Items.Clear();

                foreach (DetalleOP detalle in op.Productos)
                {
                    ListViewItem item = new ListViewItem(detalle.SKU);
                    item.SubItems.Add(detalle.Descripcion);
                    item.SubItems.Add(detalle.Cantidad.ToString());

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

                // Reactivar el rediseño visual
                origen.EndUpdate();
                destino.EndUpdate();
            }
        }

        private void buscarBTN_Click_2(object sender, EventArgs e)
        {
            string cliente = clienteBox.Text;
            string numeroOP = opTX.Text.Trim();

            var ordenesFiltradas = modelo.ops
                .Where(op =>
                    op.Estado == "Pendiente" &&
                    (cliente == "" || op.RazonSocial == cliente) &&
                    (numeroOP == "" || op.NumeroOP.ToString() == numeroOP)
                )
                .ToList();

            opLIST.Items.Clear();

            foreach (var op in ordenesFiltradas)
            {
                var item = new ListViewItem(op.NumeroOP.ToString());
                item.SubItems.Add(op.FechaRecibida.ToString("dd/MM/yyyy"));
                item.SubItems.Add(op.RazonSocial);

                opLIST.Items.Add(item);
            }
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
        }

        private void limpiarBTN_Click_1(object sender, EventArgs e)
        {
            this.clienteBox.SelectedIndex = -1;
            CargarOrdenesEnListView(modelo.ops);
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
            this.opdetailsLIST.Items.Clear();
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


    }
}
