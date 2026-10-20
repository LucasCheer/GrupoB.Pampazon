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
            grpBultos = new GroupBox();
            btnGenerarEtiqueta = new Button();
            btnAgregarBulto = new Button();
            nudPeso = new NumericUpDown();
            lblPeso = new Label();
            cboTipoEmbalaje = new ComboBox();
            lblTipoEmbalaje = new Label();
            lvBultos = new ListView();
            colNumeroBulto = new ColumnHeader();
            colTipoEmbalaje = new ColumnHeader();
            colProductos = new ColumnHeader();
            colPeso = new ColumnHeader();
            colEtiqueta = new ColumnHeader();
            btnConfirmarLote = new Button();
            btnCancelar = new Button();
            grpOrden.SuspendLayout();
            grpMercaderia.SuspendLayout();
            grpBultos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPeso).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(10, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(400, 30);
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
            lblFecha.Size = new Size(42, 15);
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
            lblCliente.Size = new Size(49, 15);
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
            lblOrdenPreparacion.Size = new Size(46, 15);
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
            grpMercaderia.Size = new Size(815, 142);
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
            lvProductos.Size = new Size(789, 110);
            lvProductos.TabIndex = 0;
            lvProductos.UseCompatibleStateImageBehavior = false;
            lvProductos.View = View.Details;
            lvProductos.SelectedIndexChanged += lvProductos_SelectedIndexChanged;
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
            // grpBultos
            // 
            grpBultos.Controls.Add(btnGenerarEtiqueta);
            grpBultos.Controls.Add(btnAgregarBulto);
            grpBultos.Controls.Add(nudPeso);
            grpBultos.Controls.Add(lblPeso);
            grpBultos.Controls.Add(cboTipoEmbalaje);
            grpBultos.Controls.Add(lblTipoEmbalaje);
            grpBultos.Controls.Add(lvBultos);
            grpBultos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBultos.Location = new Point(10, 260);
            grpBultos.Margin = new Padding(3, 2, 3, 2);
            grpBultos.Name = "grpBultos";
            grpBultos.Padding = new Padding(3, 2, 3, 2);
            grpBultos.Size = new Size(815, 184);
            grpBultos.TabIndex = 2;
            grpBultos.TabStop = false;
            grpBultos.Text = "ARMADO DE BULTOS";
            // 
            // btnGenerarEtiqueta
            // 
            btnGenerarEtiqueta.Location = new Point(640, 58);
            btnGenerarEtiqueta.Margin = new Padding(3, 2, 3, 2);
            btnGenerarEtiqueta.Name = "btnGenerarEtiqueta";
            btnGenerarEtiqueta.Size = new Size(155, 30);
            btnGenerarEtiqueta.TabIndex = 0;
            btnGenerarEtiqueta.Text = "Generar etiqueta";
            btnGenerarEtiqueta.UseVisualStyleBackColor = true;
            // 
            // btnAgregarBulto
            // 
            btnAgregarBulto.Location = new Point(534, 19);
            btnAgregarBulto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarBulto.Name = "btnAgregarBulto";
            btnAgregarBulto.Size = new Size(158, 28);
            btnAgregarBulto.TabIndex = 1;
            btnAgregarBulto.Text = "Agregar bulto";
            btnAgregarBulto.UseVisualStyleBackColor = true;
            // 
            // nudPeso
            // 
            nudPeso.DecimalPlaces = 2;
            nudPeso.Location = new Point(407, 21);
            nudPeso.Margin = new Padding(3, 2, 3, 2);
            nudPeso.Name = "nudPeso";
            nudPeso.Size = new Size(101, 26);
            nudPeso.TabIndex = 2;
            nudPeso.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(324, 24);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(61, 15);
            lblPeso.TabIndex = 3;
            lblPeso.Text = "Peso (kg):";
            // 
            // cboTipoEmbalaje
            // 
            cboTipoEmbalaje.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoEmbalaje.Items.AddRange(new object[] { "Caja", "Bolsa", "Pallet" });
            cboTipoEmbalaje.Location = new Point(152, 21);
            cboTipoEmbalaje.Margin = new Padding(3, 2, 3, 2);
            cboTipoEmbalaje.Name = "cboTipoEmbalaje";
            cboTipoEmbalaje.Size = new Size(154, 27);
            cboTipoEmbalaje.TabIndex = 4;
            // 
            // lblTipoEmbalaje
            // 
            lblTipoEmbalaje.AutoSize = true;
            lblTipoEmbalaje.Location = new Point(13, 24);
            lblTipoEmbalaje.Name = "lblTipoEmbalaje";
            lblTipoEmbalaje.Size = new Size(104, 15);
            lblTipoEmbalaje.TabIndex = 5;
            lblTipoEmbalaje.Text = "Tipo de embalaje:";
            // 
            // lvBultos
            // 
            lvBultos.Columns.AddRange(new ColumnHeader[] { colNumeroBulto, colTipoEmbalaje, colProductos, colPeso, colEtiqueta });
            lvBultos.FullRowSelect = true;
            lvBultos.GridLines = true;
            lvBultos.Location = new Point(13, 58);
            lvBultos.Margin = new Padding(3, 2, 3, 2);
            lvBultos.MultiSelect = false;
            lvBultos.Name = "lvBultos";
            lvBultos.Size = new Size(614, 106);
            lvBultos.TabIndex = 6;
            lvBultos.UseCompatibleStateImageBehavior = false;
            lvBultos.View = View.Details;
            // 
            // colNumeroBulto
            // 
            colNumeroBulto.Text = "N.º bulto";
            colNumeroBulto.Width = 95;
            // 
            // colTipoEmbalaje
            // 
            colTipoEmbalaje.Text = "Tipo de embalaje";
            colTipoEmbalaje.Width = 160;
            // 
            // colProductos
            // 
            colProductos.Text = "Productos";
            colProductos.Width = 120;
            // 
            // colPeso
            // 
            colPeso.Text = "Peso";
            colPeso.Width = 100;
            // 
            // colEtiqueta
            // 
            colEtiqueta.Text = "Etiqueta";
            colEtiqueta.Width = 120;
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
            Controls.Add(grpBultos);
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
            grpBultos.ResumeLayout(false);
            grpBultos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPeso).EndInit();
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
        private GroupBox grpBultos;
        private Label lblTipoEmbalaje;
        private ComboBox cboTipoEmbalaje;
        private Label lblPeso;
        private NumericUpDown nudPeso;
        private Button btnAgregarBulto;
        private ListView lvBultos;
        private ColumnHeader colNumeroBulto;
        private ColumnHeader colTipoEmbalaje;
        private ColumnHeader colProductos;
        private ColumnHeader colPeso;
        private ColumnHeader colEtiqueta;
        private Button btnGenerarEtiqueta;
        private Button btnConfirmarLote;
        private Button btnCancelar;
    }
}
