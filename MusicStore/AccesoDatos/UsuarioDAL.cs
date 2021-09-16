using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;




namespace AccesoDatos
{
    public class UsuarioDAL
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

        
        

       

       

        


    }
}

