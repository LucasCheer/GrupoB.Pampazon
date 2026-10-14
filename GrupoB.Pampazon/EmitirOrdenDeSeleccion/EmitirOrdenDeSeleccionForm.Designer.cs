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
            ProductoCOL = new ColumnHeader();
            cantidad = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            Cantcol = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            listView3 = new ListView();
            CantSelCOL = new ColumnHeader();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label3 = new Label();
            UbicacionCOL = new ColumnHeader();
            SKUCOL = new ColumnHeader();
            DescripCOL = new ColumnHeader();
            cantidadcol = new ColumnHeader();
            UBICOL = new ColumnHeader();
            label4 = new Label();
            OPsasociadaCOL = new ColumnHeader();
            label5 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { Número, Fecha_recibida, Cliente, ProductoCOL, cantidad });
            listView1.Location = new Point(14, 101);
            listView1.Name = "listView1";
            listView1.Size = new Size(765, 232);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Número
            // 
            Número.Text = "# OP";
            Número.Width = 153;
            // 
            // Fecha_recibida
            // 
            Fecha_recibida.Text = "Fecha recibida";
            Fecha_recibida.Width = 153;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 153;
            // 
            // ProductoCOL
            // 
            ProductoCOL.Text = "Producto";
            ProductoCOL.Width = 153;
            // 
            // cantidad
            // 
            cantidad.Text = "Cantidad";
            cantidad.Width = 153;
            // 
            // button1
            // 
            button1.Location = new Point(12, 339);
            button1.Name = "button1";
            button1.Size = new Size(763, 29);
            button1.TabIndex = 2;
            button1.Text = "Agregar a orden de selección";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(15, 679);
            button2.Name = "button2";
            button2.Size = new Size(763, 29);
            button2.TabIndex = 3;
            button2.Text = "Quitar de orden de selección";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(622, 20);
            label2.TabIndex = 4;
            label2.Text = "Seleccione que ordenes de preparación se incluiran en la orden de selección a emitir";
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
            // listView3
            // 
            listView3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView3.Columns.AddRange(new ColumnHeader[] { SKUCOL, DescripCOL, cantidadcol, UBICOL, OPsasociadaCOL });
            listView3.Location = new Point(12, 425);
            listView3.Name = "listView3";
            listView3.Size = new Size(766, 236);
            listView3.TabIndex = 7;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // CantSelCOL
            // 
            CantSelCOL.Text = "Cantidad";
            CantSelCOL.Width = 100;
            // 
            // button3
            // 
            button3.Location = new Point(447, 754);
            button3.Name = "button3";
            button3.Size = new Size(213, 29);
            button3.TabIndex = 8;
            button3.Text = "Generar orden de selección";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(677, 754);
            button4.Name = "button4";
            button4.Size = new Size(101, 29);
            button4.TabIndex = 9;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 392);
            label3.Name = "label3";
            label3.Size = new Size(254, 20);
            label3.TabIndex = 10;
            label3.Text = "Consolidado de selección para almacen";
            label3.Click += label3_Click;
            // 
            // UbicacionCOL
            // 
            UbicacionCOL.Text = "Ubicación (X-Y-Z)";
            // 
            // SKUCOL
            // 
            SKUCOL.Text = "SKU";
            // 
            // DescripCOL
            // 
            DescripCOL.Text = "Descripción";
            DescripCOL.Width = 250;
            // 
            // cantidadcol
            // 
            cantidadcol.Text = "Cantidad";
            cantidadcol.Width = 100;
            // 
            // UBICOL
            // 
            UBICOL.Text = "Ubicación (X-Y-Z)";
            UBICOL.Width = 170;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 516);
            label4.Name = "label4";
            label4.Size = new Size(518, 20);
            label4.TabIndex = 11;
            label4.Text = "Las ordenes de preparación se pueden agrupar en una misma orden de seleccion";
            // 
            // OPsasociadaCOL
            // 
            OPsasociadaCOL.Text = "OP(s) Asociada(s)";
            OPsasociadaCOL.Width = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(138, 552);
            label5.Name = "label5";
            label5.Size = new Size(526, 20);
            label5.TabIndex = 12;
            label5.Text = "Las OPs asociadas estarán listadas por coma. Se manejará a nivel modelo la relacion";
            // 
            // EmitirOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 809);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listView3);
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
        private ColumnHeader Número;
        private ColumnHeader Fecha_recibida;
        private ColumnHeader Cliente;
        private Button button1;
        private Button button2;
        private Label label2;
        private ColumnHeader Cantcol;
        private ColumnHeader columnHeader3;
        private ListView listView3;
        private ColumnHeader CantSelCOL;
        private Button button3;
        private Button button4;
        private ColumnHeader ProductoCOL;
        private ColumnHeader cantidad;
        private Label label1;
        private Label label3;
        private ColumnHeader UbicacionCOL;
        private ColumnHeader SKUCOL;
        private ColumnHeader DescripCOL;
        private ColumnHeader cantidadcol;
        private ColumnHeader UBICOL;
        private Label label4;
        private ColumnHeader OPsasociadaCOL;
        private Label label5;
    }
}