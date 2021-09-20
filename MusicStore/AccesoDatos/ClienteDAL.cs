using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class ClienteDAL
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        //Cancion consultas
        public DataTable mostrarCliente()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void insertarCliente(string nombre, string apellido, string ci, string tarjeta)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@link", apellido);
            comando.Parameters.AddWithValue("@genero", ci);
            comando.Parameters.AddWithValue("@idal", tarjeta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void editarCliente(int id, string nombre, string apellido, string ci, string tarjeta)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarCancion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@link", apellido);
            comando.Parameters.AddWithValue("@genero", ci);
            comando.Parameters.AddWithValue("@idal", tarjeta);
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void eliminarCliente(int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
    }
}