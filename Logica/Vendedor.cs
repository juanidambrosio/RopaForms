using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class Vendedor
    {
        public void Agregar(Entidades.Vendedor vendedor)
        {
            Datos.Vendedor.Agregar(vendedor);
        }

        public void Modificar(Entidades.Vendedor vendedor)
        {
            Datos.Vendedor.Modificar(vendedor);
        }

        public Entidades.Vendedor TraerVendedor(int id)
        {
            if (id > 0)
            {
               return Datos.Vendedor.TraerVendedor(id);
            }

            else throw new Exception("El vendedor que se busca modificar es inexistente");
            
        }

        public void Eliminar(int Id)
        {
            Datos.Vendedor.Eliminar(Id);
        }
    }
}
