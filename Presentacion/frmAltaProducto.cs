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
    public partial class frmAltaProducto : BaseForm
    {
        public frmAltaProducto()
        {
            InitializeComponent();
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
        }

        public frmAltaProducto(Entidades.Producto Producto)
        {
            InitializeComponent();
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
