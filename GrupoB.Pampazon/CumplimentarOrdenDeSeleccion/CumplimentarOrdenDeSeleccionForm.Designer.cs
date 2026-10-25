namespace GrupoB.Pampazon.CumplimentarOrdenDeSeleccion
{
    partial class CumplimentarOrdenDeSeleccionForm
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
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "1", SystemColors.InfoText, SystemColors.ActiveCaption, new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)), new ListViewItem.ListViewSubItem(null, "CEM-01", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)), new ListViewItem.ListViewSubItem(null, "Bolsa Cemento 35kg", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)), new ListViewItem.ListViewSubItem(null, "50"), new ListViewItem.ListViewSubItem(null, "Retirado") }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "2", "CEM-02", "Bolsa Cal 25kg", "20", "Pendiente" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10.2F));
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "12-43-2", "CEM-02", "Bolsa Cal 25kg", "20", "Pendiente" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10.2F));
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "14-10-1" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0));
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            listView2 = new ListView();
            colOrden = new ColumnHeader();
            colSKU = new ColumnHeader();
            colDesc = new ColumnHeader();
            colCant = new ColumnHeader();
            listView1 = new ListView();
            colCoordRut = new ColumnHeader();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label2);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(11, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 123);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "ORDEN DE SELECCIÓN ASIGNADA";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(221, 36);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 31);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "PICK-5000";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F);
            textBox2.Location = new Point(221, 77);
            textBox2.Margin = new Padding(6, 3, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(143, 30);
            textBox2.TabIndex = 11;
            textBox2.Text = "Juan Pérez";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 10;
            label3.Text = "Operario asignado:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(371, 32);
            button1.Name = "button1";
            button1.Size = new Size(182, 36);
            button1.TabIndex = 9;
            button1.Text = "Cargar Hoja de Ruta";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(209, 23);
            label2.TabIndex = 3;
            label2.Text = "Nro. Orden de Selección:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(731, 41);
            label1.TabIndex = 7;
            label1.Text = "CUMPLIMENTAR ORDEN DE SELECCIÓN - PICKING";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(listView2);
            groupBox1.Controls.Add(listView1);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 259);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "HOJA DE RUTA";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI", 10.2F);
            button4.Location = new Point(753, 201);
            button4.Name = "button4";
            button4.Size = new Size(99, 52);
            button4.TabIndex = 18;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI", 10.2F);
            button3.Location = new Point(648, 201);
            button3.Name = "button3";
            button3.Size = new Size(99, 52);
            button3.TabIndex = 19;
            button3.Text = "Finalizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView2.Columns.AddRange(new ColumnHeader[] { colOrden, colSKU, colDesc, colCant });
            listView2.ForeColor = SystemColors.InfoText;
            listViewItem2.Tag = "";
            listView2.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView2.Location = new Point(6, 39);
            listView2.Name = "listView2";
            listView2.Size = new Size(467, 135);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // colOrden
            // 
            colOrden.Text = "Orden";
            colOrden.Width = 100;
            // 
            // colSKU
            // 
            colSKU.Text = "SKU";
            colSKU.Width = 100;
            // 
            // colDesc
            // 
            colDesc.Text = "Descripción";
            colDesc.Width = 200;
            // 
            // colCant
            // 
            colCant.Text = "Cant.";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { colCoordRut });
            listView1.ForeColor = SystemColors.InfoText;
            listViewItem3.Tag = "";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            listView1.Location = new Point(495, 39);
            listView1.Name = "listView1";
            listView1.Size = new Size(357, 135);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colCoordRut
            // 
            colCoordRut.Text = "Coordenadas del producto seleccionado";
            colCoordRut.Width = 350;
            // 
            // CumplimentarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 469);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "CumplimentarOrdenDeSeleccionForm";
            Text = "CumplimentarOrdenDeSeleccion";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private GroupBox groupBox1;
        private ListView listView2;
        private ColumnHeader colOrden;
        private ColumnHeader colSKU;
        private ColumnHeader colDesc;
        private ColumnHeader colCant;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private ListView listView1;
        private ColumnHeader colCoordRut;
    }
}