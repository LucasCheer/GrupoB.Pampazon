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
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "P-1000", "11/10/2026", "Mercado 1", "4" }, -1, SystemColors.ControlText, SystemColors.GradientActiveCaption, null);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "P-1001", "10/10/2026", "Mercado 2", "2" }, -1);
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            colPedido = new ColumnHeader();
            colFecha = new ColumnHeader();
            colCliente = new ColumnHeader();
            colBulto = new ColumnHeader();
            label1 = new Label();
            colEstado = new ColumnHeader();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 46);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(655, 144);
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
            listView1.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            listView1.Location = new Point(5, 22);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(622, 109);
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
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(341, 32);
            label1.TabIndex = 1;
            label1.Text = "EMITIR ORDEN DE ENTREGA";
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 150;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.FlatStyle = FlatStyle.System;
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(10, 207);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(655, 199);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "DATOS DE DESPACHO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 138);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(321, 26);
            textBox1.TabIndex = 14;
            textBox1.Text = "12-345-678";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 141);
            label2.Name = "label2";
            label2.Size = new Size(127, 19);
            label2.TabIndex = 15;
            label2.Text = "DNI transportista:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(174, 33);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(321, 26);
            textBox5.TabIndex = 9;
            textBox5.Text = "Logística Rápida S.A.";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 65);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(321, 26);
            textBox4.TabIndex = 9;
            textBox4.Text = "Av. Córdoba";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.MenuHighlight;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(174, 104);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(321, 26);
            dateTimePicker1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 104);
            label7.Name = "label7";
            label7.Size = new Size(145, 19);
            label7.TabIndex = 11;
            label7.Text = "Fecha prev. entrega:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 68);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 10;
            label6.Text = "Destino final:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 33);
            label5.Name = "label5";
            label5.Size = new Size(150, 19);
            label5.TabIndex = 9;
            label5.Text = "Transporte asignado:";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(582, 410);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 4;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(465, 410);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(111, 22);
            button2.TabIndex = 5;
            button2.Text = "Emitir Orden";
            button2.UseVisualStyleBackColor = true;
            // 
            // EmitirOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 448);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmitirOrdenDeEntregaForm";
            Text = "EmitirOrdenDeEntrega";
            Load += EmitirOrdenDeEntrega_Load;
            groupBox1.ResumeLayout(false);
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

        public ColumnHeader colSKUu { get; private set; }

        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader colEstado;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox1;
        private Label label2;
        private ListViewItem listViewItem1;
        private ListViewItem listViewItem2;
    }
}