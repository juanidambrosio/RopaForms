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

            //Cambiar el ancho de las columnas

            this.dgvProductos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvProductos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvProductos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvProductos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


        }

        public void TraerTodos()
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
            DataGridViewCell Cell = dgvProductos.SelectedCells[0];
            int ProductoId = Convert.ToInt32(Cell.Value.ToString());
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
                DataGridViewCell Cell = dgvProductos.SelectedCells[0];
                LogicaProducto.Eliminar(Convert.ToInt32(Cell.Value.ToString()));
                TraerTodos();
            }
        }
        }
}
