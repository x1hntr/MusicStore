using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace AccesoDatos
{
    public class Data
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        //usuarios consultas
        public DataTable mostrarUsuarios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
       
        public void insertarUsuario(string nombre, string apellido, string username, int administrador, string contrasenia )
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@username",username );
            comando.Parameters.AddWithValue("@administrador", administrador);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
      
        }
        public void editarUsuario(int id,string nombre, string apellido, string username, int administrador, string contrasenia)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@username", username);
            comando.Parameters.AddWithValue("@badministrador", administrador);
            comando.Parameters.AddWithValue("@contrasenia", contrasenia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void eliminarUsuario(int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

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
        public void editarArtista(int id, string nombre,  string nacionalidad)
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

        public void insertarCancion(string nombre, string link, string genero,int idal)
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
        public void editarCancion(int id,string nombre, string link, string genero, int idal)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarCancion";
            comando.CommandType = CommandType.StoredProcedure;
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
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        //Factura consultas

        public DataTable mostrarFactura()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarFactura";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void insertarFactura(int id_Usuario, DateTime fechaCompra, decimal total)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Usuario", id_Usuario);
            comando.Parameters.AddWithValue("@fechaCompra", fechaCompra);
            comando.Parameters.AddWithValue("@total", total);
   
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void editarFactura(int id, int id_Usuario, DateTime fechaCompra, decimal total)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Usuario", id_Usuario);
            comando.Parameters.AddWithValue("@fechaCompra", fechaCompra);
            comando.Parameters.AddWithValue("@total", total);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void eliminarFactura(int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

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
        public void insertarAlbum(int stock, string nombre, string genero, DateTime fechaLanzamiento, string portada, decimal precio,int id_Artista )
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
        public void editarAlbum(int id,int stock, string nombre, string genero, DateTime fechaLanzamiento, string portada, decimal precio, int id_Artista)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarAlbum ";
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
        public void eliminarAlbum(int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarAlbum ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        //itemFactura consultas
        public DataTable mostraritemFactura()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostraritemFactura";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void insertaritemFactura(int id_Factura, int id_Album)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertaritemFactura ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Factura", id_Factura);
            comando.Parameters.AddWithValue("@id_Album", id_Album);
           

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void editaritemFactura(int id, int id_Factura, int id_Album)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editaritemFactura ";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_Factura", id_Factura);
            comando.Parameters.AddWithValue("@id_Album", id_Album);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void eliminaritemFactura(int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminaritemFactura ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }



    }
}

