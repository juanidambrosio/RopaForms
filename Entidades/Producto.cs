using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Producto
    {
        public int IdProducto { get; set; }
        public TiposEnum TipoProducto { get; set; }
        public MarcasEnum Marca { get; set; }
        
        public string Descripcion { get; set; }

        public double PrecioInicial { get; set; }
        public double Peso { get; set; }
        public int Stock { get; set; }
    }
}
