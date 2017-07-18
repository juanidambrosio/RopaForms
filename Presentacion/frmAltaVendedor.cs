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
    public partial class frmAltaVendedor : BaseForm
    {
        Logica.Vendedor LogicaVendedor = new Logica.Vendedor();
        public frmAltaVendedor()
        {
            InitializeComponent();
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
        }

        public frmAltaVendedor(int Id)
        {
            InitializeComponent();
            btnAgregar.Visible = false;
            btnModificar.Visible = true;

            var Vendedor = LogicaVendedor.TraerVendedor(Id);
            txtApellido.Text = Vendedor.Apellido;
            txtNombre.Text = Vendedor.Nombre;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Vendedor Vendedor = new Entidades.Vendedor();
            Vendedor.Nombre = txtNombre.Text;
            Vendedor.Apellido = txtApellido.Text;
            LogicaVendedor.Agregar(Vendedor);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Vendedor Vendedor = new Entidades.Vendedor();
            Vendedor.Nombre = txtNombre.Text;
            Vendedor.Apellido = txtApellido.Text;
            LogicaVendedor.Modificar(Vendedor);
        }
    }
}
