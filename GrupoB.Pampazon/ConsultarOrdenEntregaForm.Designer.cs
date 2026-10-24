namespace GrupoB.Pampazon
{
    partial class ConsultarOrdenEntregaForm
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
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "P-1000", "10/10/2026", "Entregado" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "P-1001", "10/10/2026", "Entregado" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "P-1002", "11/10/2026", "Pendiente" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "P-1003", "11/10/2026", "Pendiente" }, -1);
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            checkBox1 = new CheckBox();
            listView1 = new ListView();
            colPedido = new ColumnHeader();
            fechacol = new ColumnHeader();
            estadoCol = new ColumnHeader();
            button2 = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label2);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(2, 11);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(469, 282);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "CONSULTAR ORDEN DE ENTREGA";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(193, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 27);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "OE-1000-1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(325, 21);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 27);
            button1.TabIndex = 9;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 26);
            label2.Name = "label2";
            label2.Size = new Size(165, 19);
            label2.TabIndex = 3;
            label2.Text = "Nro. Orden de Entrega:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Indeterminate;
            checkBox1.Location = new Point(9, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(379, 23);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Mostrar órdenes de entrega con pedidos pendientes";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { colPedido, fechacol, estadoCol });
            listView1.ForeColor = SystemColors.InfoText;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6, listViewItem7, listViewItem8 });
            listView1.Location = new Point(6, 99);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(334, 139);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colPedido
            // 
            colPedido.Text = "N°Pedido";
            colPedido.Width = 100;
            // 
            // fechacol
            // 
            fechacol.Text = "Fecha";
            fechacol.Width = 130;
            // 
            // estadoCol
            // 
            estadoCol.Text = "Estado";
            estadoCol.Width = 100;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(325, 242);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 27);
            button2.TabIndex = 22;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ConsultarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 307);
            Controls.Add(groupBox2);
            Name = "ConsultarOrdenEntregaForm";
            Text = "ConsultarOrdenEntregaForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label2;
        private CheckBox checkBox1;
        private ListView listView1;
        private ColumnHeader merccol;
        private ColumnHeader colPedido;
        private Button button2;
        private ColumnHeader fechacol;
        private ColumnHeader estadoCol;
    }
}