using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Vendedor
    {
        public static void Agregar(Entidades.Vendedor vendedor)
        {
            throw new NotImplementedException();
            //TODO: Agregar vendedor a la BD
        }

        public static void Modificar(Entidades.Vendedor vendedor)
        {
           //TODO: Modificar vendedor en la BD
        }

        public static Entidades.Vendedor TraerVendedor(int id)
        {
            return new Entidades.Vendedor();//TODO: Consultar a la base de datos por el vendedor
        }
    }
}
