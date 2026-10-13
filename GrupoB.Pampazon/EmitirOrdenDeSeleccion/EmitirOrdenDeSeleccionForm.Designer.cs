namespace GrupoB.Pampazon.NewFolder
{
    partial class EmitirOrdenDeSeleccionForm
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
            listView1 = new ListView();
            Número = new ColumnHeader();
            Fecha_recibida = new ColumnHeader();
            Cliente = new ColumnHeader();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            listView2 = new ListView();
            Cantcol = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label3 = new Label();
            SKUCol = new ColumnHeader();
            CantidadCOL = new ColumnHeader();
            DescripcionCOL = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { Número, Fecha_recibida, Cliente });
            listView1.Location = new Point(15, 101);
            listView1.Name = "listView1";
            listView1.Size = new Size(376, 275);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Número
            // 
            Número.Text = "# OP";
            Número.Width = 50;
            // 
            // Fecha_recibida
            // 
            Fecha_recibida.Text = "Fecha recibida";
            Fecha_recibida.Width = 100;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(234, 20);
            label1.TabIndex = 1;
            label1.Text = "Ordenes de preparación pendientes";
            // 
            // button1
            // 
            button1.Location = new Point(15, 396);
            button1.Name = "button1";
            button1.Size = new Size(381, 29);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(397, 396);
            button2.Name = "button2";
            button2.Size = new Size(381, 29);
            button2.TabIndex = 3;
            button2.Text = "Quitar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(509, 20);
            label2.TabIndex = 4;
            label2.Text = "Seleccione que ordenes se incluiran en la orden de selección a emitir";
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView2.Columns.AddRange(new ColumnHeader[] { SKUCol, DescripcionCOL, CantidadCOL });
            listView2.Location = new Point(397, 101);
            listView2.Name = "listView2";
            listView2.Size = new Size(381, 275);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // Cantcol
            // 
            Cantcol.Text = "Cantidad";
            Cantcol.Width = 254;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cliente";
            columnHeader3.Width = 254;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(393, 78);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Detalle";
            // 
            // SKUCol
            // 
            SKUCol.Text = "SKU";
            SKUCol.Width = 100;
            // 
            // CantidadCOL
            // 
            CantidadCOL.Text = "Cantidad";
            CantidadCOL.Width = 100;
            // 
            // DescripcionCOL
            // 
            DescripcionCOL.Text = "Descripción";
            DescripcionCOL.Width = 150;
            // 
            // EmitirOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 623);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "EmitirOrdenDeSeleccionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Emitir orden de selección";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private ColumnHeader Número;
        private ColumnHeader Fecha_recibida;
        private ColumnHeader Cliente;
        private Button button1;
        private Button button2;
        private Label label2;
        private ListView listView2;
        private ColumnHeader DescripcionCOL;
        private ColumnHeader Cantcol;
        private ColumnHeader columnHeader3;
        private Label label3;
        private ColumnHeader SKUCol;
        private ColumnHeader CantidadCOL;
    }
}