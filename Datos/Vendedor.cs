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
    public class Vendedor
    {
        public static void Agregar(Entidades.Vendedor vendedor)
        {
            string strSP = "proc_alta_vendedor";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comAlta = new SqlCommand(strSP, objConexion);
            comAlta.CommandType = CommandType.StoredProcedure;
            comAlta.Parameters.AddWithValue("@Nombre", vendedor.Nombre.ToString());
            comAlta.Parameters.AddWithValue("@Apellido", vendedor.Apellido.ToString());
            objConexion.Open();
            comAlta.ExecuteNonQuery();
            objConexion.Close();
        }

        public static DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select IdVendedor as ID,Nombre, Apellido from Vendedores";
            SqlDataAdapter daTraerTodos = new SqlDataAdapter(strSQL, Conexion.strConexion);
            daTraerTodos.Fill(dt);
            return dt;
        }

        public static void Modificar(Entidades.Vendedor vendedor)
        {
            string strSP = "proc_modificar_vendedor";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comAlta = new SqlCommand(strSP, objConexion);
            comAlta.CommandType = CommandType.StoredProcedure;
            comAlta.Parameters.AddWithValue("@IdVendedor",Convert.ToInt32(vendedor.IdVendedor));
            comAlta.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
            comAlta.Parameters.AddWithValue("@Apellido", vendedor.Apellido.ToString());
            objConexion.Open();
            comAlta.ExecuteNonQuery();
            objConexion.Close();
        }

        public static Entidades.Vendedor TraerVendedor(int id)
        {
            Entidades.Vendedor objEntidadVendedor = new Entidades.Vendedor();
            string strSQL = "Select * from vendedores where idVendedor=" + id;
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comTraerUno = new SqlCommand(strSQL, objConexion);
            SqlDataReader drVendedor;
            objConexion.Open(); // abro conexion
            drVendedor = comTraerUno.ExecuteReader(); // cargo datareader con la ejecucion del command
            if (drVendedor.Read())
            {
                objEntidadVendedor.IdVendedor = Convert.ToInt32(drVendedor["IdVendedor"]);
                objEntidadVendedor.Nombre= drVendedor["Nombre"].ToString();
                objEntidadVendedor.Apellido = drVendedor["Apellido"].ToString();

            }
            return objEntidadVendedor;

        }

        public static void Eliminar(int id)
        {
            string strSP = "proc_eliminar_vendedor";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comAlta = new SqlCommand(strSP, objConexion);
            comAlta.CommandType = CommandType.StoredProcedure;
            comAlta.Parameters.AddWithValue("@IdVendedor", id);
            objConexion.Open();
            comAlta.ExecuteNonQuery();
            objConexion.Close();
        }
    }
}
