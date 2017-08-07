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
            dgvListaPrecios.AutoGenerateColumns = false;
            dgvListaPrecios.DataSource=LogicaProducto.TraerLista();
            this.dgvListaPrecios.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvListaPrecios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
 
            //TODO: Comisiones pasadas a pesos, filtros
        }

        private void btnGanancia_Click(object sender, EventArgs e)
        {
            int Aux = dgvListaPrecios.Rows.Count;
            int I = 0;
            while (I < Aux)
            {
                int Id = (int)dgvListaPrecios[0, I].Value;
                decimal Data = (decimal)dgvListaPrecios[2, I].Value;
                LogicaProducto.ActualizarPrecios(Id, Data, 0, 0);
                //TODO: Generar la actualizacion de precios pegandole a Google Finance
                I++;
            }
            dgvListaPrecios.DataSource=LogicaProducto.TraerLista();
        }
    }
}
