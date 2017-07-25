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
        public frmAdminVendedores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var AltaVendedores = new frmAltaVendedor();
            AltaVendedores.StartPosition = this.StartPosition;
            AltaVendedores.Show();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            int VendedorId = Convert.ToInt32(dgvVendedores.SelectedRows[0]);
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
                //TODO: Ir a buscar a la base de datos el ID con el producto para eliminarlo
                Logica.Vendedor LogicaVendedor = new Logica.Vendedor();
                LogicaVendedor.Eliminar(Convert.ToInt32(dgvVendedores.SelectedRows[0]));
            }
        }
    }
}
