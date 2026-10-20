namespace GrupoB.Pampazon.ControlarMermasEIncidencias
{
    partial class ControlarMermasEIncidenciasForm
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
            listView1 = new ListView();
            Columna = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(368, 25);
            label1.TabIndex = 0;
            label1.Text = "INCIDENCIAS PENDIENTES DE REVISION";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Columna, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(24, 78);
            listView1.Name = "listView1";
            listView1.Size = new Size(1036, 161);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Columna
            // 
            Columna.Text = "N° Incidencia";
            Columna.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha/Hora";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Operario Reportante";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SKU / Descripcion";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ubicacion";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Cant.";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Causa Reportada";
            columnHeader6.Width = 200;
            // 
            // button1
            // 
            button1.Location = new Point(937, 251);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Ver Detalle";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(24, 286);
            label2.Name = "label2";
            label2.Size = new Size(380, 25);
            label2.TabIndex = 3;
            label2.Text = "AUDITORIA Y REVISION DEL SUPERVISOR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 355);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 202);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 321);
            label3.Name = "label3";
            label3.Size = new Size(281, 25);
            label3.TabIndex = 5;
            label3.Text = "Justificacion Tecnica del Operador:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 321);
            label4.Name = "label4";
            label4.Size = new Size(305, 25);
            label4.TabIndex = 7;
            label4.Text = "Dictamen / Justificacion de Auditoria:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(513, 355);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(547, 138);
            textBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(513, 513);
            button2.Name = "button2";
            button2.Size = new Size(277, 44);
            button2.TabIndex = 8;
            button2.Text = "APROBAR BAJA DEFINITIVA";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(815, 513);
            button3.Name = "button3";
            button3.Size = new Size(245, 44);
            button3.TabIndex = 9;
            button3.Text = "RECHAZAR / REINTEGRAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // ControlarMermasEIncidenciasForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 587);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "ControlarMermasEIncidenciasForm";
            Text = "ControlarMermasEIncidenciasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader Columna;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}