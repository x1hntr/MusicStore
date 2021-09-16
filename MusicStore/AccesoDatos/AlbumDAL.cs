using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class AlbumDAL
    {

        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        //Album consultas
        public DataTable mostrarAlbum()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarAlbum";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void insertarAlbum(int stock, string nombre, string genero, DateTime fechaLanzamiento, string portada, decimal precio, int id_Artista)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarAlbum ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@fechaLanzamiento", fechaLanzamiento);
            comando.Parameters.AddWithValue("@portada", portada);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@id_Artista", id_Artista);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void editarAlbum(int id, int stock, string nombre, string genero, DateTime fechaLanzamiento, string portada, decimal precio, int id_Artista)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarAlbum ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@fechaLanzamiento", fechaLanzamiento);
            comando.Parameters.AddWithValue("@portada", portada);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@id_Artista", id_Artista);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void eliminarAlbum(int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarAlbum";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    
    }
}
