namespace GrupoB.Pampazon.EmitirOrdenDeEntrega
{
    partial class EmitirOrdenDeEntregaForm
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
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "OP-1000", "09/10/2026", "Mercado 1", "4" }, -1, SystemColors.ControlText, SystemColors.GradientActiveCaption, null);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "OP-1001", "10/10/2026", "Mercado 2", "2" }, -1, Color.Empty, SystemColors.GradientActiveCaption, null);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "OP-1002", "10/10/2026" }, -1, Color.Empty, SystemColors.GradientActiveCaption, null);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "OP-1003", "11/10/2026" }, -1);
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            colOP = new ColumnHeader();
            colFecha = new ColumnHeader();
            label1 = new Label();
            colEstado = new ColumnHeader();
            button1 = new Button();
            EmitirOrdenBTN = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 296);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SELECCIÓN DE ORDEN DE PREPARACIÓN";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { colOP, colFecha });
            listView1.ForeColor = SystemColors.InfoText;
            listViewItem8.Tag = "";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6, listViewItem7, listViewItem8 });
            listView1.Location = new Point(6, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(411, 240);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // colOP
            // 
            colOP.Text = "N°OP";
            colOP.Width = 153;
            // 
            // colFecha
            // 
            colFecha.Text = "Fecha Preparación";
            colFecha.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(424, 41);
            label1.TabIndex = 1;
            label1.Text = "EMITIR ORDEN DE ENTREGA";
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 150;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(342, 363);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // EmitirOrdenBTN
            // 
            EmitirOrdenBTN.FlatStyle = FlatStyle.System;
            EmitirOrdenBTN.Location = new Point(129, 363);
            EmitirOrdenBTN.Name = "EmitirOrdenBTN";
            EmitirOrdenBTN.Size = new Size(206, 29);
            EmitirOrdenBTN.TabIndex = 5;
            EmitirOrdenBTN.Text = "Emitir Orden de preparación";
            EmitirOrdenBTN.UseVisualStyleBackColor = true;
            // 
            // EmitirOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 405);
            Controls.Add(EmitirOrdenBTN);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "EmitirOrdenDeEntregaForm";
            Text = "EmitirOrdenDeEntrega";
            Load += EmitirOrdenDeEntrega_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ListView listView1;
        private ColumnHeader colOP;
        private ColumnHeader colFecha;

        public ColumnHeader colSKUu { get; private set; }

        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader colEstado;
        private Button button1;
        private Button EmitirOrdenBTN;
        private ListViewItem listViewItem1;
        private ListViewItem listViewItem2;
    }
}