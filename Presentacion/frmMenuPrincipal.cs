﻿using Entidades;
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

        private void agregarModificarEliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdminProducto objForm = new frmAdminProducto();
            objForm.StartPosition = this.StartPosition;
            objForm.Show();
        }
    }
}
