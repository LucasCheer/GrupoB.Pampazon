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
            groupBox2 = new GroupBox();
            OrdenSeleccionCombo = new ComboBox();
            OperarioAsignadoText = new TextBox();
            label3 = new Label();
            CargarHojaRutaBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            CancelarBtn = new Button();
            FinalizarBtn = new Button();
            ProductosHojaRutaListView = new ListView();
            colOrden = new ColumnHeader();
            colSKU = new ColumnHeader();
            colDesc = new ColumnHeader();
            colCant = new ColumnHeader();
            CoordenadasListView = new ListView();
            colCoordRut = new ColumnHeader();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OrdenSeleccionCombo);
            groupBox2.Controls.Add(OperarioAsignadoText);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(CargarHojaRutaBtn);
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
            // OrdenSeleccionCombo
            // 
            OrdenSeleccionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            OrdenSeleccionCombo.FormattingEnabled = true;
            OrdenSeleccionCombo.Location = new Point(221, 36);
            OrdenSeleccionCombo.Margin = new Padding(3, 4, 3, 4);
            OrdenSeleccionCombo.Name = "OrdenSeleccionCombo";
            OrdenSeleccionCombo.Size = new Size(143, 31);
            OrdenSeleccionCombo.TabIndex = 12;
            // 
            // OperarioAsignadoText
            // 
            OperarioAsignadoText.Font = new Font("Segoe UI", 10.2F);
            OperarioAsignadoText.Location = new Point(221, 77);
            OperarioAsignadoText.Margin = new Padding(6, 3, 3, 3);
            OperarioAsignadoText.Name = "OperarioAsignadoText";
            OperarioAsignadoText.ReadOnly = true;
            OperarioAsignadoText.Size = new Size(143, 30);
            OperarioAsignadoText.TabIndex = 11;
            OperarioAsignadoText.TextAlign = HorizontalAlignment.Center;
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
            // CargarHojaRutaBtn
            // 
            CargarHojaRutaBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CargarHojaRutaBtn.Location = new Point(371, 32);
            CargarHojaRutaBtn.Name = "CargarHojaRutaBtn";
            CargarHojaRutaBtn.Size = new Size(182, 36);
            CargarHojaRutaBtn.TabIndex = 9;
            CargarHojaRutaBtn.Text = "Cargar Hoja de Ruta";
            CargarHojaRutaBtn.UseVisualStyleBackColor = true;
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
            groupBox1.Controls.Add(CancelarBtn);
            groupBox1.Controls.Add(FinalizarBtn);
            groupBox1.Controls.Add(ProductosHojaRutaListView);
            groupBox1.Controls.Add(CoordenadasListView);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 259);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "HOJA DE RUTA";
            //
            // CancelarBtn
            //
            CancelarBtn.FlatStyle = FlatStyle.System;
            CancelarBtn.Font = new Font("Segoe UI", 10.2F);
            CancelarBtn.Location = new Point(753, 201);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(99, 52);
            CancelarBtn.TabIndex = 18;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            //
            // FinalizarBtn
            //
            FinalizarBtn.FlatStyle = FlatStyle.System;
            FinalizarBtn.Font = new Font("Segoe UI", 10.2F);
            FinalizarBtn.Location = new Point(648, 201);
            FinalizarBtn.Name = "FinalizarBtn";
            FinalizarBtn.Size = new Size(99, 52);
            FinalizarBtn.TabIndex = 19;
            FinalizarBtn.Text = "Finalizar";
            FinalizarBtn.UseVisualStyleBackColor = true;
            //
            // ProductosHojaRutaListView
            //
            ProductosHojaRutaListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductosHojaRutaListView.Columns.AddRange(new ColumnHeader[] { colOrden, colSKU, colDesc, colCant });
            ProductosHojaRutaListView.ForeColor = SystemColors.InfoText;
            ProductosHojaRutaListView.FullRowSelect = true;
            ProductosHojaRutaListView.Location = new Point(6, 39);
            ProductosHojaRutaListView.MultiSelect = false;
            ProductosHojaRutaListView.Name = "ProductosHojaRutaListView";
            ProductosHojaRutaListView.Size = new Size(467, 135);
            ProductosHojaRutaListView.TabIndex = 3;
            ProductosHojaRutaListView.UseCompatibleStateImageBehavior = false;
            ProductosHojaRutaListView.View = View.Details;
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
            // CoordenadasListView
            // 
            CoordenadasListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CoordenadasListView.Columns.AddRange(new ColumnHeader[] { colCoordRut });
            CoordenadasListView.ForeColor = SystemColors.InfoText;
            CoordenadasListView.Location = new Point(495, 39);
            CoordenadasListView.Name = "CoordenadasListView";
            CoordenadasListView.Size = new Size(357, 135);
            CoordenadasListView.TabIndex = 20;
            CoordenadasListView.UseCompatibleStateImageBehavior = false;
            CoordenadasListView.View = View.Details;
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
        private Button CargarHojaRutaBtn;
        private Label label2;
        private Label label1;
        private TextBox OperarioAsignadoText;
        private Label label3;
        private GroupBox groupBox1;
        private ListView ProductosHojaRutaListView;
        private ColumnHeader colOrden;
        private ColumnHeader colSKU;
        private ColumnHeader colDesc;
        private ColumnHeader colCant;
        private Button FinalizarBtn;
        private Button CancelarBtn;
        private ComboBox OrdenSeleccionCombo;
        private ListView CoordenadasListView;
        private ColumnHeader colCoordRut;
    }
}
