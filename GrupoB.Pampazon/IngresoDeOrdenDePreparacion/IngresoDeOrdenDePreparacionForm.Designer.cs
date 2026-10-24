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
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            comboBox3 = new ComboBox();
            label9 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label10 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label11 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(22, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(330, 20);
            label1.TabIndex = 0;
            label1.Text = "DATOS GENERALES DE LA ORDEN Y CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Cliente / Empresa:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 61);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(282, 28);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 61);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 3;
            label3.Text = "CUIT Cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(561, 61);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 110);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 5;
            label4.Text = "Fecha Solicitada:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(155, 110);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(162, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 210);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 7;
            label5.Text = "Modalidad:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(597, 210);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 28);
            comboBox2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 110);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 9;
            label6.Text = "Transportista:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(561, 107);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 27);
            textBox2.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(22, 171);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(288, 20);
            label7.TabIndex = 11;
            label7.Text = "INGRESO DE PRODUCTOS A LA ORDEN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 210);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 12;
            label8.Text = "SKU del Cliente:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(185, 210);
            comboBox3.Margin = new Padding(2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(196, 28);
            comboBox3.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(460, 275);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 14;
            label9.Text = "Cantidad a Pedir:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(597, 272);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 27);
            textBox3.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(27, 320);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(730, 27);
            button1.TabIndex = 16;
            button1.Text = "Agregar a la Orden";
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.HotTrack;
            label10.Location = new Point(22, 369);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(295, 20);
            label10.TabIndex = 17;
            label10.Text = "DETALLE DE PRODUCTOS EN LA ORDEN";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(27, 395);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(730, 146);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "SKU";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descripcion del Producto";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cant. Pedida";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Peso Unitario";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Modalidad";
            columnHeader5.Width = 200;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 275);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(148, 20);
            label11.TabIndex = 19;
            label11.Text = "Cantidad Disponible:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.AppWorkspace;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(185, 272);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(132, 27);
            textBox4.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(659, 545);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(98, 27);
            button2.TabIndex = 21;
            button2.Text = "Quitar ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(597, 606);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(160, 27);
            button4.TabIndex = 23;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(362, 606);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(227, 27);
            button5.TabIndex = 24;
            button5.Text = "Ingresar Orden de Preparacion";
            button5.UseVisualStyleBackColor = true;
            // 
            // IngresoDeOrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 644);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label11);
            Controls.Add(listView1);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(comboBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
        private ComboBox comboBox3;
        private Label label9;
        private TextBox textBox3;
        private Button button1;
        private Label label10;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label11;
        private TextBox textBox4;
        private ColumnHeader columnHeader4;
        private Button button2;
        private ColumnHeader columnHeader5;
        private Button button4;
        private Button button5;
    }
}