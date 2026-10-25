namespace GrupoB.Pampazon.AcondicionarYEmpaquetarLote
{
    partial class AcondicionarYEmpaquetarLoteForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpOrden = new GroupBox();
            txtFecha = new TextBox();
            lblFecha = new Label();
            txtCliente = new TextBox();
            lblCliente = new Label();
            txtOrdenPreparacion = new TextBox();
            lblOrdenPreparacion = new Label();
            grpMercaderia = new GroupBox();
            lvProductos = new ListView();
            colSku = new ColumnHeader();
            colDescripcion = new ColumnHeader();
            colCantidadOp = new ColumnHeader();
            btnConfirmarLote = new Button();
            btnCancelar = new Button();
            grpOrden.SuspendLayout();
            grpMercaderia.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(11, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(566, 41);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "ACONDICIONAR Y EMPAQUETAR LOTE";
            // 
            // grpOrden
            // 
            grpOrden.Controls.Add(txtFecha);
            grpOrden.Controls.Add(lblFecha);
            grpOrden.Controls.Add(txtCliente);
            grpOrden.Controls.Add(lblCliente);
            grpOrden.Controls.Add(txtOrdenPreparacion);
            grpOrden.Controls.Add(lblOrdenPreparacion);
            grpOrden.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpOrden.Location = new Point(11, 60);
            grpOrden.Name = "grpOrden";
            grpOrden.Size = new Size(931, 73);
            grpOrden.TabIndex = 4;
            grpOrden.TabStop = false;
            grpOrden.Text = "ORDEN DE PREPARACIÓN";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(749, 27);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(159, 30);
            txtFecha.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(685, 31);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(60, 23);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(370, 27);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(297, 30);
            txtCliente.TabIndex = 4;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(293, 31);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(71, 23);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente:";
            // 
            // txtOrdenPreparacion
            // 
            txtOrdenPreparacion.Location = new Point(93, 27);
            txtOrdenPreparacion.Name = "txtOrdenPreparacion";
            txtOrdenPreparacion.ReadOnly = true;
            txtOrdenPreparacion.Size = new Size(175, 30);
            txtOrdenPreparacion.TabIndex = 6;
            // 
            // lblOrdenPreparacion
            // 
            lblOrdenPreparacion.AutoSize = true;
            lblOrdenPreparacion.Location = new Point(15, 31);
            lblOrdenPreparacion.Name = "lblOrdenPreparacion";
            lblOrdenPreparacion.Size = new Size(69, 23);
            lblOrdenPreparacion.TabIndex = 7;
            lblOrdenPreparacion.Text = "N.º OP:";
            // 
            // grpMercaderia
            // 
            grpMercaderia.Controls.Add(lvProductos);
            grpMercaderia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMercaderia.Location = new Point(11, 145);
            grpMercaderia.Name = "grpMercaderia";
            grpMercaderia.Size = new Size(931, 447);
            grpMercaderia.TabIndex = 3;
            grpMercaderia.TabStop = false;
            grpMercaderia.Text = "MERCADERÍA DE LA ORDEN";
            // 
            // lvProductos
            // 
            lvProductos.Columns.AddRange(new ColumnHeader[] { colSku, colDescripcion, colCantidadOp });
            lvProductos.FullRowSelect = true;
            lvProductos.GridLines = true;
            lvProductos.Location = new Point(15, 29);
            lvProductos.MultiSelect = false;
            lvProductos.Name = "lvProductos";
            lvProductos.Size = new Size(893, 403);
            lvProductos.TabIndex = 0;
            lvProductos.UseCompatibleStateImageBehavior = false;
            lvProductos.View = View.Details;
            // 
            // colSku
            // 
            colSku.Text = "SKU";
            colSku.Width = 170;
            // 
            // colDescripcion
            // 
            colDescripcion.Text = "Descripción";
            colDescripcion.Width = 430;
            // 
            // colCantidadOp
            // 
            colCantidadOp.Text = "Cantidad a empaquetar";
            colCantidadOp.Width = 170;
            // 
            // btnConfirmarLote
            // 
            btnConfirmarLote.Location = new Point(613, 609);
            btnConfirmarLote.Name = "btnConfirmarLote";
            btnConfirmarLote.Size = new Size(210, 40);
            btnConfirmarLote.TabIndex = 1;
            btnConfirmarLote.Text = "Confirmar lote preparado";
            btnConfirmarLote.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(823, 609);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AcondicionarYEmpaquetarLoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(957, 667);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarLote);
            Controls.Add(grpMercaderia);
            Controls.Add(grpOrden);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AcondicionarYEmpaquetarLoteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Acondicionar y empaquetar lote";
            grpOrden.ResumeLayout(false);
            grpOrden.PerformLayout();
            grpMercaderia.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private GroupBox grpOrden;
        private Label lblOrdenPreparacion;
        private TextBox txtOrdenPreparacion;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblFecha;
        private TextBox txtFecha;
        private GroupBox grpMercaderia;
        private ListView lvProductos;
        private ColumnHeader colSku;
        private ColumnHeader colDescripcion;
        private ColumnHeader colCantidadOp;
        private Button btnConfirmarLote;
        private Button btnCancelar;
    }
}
