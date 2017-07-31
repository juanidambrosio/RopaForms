using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Producto
    {
        public static void Agregar(Entidades.Producto producto)
        {
                string strSP = "proc_alta_producto";
                SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
                SqlCommand comAlta = new SqlCommand(strSP, objConexion);
                comAlta.CommandType = CommandType.StoredProcedure;
                comAlta.Parameters.AddWithValue("@TipoProducto", producto.TipoProducto.ToString());
                comAlta.Parameters.AddWithValue("@Marca",producto.Marca.ToString());
                comAlta.Parameters.AddWithValue("@Descripcion",producto.Descripcion);
                comAlta.Parameters.AddWithValue("@PrecioInicial",producto.PrecioInicial);
                comAlta.Parameters.AddWithValue("@Peso",producto.Peso);
                comAlta.Parameters.AddWithValue("@Stock",producto.Stock);
                objConexion.Open();
                comAlta.ExecuteNonQuery();
                objConexion.Close();

            
        }

        public static DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select IdProducto as ID,TipoProducto as TipoProducto, Descripcion, PrecioInicial as Precio from Productos";
            SqlDataAdapter daTraerTodos = new SqlDataAdapter(strSQL, Conexion.strConexion);
            daTraerTodos.Fill(dt);
            return dt;
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
