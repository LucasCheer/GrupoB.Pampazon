namespace GrupoB.Pampazon.IngresoDeOrdenDePreparacion
{
    partial class IngresoDeOrdenDePreparacionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            ClienteCombo = new ComboBox();
            label3 = new Label();
            CUITClienteText = new TextBox();
            label4 = new Label();
            FechaSolicitadaDateTimePicker = new DateTimePicker();
            label5 = new Label();
            ModalidadCombo = new ComboBox();
            label6 = new Label();
            TransporteText = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SKUCombo = new ComboBox();
            label9 = new Label();
            CantAPedirText = new TextBox();
            AgregarALaOrdenBtn = new Button();
            label10 = new Label();
            DetallesDeProductosListView = new ListView();
            SKUCol = new ColumnHeader();
            DescripcionCol = new ColumnHeader();
            CantPedidaCol = new ColumnHeader();
            ModalidadCol = new ColumnHeader();
            label11 = new Label();
            CantDisponibleText = new TextBox();
            QuitarBtn = new Button();
            CancelarBtn = new Button();
            IngresarOPBtn = new Button();
            DNITransportistaText = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(28, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(407, 25);
            label1.TabIndex = 0;
            label1.Text = "DATOS GENERALES DE LA ORDEN Y CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 1;
            label2.Text = "Cliente / Empresa:";
            // 
            // ClienteCombo
            // 
            ClienteCombo.FormattingEnabled = true;
            ClienteCombo.Location = new Point(194, 76);
            ClienteCombo.Margin = new Padding(2);
            ClienteCombo.Name = "ClienteCombo";
            ClienteCombo.Size = new Size(352, 33);
            ClienteCombo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(575, 76);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 3;
            label3.Text = "CUIT Cliente:";
            // 
            // CUITClienteText
            // 
            CUITClienteText.Location = new Point(701, 76);
            CUITClienteText.Margin = new Padding(2);
            CUITClienteText.Name = "CUITClienteText";
            CUITClienteText.Size = new Size(244, 31);
            CUITClienteText.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 138);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 5;
            label4.Text = "Fecha Solicitada:";
            // 
            // FechaSolicitadaDateTimePicker
            // 
            FechaSolicitadaDateTimePicker.Format = DateTimePickerFormat.Short;
            FechaSolicitadaDateTimePicker.Location = new Point(194, 138);
            FechaSolicitadaDateTimePicker.Margin = new Padding(2);
            FechaSolicitadaDateTimePicker.Name = "FechaSolicitadaDateTimePicker";
            FechaSolicitadaDateTimePicker.Size = new Size(189, 31);
            FechaSolicitadaDateTimePicker.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(584, 365);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 7;
            label5.Text = "Modalidad:";
            // 
            // ModalidadCombo
            // 
            ModalidadCombo.FormattingEnabled = true;
            ModalidadCombo.Location = new Point(701, 362);
            ModalidadCombo.Margin = new Padding(2);
            ModalidadCombo.Name = "ModalidadCombo";
            ModalidadCombo.Size = new Size(237, 33);
            ModalidadCombo.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 138);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 9;
            label6.Text = "Transporte:";
            // 
            // TransporteText
            // 
            TransporteText.Location = new Point(511, 135);
            TransporteText.Margin = new Padding(2);
            TransporteText.Name = "TransporteText";
            TransporteText.Size = new Size(434, 31);
            TransporteText.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(28, 256);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(355, 25);
            label7.TabIndex = 11;
            label7.Text = "INGRESO DE PRODUCTOS A LA ORDEN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 304);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(135, 25);
            label8.TabIndex = 12;
            label8.Text = "SKU del Cliente:";
            // 
            // SKUCombo
            // 
            SKUCombo.FormattingEnabled = true;
            SKUCombo.Location = new Point(194, 304);
            SKUCombo.Margin = new Padding(2);
            SKUCombo.Name = "SKUCombo";
            SKUCombo.Size = new Size(281, 33);
            SKUCombo.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 365);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 25);
            label9.TabIndex = 14;
            label9.Text = "Cantidad a Pedir:";
            // 
            // CantAPedirText
            // 
            CantAPedirText.Location = new Point(194, 365);
            CantAPedirText.Margin = new Padding(2);
            CantAPedirText.Name = "CantAPedirText";
            CantAPedirText.Size = new Size(281, 31);
            CantAPedirText.TabIndex = 15;
            // 
            // AgregarALaOrdenBtn
            // 
            AgregarALaOrdenBtn.Location = new Point(33, 420);
            AgregarALaOrdenBtn.Margin = new Padding(2);
            AgregarALaOrdenBtn.Name = "AgregarALaOrdenBtn";
            AgregarALaOrdenBtn.Size = new Size(912, 34);
            AgregarALaOrdenBtn.TabIndex = 16;
            AgregarALaOrdenBtn.Text = "Agregar a la Orden";
            AgregarALaOrdenBtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(28, 489);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(365, 25);
            label10.TabIndex = 17;
            label10.Text = "DETALLE DE PRODUCTOS EN LA ORDEN";
            // 
            // DetallesDeProductosListView
            // 
            DetallesDeProductosListView.Columns.AddRange(new ColumnHeader[] { SKUCol, DescripcionCol, CantPedidaCol, ModalidadCol });
            DetallesDeProductosListView.Location = new Point(34, 522);
            DetallesDeProductosListView.Margin = new Padding(2);
            DetallesDeProductosListView.Name = "DetallesDeProductosListView";
            DetallesDeProductosListView.Size = new Size(912, 182);
            DetallesDeProductosListView.TabIndex = 18;
            DetallesDeProductosListView.UseCompatibleStateImageBehavior = false;
            DetallesDeProductosListView.View = View.Details;
            // 
            // SKUCol
            // 
            SKUCol.Text = "SKU";
            SKUCol.Width = 100;
            // 
            // DescripcionCol
            // 
            DescripcionCol.Text = "Descripcion del Producto";
            DescripcionCol.Width = 250;
            // 
            // CantPedidaCol
            // 
            CantPedidaCol.Text = "Cant. Pedida";
            CantPedidaCol.Width = 120;
            // 
            // ModalidadCol
            // 
            ModalidadCol.Text = "Modalidad";
            ModalidadCol.Width = 200;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(511, 306);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(177, 25);
            label11.TabIndex = 19;
            label11.Text = "Cantidad Disponible:";
            // 
            // CantDisponibleText
            // 
            CantDisponibleText.BackColor = SystemColors.AppWorkspace;
            CantDisponibleText.BorderStyle = BorderStyle.FixedSingle;
            CantDisponibleText.Location = new Point(701, 302);
            CantDisponibleText.Margin = new Padding(2);
            CantDisponibleText.Name = "CantDisponibleText";
            CantDisponibleText.ReadOnly = true;
            CantDisponibleText.Size = new Size(237, 31);
            CantDisponibleText.TabIndex = 20;
            // 
            // QuitarBtn
            // 
            QuitarBtn.Location = new Point(824, 709);
            QuitarBtn.Margin = new Padding(2);
            QuitarBtn.Name = "QuitarBtn";
            QuitarBtn.Size = new Size(122, 34);
            QuitarBtn.TabIndex = 21;
            QuitarBtn.Text = "Quitar ";
            QuitarBtn.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(746, 758);
            CancelarBtn.Margin = new Padding(2);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(200, 34);
            CancelarBtn.TabIndex = 23;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // IngresarOPBtn
            // 
            IngresarOPBtn.Location = new Point(452, 758);
            IngresarOPBtn.Margin = new Padding(2);
            IngresarOPBtn.Name = "IngresarOPBtn";
            IngresarOPBtn.Size = new Size(284, 34);
            IngresarOPBtn.TabIndex = 24;
            IngresarOPBtn.Text = "Ingresar Orden de Preparacion";
            IngresarOPBtn.UseVisualStyleBackColor = true;
            // 
            // DNITransportistaText
            // 
            DNITransportistaText.Location = new Point(198, 195);
            DNITransportistaText.Margin = new Padding(2);
            DNITransportistaText.Name = "DNITransportistaText";
            DNITransportistaText.Size = new Size(237, 31);
            DNITransportistaText.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 198);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(153, 25);
            label12.TabIndex = 25;
            label12.Text = "DNI Transportista:";
            // 
            // IngresoDeOrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 805);
            Controls.Add(DNITransportistaText);
            Controls.Add(label12);
            Controls.Add(IngresarOPBtn);
            Controls.Add(CancelarBtn);
            Controls.Add(QuitarBtn);
            Controls.Add(CantDisponibleText);
            Controls.Add(label11);
            Controls.Add(DetallesDeProductosListView);
            Controls.Add(label10);
            Controls.Add(AgregarALaOrdenBtn);
            Controls.Add(CantAPedirText);
            Controls.Add(label9);
            Controls.Add(SKUCombo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(TransporteText);
            Controls.Add(label6);
            Controls.Add(ModalidadCombo);
            Controls.Add(label5);
            Controls.Add(FechaSolicitadaDateTimePicker);
            Controls.Add(label4);
            Controls.Add(CUITClienteText);
            Controls.Add(label3);
            Controls.Add(ClienteCombo);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "IngresoDeOrdenDePreparacionForm";
            Text = "IngresoDeOrdenDePreparacionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox ClienteCombo;
        private Label label3;
        private TextBox CUITClienteText;
        private Label label4;
        private DateTimePicker FechaSolicitadaDateTimePicker;
        private Label label5;
        private ComboBox ModalidadCombo;
        private Label label6;
        private TextBox TransporteText;
        private Label label7;
        private Label label8;
        private ComboBox SKUCombo;
        private Label label9;
        private TextBox CantAPedirText;
        private Button AgregarALaOrdenBtn;
        private Label label10;
        private ListView DetallesDeProductosListView;
        private ColumnHeader SKUCol;
        private ColumnHeader DescripcionCol;
        private ColumnHeader CantPedidaCol;
        private Label label11;
        private TextBox CantDisponibleText;
        private Button QuitarBtn;
        private ColumnHeader ModalidadCol;
        private Button CancelarBtn;
        private Button IngresarOPBtn;
        private TextBox DNITransportistaText;
        private Label label12;
    }
}