using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void buzosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Crear un objeto del form a mostrar

            frmAltaProducto objForm = new frmAltaProducto(TiposEnum.Buzo);
            objForm.StartPosition = this.StartPosition;
            objForm.Show();
        }
    }
}
