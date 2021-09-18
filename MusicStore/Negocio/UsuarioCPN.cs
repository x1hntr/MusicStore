using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace Negocio
{
    public class UsuarioCPN
    {
        private UsuarioDAL user = new UsuarioDAL();
        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = user.mostrarUsuarios();
            return tabla;
        }

        public void insertarUsuario(string nombre, string apellido, string username, int administrador, string contrasenia)
        {
            user.insertarUsuario(nombre, apellido, username,  administrador, contrasenia);
  
        }
        public void editarUsuario(int id, string nombre, string apellido, string username, int administrador, string contrasenia)
        {
            user.editarUsuario(id, nombre, apellido, username, administrador, contrasenia);
        }
        public void eliminarUsuario(string id)
        {
            user.eliminarUsuario(Int32.Parse(id));
        }


    }
}
