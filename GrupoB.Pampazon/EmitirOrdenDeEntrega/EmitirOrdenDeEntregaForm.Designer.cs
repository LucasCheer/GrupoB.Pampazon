namespace GrupoB.Pampazon.EmitirOrdenDeEntrega
{
    partial class EmitirOrdenDeEntregaForm
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
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "P-1000", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)), new ListViewItem.ListViewSubItem(null, "11/10/2026", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)), new ListViewItem.ListViewSubItem(null, "Mercado 1", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)), new ListViewItem.ListViewSubItem(null, "4", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)) }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "P-1001", "10/10/2026", "Mercado 2", "2" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10.2F));
            ListViewItem listViewItem3 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "CEM-01", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)), new ListViewItem.ListViewSubItem(null, "Bolsa Cemento 35kg", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)), new ListViewItem.ListViewSubItem(null, "123456789", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)), new ListViewItem.ListViewSubItem(null, "Escaneado", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)) }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "CEM-02", "Bolsa Cal 25kg", "365799321", "Pendiente de escaneo" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10.2F));
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            colPedido = new ColumnHeader();
            colFecha = new ColumnHeader();
            colCliente = new ColumnHeader();
            colBulto = new ColumnHeader();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            listView2 = new ListView();
            colSKU = new ColumnHeader();
            colDesc = new ColumnHeader();
            colBar = new ColumnHeader();
            colEstad = new ColumnHeader();
            colEstado = new ColumnHeader();
            groupBox3 = new GroupBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(749, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SELECCIÓN DE PEDIDO PREPARADO";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { colPedido, colFecha, colCliente, colBulto });
            listView1.ForeColor = SystemColors.InfoText;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(6, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(710, 144);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colPedido
            // 
            colPedido.Text = "N°Pedido";
            colPedido.Width = 153;
            // 
            // colFecha
            // 
            colFecha.Text = "Fecha Preparación";
            colFecha.Width = 200;
            // 
            // colCliente
            // 
            colCliente.Text = "Cliente";
            colCliente.Width = 153;
            // 
            // colBulto
            // 
            colBulto.Text = "Cant. Bultos";
            colBulto.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(424, 41);
            label1.TabIndex = 1;
            label1.Text = "EMITIR ORDEN DE ENTREGA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(listView2);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(749, 293);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "DETALLE DEL PEDIDO - VALIDACIÓN DE BULTOS";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 244);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(144, 30);
            textBox3.TabIndex = 8;
            textBox3.Text = "123456789";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 247);
            label4.Name = "label4";
            label4.Size = new Size(131, 23);
            label4.TabIndex = 7;
            label4.Text = "Escanear bulto:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(548, 42);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(144, 30);
            textBox2.TabIndex = 6;
            textBox2.Text = "OP-4000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 45);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 5;
            label3.Text = "OP asociado:";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 42);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(144, 30);
            textBox1.TabIndex = 4;
            textBox1.Text = "Mercado 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 45);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 3;
            label2.Text = "Cliente:";
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView2.Columns.AddRange(new ColumnHeader[] { colSKU, colDesc, colBar, colEstad });
            listView2.ForeColor = SystemColors.InfoText;
            listViewItem4.Tag = "";
            listView2.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            listView2.Location = new Point(6, 87);
            listView2.Name = "listView2";
            listView2.Size = new Size(710, 144);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // colSKU
            // 
            colSKU.Text = "SKU";
            colSKU.Width = 100;
            // 
            // colDesc
            // 
            colDesc.Text = "Descripcion";
            colDesc.Width = 200;
            // 
            // colBar
            // 
            colBar.Text = "Etiqueta Código Barras";
            colBar.Width = 200;
            // 
            // colEstad
            // 
            colEstad.Text = "Estado";
            colEstad.Width = 200;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 150;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.FlatStyle = FlatStyle.System;
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 569);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(749, 200);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "DATOS DE DESPACHO";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(204, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(362, 30);
            textBox4.TabIndex = 9;
            textBox4.Text = "Av. Córdoba";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(204, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 30);
            dateTimePicker1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(204, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(362, 31);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Logística Rápida S.A.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 138);
            label7.Name = "label7";
            label7.Size = new Size(172, 23);
            label7.TabIndex = 11;
            label7.Text = "Fecha prev. entrega:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 91);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 10;
            label6.Text = "Destino final:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 44);
            label5.Name = "label5";
            label5.Size = new Size(178, 23);
            label5.TabIndex = 9;
            label5.Text = "Transporte asignado:";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(667, 780);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(522, 780);
            button2.Name = "button2";
            button2.Size = new Size(127, 29);
            button2.TabIndex = 5;
            button2.Text = "Emitir Orden";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(12, 784);
            label8.Name = "label8";
            label8.Size = new Size(345, 20);
            label8.TabIndex = 14;
            label8.Text = "⚠ Faltan escanear bultos para habilitar la emisión";
            label8.Click += label8_Click;
            // 
            // EmitirOrdenDeEntrega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 830);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "EmitirOrdenDeEntrega";
            Text = "EmitirOrdenDeEntrega";
            Load += EmitirOrdenDeEntrega_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ListView listView1;
        private ColumnHeader colPedido;
        private ColumnHeader colFecha;
        private ColumnHeader colCliente;
        private ColumnHeader colBulto;
        private GroupBox groupBox2;
        private ListView listView2;

        public ColumnHeader colSKUu { get; private set; }

        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader colEstado;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private GroupBox groupBox3;
        private ColumnHeader colSKU;
        private ColumnHeader colDesc;
        private ColumnHeader colBar;
        private ColumnHeader colEstad;
        private Label label5;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Button button1;
        private Button button2;
        private Label label8;
    }
}