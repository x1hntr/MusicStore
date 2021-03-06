using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using Enti;
namespace Negocio
{
    public class CancionCPN
    {
        private CancionDAL can = new CancionDAL();
        public DataTable MostrarCancion()
        {
            DataTable tabla = new DataTable();
            tabla = can.mostrarCancion();
            return tabla;
        }

        public void insertarCancion(string nombre, string link, string genero, int idal)
        {
            can.insertarCancion(nombre, link, genero, idal);

        }
        public void editarCancion(string id, string nombre, string link, string genero, string ida)
        {
            can.editarCancion(int.Parse(id), nombre, link, genero, int.Parse(ida));

        }
        public void eliminarCancion(string id)
        {
            can.eliminarCancion(int.Parse(id));
        }
        public List<ECancion> ListaCancion()
        {
            CancionCPN ar = new CancionCPN();
            DataTable tab = ar.MostrarCancion();
            List<ECancion> listaCancion = new List<ECancion>();
            foreach (DataRow d in tab.Rows)
            {
                ECancion cancion = new ECancion(int.Parse(d["idCancion"].ToString()), d["link"].ToString(),
                    d["nombre"].ToString(), d["genero"].ToString(),
                    int.Parse(d["id_Album"].ToString()));
                listaCancion.Add(cancion);

            }
            return listaCancion;
        }
        public List<ECancion> BuscarCancion(int id)
        {
            CancionCPN ar = new CancionCPN();
            DataTable tab = ar.MostrarCancion();
            List<ECancion> listaCancion = new List<ECancion>();
            foreach (DataRow d in tab.Rows)
            {
                if (id == int.Parse(d["idCancion"].ToString()))
                {
                    ECancion cancion = new ECancion(int.Parse(d["idCancion"].ToString()), d["link"].ToString(),
                        d["nombre"].ToString(), d["genero"].ToString(),
                        int.Parse(d["id_Album"].ToString()));
                    listaCancion.Add(cancion);
                }

            }
            return listaCancion;
        }

    }
}
