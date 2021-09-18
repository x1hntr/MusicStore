using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace AccesoDatos
{
    public class ConexionBD
    {
        private SqlConnection Conexion = new SqlConnection("Server=tcp:joureyes7.database.windows.net,1433;Initial Catalog=ProyectoBDD;Persist Security Info=False;User ID=administrador;Password=Proyecto12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public SqlConnection AbrirConexion()
         {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
