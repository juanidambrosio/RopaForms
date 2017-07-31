using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

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


        public void TraerLista()
        {
            Datos.Producto.TraerLista();
        }

        public DataTable TraerTodos()
        {
            return Datos.Producto.TraerTodos();
        }

        public void Eliminar(int Id)
        {
            Datos.Producto.Eliminar(Id);
        }

        public List<string> TraerTiposProducto()
        {
            List<string> lista = new List<string>();
            foreach (TiposEnum p in Enum.GetValues(typeof(TiposEnum)))
            {
                lista.Add(p.ToString());

            }
            return lista;
        }

        public List<string> TraerMarcas()
        {
            List<string> lista = new List<string>();
            foreach (MarcasEnum p in Enum.GetValues(typeof(MarcasEnum)))
            {
                lista.Add(p.ToString());

            }
            return lista;
        }

        public Entidades.Producto TraerProducto(int id)
        {
           return Datos.Producto.TraerProducto(id);
        }
    }
}
