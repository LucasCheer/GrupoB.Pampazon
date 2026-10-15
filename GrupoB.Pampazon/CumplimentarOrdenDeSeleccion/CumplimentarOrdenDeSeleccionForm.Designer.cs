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
            ListViewItem listViewItem3 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "1", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)), new ListViewItem.ListViewSubItem(null, "12-43-2", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)), new ListViewItem.ListViewSubItem(null, "CEM-01", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)), new ListViewItem.ListViewSubItem(null, "Bolsa Cemento 35kg", SystemColors.InfoText, SystemColors.Window, new Font("Segoe UI", 10.2F)), new ListViewItem.ListViewSubItem(null, "50"), new ListViewItem.ListViewSubItem(null, "Retirado") }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "2", "14-10-1", "CEM-02", "Bolsa Cal 25kg", "20", "Pendiente" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 10.2F));
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            listView2 = new ListView();
            colOrden = new ColumnHeader();
            colCoord = new ColumnHeader();
            colSKU = new ColumnHeader();
            colDesc = new ColumnHeader();
            colCant = new ColumnHeader();
            colEstado = new ColumnHeader();
            textBox3 = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(823, 122);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "ORDEN DE SELECCIÓN ASIGNADA";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(371, 32);
            button1.Name = "button1";
            button1.Size = new Size(182, 30);
            button1.TabIndex = 9;
            button1.Text = "Cargar Hoja de Ruta";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 30);
            textBox1.TabIndex = 4;
            textBox1.Text = "PICK-5000";
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(731, 41);
            label1.TabIndex = 7;
            label1.Text = "CUMPLIMENTAR ORDEN DE SELECCIÓN - PICKING";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F);
            textBox2.Location = new Point(221, 77);
            textBox2.Margin = new Padding(6, 3, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(144, 30);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(listView2);
            groupBox1.Controls.Add(label4);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(823, 238);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "HOJA DE RUTA";
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView2.Columns.AddRange(new ColumnHeader[] { colOrden, colCoord, colSKU, colDesc, colCant, colEstado });
            listView2.ForeColor = SystemColors.InfoText;
            listViewItem4.Tag = "";
            listView2.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            listView2.Location = new Point(6, 39);
            listView2.Name = "listView2";
            listView2.Size = new Size(766, 135);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // colOrden
            // 
            colOrden.Text = "Orden";
            colOrden.Width = 100;
            // 
            // colCoord
            // 
            colCoord.Text = "Coordenada X-Y-Z";
            colCoord.Width = 200;
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
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 100;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.2F);
            textBox3.Location = new Point(227, 188);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(102, 30);
            textBox3.TabIndex = 14;
            textBox3.Text = "12-43-2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 191);
            label4.Name = "label4";
            label4.Size = new Size(215, 23);
            label4.TabIndex = 13;
            label4.Text = "Escanear ubicación (rack):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button4);
            groupBox3.FlatStyle = FlatStyle.System;
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 446);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(823, 122);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "ACCIONES - FINALIZACIÓN";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(6, 39);
            button2.Name = "button2";
            button2.Size = new Size(300, 30);
            button2.TabIndex = 9;
            button2.Text = "⚠REPORTAR DISCREPANCIA ";
            button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(8, 85);
            label6.Name = "label6";
            label6.Size = new Size(321, 20);
            label6.TabIndex = 20;
            label6.Text = "⚠ Falta recolectar ubicaciones en el recorrido.";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10.2F);
            button3.Location = new Point(564, 82);
            button3.Name = "button3";
            button3.Size = new Size(127, 29);
            button3.TabIndex = 19;
            button3.Text = "Finalizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI", 10.2F);
            button4.Location = new Point(709, 82);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 18;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // CumplimentarOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 582);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "CumplimentarOrdenDeSeleccion";
            Text = "CumplimentarOrdenDeSeleccion";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private GroupBox groupBox1;
        private ListView listView2;
        private ColumnHeader colOrden;
        private ColumnHeader colCoord;
        private ColumnHeader colSKU;
        private ColumnHeader colDesc;
        private ColumnHeader colCant;
        private ColumnHeader colEstado;
        private TextBox textBox3;
        private Label label4;
        private GroupBox groupBox3;
        private Button button2;
        private Label label6;
        private Button button3;
        private Button button4;
    }
}