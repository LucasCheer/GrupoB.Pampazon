using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrupoB.Pampazon.ValidarOrdenDePreparacion
{
    public partial class ValidarOrdenDePreparacionForm : Form
    {
        private readonly ValidarOrdenDePreparacionModelo modelo = new();
        public ValidarOrdenDePreparacionForm()
        {
            InitializeComponent();
        }
    }
}
