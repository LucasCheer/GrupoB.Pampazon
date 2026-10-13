using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoB.Pampazon.IngresarOrdenDePreparacion
{
    public partial class IngresarOrdenDePreparacionForm : Form
    {
        private readonly IngresarOrdenDePreparacionModelo modelo = new();
        public IngresarOrdenDePreparacionForm()
        {
            InitializeComponent();
        }
    }
}
