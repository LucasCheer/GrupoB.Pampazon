namespace GrupoB.Pampazon.DespacharPedidoLiberarCamion
{
    partial class DespacharPedidoLiberarCamion
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
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "CEM-01", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)), new ListViewItem.ListViewSubItem(null, "Bolsa Cemento 35kg", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)), new ListViewItem.ListViewSubItem(null, "123456789", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)), new ListViewItem.ListViewSubItem(null, "Escaneado", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)) }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "CEM-02", "Bolsa Cal 25kg", "365799321", "Escaneado" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10.2F));
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            listView2 = new ListView();
            colSKU = new ColumnHeader();
            colDesc = new ColumnHeader();
            colBar = new ColumnHeader();
            colEstad = new ColumnHeader();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            dateTimePicker2 = new DateTimePicker();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            textBox4 = new TextBox();
            label5 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(595, 41);
            label1.TabIndex = 5;
            label1.Text = "DESPACHAR PEDIDO - LIBERAR CAMIÓN";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(749, 91);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "IDENTIFICACIÓN ORDEN DE ENTREGA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 30);
            textBox1.TabIndex = 4;
            textBox1.Text = "OE-9000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(197, 23);
            label2.TabIndex = 3;
            label2.Text = "Nro. Orden de Entrega:";
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView2.Columns.AddRange(new ColumnHeader[] { colSKU, colDesc, colBar, colEstad });
            listView2.ForeColor = SystemColors.InfoText;
            listViewItem2.Tag = "";
            listView2.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView2.Location = new Point(6, 39);
            listView2.Name = "listView2";
            listView2.Size = new Size(713, 107);
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(368, 38);
            button1.Name = "button1";
            button1.Size = new Size(113, 30);
            button1.TabIndex = 9;
            button1.Text = "Validar OE";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(749, 210);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DE DESPACHO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 30);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(362, 30);
            textBox2.TabIndex = 4;
            textBox2.Text = "Mercado 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 37);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 3;
            label3.Text = "Cliente:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(190, 71);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(362, 30);
            textBox5.TabIndex = 6;
            textBox5.Text = "Av. Córdoba";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 78);
            label8.Name = "label8";
            label8.Size = new Size(117, 23);
            label8.TabIndex = 5;
            label8.Text = "Destino final:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 117);
            label9.Name = "label9";
            label9.Size = new Size(178, 23);
            label9.TabIndex = 14;
            label9.Text = "Transporte asignado:";
            label9.Click += label9_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(190, 110);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(362, 30);
            textBox6.TabIndex = 15;
            textBox6.Text = "Logística Rápida S.A.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 160);
            label10.Name = "label10";
            label10.Size = new Size(60, 23);
            label10.TabIndex = 14;
            label10.Text = "Fecha:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(190, 153);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(289, 30);
            dateTimePicker2.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(listView2);
            groupBox3.FlatStyle = FlatStyle.System;
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 408);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(749, 209);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "BULTOS VALIDADOS";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 161);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(144, 30);
            textBox3.TabIndex = 10;
            textBox3.Text = "123456789";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 164);
            label4.Name = "label4";
            label4.Size = new Size(131, 23);
            label4.TabIndex = 9;
            label4.Text = "Escanear bulto:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox1);
            groupBox4.FlatStyle = FlatStyle.System;
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(12, 623);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(749, 91);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "CONFIRMACIÓN DE SALIDA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(12, 733);
            label6.Name = "label6";
            label6.Size = new Size(357, 20);
            label6.TabIndex = 17;
            label6.Text = "⚠ Aún no se ha verificado físicamente el transporte";
            label6.Click += this.label6_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(522, 729);
            button3.Name = "button3";
            button3.Size = new Size(127, 29);
            button3.TabIndex = 16;
            button3.Text = "Liberar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(667, 729);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 15;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(13, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(393, 32);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Verificación física del transporte realizada";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(599, 30);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(120, 30);
            textBox4.TabIndex = 17;
            textBox4.Text = "OP-4000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(557, 33);
            label5.Name = "label5";
            label5.Size = new Size(38, 23);
            label5.TabIndex = 16;
            label5.Text = "OP:";
            // 
            // DespacharPedidoLiberarCamion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 778);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "DespacharPedidoLiberarCamion";
            Text = "DespacharPedidoLiberarCamion";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label2;
        private ListView listView2;
        private ColumnHeader colSKU;
        private ColumnHeader colDesc;
        private ColumnHeader colBar;
        private ColumnHeader colEstad;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private Label label4;
        private GroupBox groupBox4;
        private Label label6;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private Label label5;
    }
}