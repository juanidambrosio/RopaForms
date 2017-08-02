using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAltaVendedor : BaseForm
    {
        Logica.Vendedor LogicaVendedor = new Logica.Vendedor();
        Entidades.Vendedor Vendedor = new Entidades.Vendedor();
        bool Modificar = false;
        List<ErrorProvider> errorProviders = new List<ErrorProvider> { new ErrorProvider(),new ErrorProvider()};

        frmAdminVendedores obj = (frmAdminVendedores)Application.OpenForms["frmAdminVendedores"];

        public frmAltaVendedor()
        {
            InitializeComponent();
            btnAgregar.Text = "Agregar";
        }

        public frmAltaVendedor(int Id)
        {
            InitializeComponent();
            Vendedor = LogicaVendedor.TraerVendedor(Id);
            txtApellido.Text = Vendedor.Apellido;
            txtNombre.Text = Vendedor.Nombre;
            Modificar = true;
            btnAgregar.Text = "Modificar";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (ValidarCampos())
            {
                Vendedor.Nombre = txtNombre.Text;
                Vendedor.Apellido = txtApellido.Text;
               
            
            if (Modificar == false)
            {
                try
                {
                    LogicaVendedor.Agregar(Vendedor);
                    MessageBox.Show("VENDEDOR AGREGADO CORRECTAMENTE");
                    this.Close();
                    obj.TraerTodos();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else try
                {
                    LogicaVendedor.Modificar(Vendedor);
                    MessageBox.Show("VENDEDOR MODIFICADO CORRECTAMENTE");
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
            int i = 0;
            var boxes = Controls.OfType<TextBox>();
            var valorRetorno = true;

            foreach (var box in boxes)
            {
                
                if (string.IsNullOrWhiteSpace(box.Text))
                {

                    errorProviders.ElementAt(i).SetError(box, "Por favor, llenar todos los campos antes de continuar");
                    valorRetorno = false;
                }
                else
                {
                    errorProviders.ElementAt(i).Clear();
                }
                i++;
            }
            return valorRetorno;
        }
    }
}
