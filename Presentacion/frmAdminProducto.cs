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
        Logica.Producto LogicaProducto = new Logica.Producto();
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

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            Entidades.Producto Producto = new Entidades.Producto();
            var frmAltaProducto = new frmAltaProducto(Producto);
            frmAltaProducto.StartPosition = this.StartPosition;
            frmAltaProducto.Show();
            //TODO: Ir a buscar a la base de datos el ID con el producto para modificarlo
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string message = "Estás seguro de querer borrar el producto seleccionado?";
            string caption = "Atencion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                //TODO: Ir a buscar a la base de datos el ID con el producto para eliminarlo
                 
            }
        }
        }
}
