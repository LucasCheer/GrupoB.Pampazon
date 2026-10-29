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
            NumeroIncidenciaText = new TextBox();
            OperarioText = new TextBox();
            FechaYHoraText = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SectorDepositoCombo = new ComboBox();
            EtapaOperativaCombo = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            CoordenadaText = new TextBox();
            label9 = new Label();
            label14 = new Label();
            TipoCausaIncidenciaCombo = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            CantAfectadaText = new TextBox();
            label18 = new Label();
            JustificacionIncidenciaText = new TextBox();
            ReportarBtn = new Button();
            CancelarBtn = new Button();
            SKUProductoCombo = new ComboBox();
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
            label3.Location = new Point(248, 58);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha y Hora:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 58);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 3;
            label4.Text = "Operario Responsable:";
            // 
            // NumeroIncidenciaText
            // 
            NumeroIncidenciaText.BackColor = SystemColors.ControlLight;
            NumeroIncidenciaText.BorderStyle = BorderStyle.FixedSingle;
            NumeroIncidenciaText.Location = new Point(31, 87);
            NumeroIncidenciaText.Name = "NumeroIncidenciaText";
            NumeroIncidenciaText.ReadOnly = true;
            NumeroIncidenciaText.Size = new Size(188, 31);
            NumeroIncidenciaText.TabIndex = 4;
            // 
            // OperarioText
            // 
            OperarioText.BackColor = SystemColors.ControlLight;
            OperarioText.BorderStyle = BorderStyle.FixedSingle;
            OperarioText.Location = new Point(490, 87);
            OperarioText.Name = "OperarioText";
            OperarioText.ReadOnly = true;
            OperarioText.Size = new Size(435, 31);
            OperarioText.TabIndex = 5;
            // 
            // FechaYHoraText
            // 
            FechaYHoraText.BackColor = SystemColors.ControlLight;
            FechaYHoraText.BorderStyle = BorderStyle.FixedSingle;
            FechaYHoraText.Location = new Point(248, 87);
            FechaYHoraText.Name = "FechaYHoraText";
            FechaYHoraText.ReadOnly = true;
            FechaYHoraText.Size = new Size(207, 31);
            FechaYHoraText.TabIndex = 6;
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
            // SectorDepositoCombo
            // 
            SectorDepositoCombo.FormattingEnabled = true;
            SectorDepositoCombo.Location = new Point(31, 158);
            SectorDepositoCombo.Name = "SectorDepositoCombo";
            SectorDepositoCombo.Size = new Size(289, 33);
            SectorDepositoCombo.TabIndex = 9;
            SectorDepositoCombo.SelectedIndexChanged += SectorDepositoCombo_SelectedIndexChanged;
            // 
            // EtapaOperativaCombo
            // 
            EtapaOperativaCombo.FormattingEnabled = true;
            EtapaOperativaCombo.Location = new Point(359, 158);
            EtapaOperativaCombo.Name = "EtapaOperativaCombo";
            EtapaOperativaCombo.Size = new Size(327, 33);
            EtapaOperativaCombo.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(31, 222);
            label7.Name = "label7";
            label7.Size = new Size(311, 25);
            label7.TabIndex = 11;
            label7.Text = "IDENTIFICACION DEL PRODUCTO ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 268);
            label8.Name = "label8";
            label8.Size = new Size(207, 25);
            label8.TabIndex = 12;
            label8.Text = "Codigo SKU - Producto :";
            // 
            // CoordenadaText
            // 
            CoordenadaText.Location = new Point(716, 160);
            CoordenadaText.Name = "CoordenadaText";
            CoordenadaText.Size = new Size(209, 31);
            CoordenadaText.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(716, 131);
            label9.Name = "label9";
            label9.Size = new Size(218, 25);
            label9.TabIndex = 14;
            label9.Text = "Coordenada fisica (X-Y-Z):";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.HotTrack;
            label14.Location = new Point(26, 331);
            label14.Name = "label14";
            label14.Size = new Size(508, 25);
            label14.TabIndex = 26;
            label14.Text = "CLASIFICACION DE MERMA / CAUSA DE LA INCIDENCIA";
            // 
            // TipoCausaIncidenciaCombo
            // 
            TipoCausaIncidenciaCombo.FormattingEnabled = true;
            TipoCausaIncidenciaCombo.Location = new Point(28, 426);
            TipoCausaIncidenciaCombo.Name = "TipoCausaIncidenciaCombo";
            TipoCausaIncidenciaCombo.Size = new Size(245, 33);
            TipoCausaIncidenciaCombo.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 398);
            label15.Name = "label15";
            label15.Size = new Size(240, 25);
            label15.TabIndex = 27;
            label15.Text = "Tipo / Causa de la incidencia:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(28, 478);
            label16.Name = "label16";
            label16.Size = new Size(162, 25);
            label16.TabIndex = 29;
            label16.Text = "Cantidad Afectada:";
            // 
            // CantAfectadaText
            // 
            CantAfectadaText.Location = new Point(28, 506);
            CantAfectadaText.Name = "CantAfectadaText";
            CantAfectadaText.Size = new Size(245, 31);
            CantAfectadaText.TabIndex = 30;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(310, 372);
            label18.Name = "label18";
            label18.Size = new Size(371, 25);
            label18.TabIndex = 33;
            label18.Text = "Detalle / Justificacion Tecnica de la incidencia :";
            // 
            // JustificacionIncidenciaText
            // 
            JustificacionIncidenciaText.Location = new Point(310, 400);
            JustificacionIncidenciaText.Multiline = true;
            JustificacionIncidenciaText.Name = "JustificacionIncidenciaText";
            JustificacionIncidenciaText.Size = new Size(615, 172);
            JustificacionIncidenciaText.TabIndex = 34;
            // 
            // ReportarBtn
            // 
            ReportarBtn.Location = new Point(310, 602);
            ReportarBtn.Name = "ReportarBtn";
            ReportarBtn.Size = new Size(272, 34);
            ReportarBtn.TabIndex = 35;
            ReportarBtn.Text = "Reportar Incidencia";
            ReportarBtn.UseVisualStyleBackColor = true;
            ReportarBtn.Click += ReportarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(627, 602);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(269, 34);
            CancelarBtn.TabIndex = 36;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // SKUProductoCombo
            // 
            SKUProductoCombo.FormattingEnabled = true;
            SKUProductoCombo.Location = new Point(257, 268);
            SKUProductoCombo.Name = "SKUProductoCombo";
            SKUProductoCombo.Size = new Size(668, 33);
            SKUProductoCombo.TabIndex = 37;
            // 
            // RegistrarMermasEIncidenciasForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 649);
            Controls.Add(SKUProductoCombo);
            Controls.Add(CancelarBtn);
            Controls.Add(ReportarBtn);
            Controls.Add(JustificacionIncidenciaText);
            Controls.Add(label18);
            Controls.Add(CantAfectadaText);
            Controls.Add(label16);
            Controls.Add(TipoCausaIncidenciaCombo);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(CoordenadaText);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(EtapaOperativaCombo);
            Controls.Add(SectorDepositoCombo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(FechaYHoraText);
            Controls.Add(OperarioText);
            Controls.Add(NumeroIncidenciaText);
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
        private TextBox NumeroIncidenciaText;
        private TextBox OperarioText;
        private TextBox FechaYHoraText;
        private Label label5;
        private Label label6;
        private ComboBox SectorDepositoCombo;
        private ComboBox EtapaOperativaCombo;
        private Label label7;
        private Label label8;
        private TextBox CoordenadaText;
        private Label label9;
        private Label label14;
        private ComboBox TipoCausaIncidenciaCombo;
        private Label label15;
        private Label label16;
        private TextBox CantAfectadaText;
        private Label label18;
        private TextBox JustificacionIncidenciaText;
        private Button ReportarBtn;
        private Button CancelarBtn;
        private ComboBox SKUProductoCombo;
    }
}