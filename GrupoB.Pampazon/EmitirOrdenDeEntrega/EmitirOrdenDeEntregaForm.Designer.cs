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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "P-1000", "09/10/2026", "Mercado 1", "4" }, -1, SystemColors.ControlText, SystemColors.GradientActiveCaption, null);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "P-1001", "10/10/2026", "Mercado 2", "2" }, -1, Color.Empty, SystemColors.GradientActiveCaption, null);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "P-1002", "10/10/2026" }, -1, Color.Empty, SystemColors.GradientActiveCaption, null);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "P-1003", "11/10/2026" }, -1);
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            colPedido = new ColumnHeader();
            colFecha = new ColumnHeader();
            label1 = new Label();
            colEstado = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
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
            groupBox1.Size = new Size(371, 222);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SELECCIÓN DE PEDIDO PREPARADO";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { colPedido, colFecha });
            listView1.ForeColor = SystemColors.InfoText;
            listViewItem4.Tag = "";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listView1.Location = new Point(5, 22);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(360, 181);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(299, 272);
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
            button2.Location = new Point(182, 272);
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
            ClientSize = new Size(399, 304);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmitirOrdenDeEntregaForm";
            Text = "EmitirOrdenDeEntrega";
            Load += EmitirOrdenDeEntrega_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ListView listView1;
        private ColumnHeader colPedido;
        private ColumnHeader colFecha;

        public ColumnHeader colSKUu { get; private set; }

        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader colEstado;
        private Button button1;
        private Button button2;
        private ListViewItem listViewItem1;
        private ListViewItem listViewItem2;
    }
}