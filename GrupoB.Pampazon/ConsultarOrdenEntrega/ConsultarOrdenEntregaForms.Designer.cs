namespace GrupoB.Pampazon.ConsultarOrdenEntrega
{
    partial class ConsultarOrdenEntregaForms
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
            contenedorConsultarOE = new GroupBox();
            botonCerrar = new Button();
            listaPedidos = new ListView();
            colPedido = new ColumnHeader();
            fechacol = new ColumnHeader();
            estadoCol = new ColumnHeader();
            checkBoxOrdenesConPendientes = new CheckBox();
            comboBoxNumeroOrdenEntrega = new ComboBox();
            botonConsultar = new Button();
            labelNumOrdenEntrega = new Label();
            contenedorConsultarOE.SuspendLayout();
            SuspendLayout();
            // 
            // contenedorConsultarOE
            // 
            contenedorConsultarOE.Controls.Add(botonCerrar);
            contenedorConsultarOE.Controls.Add(listaPedidos);
            contenedorConsultarOE.Controls.Add(checkBoxOrdenesConPendientes);
            contenedorConsultarOE.Controls.Add(comboBoxNumeroOrdenEntrega);
            contenedorConsultarOE.Controls.Add(botonConsultar);
            contenedorConsultarOE.Controls.Add(labelNumOrdenEntrega);
            contenedorConsultarOE.FlatStyle = FlatStyle.System;
            contenedorConsultarOE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contenedorConsultarOE.Location = new Point(10, 9);
            contenedorConsultarOE.Margin = new Padding(3, 2, 3, 2);
            contenedorConsultarOE.Name = "contenedorConsultarOE";
            contenedorConsultarOE.Padding = new Padding(3, 2, 3, 2);
            contenedorConsultarOE.Size = new Size(472, 282);
            contenedorConsultarOE.TabIndex = 10;
            contenedorConsultarOE.TabStop = false;
            contenedorConsultarOE.Text = "CONSULTAR ORDEN DE ENTREGA";
            // 
            // botonCerrar
            // 
            botonCerrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonCerrar.Location = new Point(325, 242);
            botonCerrar.Margin = new Padding(3, 2, 3, 2);
            botonCerrar.Name = "botonCerrar";
            botonCerrar.Size = new Size(108, 27);
            botonCerrar.TabIndex = 22;
            botonCerrar.Text = "Cerrar";
            botonCerrar.UseVisualStyleBackColor = true;
            botonCerrar.Click += botonCerrar_Click;
            // 
            // listaPedidos
            // 
            listaPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listaPedidos.Columns.AddRange(new ColumnHeader[] { colPedido, fechacol, estadoCol });
            listaPedidos.ForeColor = SystemColors.InfoText;
            listaPedidos.Location = new Point(6, 99);
            listaPedidos.Margin = new Padding(3, 2, 3, 2);
            listaPedidos.Name = "listaPedidos";
            listaPedidos.Size = new Size(319, 139);
            listaPedidos.TabIndex = 21;
            listaPedidos.UseCompatibleStateImageBehavior = false;
            listaPedidos.View = View.Details;
            // 
            // colPedido
            // 
            colPedido.Text = "N°Pedido";
            colPedido.Width = 100;
            // 
            // fechacol
            // 
            fechacol.Text = "Fecha";
            fechacol.Width = 130;
            // 
            // estadoCol
            // 
            estadoCol.Text = "Estado";
            estadoCol.Width = 100;
            // 
            // checkBoxOrdenesConPendientes
            // 
            checkBoxOrdenesConPendientes.AutoSize = true;
            checkBoxOrdenesConPendientes.Location = new Point(9, 55);
            checkBoxOrdenesConPendientes.Name = "checkBoxOrdenesConPendientes";
            checkBoxOrdenesConPendientes.Size = new Size(379, 23);
            checkBoxOrdenesConPendientes.TabIndex = 13;
            checkBoxOrdenesConPendientes.Text = "Mostrar órdenes de entrega con pedidos pendientes";
            checkBoxOrdenesConPendientes.UseVisualStyleBackColor = true;
            checkBoxOrdenesConPendientes.CheckedChanged += checkBoxOrdenesConPendientes_CheckedChanged;
            // 
            // comboBoxNumeroOrdenEntrega
            // 
            comboBoxNumeroOrdenEntrega.FormattingEnabled = true;
            comboBoxNumeroOrdenEntrega.Location = new Point(193, 22);
            comboBoxNumeroOrdenEntrega.Name = "comboBoxNumeroOrdenEntrega";
            comboBoxNumeroOrdenEntrega.Size = new Size(126, 27);
            comboBoxNumeroOrdenEntrega.TabIndex = 12;
            comboBoxNumeroOrdenEntrega.SelectedIndexChanged += comboBoxNumeroOrdenEntrega_SelectedIndexChanged;
            // 
            // botonConsultar
            // 
            botonConsultar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonConsultar.Location = new Point(325, 21);
            botonConsultar.Margin = new Padding(3, 2, 3, 2);
            botonConsultar.Name = "botonConsultar";
            botonConsultar.Size = new Size(108, 27);
            botonConsultar.TabIndex = 9;
            botonConsultar.Text = "Consultar";
            botonConsultar.UseVisualStyleBackColor = true;
            botonConsultar.Click += botonConsultar_Click;
            // 
            // labelNumOrdenEntrega
            // 
            labelNumOrdenEntrega.AutoSize = true;
            labelNumOrdenEntrega.Location = new Point(5, 26);
            labelNumOrdenEntrega.Name = "labelNumOrdenEntrega";
            labelNumOrdenEntrega.Size = new Size(165, 19);
            labelNumOrdenEntrega.TabIndex = 3;
            labelNumOrdenEntrega.Text = "Nro. Orden de Entrega:";
            // 
            // ConsultarOrdenEntregaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 306);
            Controls.Add(contenedorConsultarOE);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ConsultarOrdenEntregaForms";
            Text = "ConsultarOrdenEntregaForms";
            contenedorConsultarOE.ResumeLayout(false);
            contenedorConsultarOE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox contenedorConsultarOE;
        private Button botonCerrar;
        private ListView listaPedidos;
        private ColumnHeader colPedido;
        private ColumnHeader fechacol;
        private ColumnHeader estadoCol;
        private CheckBox checkBoxOrdenesConPendientes;
        private ComboBox comboBoxNumeroOrdenEntrega;
        private Button botonConsultar;
        private Label labelNumOrdenEntrega;
    }
}