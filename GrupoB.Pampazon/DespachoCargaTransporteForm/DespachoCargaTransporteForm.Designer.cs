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
        /// Required method for Designer - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox2 = new GroupBox();
            ConsultarCargasBtn = new Button();
            DNITransportistaText = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            CajasListView = new ListView();
            IDMercaderiaCol = new ColumnHeader();
            TotalCajasText = new TextBox();
            label4 = new Label();
            TransporteValidadoText = new TextBox();
            label9 = new Label();
            RegistrarCargaBtn = new Button();
            CerrarBtn = new Button();
            CajasEntregadasCheck = new CheckBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(660, 48);
            label1.TabIndex = 5;
            label1.Text = "DESPACHO - CARGA DE TRANSPORTE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ConsultarCargasBtn);
            groupBox2.Controls.Add(DNITransportistaText);
            groupBox2.Controls.Add(label7);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(14, 83);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(716, 98);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "IDENTIFICACIÓN DEL TRANSPORTE EN PUERTA";
            // 
            // ConsultarCargasBtn
            // 
            ConsultarCargasBtn.FlatStyle = FlatStyle.System;
            ConsultarCargasBtn.Location = new Point(479, 50);
            ConsultarCargasBtn.Margin = new Padding(4, 3, 4, 3);
            ConsultarCargasBtn.Name = "ConsultarCargasBtn";
            ConsultarCargasBtn.Size = new Size(211, 38);
            ConsultarCargasBtn.TabIndex = 18;
            ConsultarCargasBtn.Text = "Consultar cargas";
            ConsultarCargasBtn.UseVisualStyleBackColor = true;
            ConsultarCargasBtn.Click += ConsultarCargasBtn_Click;
            // 
            // DNITransportistaText
            // 
            DNITransportistaText.Location = new Point(286, 45);
            DNITransportistaText.Margin = new Padding(4, 3, 4, 3);
            DNITransportistaText.Name = "DNITransportistaText";
            DNITransportistaText.Size = new Size(178, 35);
            DNITransportistaText.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 50);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(268, 30);
            label7.TabIndex = 10;
            label7.Text = "Ingrese DNI transportista:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CajasListView);
            groupBox1.Controls.Add(TotalCajasText);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TransporteValidadoText);
            groupBox1.Controls.Add(label9);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 188);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(716, 380);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "CAJAS ASIGNADAS PARA HOY";
            // 
            // CajasListView
            // 
            CajasListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CajasListView.Columns.AddRange(new ColumnHeader[] { IDMercaderiaCol });
            CajasListView.ForeColor = SystemColors.InfoText;
            CajasListView.Location = new Point(9, 88);
            CajasListView.Margin = new Padding(4, 3, 4, 3);
            CajasListView.Name = "CajasListView";
            CajasListView.Size = new Size(225, 209);
            CajasListView.TabIndex = 20;
            CajasListView.UseCompatibleStateImageBehavior = false;
            CajasListView.View = View.Details;
            // 
            // IDMercaderiaCol
            // 
            IDMercaderiaCol.Text = "ID Mercadería";
            IDMercaderiaCol.Width = 153;
            // 
            // TotalCajasText
            // 
            TotalCajasText.Location = new Point(246, 318);
            TotalCajasText.Margin = new Padding(4, 3, 4, 3);
            TotalCajasText.Name = "TotalCajasText";
            TotalCajasText.ReadOnly = true;
            TotalCajasText.Size = new Size(80, 35);
            TotalCajasText.TabIndex = 19;
            TotalCajasText.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 323);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(223, 30);
            label4.TabIndex = 18;
            label4.Text = "Total de cajas a subir:";
            // 
            // TransporteValidadoText
            // 
            TransporteValidadoText.Location = new Point(237, 38);
            TransporteValidadoText.Margin = new Padding(4, 3, 4, 3);
            TransporteValidadoText.Name = "TransporteValidadoText";
            TransporteValidadoText.ReadOnly = true;
            TransporteValidadoText.Size = new Size(290, 35);
            TransporteValidadoText.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 48);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(214, 30);
            label9.TabIndex = 14;
            label9.Text = "Transporte validado:";
            // 
            // RegistrarCargaBtn
            // 
            RegistrarCargaBtn.Location = new Point(309, 583);
            RegistrarCargaBtn.Margin = new Padding(4, 5, 4, 5);
            RegistrarCargaBtn.Name = "RegistrarCargaBtn";
            RegistrarCargaBtn.Size = new Size(150, 38);
            RegistrarCargaBtn.TabIndex = 11;
            RegistrarCargaBtn.Text = "Registrar carga";
            RegistrarCargaBtn.UseVisualStyleBackColor = true;
            RegistrarCargaBtn.Click += RegistrarCargaBtn_Click;
            // 
            // CerrarBtn
            // 
            CerrarBtn.Location = new Point(467, 583);
            CerrarBtn.Margin = new Padding(4, 5, 4, 5);
            CerrarBtn.Name = "CerrarBtn";
            CerrarBtn.Size = new Size(107, 38);
            CerrarBtn.TabIndex = 12;
            CerrarBtn.Text = "Cerrar";
            CerrarBtn.UseVisualStyleBackColor = true;
            CerrarBtn.Click += CerrarBtn_Click;
            // 
            // CajasEntregadasCheck
            // 
            CajasEntregadasCheck.AutoSize = true;
            CajasEntregadasCheck.Location = new Point(20, 592);
            CajasEntregadasCheck.Margin = new Padding(4, 5, 4, 5);
            CajasEntregadasCheck.Name = "CajasEntregadasCheck";
            CajasEntregadasCheck.Size = new Size(295, 29);
            CajasEntregadasCheck.TabIndex = 13;
            CajasEntregadasCheck.Text = "Cajas entregadas al transportista";
            CajasEntregadasCheck.UseVisualStyleBackColor = true;
            // 
            // DespachoCargaTransporteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 655);
            Controls.Add(CajasEntregadasCheck);
            Controls.Add(CerrarBtn);
            Controls.Add(RegistrarCargaBtn);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
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
        private TextBox TransporteValidadoText;
        private Label label9;
        private TextBox DNITransportistaText;
        private Label label7;
        private TextBox TotalCajasText;
        private Label label4;
        private Button ConsultarCargasBtn;
        private ListView CajasListView;
        private ColumnHeader IDMercaderiaCol;
        private Button RegistrarCargaBtn;
        private Button CerrarBtn;
        private CheckBox CajasEntregadasCheck;
    }
}