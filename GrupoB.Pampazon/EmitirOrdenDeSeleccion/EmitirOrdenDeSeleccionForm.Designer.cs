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
            UBICOL = new ColumnHeader();
            ModalidadCOL = new ColumnHeader();
            CantSelCOL = new ColumnHeader();
            cancelarBTN = new Button();
            UbicacionCOL = new ColumnHeader();
            clienteBox = new ComboBox();
            allCHCK = new CheckBox();
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
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            groupBox2.SuspendLayout();
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
            opLIST.Size = new Size(492, 195);
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
            consoLIST.Columns.AddRange(new ColumnHeader[] { SKUCOL, DescripCOL, cantidadcol, UBICOL, this.ModalidadCOL });
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
            // UBICOL
            // 
            UBICOL.DisplayIndex = 4;
            UBICOL.Text = "Ubicación (X-Y-Z)";
            UBICOL.Width = 170;
            // 
            // ModalidadCOL
            // 
            this.ModalidadCOL.DisplayIndex = 2;
            this.ModalidadCOL.Text = "Modalidad";
            this.ModalidadCOL.Width = 200;
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
            // allCHCK
            // 
            allCHCK.AutoSize = true;
            allCHCK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allCHCK.Location = new Point(346, 23);
            allCHCK.Name = "allCHCK";
            allCHCK.Size = new Size(148, 24);
            allCHCK.TabIndex = 21;
            allCHCK.Text = "Seleccionar todas";
            allCHCK.UseVisualStyleBackColor = true;
            allCHCK.CheckedChanged += allCHCK_CheckedChanged;
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
            agregarBTN.Location = new Point(529, 161);
            agregarBTN.Name = "agregarBTN";
            agregarBTN.Size = new Size(105, 29);
            agregarBTN.TabIndex = 20;
            agregarBTN.Text = "Agregar 🢂";
            agregarBTN.UseVisualStyleBackColor = true;
            agregarBTN.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(529, 235);
            button2.Name = "button2";
            button2.Size = new Size(105, 29);
            button2.TabIndex = 33;
            button2.Text = "Quitar 🢀";
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
            opdetailsLIST.Location = new Point(16, 389);
            opdetailsLIST.Name = "opdetailsLIST";
            opdetailsLIST.Size = new Size(1134, 158);
            opdetailsLIST.TabIndex = 29;
            opdetailsLIST.UseCompatibleStateImageBehavior = false;
            opdetailsLIST.View = View.Details;
            // 
            // detailSKUCOL
            // 
            detailSKUCOL.Text = "SKU";
            detailSKUCOL.Width = 200;
            // 
            // detailDESCCOL
            // 
            detailDESCCOL.Text = "Descripción";
            detailDESCCOL.Width = 500;
            // 
            // detailCANTCOL
            // 
            detailCANTCOL.DisplayIndex = 3;
            detailCANTCOL.Text = "Cantidad";
            detailCANTCOL.Width = 200;
            // 
            // detailMODALIDADCOL
            // 
            detailMODALIDADCOL.DisplayIndex = 2;
            detailMODALIDADCOL.Text = "Modalidad";
            detailMODALIDADCOL.Width = 200;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.Location = new Point(16, 368);
            label4.Name = "label4";
            label4.Size = new Size(96, 18);
            label4.TabIndex = 35;
            label4.Text = "Detalle OP #";
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
            groupBox2.Controls.Add(allCHCK);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(6, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(517, 274);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenes de preparación pendientes";
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(645, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(517, 274);
            groupBox3.TabIndex = 40;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ordenes de preparación seleccionadas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(583, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 41;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(936, 20);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 43;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1047, 20);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 44;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(clienteBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(9, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1153, 57);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
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
            // EmitirOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 923);
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
        private Button button3;
        private Button cancelarBTN;
        private ColumnHeader UbicacionCOL;
        private ColumnHeader SKUCOL;
        private ColumnHeader DescripCOL;
        private ColumnHeader cantidadcol;
        private ColumnHeader UBICOL;
        private ColumnHeader ModalidadCOL;
        private ComboBox clienteBox;
        private Button button5;
        private CheckBox allCHCK;
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
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private ColumnHeader detailMODALIDADCOL;
        private Label label6;
    }
}