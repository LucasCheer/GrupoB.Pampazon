namespace GrupoB.Pampazon.RegistrarMermasEIncidencias
{
    partial class RegistrarMermasEIncidenciasForm
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(355, 25);
            label1.TabIndex = 0;
            label1.Text = "DATOS GENERALES DE LA INCIDENCIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 58);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "N° Incidencia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 58);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha y Hora:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 58);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 3;
            label4.Text = "Operario Responsable:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(31, 87);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(183, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(425, 87);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(220, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLight;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(228, 87);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(176, 31);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 131);
            label5.Name = "label5";
            label5.Size = new Size(173, 25);
            label5.TabIndex = 7;
            label5.Text = "Sector del Deposito:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(359, 131);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 8;
            label6.Text = "Etapa Operativa:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(289, 33);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(359, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(286, 33);
            comboBox2.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(31, 222);
            label7.Name = "label7";
            label7.Size = new Size(504, 25);
            label7.TabIndex = 11;
            label7.Text = "IDENTIFICACION DEL PRODUCTO E INVENTARIO FISICO";
            // 
            // RegistrarMermasEIncidenciasForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrarMermasEIncidenciasForm";
            Text = "RegistrarMermasEIncidenciasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label7;
    }
}