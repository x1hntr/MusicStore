using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using Entidades;

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
            user.insertarUsuario(nombre, apellido, username, administrador, contrasenia);

        }
        public void editarUsuario(int id, string nombre, string apellido, string username, int administrador, string contrasenia)
        {
            user.editarUsuario(id, nombre, apellido, username, administrador, contrasenia);
        }
        public void eliminarUsuario(int id)
        {
            user.eliminarUsuario(id);
        }
        public List<EUsuario> ListaUsuario()
        {
            UsuarioCPN ar = new UsuarioCPN();
            DataTable tab = ar.MostrarUsuarios();
            List<EUsuario> listaUsuario = new List<EUsuario>();
            foreach (DataRow d in tab.Rows)
            {
                EUsuario usuario = new EUsuario(int.Parse(d["idUsuario"].ToString()), d["nombre"].ToString(),
                    d["apellido"].ToString(), d["userName"].ToString(), d["contrasenia"].ToString(),
                    int.Parse(d["administrador"].ToString()));
                listaUsuario.Add(usuario);

            }
            return listaUsuario;
        }

    }
}
