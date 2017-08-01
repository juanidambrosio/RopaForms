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
        Entidades.Producto Producto = new Entidades.Producto();
        frmAdminProducto obj = (frmAdminProducto)Application.OpenForms["frmAdminProducto"];
       

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
            cboMarca.DataSource = LogicaProducto.TraerMarcas();
            cboTipoProducto.DataSource = LogicaProducto.TraerTiposProducto();
            Producto = LogicaProducto.TraerProducto(Id);
            Modifica = true;

            int index = cboMarca.FindString(Producto.Marca.ToString());
            cboMarca.SelectedIndex = index;

            int index2 = cboTipoProducto.FindString(Producto.TipoProducto.ToString());
            cboTipoProducto.SelectedIndex = index2;

            txtDescripcion.Text = Producto.Descripcion;
            nudPeso.Value = Convert.ToDecimal(Producto.Peso);
            nudPrecio.Value = Convert.ToDecimal(Producto.PrecioPer);
            nudStockInicial.Value = Convert.ToInt32(Producto.Stock);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {

                Producto.Descripcion = txtDescripcion.Text;

                Entidades.MarcasEnum Marca = new Entidades.MarcasEnum();
                Enum.TryParse(cboMarca.SelectedValue.ToString(), out Marca);
                Producto.Marca = Marca;

                Entidades.TiposEnum TipoProducto = new Entidades.TiposEnum();
                Enum.TryParse(cboTipoProducto.SelectedValue.ToString(), out TipoProducto);
                Producto.TipoProducto = TipoProducto;

                Producto.PrecioPer = Convert.ToDecimal(nudPrecio.Value);

                //Conversion de soles a dolares y pesos

                string Pesos = Logica.Currency.CurrencyConvert(Convert.ToDecimal(Producto.PrecioPer), "PEN", "ARS");
                string Dolares = Logica.Currency.CurrencyConvert(Convert.ToDecimal(Producto.PrecioPer), "PEN", "USD");
                var Pesos2 = Pesos.Replace(".",",");
                var Dolares2 = Dolares.Replace(".",",");
                Producto.PrecioArs = Convert.ToDecimal(Pesos2.Substring(0, Pesos2.IndexOf(' ') -1));
                Producto.PrecioUs = Convert.ToDecimal(Dolares2.Substring(0, Dolares2.IndexOf(' ') - 1));


                Producto.Stock = Convert.ToInt32(nudStockInicial.Value);
                Producto.Peso = Convert.ToDouble(nudPeso.Value);


                //Verificacion si es Agregar o Modificar

                if (Modifica == false)
                {
                    try
                    {
                        LogicaProducto.Agregar(Producto);
                        MessageBox.Show("PRODUCTO AGREGADO CORRECTAMENTE");
                        
                        this.Close();
                        obj.Show();
                        obj.TraerTodos();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else try
                    {
                        LogicaProducto.Modificar(Producto);
                        MessageBox.Show("DATOS DEL PRODUCTO MODIFICADOS CORRECTAMENTE");
                        this.Close();
                        obj.TraerTodos();
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
