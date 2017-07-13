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
    public partial class frmAdminProducto : BaseForm
    {
        Logica.Producto logicaProducto = new Logica.Producto();
        public frmAdminProducto()
        {
            InitializeComponent();
           
            
            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var frmAltaProducto = new frmAltaProducto();
            frmAltaProducto.StartPosition = this.StartPosition;
            frmAltaProducto.Show();
        }
    }
}
