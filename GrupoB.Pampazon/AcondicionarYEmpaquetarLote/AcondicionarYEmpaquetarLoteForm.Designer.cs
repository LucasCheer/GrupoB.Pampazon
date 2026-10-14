namespace GrupoB.Pampazon.AcondicionarYEmpaquetarLote
{
    partial class AcondicionarYEmpaquetarLoteForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblDatosGenerales = new Label();
            lblNumeroOrdenPreparacion = new Label();
            txtNumeroOrdenPreparacion = new TextBox();
            lblNumeroOrdenSeleccion = new Label();
            txtNumeroOrdenSeleccion = new TextBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblFechaRecepcion = new Label();
            txtFechaRecepcion = new TextBox();
            lblOperador = new Label();
            txtOperador = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lblVerificacionMercaderia = new Label();
            lvProductosRecibidos = new ListView();
            colSku = new ColumnHeader();
            colDescripcion = new ColumnHeader();
            colCantidadEsperada = new ColumnHeader();
            colCantidadRecibida = new ColumnHeader();
            colDiferencia = new ColumnHeader();
            colCondicion = new ColumnHeader();
            colVerificado = new ColumnHeader();
            btnMarcarVerificado = new Button();
            btnRegistrarIncidencia = new Button();
            lblArmadoBultos = new Label();
            lvBultos = new ListView();
            colNumeroBulto = new ColumnHeader();
            colTipoEmbalaje = new ColumnHeader();
            colCantidadProductos = new ColumnHeader();
            colPesoTotal = new ColumnHeader();
            colEstadoEtiqueta = new ColumnHeader();
            colObservaciones = new ColumnHeader();
            btnCrearBulto = new Button();
            btnEditarBulto = new Button();
            btnEliminarBulto = new Button();
            btnGenerarEtiqueta = new Button();
            btnConfirmarLote = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(443, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ACONDICIONAMIENTO Y EMPAQUETADO DEL LOTE";
            // 
            // lblDatosGenerales
            // 
            lblDatosGenerales.AutoSize = true;
            lblDatosGenerales.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosGenerales.Location = new Point(16, 56);
            lblDatosGenerales.Name = "lblDatosGenerales";
            lblDatosGenerales.Size = new Size(159, 25);
            lblDatosGenerales.TabIndex = 1;
            lblDatosGenerales.Text = "DATOS GENERALES";
            // 
            // lblNumeroOrdenPreparacion
            // 
            lblNumeroOrdenPreparacion.AutoSize = true;
            lblNumeroOrdenPreparacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroOrdenPreparacion.Location = new Point(16, 93);
            lblNumeroOrdenPreparacion.Name = "lblNumeroOrdenPreparacion";
            lblNumeroOrdenPreparacion.Size = new Size(72, 25);
            lblNumeroOrdenPreparacion.TabIndex = 2;
            lblNumeroOrdenPreparacion.Text = "N.º OP:";
            // 
            // txtNumeroOrdenPreparacion
            // 
            txtNumeroOrdenPreparacion.BackColor = SystemColors.ControlLight;
            txtNumeroOrdenPreparacion.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroOrdenPreparacion.Location = new Point(94, 90);
            txtNumeroOrdenPreparacion.Name = "txtNumeroOrdenPreparacion";
            txtNumeroOrdenPreparacion.ReadOnly = true;
            txtNumeroOrdenPreparacion.Size = new Size(150, 31);
            txtNumeroOrdenPreparacion.TabIndex = 3;
            // 
            // lblNumeroOrdenSeleccion
            // 
            lblNumeroOrdenSeleccion.AutoSize = true;
            lblNumeroOrdenSeleccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroOrdenSeleccion.Location = new Point(270, 93);
            lblNumeroOrdenSeleccion.Name = "lblNumeroOrdenSeleccion";
            lblNumeroOrdenSeleccion.Size = new Size(73, 25);
            lblNumeroOrdenSeleccion.TabIndex = 4;
            lblNumeroOrdenSeleccion.Text = "N.º OS:";
            // 
            // txtNumeroOrdenSeleccion
            // 
            txtNumeroOrdenSeleccion.BackColor = SystemColors.ControlLight;
            txtNumeroOrdenSeleccion.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroOrdenSeleccion.Location = new Point(349, 90);
            txtNumeroOrdenSeleccion.Name = "txtNumeroOrdenSeleccion";
            txtNumeroOrdenSeleccion.ReadOnly = true;
            txtNumeroOrdenSeleccion.Size = new Size(150, 31);
            txtNumeroOrdenSeleccion.TabIndex = 5;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(528, 93);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(76, 25);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = SystemColors.ControlLight;
            txtCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCliente.Location = new Point(610, 90);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(346, 31);
            txtCliente.TabIndex = 7;
            // 
            // lblFechaRecepcion
            // 
            lblFechaRecepcion.AutoSize = true;
            lblFechaRecepcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaRecepcion.Location = new Point(982, 93);
            lblFechaRecepcion.Name = "lblFechaRecepcion";
            lblFechaRecepcion.Size = new Size(64, 25);
            lblFechaRecepcion.TabIndex = 8;
            lblFechaRecepcion.Text = "Fecha:";
            // 
            // txtFechaRecepcion
            // 
            txtFechaRecepcion.BackColor = SystemColors.ControlLight;
            txtFechaRecepcion.BorderStyle = BorderStyle.FixedSingle;
            txtFechaRecepcion.Location = new Point(1052, 90);
            txtFechaRecepcion.Name = "txtFechaRecepcion";
            txtFechaRecepcion.ReadOnly = true;
            txtFechaRecepcion.Size = new Size(220, 31);
            txtFechaRecepcion.TabIndex = 9;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperador.Location = new Point(16, 142);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(94, 25);
            lblOperador.TabIndex = 10;
            lblOperador.Text = "Operador:";
            // 
            // txtOperador
            // 
            txtOperador.BackColor = SystemColors.ControlLight;
            txtOperador.BorderStyle = BorderStyle.FixedSingle;
            txtOperador.Location = new Point(116, 139);
            txtOperador.Name = "txtOperador";
            txtOperador.ReadOnly = true;
            txtOperador.Size = new Size(383, 31);
            txtOperador.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(528, 142);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(71, 25);
            lblEstado.TabIndex = 12;
            lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.ControlLight;
            txtEstado.BorderStyle = BorderStyle.FixedSingle;
            txtEstado.Location = new Point(610, 139);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(346, 31);
            txtEstado.TabIndex = 13;
            // 
            // lblVerificacionMercaderia
            // 
            lblVerificacionMercaderia.AutoSize = true;
            lblVerificacionMercaderia.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerificacionMercaderia.Location = new Point(16, 194);
            lblVerificacionMercaderia.Name = "lblVerificacionMercaderia";
            lblVerificacionMercaderia.Size = new Size(274, 25);
            lblVerificacionMercaderia.TabIndex = 14;
            lblVerificacionMercaderia.Text = "VERIFICACION DE MERCADERIA";
            // 
            // lvProductosRecibidos
            // 
            lvProductosRecibidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvProductosRecibidos.Columns.AddRange(new ColumnHeader[] { colSku, colDescripcion, colCantidadEsperada, colCantidadRecibida, colDiferencia, colCondicion, colVerificado });
            lvProductosRecibidos.FullRowSelect = true;
            lvProductosRecibidos.GridLines = true;
            lvProductosRecibidos.Location = new Point(16, 226);
            lvProductosRecibidos.MultiSelect = false;
            lvProductosRecibidos.Name = "lvProductosRecibidos";
            lvProductosRecibidos.Size = new Size(1256, 210);
            lvProductosRecibidos.TabIndex = 15;
            lvProductosRecibidos.UseCompatibleStateImageBehavior = false;
            lvProductosRecibidos.View = View.Details;
            // 
            // colSku
            // 
            colSku.Text = "SKU";
            colSku.Width = 110;
            // 
            // colDescripcion
            // 
            colDescripcion.Text = "Descripcion";
            colDescripcion.Width = 300;
            // 
            // colCantidadEsperada
            // 
            colCantidadEsperada.Text = "Cant. esperada";
            colCantidadEsperada.Width = 145;
            // 
            // colCantidadRecibida
            // 
            colCantidadRecibida.Text = "Cant. recibida";
            colCantidadRecibida.Width = 145;
            // 
            // colDiferencia
            // 
            colDiferencia.Text = "Diferencia";
            colDiferencia.Width = 115;
            // 
            // colCondicion
            // 
            colCondicion.Text = "Condicion";
            colCondicion.Width = 150;
            // 
            // colVerificado
            // 
            colVerificado.Text = "Verificado";
            colVerificado.Width = 145;
            // 
            // btnMarcarVerificado
            // 
            btnMarcarVerificado.Location = new Point(816, 446);
            btnMarcarVerificado.Name = "btnMarcarVerificado";
            btnMarcarVerificado.Size = new Size(221, 34);
            btnMarcarVerificado.TabIndex = 16;
            btnMarcarVerificado.Text = "Marcar como verificado";
            btnMarcarVerificado.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarIncidencia
            // 
            btnRegistrarIncidencia.Location = new Point(1051, 446);
            btnRegistrarIncidencia.Name = "btnRegistrarIncidencia";
            btnRegistrarIncidencia.Size = new Size(221, 34);
            btnRegistrarIncidencia.TabIndex = 17;
            btnRegistrarIncidencia.Text = "Registrar incidencia";
            btnRegistrarIncidencia.UseVisualStyleBackColor = true;
            // 
            // lblArmadoBultos
            // 
            lblArmadoBultos.AutoSize = true;
            lblArmadoBultos.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArmadoBultos.Location = new Point(16, 505);
            lblArmadoBultos.Name = "lblArmadoBultos";
            lblArmadoBultos.Size = new Size(184, 25);
            lblArmadoBultos.TabIndex = 18;
            lblArmadoBultos.Text = "ARMADO DE BULTOS";
            // 
            // lvBultos
            // 
            lvBultos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvBultos.Columns.AddRange(new ColumnHeader[] { colNumeroBulto, colTipoEmbalaje, colCantidadProductos, colPesoTotal, colEstadoEtiqueta, colObservaciones });
            lvBultos.FullRowSelect = true;
            lvBultos.GridLines = true;
            lvBultos.Location = new Point(16, 537);
            lvBultos.MultiSelect = false;
            lvBultos.Name = "lvBultos";
            lvBultos.Size = new Size(1256, 185);
            lvBultos.TabIndex = 19;
            lvBultos.UseCompatibleStateImageBehavior = false;
            lvBultos.View = View.Details;
            // 
            // colNumeroBulto
            // 
            colNumeroBulto.Text = "N.º bulto";
            colNumeroBulto.Width = 110;
            // 
            // colTipoEmbalaje
            // 
            colTipoEmbalaje.Text = "Tipo de embalaje";
            colTipoEmbalaje.Width = 200;
            // 
            // colCantidadProductos
            // 
            colCantidadProductos.Text = "Productos";
            colCantidadProductos.Width = 140;
            // 
            // colPesoTotal
            // 
            colPesoTotal.Text = "Peso total";
            colPesoTotal.Width = 140;
            // 
            // colEstadoEtiqueta
            // 
            colEstadoEtiqueta.Text = "Etiqueta";
            colEstadoEtiqueta.Width = 160;
            // 
            // colObservaciones
            // 
            colObservaciones.Text = "Observaciones";
            colObservaciones.Width = 420;
            // 
            // btnCrearBulto
            // 
            btnCrearBulto.Location = new Point(16, 732);
            btnCrearBulto.Name = "btnCrearBulto";
            btnCrearBulto.Size = new Size(160, 34);
            btnCrearBulto.TabIndex = 20;
            btnCrearBulto.Text = "Crear bulto";
            btnCrearBulto.UseVisualStyleBackColor = true;
            // 
            // btnEditarBulto
            // 
            btnEditarBulto.Location = new Point(187, 732);
            btnEditarBulto.Name = "btnEditarBulto";
            btnEditarBulto.Size = new Size(160, 34);
            btnEditarBulto.TabIndex = 21;
            btnEditarBulto.Text = "Editar bulto";
            btnEditarBulto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarBulto
            // 
            btnEliminarBulto.Location = new Point(358, 732);
            btnEliminarBulto.Name = "btnEliminarBulto";
            btnEliminarBulto.Size = new Size(160, 34);
            btnEliminarBulto.TabIndex = 22;
            btnEliminarBulto.Text = "Eliminar bulto";
            btnEliminarBulto.UseVisualStyleBackColor = true;
            // 
            // btnGenerarEtiqueta
            // 
            btnGenerarEtiqueta.Location = new Point(529, 732);
            btnGenerarEtiqueta.Name = "btnGenerarEtiqueta";
            btnGenerarEtiqueta.Size = new Size(180, 34);
            btnGenerarEtiqueta.TabIndex = 23;
            btnGenerarEtiqueta.Text = "Generar etiqueta";
            btnGenerarEtiqueta.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarLote
            // 
            btnConfirmarLote.Enabled = false;
            btnConfirmarLote.Location = new Point(890, 792);
            btnConfirmarLote.Name = "btnConfirmarLote";
            btnConfirmarLote.Size = new Size(244, 38);
            btnConfirmarLote.TabIndex = 24;
            btnConfirmarLote.Text = "Confirmar lote preparado";
            btnConfirmarLote.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(1146, 792);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 38);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AcondicionarYEmpaquetarLoteForm
            // 
            AcceptButton = btnConfirmarLote;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(1288, 850);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarLote);
            Controls.Add(btnGenerarEtiqueta);
            Controls.Add(btnEliminarBulto);
            Controls.Add(btnEditarBulto);
            Controls.Add(btnCrearBulto);
            Controls.Add(lvBultos);
            Controls.Add(lblArmadoBultos);
            Controls.Add(btnRegistrarIncidencia);
            Controls.Add(btnMarcarVerificado);
            Controls.Add(lvProductosRecibidos);
            Controls.Add(lblVerificacionMercaderia);
            Controls.Add(txtEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtOperador);
            Controls.Add(lblOperador);
            Controls.Add(txtFechaRecepcion);
            Controls.Add(lblFechaRecepcion);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Controls.Add(txtNumeroOrdenSeleccion);
            Controls.Add(lblNumeroOrdenSeleccion);
            Controls.Add(txtNumeroOrdenPreparacion);
            Controls.Add(lblNumeroOrdenPreparacion);
            Controls.Add(lblDatosGenerales);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AcondicionarYEmpaquetarLoteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Acondicionar y empaquetar lote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDatosGenerales;
        private Label lblNumeroOrdenPreparacion;
        private TextBox txtNumeroOrdenPreparacion;
        private Label lblNumeroOrdenSeleccion;
        private TextBox txtNumeroOrdenSeleccion;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblFechaRecepcion;
        private TextBox txtFechaRecepcion;
        private Label lblOperador;
        private TextBox txtOperador;
        private Label lblEstado;
        private TextBox txtEstado;
        private Label lblVerificacionMercaderia;
        private ListView lvProductosRecibidos;
        private ColumnHeader colSku;
        private ColumnHeader colDescripcion;
        private ColumnHeader colCantidadEsperada;
        private ColumnHeader colCantidadRecibida;
        private ColumnHeader colDiferencia;
        private ColumnHeader colCondicion;
        private ColumnHeader colVerificado;
        private Button btnMarcarVerificado;
        private Button btnRegistrarIncidencia;
        private Label lblArmadoBultos;
        private ListView lvBultos;
        private ColumnHeader colNumeroBulto;
        private ColumnHeader colTipoEmbalaje;
        private ColumnHeader colCantidadProductos;
        private ColumnHeader colPesoTotal;
        private ColumnHeader colEstadoEtiqueta;
        private ColumnHeader colObservaciones;
        private Button btnCrearBulto;
        private Button btnEditarBulto;
        private Button btnEliminarBulto;
        private Button btnGenerarEtiqueta;
        private Button btnConfirmarLote;
        private Button btnCancelar;
    }
}
