namespace GrupoB.Pampazon.IngresarOrdenDePreparacion
{
    partial class IngresarOrdenDePreparacionForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(726, 25);
            label1.TabIndex = 0;
            label1.Text = "DATOS GENERALES DE LA ORDEN DE PREPARACION (RECEPCIONADA VIA WEB)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(16, 63);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 1;
            label2.Text = "ID Orden Web:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(166, 61);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(170, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(452, 61);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(325, 31);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(366, 63);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 3;
            label3.Text = "Cliente:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLight;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(941, 61);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(343, 31);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(809, 63);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 5;
            label4.Text = "CUIT Cliente:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlLight;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(166, 131);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(170, 31);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(16, 133);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 7;
            label5.Text = "Fecha Entrega:";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ControlLight;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(487, 131);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(290, 31);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(366, 133);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 9;
            label6.Text = "Modalidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 206);
            label7.Name = "label7";
            label7.Size = new Size(630, 25);
            label7.TabIndex = 11;
            label7.Text = "DETALLE DE PRODUCTOS SOLICITADOS VS. INVENTARIO DISPONIBLE";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(16, 250);
            listView1.Name = "listView1";
            listView1.Size = new Size(1268, 225);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo SKU";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descripcion del Producto";
            columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cant. Pedida";
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Inventario Disponible";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Peso Unit.";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Estado de Inventario / Bulto";
            columnHeader6.Width = 290;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 505);
            label8.Name = "label8";
            label8.Size = new Size(630, 25);
            label8.TabIndex = 13;
            label8.Text = "DETALLE DE PRODUCTOS SOLICITADOS VS. INVENTARIO DISPONIBLE";
            // 
            // IngresarOrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 789);
            Controls.Add(label8);
            Controls.Add(listView1);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.HotTrack;
            Name = "IngresarOrdenDePreparacionForm";
            Text = "IngresarOrdenDePreparacionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label8;
    }
}