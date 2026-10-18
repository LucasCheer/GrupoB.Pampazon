using GrupoB.Pampazon.EmitirOrdenDeSeleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void EmitirOrdenDeSeleccionForm_Load_1(object sender, EventArgs e)
        {
            this.clienteBox.DisplayMember = "Descripcion";
            this.clienteBox.ValueMember = "Id";
            this.clienteBox.DataSource = modelo.clientes;

            // Desselecciona el elemento inicial para que quede el campo en blanco
            this.clienteBox.SelectedIndex = -1;

            CargarOrdenesEnListView(modelo.ops);

        
        }

        private void CargarOrdenesEnListView(IEnumerable<OPs> ordenes)
        {
            this.opLIST.Items.Clear();
            foreach (var orden in ordenes)
            {
                ListViewItem item = new ListViewItem(orden.NumeroOP);
                item.SubItems.Add(orden.FechaRecibida.ToShortDateString());
                item.SubItems.Add(orden.ClienteID.ToString());
                item.SubItems.Add(orden.Producto);
                item.SubItems.Add(orden.Cantidad.ToString());
                this.opLIST.Items.Add(item);
            }
        }
        private void limpiarBTN_Click(object sender, EventArgs e)
        {
            this.clienteBox.SelectedIndex = -1;
            CargarOrdenesEnListView(modelo.ops);
        }

        private void buscarBTN_Click(object sender, EventArgs e)
        {

            if (this.clienteBox.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente para filtrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ejemplo de filtrado por cliente seleccionado:
            int clienteId = Convert.ToInt32(this.clienteBox.SelectedValue);

            // Si la propiedad cliente coincide con el filtro:
            var ordenesFiltradas = modelo.ops.Where(o => o.ClienteID == clienteId);

            CargarOrdenesEnListView(ordenesFiltradas);
        
    }

        
    }
}
