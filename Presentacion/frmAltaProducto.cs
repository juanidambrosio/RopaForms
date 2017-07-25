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
        bool Modifica = false; // Con la unica finalidad de distinguir entre una llamada a modificar o agregar
        Logica.Producto LogicaProducto = new Logica.Producto();
        public frmAltaProducto()
        {
            InitializeComponent();
            btnAgregar.Text = "Agregar";
            Modifica = false;
        }

        public frmAltaProducto(int Id)
        {
            InitializeComponent();
            btnAgregar.Text = "Modificar";
            LogicaProducto.TraerProducto(Id);
            Modifica = true;
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Producto Producto = new Entidades.Producto();
            Producto.Descripcion = txtDescripcion.Text;
            
            Entidades.MarcasEnum Marca = new Entidades.MarcasEnum();
            Enum.TryParse(cboMarca.SelectedValue.ToString(), out Marca);
            Producto.Marca = Marca;

            Entidades.TiposEnum TipoProducto = new Entidades.TiposEnum();
            Enum.TryParse(cboTipoProducto.SelectedValue.ToString(), out TipoProducto);
            Producto.TipoProducto = TipoProducto;

            Producto.PrecioInicial = Convert.ToDouble(nudPrecio.Value);
            Producto.Stock = Convert.ToInt32(nudStockInicial.Value);
            Producto.Peso = Convert.ToDouble(nudPeso.Value);
            if (Modifica == true)
                LogicaProducto.Agregar(Producto);
            else
                LogicaProducto.Modificar(Producto);
        }


    }
}
