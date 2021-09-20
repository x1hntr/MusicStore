using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class FacturaDAL
    {

        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        //Cancion consultas
        public DataTable mostrarFactura()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "emitirFactura";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable mostrarFactura(int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "emitirFactura3";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
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
            comando.Parameters.AddWithValue("@id_Cliente", id_Usuario);
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
            comando.Parameters.AddWithValue("@id_Cliente", id_Usuario);
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
    }
}
