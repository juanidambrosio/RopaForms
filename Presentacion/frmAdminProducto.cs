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
        
        public frmAdminProducto()
        {
            InitializeComponent();
            TraerTodos();
            
            
        }

        private void TraerTodos()
        {
            Logica.Producto logicaProducto = new Logica.Producto();
            dgvProductos.DataSource = logicaProducto.TraerTodos();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var frmAltaProducto = new frmAltaProducto();
            frmAltaProducto.StartPosition = this.StartPosition;
            frmAltaProducto.Show();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            int ProductoId = Convert.ToInt32(dgvProductos.SelectedRows[0]);
            var frmAltaProducto = new frmAltaProducto(ProductoId);
            frmAltaProducto.StartPosition = this.StartPosition;
            frmAltaProducto.Show();
           
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
                Logica.Producto LogicaProducto = new Logica.Producto();
                LogicaProducto.Eliminar(Convert.ToInt32(dgvProductos.SelectedRows[0]));
            }
        }
        }
}
