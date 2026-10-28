using System;
using System.Drawing;
using System.Windows.Forms;

namespace GrupoB.Pampazon.DespachoCargaTransporte
{
    public partial class DespachoCargaTransporteForm : Form
    {
        private DespachoCargaTransporteModelo modelo;

        public DespachoCargaTransporteForm()
        {
            InitializeComponent();
            modelo = new DespachoCargaTransporteModelo();
            ConfigurarControlesReadOnly();
        }

        /// <summary>
        /// Excepción 5.1: Bloquea la edición manual de campos ReadOnly.
        /// </summary>
        private void ConfigurarControlesReadOnly()
        {
            textBox7.ReadOnly = true; // Transporte validado
            textBox3.ReadOnly = true; // Total de cajas a subir
        }

        /// <summary>
        /// Botón 'Consultar cargas' (button1) - Pasos 3, 4 y 5
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = textBox6.Text; // DNI Transportista
                DespachoDTO dto = modelo.ConsultarCargas(dni);

                // Paso 5: Mostrar datos en pantalla
                textBox7.Text = dto.TransporteValidado;

                listView1.Items.Clear();
                foreach (string cajaId in dto.ListaCajas)
                {
                    listView1.Items.Add(new ListViewItem(cajaId));
                }

                textBox3.Text = dto.TotalCajas.ToString();
            }
            catch (Exception ex)
            {
                // Excepciones 3.1, 4.1 y 4.2
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCamposCargas();
            }
        }

        /// <summary>
        /// Botón 'Registrar carga' (button2) - Pasos 8 al 14
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmacionTildada = checkBox1.Checked; // Casilla 'Cajas entregadas'

                if (modelo.RegistrarCarga(confirmacionTildada))
                {
                    // Pasos 13 y 14: Confirmación y remito impreso
                    MessageBox.Show(
                        "Carga registrada con éxito.\nEstado de la orden actualizado a 'Despachado'.\nRemito de entrega emitido e impreso por duplicado.",
                        "Operación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Paso 14: Limpiar pantalla
                    LimpiarTodo();
                }
            }
            catch (Exception ex)
            {
                // Excepción 9.1
                MessageBox.Show(ex.Message, "Validación requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Botón 'Cerrar' (button3)
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCamposCargas()
        {
            textBox7.Clear();
            listView1.Items.Clear();
            textBox3.Clear();
            checkBox1.Checked = false;
        }

        private void LimpiarTodo()
        {
            textBox6.Clear();
            LimpiarCamposCargas();
            modelo.LimpiarDatos();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}