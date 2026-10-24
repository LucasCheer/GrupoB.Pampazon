namespace GrupoB.Pampazon.DespachoCargaTransporte
{
    partial class DespachoCargaTransporteForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "MER-1000-1", "P-1000" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "MER-1000-2", "P-1000" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "BLT-1001-1", "P-1001" }, -1);
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox7 = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            merccol = new ColumnHeader();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(446, 32);
            label1.TabIndex = 5;
            label1.Text = "DESPACHO - CARGA DE TRANSPORTE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label7);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(10, 50);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(501, 59);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "IDENTIFICACIÓN DEL TRANSPORTE EN PUERTA";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(335, 30);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 18;
            button1.Text = "Consultar cargas";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(200, 27);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(126, 26);
            textBox7.TabIndex = 12;
            textBox7.Text = "12-345-678";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 30);
            label7.Name = "label7";
            label7.Size = new Size(180, 19);
            label7.TabIndex = 10;
            label7.Text = "Ingrese DNI transportista:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label9);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 113);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(501, 228);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "CAJAS ASIGNADAS PARA HOY";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { merccol });
            listView1.ForeColor = SystemColors.InfoText;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(6, 53);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(159, 127);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // merccol
            // 
            merccol.Text = "ID Mercadería";
            merccol.Width = 153;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 191);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(57, 26);
            textBox3.TabIndex = 19;
            textBox3.Text = "3";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 194);
            label4.Name = "label4";
            label4.Size = new Size(154, 19);
            label4.TabIndex = 18;
            label4.Text = "Total de cajas a subir:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(166, 23);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(204, 26);
            textBox6.TabIndex = 15;
            textBox6.Text = "Logística Rápida S.A.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 29);
            label9.Name = "label9";
            label9.Size = new Size(148, 19);
            label9.TabIndex = 14;
            label9.Text = "Transporte validado:";
            label9.Click += label9_Click;
            // 
            // button2
            // 
            button2.Location = new Point(327, 350);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(216, 350);
            button3.Name = "button3";
            button3.Size = new Size(105, 23);
            button3.TabIndex = 12;
            button3.Text = "Registrar carga";
            button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(14, 355);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(196, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Cajas entregadas al transportista";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // DespachoCargaTransporteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 393);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DespachoCargaTransporteForm";
            Text = "DespachoCargaTransporteForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private ListView listView1;
        private ColumnHeader merccol;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
    }
}