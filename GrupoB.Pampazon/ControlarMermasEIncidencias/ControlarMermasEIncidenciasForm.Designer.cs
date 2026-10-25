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
            IncidenciasPendientesListView = new ListView();
            NumeroIncidenciaCol = new ColumnHeader();
            FechaHoraCol = new ColumnHeader();
            OperarioCol = new ColumnHeader();
            SKUDescripcionCol = new ColumnHeader();
            UbicacionCol = new ColumnHeader();
            CantCol = new ColumnHeader();
            CausaCol = new ColumnHeader();
            label2 = new Label();
            JustificacionOperadorText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            JustificacionAuditoriaText = new TextBox();
            AprobarBtn = new Button();
            RechazarBtn = new Button();
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
            // IncidenciasPendientesListView
            // 
            IncidenciasPendientesListView.Columns.AddRange(new ColumnHeader[] { NumeroIncidenciaCol, FechaHoraCol, OperarioCol, SKUDescripcionCol, UbicacionCol, CantCol, CausaCol });
            IncidenciasPendientesListView.Location = new Point(24, 78);
            IncidenciasPendientesListView.Name = "IncidenciasPendientesListView";
            IncidenciasPendientesListView.Size = new Size(1036, 161);
            IncidenciasPendientesListView.TabIndex = 1;
            IncidenciasPendientesListView.UseCompatibleStateImageBehavior = false;
            IncidenciasPendientesListView.View = View.Details;
            // 
            // NumeroIncidenciaCol
            // 
            NumeroIncidenciaCol.Text = "N° Incidencia";
            NumeroIncidenciaCol.Width = 120;
            // 
            // FechaHoraCol
            // 
            FechaHoraCol.Text = "Fecha/Hora";
            FechaHoraCol.Width = 120;
            // 
            // OperarioCol
            // 
            OperarioCol.Text = "Operario Reportante";
            OperarioCol.Width = 200;
            // 
            // SKUDescripcionCol
            // 
            SKUDescripcionCol.Text = "SKU / Descripcion";
            SKUDescripcionCol.Width = 200;
            // 
            // UbicacionCol
            // 
            UbicacionCol.Text = "Ubicacion";
            UbicacionCol.Width = 120;
            // 
            // CantCol
            // 
            CantCol.Text = "Cant.";
            CantCol.Width = 100;
            // 
            // CausaCol
            // 
            CausaCol.Text = "Causa Reportada";
            CausaCol.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(24, 430);
            label2.Name = "label2";
            label2.Size = new Size(380, 25);
            label2.TabIndex = 3;
            label2.Text = "AUDITORIA Y REVISION DEL SUPERVISOR";
            // 
            // JustificacionOperadorText
            // 
            JustificacionOperadorText.Location = new Point(24, 285);
            JustificacionOperadorText.Multiline = true;
            JustificacionOperadorText.Name = "JustificacionOperadorText";
            JustificacionOperadorText.Size = new Size(1036, 127);
            JustificacionOperadorText.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 257);
            label3.Name = "label3";
            label3.Size = new Size(281, 25);
            label3.TabIndex = 5;
            label3.Text = "Justificacion Tecnica del Operador:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 464);
            label4.Name = "label4";
            label4.Size = new Size(305, 25);
            label4.TabIndex = 7;
            label4.Text = "Dictamen / Justificacion de Auditoria:";
            // 
            // JustificacionAuditoriaText
            // 
            JustificacionAuditoriaText.Location = new Point(24, 498);
            JustificacionAuditoriaText.Multiline = true;
            JustificacionAuditoriaText.Name = "JustificacionAuditoriaText";
            JustificacionAuditoriaText.Size = new Size(1036, 119);
            JustificacionAuditoriaText.TabIndex = 6;
            // 
            // AprobarBtn
            // 
            AprobarBtn.Location = new Point(519, 623);
            AprobarBtn.Name = "AprobarBtn";
            AprobarBtn.Size = new Size(277, 44);
            AprobarBtn.TabIndex = 8;
            AprobarBtn.Text = "APROBAR BAJA DEFINITIVA";
            AprobarBtn.UseVisualStyleBackColor = true;
            // 
            // RechazarBtn
            // 
            RechazarBtn.Location = new Point(815, 623);
            RechazarBtn.Name = "RechazarBtn";
            RechazarBtn.Size = new Size(245, 44);
            RechazarBtn.TabIndex = 9;
            RechazarBtn.Text = "RECHAZAR / REINTEGRAR";
            RechazarBtn.UseVisualStyleBackColor = true;
            // 
            // ControlarMermasEIncidenciasForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 679);
            Controls.Add(RechazarBtn);
            Controls.Add(AprobarBtn);
            Controls.Add(label4);
            Controls.Add(JustificacionAuditoriaText);
            Controls.Add(label3);
            Controls.Add(JustificacionOperadorText);
            Controls.Add(label2);
            Controls.Add(IncidenciasPendientesListView);
            Controls.Add(label1);
            Name = "ControlarMermasEIncidenciasForm";
            Text = "ControlarMermasEIncidenciasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView IncidenciasPendientesListView;
        private ColumnHeader NumeroIncidenciaCol;
        private ColumnHeader FechaHoraCol;
        private ColumnHeader OperarioCol;
        private ColumnHeader SKUDescripcionCol;
        private ColumnHeader UbicacionCol;
        private ColumnHeader CantCol;
        private ColumnHeader CausaCol;
        private Label label2;
        private TextBox JustificacionOperadorText;
        private Label label3;
        private Label label4;
        private TextBox JustificacionAuditoriaText;
        private Button AprobarBtn;
        private Button RechazarBtn;
    }
}