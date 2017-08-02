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
    public partial class frmAdminVendedores : BaseForm
    {
        Logica.Vendedor LogicaVendedor = new Logica.Vendedor();

        public frmAdminVendedores()
        {
            InitializeComponent();
            TraerTodos();
            dgvVendedores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        public void TraerTodos()
        {
            dgvVendedores.DataSource = LogicaVendedor.TraerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var AltaVendedores = new frmAltaVendedor();
            AltaVendedores.StartPosition = this.StartPosition;
            AltaVendedores.Show();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            DataGridViewCell Cell = dgvVendedores.SelectedCells[0];
            int VendedorId = Convert.ToInt32(Cell.Value.ToString());
            frmAltaVendedor AltaVendedores = new frmAltaVendedor(VendedorId);
            AltaVendedores.StartPosition = this.StartPosition;
            AltaVendedores.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "Estás seguro de querer borrar el vendedor seleccionado?";
            string caption = "Atencion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
               
                Logica.Vendedor LogicaVendedor = new Logica.Vendedor();
                DataGridViewCell Cell = dgvVendedores.SelectedCells[0];
                LogicaVendedor.Eliminar(Convert.ToInt32(Cell.Value.ToString()));
                TraerTodos();
            }
        }
    }
}
