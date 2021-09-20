using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class CancionDAL
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        //Cancion consultas
        public DataTable mostrarCancion()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarCancion";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void insertarCancion(string nombre, string link, string genero, int idal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarCancion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@link", link);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@idal", idal);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void editarCancion(int id, string nombre, string link, string genero, int idal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarCancion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@link", link);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@idal", idal);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void eliminarCancion(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarCancion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
    }
}
