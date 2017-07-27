using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Producto
    {
        public static void Agregar(Entidades.Producto producto)
        {
           //TODO: Agregar a la BD el nuevo producto
        }

        public static void Modificar(Entidades.Producto producto)
        {
           //TODO: Modificar en la BD el producto existente
        }

        public static void TraerProducto(int id)
        {
           //TODO: Buscar en la BD el producto asociado al id y cargarlo
        }

        public static void TraerLista()
        {
           //TODO: Hacer consulta para traer lista de precios
        }

        public static void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
