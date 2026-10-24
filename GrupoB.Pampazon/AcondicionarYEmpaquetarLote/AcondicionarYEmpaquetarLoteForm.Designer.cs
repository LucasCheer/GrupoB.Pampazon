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
            btnImprimirEtiqueta = new Button();
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
            lblTitulo.Location = new Point(10, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(453, 32);
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
            grpOrden.Location = new Point(10, 45);
            grpOrden.Margin = new Padding(3, 2, 3, 2);
            grpOrden.Name = "grpOrden";
            grpOrden.Padding = new Padding(3, 2, 3, 2);
            grpOrden.Size = new Size(815, 55);
            grpOrden.TabIndex = 4;
            grpOrden.TabStop = false;
            grpOrden.Text = "ORDEN DE PREPARACIÓN";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(655, 20);
            txtFecha.Margin = new Padding(3, 2, 3, 2);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(140, 26);
            txtFecha.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(599, 23);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(51, 19);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(324, 20);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(260, 26);
            txtCliente.TabIndex = 4;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(256, 23);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(59, 19);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente:";
            // 
            // txtOrdenPreparacion
            // 
            txtOrdenPreparacion.Location = new Point(81, 20);
            txtOrdenPreparacion.Margin = new Padding(3, 2, 3, 2);
            txtOrdenPreparacion.Name = "txtOrdenPreparacion";
            txtOrdenPreparacion.ReadOnly = true;
            txtOrdenPreparacion.Size = new Size(154, 26);
            txtOrdenPreparacion.TabIndex = 6;
            // 
            // lblOrdenPreparacion
            // 
            lblOrdenPreparacion.AutoSize = true;
            lblOrdenPreparacion.Location = new Point(13, 23);
            lblOrdenPreparacion.Name = "lblOrdenPreparacion";
            lblOrdenPreparacion.Size = new Size(58, 19);
            lblOrdenPreparacion.TabIndex = 7;
            lblOrdenPreparacion.Text = "N.º OP:";
            // 
            // grpMercaderia
            // 
            grpMercaderia.Controls.Add(lvProductos);
            grpMercaderia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMercaderia.Location = new Point(10, 109);
            grpMercaderia.Margin = new Padding(3, 2, 3, 2);
            grpMercaderia.Name = "grpMercaderia";
            grpMercaderia.Padding = new Padding(3, 2, 3, 2);
            grpMercaderia.Size = new Size(815, 335);
            grpMercaderia.TabIndex = 3;
            grpMercaderia.TabStop = false;
            grpMercaderia.Text = "MERCADERÍA DE LA ORDEN";
            // 
            // lvProductos
            // 
            lvProductos.Columns.AddRange(new ColumnHeader[] { colSku, colDescripcion, colCantidadOp });
            lvProductos.FullRowSelect = true;
            lvProductos.GridLines = true;
            lvProductos.Location = new Point(13, 22);
            lvProductos.Margin = new Padding(3, 2, 3, 2);
            lvProductos.MultiSelect = false;
            lvProductos.Name = "lvProductos";
            lvProductos.Size = new Size(782, 303);
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
            // btnImprimirEtiqueta
            //
            btnImprimirEtiqueta.Location = new Point(372, 457);
            btnImprimirEtiqueta.Margin = new Padding(3, 2, 3, 2);
            btnImprimirEtiqueta.Name = "btnImprimirEtiqueta";
            btnImprimirEtiqueta.Size = new Size(158, 30);
            btnImprimirEtiqueta.TabIndex = 2;
            btnImprimirEtiqueta.Text = "Imprimir etiqueta";
            btnImprimirEtiqueta.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarLote
            // 
            btnConfirmarLote.Location = new Point(536, 457);
            btnConfirmarLote.Margin = new Padding(3, 2, 3, 2);
            btnConfirmarLote.Name = "btnConfirmarLote";
            btnConfirmarLote.Size = new Size(184, 30);
            btnConfirmarLote.TabIndex = 1;
            btnConfirmarLote.Text = "Confirmar lote preparado";
            btnConfirmarLote.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(720, 457);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 30);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AcondicionarYEmpaquetarLoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(837, 500);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarLote);
            Controls.Add(btnImprimirEtiqueta);
            Controls.Add(grpMercaderia);
            Controls.Add(grpOrden);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnImprimirEtiqueta;
        private Button btnConfirmarLote;
        private Button btnCancelar;
    }
}
