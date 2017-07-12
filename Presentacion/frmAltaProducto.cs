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
    public partial class frmAltaProducto : Form
    {
        Logica.Producto logicaProducto = new Logica.Producto();
        public frmAltaProducto()
        {
            InitializeComponent();
           
            
            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //TODO: Agregar el formulario adicional y cambiar el nombre del padre.
        }
    }
}
