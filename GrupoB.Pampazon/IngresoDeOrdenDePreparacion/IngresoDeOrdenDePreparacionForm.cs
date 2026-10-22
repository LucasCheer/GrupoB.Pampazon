using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoB.Pampazon.IngresoDeOrdenDePreparacion
{
    public partial class IngresoDeOrdenDePreparacionForm : Form
    {
        private readonly IngresoDeOrdenDePreparacionModelo modelo = new();
        public IngresoDeOrdenDePreparacionForm()
        {
            InitializeComponent();
        }
    }
}
