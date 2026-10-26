namespace GrupoB.Pampazon
{
    partial class EmitirOrdenDeSeleccionForm
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
            opLIST = new ListView();
            Número = new ColumnHeader();
            Fecha_recibida = new ColumnHeader();
            ClienteCOL = new ColumnHeader();
            Cantcol = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            consoLIST = new ListView();
            SKUCOL = new ColumnHeader();
            DescripCOL = new ColumnHeader();
            cantidadcol = new ColumnHeader();
            ModalidadCOL = new ColumnHeader();
            CantSelCOL = new ColumnHeader();
            cancelarBTN = new Button();
            UbicacionCOL = new ColumnHeader();
            clienteBox = new ComboBox();
            generarOSBTN = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            agregarBTN = new Button();
            button2 = new Button();
            opselectLIST = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            skudetailCOL = new ColumnHeader();
            descripciondetailCOL = new ColumnHeader();
            cantidaddetailCOL = new ColumnHeader();
            opdetailsLIST = new ListView();
            detailSKUCOL = new ColumnHeader();
            detailDESCCOL = new ColumnHeader();
            detailCANTCOL = new ColumnHeader();
            detailMODALIDADCOL = new ColumnHeader();
            label4 = new Label();
            listView1 = new ListView();
            opAfectadasCOL = new ColumnHeader();
            groupBox2 = new GroupBox();
            opDINLBLI = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            opDINLBLD = new Label();
            label2 = new Label();
            listView2 = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            opTX = new TextBox();
            label1 = new Label();
            limpiarBTN = new Button();
            groupBox1 = new GroupBox();
            buscarBTN = new Button();
            label6 = new Label();
            groupBox4 = new GroupBox();
            agregartodasBTN = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // opLIST
            // 
            opLIST.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            opLIST.Columns.AddRange(new ColumnHeader[] { Número, Fecha_recibida, ClienteCOL });
            opLIST.FullRowSelect = true;
            opLIST.Location = new Point(12, 134);
            opLIST.Name = "opLIST";
            opLIST.Size = new Size(505, 195);
            opLIST.Sorting = SortOrder.Descending;
            opLIST.TabIndex = 0;
            opLIST.UseCompatibleStateImageBehavior = false;
            opLIST.View = View.Details;
            opLIST.SelectedIndexChanged += opLIST_SelectedIndexChanged;
            // 
            // Número
            // 
            Número.Text = "# OP";
            Número.Width = 80;
            // 
            // Fecha_recibida
            // 
            Fecha_recibida.Text = "Fecha recibida";
            Fecha_recibida.Width = 150;
            // 
            // ClienteCOL
            // 
            ClienteCOL.Text = "Cliente";
            ClienteCOL.Width = 250;
            // 
            // Cantcol
            // 
            Cantcol.Text = "Cantidad";
            Cantcol.Width = 254;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cliente";
            columnHeader3.Width = 254;
            // 
            // consoLIST
            // 
            consoLIST.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            consoLIST.Columns.AddRange(new ColumnHeader[] { SKUCOL, DescripCOL, cantidadcol, ModalidadCOL });
            consoLIST.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consoLIST.FullRowSelect = true;
            consoLIST.Location = new Point(4, 52);
            consoLIST.Name = "consoLIST";
            consoLIST.Size = new Size(790, 253);
            consoLIST.TabIndex = 7;
            consoLIST.UseCompatibleStateImageBehavior = false;
            consoLIST.View = View.Details;
            // 
            // SKUCOL
            // 
            SKUCOL.Text = "SKU";
            // 
            // DescripCOL
            // 
            DescripCOL.Text = "Descripción";
            DescripCOL.Width = 250;
            // 
            // cantidadcol
            // 
            cantidadcol.DisplayIndex = 3;
            cantidadcol.Text = "Cantidad";
            cantidadcol.Width = 100;
            // 
            // ModalidadCOL
            // 
            ModalidadCOL.DisplayIndex = 2;
            ModalidadCOL.Text = "Modalidad";
            ModalidadCOL.Width = 200;
            // 
            // CantSelCOL
            // 
            CantSelCOL.Text = "Cantidad";
            CantSelCOL.Width = 100;
            // 
            // cancelarBTN
            // 
            cancelarBTN.Location = new Point(1049, 890);
            cancelarBTN.Name = "cancelarBTN";
            cancelarBTN.Size = new Size(101, 29);
            cancelarBTN.TabIndex = 9;
            cancelarBTN.Text = "Cancelar";
            cancelarBTN.UseVisualStyleBackColor = true;
            cancelarBTN.Click += button4_Click;
            // 
            // UbicacionCOL
            // 
            UbicacionCOL.Text = "Ubicación (X-Y-Z)";
            // 
            // clienteBox
            // 
            clienteBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clienteBox.FormattingEnabled = true;
            clienteBox.Location = new Point(86, 20);
            clienteBox.Name = "clienteBox";
            clienteBox.Size = new Size(409, 28);
            clienteBox.TabIndex = 14;
            // 
            // generarOSBTN
            // 
            generarOSBTN.Location = new Point(816, 890);
            generarOSBTN.Name = "generarOSBTN";
            generarOSBTN.Size = new Size(213, 29);
            generarOSBTN.TabIndex = 22;
            generarOSBTN.Text = "Emitir orden de selección";
            generarOSBTN.UseVisualStyleBackColor = true;
            generarOSBTN.Click += generarOSBTN_Click_1;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "SKU";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descripción";
            columnHeader2.Width = 700;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cantidad";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "# OP";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha recibida";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Cliente";
            columnHeader7.Width = 250;
            // 
            // agregarBTN
            // 
            agregarBTN.Location = new Point(540, 202);
            agregarBTN.Name = "agregarBTN";
            agregarBTN.Size = new Size(95, 29);
            agregarBTN.TabIndex = 20;
            agregarBTN.Text = "Agregar >";
            agregarBTN.UseVisualStyleBackColor = true;
            agregarBTN.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(540, 236);
            button2.Name = "button2";
            button2.Size = new Size(95, 29);
            button2.TabIndex = 33;
            button2.Text = "Quitar <";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // opselectLIST
            // 
            opselectLIST.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            opselectLIST.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10 });
            opselectLIST.FullRowSelect = true;
            opselectLIST.Location = new Point(658, 134);
            opselectLIST.Name = "opselectLIST";
            opselectLIST.Size = new Size(489, 195);
            opselectLIST.Sorting = SortOrder.Descending;
            opselectLIST.TabIndex = 34;
            opselectLIST.UseCompatibleStateImageBehavior = false;
            opselectLIST.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "# OP";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Fecha recibida";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Cliente";
            columnHeader10.Width = 250;
            // 
            // skudetailCOL
            // 
            skudetailCOL.Text = "SKU";
            skudetailCOL.Width = 200;
            // 
            // descripciondetailCOL
            // 
            descripciondetailCOL.Text = "Descripcion";
            descripciondetailCOL.Width = 400;
            // 
            // cantidaddetailCOL
            // 
            cantidaddetailCOL.Text = "Cantidad";
            cantidaddetailCOL.Width = 100;
            // 
            // opdetailsLIST
            // 
            opdetailsLIST.Columns.AddRange(new ColumnHeader[] { detailSKUCOL, detailDESCCOL, detailCANTCOL, detailMODALIDADCOL });
            opdetailsLIST.Location = new Point(12, 389);
            opdetailsLIST.Name = "opdetailsLIST";
            opdetailsLIST.Size = new Size(505, 158);
            opdetailsLIST.TabIndex = 29;
            opdetailsLIST.UseCompatibleStateImageBehavior = false;
            opdetailsLIST.View = View.Details;
            // 
            // detailSKUCOL
            // 
            detailSKUCOL.Text = "SKU";
            detailSKUCOL.Width = 80;
            // 
            // detailDESCCOL
            // 
            detailDESCCOL.Text = "Descripción";
            detailDESCCOL.Width = 200;
            // 
            // detailCANTCOL
            // 
            detailCANTCOL.DisplayIndex = 3;
            detailCANTCOL.Text = "Cantidad";
            detailCANTCOL.Width = 80;
            // 
            // detailMODALIDADCOL
            // 
            detailMODALIDADCOL.DisplayIndex = 2;
            detailMODALIDADCOL.Text = "Modalidad";
            detailMODALIDADCOL.Width = 120;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.Location = new Point(16, 368);
            label4.Name = "label4";
            label4.Size = new Size(84, 18);
            label4.TabIndex = 35;
            label4.Text = "Detalle OP";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { opAfectadasCOL });
            listView1.Location = new Point(823, 621);
            listView1.Name = "listView1";
            listView1.Size = new Size(331, 253);
            listView1.TabIndex = 36;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // opAfectadasCOL
            // 
            opAfectadasCOL.Text = "Ordenes de preparación afectadas";
            opAfectadasCOL.Width = 300;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(opDINLBLI);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(6, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(517, 485);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenes de preparación pendientes";
            // 
            // opDINLBLI
            // 
            opDINLBLI.AutoSize = true;
            opDINLBLI.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            opDINLBLI.Location = new Point(122, 287);
            opDINLBLI.Name = "opDINLBLI";
            opDINLBLI.Size = new Size(16, 18);
            opDINLBLI.TabIndex = 43;
            opDINLBLI.Text = "#";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.Location = new Point(116, 287);
            label3.Name = "label3";
            label3.Size = new Size(0, 18);
            label3.TabIndex = 43;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(opDINLBLD);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(listView2);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(645, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(517, 482);
            groupBox3.TabIndex = 40;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ordenes de preparación seleccionadas";
            // 
            // opDINLBLD
            // 
            opDINLBLD.AutoSize = true;
            opDINLBLD.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            opDINLBLD.Location = new Point(106, 287);
            opDINLBLD.Name = "opDINLBLD";
            opDINLBLD.Size = new Size(16, 18);
            opDINLBLD.TabIndex = 44;
            opDINLBLD.Text = "#";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.Location = new Point(10, 287);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 42;
            label2.Text = "Detalle OP";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listView2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView2.Location = new Point(13, 308);
            listView2.Name = "listView2";
            listView2.Size = new Size(492, 158);
            listView2.TabIndex = 41;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "SKU";
            columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Descripción";
            columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            columnHeader13.DisplayIndex = 3;
            columnHeader13.Text = "Cantidad";
            columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            columnHeader14.DisplayIndex = 2;
            columnHeader14.Text = "Modalidad";
            columnHeader14.Width = 120;
            // 
            // opTX
            // 
            opTX.Location = new Point(583, 20);
            opTX.Name = "opTX";
            opTX.Size = new Size(125, 27);
            opTX.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(520, 23);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 42;
            label1.Text = "OP #";
            // 
            // limpiarBTN
            // 
            limpiarBTN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            limpiarBTN.Location = new Point(1047, 20);
            limpiarBTN.Name = "limpiarBTN";
            limpiarBTN.Size = new Size(94, 29);
            limpiarBTN.TabIndex = 44;
            limpiarBTN.Text = "Limpiar";
            limpiarBTN.UseVisualStyleBackColor = true;
            limpiarBTN.Click += limpiarBTN_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buscarBTN);
            groupBox1.Controls.Add(limpiarBTN);
            groupBox1.Controls.Add(clienteBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(opTX);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(9, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1153, 57);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            // 
            // buscarBTN
            // 
            buscarBTN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buscarBTN.Location = new Point(947, 20);
            buscarBTN.Name = "buscarBTN";
            buscarBTN.Size = new Size(94, 29);
            buscarBTN.TabIndex = 45;
            buscarBTN.Text = "Buscar";
            buscarBTN.UseVisualStyleBackColor = true;
            buscarBTN.Click += buscarBTN_Click_2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 24);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 16;
            label6.Text = "Cliente";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(consoLIST);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(12, 569);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1150, 315);
            groupBox4.TabIndex = 40;
            groupBox4.TabStop = false;
            groupBox4.Text = "Orden de selección #X";
            // 
            // agregartodasBTN
            // 
            agregartodasBTN.Location = new Point(540, 144);
            agregartodasBTN.Name = "agregartodasBTN";
            agregartodasBTN.Size = new Size(95, 52);
            agregartodasBTN.TabIndex = 41;
            agregartodasBTN.Text = "Agregar todas >>";
            agregartodasBTN.UseVisualStyleBackColor = true;
            agregartodasBTN.Click += agregartodasBTN_Click;
            // 
            // EmitirOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 923);
            Controls.Add(agregartodasBTN);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(opdetailsLIST);
            Controls.Add(opselectLIST);
            Controls.Add(button2);
            Controls.Add(agregarBTN);
            Controls.Add(generarOSBTN);
            Controls.Add(cancelarBTN);
            Controls.Add(opLIST);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmitirOrdenDeSeleccionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Emitir orden de selección";
            Load += EmitirOrdenDeSeleccionForm_Load_1;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView opLIST;
        private ColumnHeader Número;
        private ColumnHeader Fecha_recibida;
        private Button button1;
        private ColumnHeader Cantcol;
        private ColumnHeader columnHeader3;
        private ListView consoLIST;
        private ListView detailLIST;
        private ColumnHeader CantSelCOL;
        private Button limpiarBTN;
        private Button cancelarBTN;
        private ColumnHeader UbicacionCOL;
        private ColumnHeader SKUCOL;
        private ColumnHeader DescripCOL;
        private ColumnHeader cantidadcol;
        private ColumnHeader ModalidadCOL;
        private ComboBox clienteBox;
        private Button button5;
        private Button generarOSBTN;
        private ColumnHeader ClienteCOL;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ListView opdetailLIST;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ListView listView3;
        private Button agregarBTN;
        private Button button2;
        private ListView opselectLIST;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader TipoCOL;
        private ColumnHeader skudetailCOL;
        private ColumnHeader descripciondetailCOL;
        private ColumnHeader cantidaddetailCOL;
        private ListView opdetailsLIST;
        private ColumnHeader detailSKUCOL;
        private ColumnHeader detailDESCCOL;
        private ColumnHeader detailCANTCOL;
        private Label label4;
        private ListView listView1;
        private ColumnHeader opAfectadasCOL;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox opTX;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private ColumnHeader detailMODALIDADCOL;
        private Label label6;
        private Label label2;
        private ListView listView2;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Button agregartodasBTN;
        private Label opDINLBLI;
        private Label label3;
        private Label opDINLBLD;
        private Button buscarBTN;
    }
}