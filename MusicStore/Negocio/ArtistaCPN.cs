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
    public class ArtistaCPN
    {

        private ArtistaDAL art = new ArtistaDAL();
        public DataTable MostrarArtista()
        {
            DataTable tabla = new DataTable();
            tabla = art.mostrarArtista();
            return tabla;
        }

        public void insertarArtista(string nombre, string nacionalidad)
        {
            art.insertarArtista(nombre, nacionalidad);

        }
        public void editarArtista(int id, string nombre, string nacionalidad)
        {
            art.editarArtista(id, nombre, nacionalidad);

        }
        public void eliminarArtista(int id)
        {
            art.eliminarArtista(id);
        }
        public List<EArtista> ListaArtista()
        {
            ArtistaCPN ar = new ArtistaCPN();
            DataTable tab = ar.MostrarArtista();
            List<EArtista> listaArtista = new List<EArtista>();
            foreach (DataRow d in tab.Rows)
            {
                EArtista artista = new EArtista(int.Parse(d["idArtista"].ToString()), d["nombre"].ToString(),
                    d["nacionalidad"].ToString());
                listaArtista.Add(artista);

            }
            return listaArtista;
        }
    }
}
