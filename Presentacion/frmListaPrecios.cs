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
    public partial class frmListaPrecios : BaseForm
    {
        Logica.Producto LogicaProducto = new Logica.Producto();
        public frmListaPrecios()
        {
            InitializeComponent();
            dgvListaPrecios.AutoGenerateColumns = true;
            dgvListaPrecios.DataSource=LogicaProducto.TraerLista();
            //TODO: Preguntarle bien a mamá que quiere ver en la lista de precios y los filtros
        }

      
    }
}
