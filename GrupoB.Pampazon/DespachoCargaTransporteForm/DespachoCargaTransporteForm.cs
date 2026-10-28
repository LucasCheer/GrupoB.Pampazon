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
            TransporteValidadoText.ReadOnly = true; // Transporte validado
            TotalCajasText.ReadOnly = true; // Total de cajas a subir
        }

        /// <summary>
        /// Botón 'Consultar cargas' (ConsultarCargasBtn) - Pasos 3, 4 y 5
        /// </summary>
        private void ConsultarCargasBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = DNITransportistaText.Text; // DNI Transportista
                DespachoDTO dto = modelo.ConsultarCargas(dni);

                // Paso 5: Mostrar datos en pantalla
                TransporteValidadoText.Text = dto.TransporteValidado;

                CajasListView.Items.Clear();
                foreach (string cajaId in dto.ListaCajas)
                {
                    CajasListView.Items.Add(new ListViewItem(cajaId));
                }

                TotalCajasText.Text = dto.TotalCajas.ToString();
            }
            catch (Exception ex)
            {
                // Excepciones 3.1, 4.1 y 4.2
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCamposCargas();
            }
        }

        /// <summary>
        /// Botón 'Registrar carga' (RegistrarCargaBtn) - Pasos 8 al 14
        /// </summary>
        private void RegistrarCargaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmacionTildada = CajasEntregadasCheck.Checked; // Casilla 'Cajas entregadas'

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
        /// Botón 'Cerrar' (CerrarBtn)
        /// </summary>
        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCamposCargas()
        {
            TransporteValidadoText.Clear();
            CajasListView.Items.Clear();
            TotalCajasText.Clear();
            CajasEntregadasCheck.Checked = false;
        }

        private void LimpiarTodo()
        {
            DNITransportistaText.Clear();
            LimpiarCamposCargas();
            modelo.LimpiarDatos();
        }
    }
}