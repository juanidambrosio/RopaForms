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
        ErrorProvider errorProvider1 = new ErrorProvider();
        public frmAltaProducto()
        {
            InitializeComponent();
            btnAgregar.Text = "Agregar";
            Modifica = false;
            cboMarca.DataSource = LogicaProducto.TraerMarcas();
            cboTipoProducto.DataSource = LogicaProducto.TraerTiposProducto();
        }

        public frmAltaProducto(int Id)
        {
            InitializeComponent();
            btnAgregar.Text = "Modificar";
            LogicaProducto.TraerProducto(Id);
            Modifica = true;
            cboMarca.DataSource = LogicaProducto.TraerMarcas();
            cboTipoProducto.DataSource = LogicaProducto.TraerTiposProducto();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
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


                //Verificacion si es Agregar o Modificar

                if (Modifica == false)
                {
                    try
                    {
                        LogicaProducto.Agregar(Producto);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else try
                    {
                        LogicaProducto.Modificar(Producto);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

            }
        }

        public bool ValidarCampos()
        {
            var boxes = Controls.OfType<TextBox>();
            var valorRetorno = true;

            foreach (var box in boxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                     errorProvider1.SetError(box, "Por favor, llenar todos los campos antes de continuar");
                    valorRetorno = false;
                }
                
            }
            return valorRetorno;
        }

       
    }
}
