using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace Negocio
{
    public class CancionCPN
    {
        private CancionDAL can = new CancionDAL();
        public DataTable MostrarArtista()
        {
            DataTable tabla = new DataTable();
            tabla = can.mostrarCancion();
            return tabla;
        }

        public void insertarCancion(string nombre, string link, string genero, int idal)
        {
            can.insertarCancion(nombre,  link,  genero,  idal);

        }
        public void editarCancion(int id, string nombre, string link, string genero, int ida)
        {
            can.editarCancion( id,  nombre,  link, genero,  ida);

        }
        public void eliminarCancion(int id)
        {
            can.eliminarCancion(id);
        }
    }
}
