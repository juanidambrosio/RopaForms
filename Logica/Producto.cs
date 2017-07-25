using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class Producto
    {
        public void Agregar(Entidades.Producto producto)
        {
            Datos.Producto.Agregar(producto);
        }

        public void Modificar(Entidades.Producto producto)
        {
            Datos.Producto.Modificar(producto);
        }

        public void TraerProducto(int id)
        {
            Datos.Producto.TraerProducto(id);
        }

        public void Eliminar(int Id)
        {
            Datos.Producto.Eliminar(Id);
        }
    }
}
