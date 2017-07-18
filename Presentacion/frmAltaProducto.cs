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
        Logica.Producto LogicaProducto = new Logica.Producto();
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
            txtDescripcion.Text = Producto.Descripcion;
            //TODO: Ver como se asignan los distintos campos
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Producto Producto = new Entidades.Producto();
            Producto.Descripcion = txtDescripcion.Text;
            LogicaProducto.Agregar(Producto);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Entidades.Producto Producto = new Entidades.Producto();
            Producto.Descripcion = txtDescripcion.Text;
            LogicaProducto.Modificar(Producto);
        }

    }
}
