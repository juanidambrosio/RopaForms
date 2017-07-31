﻿using System;
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
            string strSQL = "Select IdProducto as ID,TipoProducto as TipoProducto, Marca, Descripcion, Stock from Productos";
            SqlDataAdapter daTraerTodos = new SqlDataAdapter(strSQL, Conexion.strConexion);
            daTraerTodos.Fill(dt);
            return dt;
        }

        public static Entidades.Producto TraerProducto(int id)
        {
            Entidades.Producto objEntidadProducto = new Entidades.Producto();
            string strSQL = "Select * from productos where idProducto=" + id;
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comTraerUno = new SqlCommand(strSQL, objConexion);
            SqlDataReader drProducto;
            objConexion.Open(); // abro conexion
            drProducto = comTraerUno.ExecuteReader(); // cargo datareader con la ejecucion del command
            if (drProducto.Read())
            {
                objEntidadProducto.IdProducto = Convert.ToInt32(drProducto["IdProducto"]);
                objEntidadProducto.Descripcion = drProducto["Descripcion"].ToString();
                objEntidadProducto.PrecioInicial = Convert.ToDouble(drProducto["PrecioInicial"]);
                objEntidadProducto.Peso = Convert.ToDouble(drProducto["Peso"]);
                objEntidadProducto.Stock = Convert.ToInt32(drProducto["Stock"]);

                Entidades.TiposEnum tipoProducto = new Entidades.TiposEnum();
                Enum.TryParse(drProducto["TipoProducto"].ToString(), out tipoProducto);
                objEntidadProducto.TipoProducto = tipoProducto;

                Entidades.MarcasEnum marca = new Entidades.MarcasEnum();
                Enum.TryParse(drProducto["Marca"].ToString(), out marca);
                objEntidadProducto.Marca = marca;
            }
            return objEntidadProducto;

        }

        public static void Modificar(Entidades.Producto producto)
        {
            string strSP = "proc_modificar_producto";
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comAlta = new SqlCommand(strSP, objConexion);
            comAlta.CommandType = CommandType.StoredProcedure;
            comAlta.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
            comAlta.Parameters.AddWithValue("@TipoProducto", producto.TipoProducto.ToString());
            comAlta.Parameters.AddWithValue("@Marca", producto.Marca.ToString());
            comAlta.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            comAlta.Parameters.AddWithValue("@PrecioInicial", producto.PrecioInicial);
            comAlta.Parameters.AddWithValue("@Peso", producto.Peso);
            comAlta.Parameters.AddWithValue("@Stock", producto.Stock);
            objConexion.Open();
            comAlta.ExecuteNonQuery();
            objConexion.Close();
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
