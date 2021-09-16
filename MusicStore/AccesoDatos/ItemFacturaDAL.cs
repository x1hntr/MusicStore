using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
   public class ItemFacturaDAL
    {

        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
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
