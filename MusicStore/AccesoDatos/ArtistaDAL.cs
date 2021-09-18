using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class ArtistaDAL
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        //Artistas consultas
        public DataTable mostrarArtista()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarArtista";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void insertarArtista(string nombre, string nacionalidad)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarArtista";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@nacionalidad", nacionalidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void editarArtista(int id, string nombre, string nacionalidad)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarArtista";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@nacionalidad", nacionalidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void eliminarArtista(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarArtista";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
    }
}
