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
    public class AlbumCPN
    {
        private AlbumDAL al = new AlbumDAL();
        public DataTable MostrarAlbum()
        {
            DataTable tabla = new DataTable();
            tabla = al.mostrarAlbum();
            return tabla;
        }

        public void insertarAlbum(int stock, string nombre, string genero, DateTime fechaLanzamiento, string portada, decimal precio, int id_Artista)
        {
            al.insertarAlbum(stock, nombre, genero, fechaLanzamiento, portada, precio, id_Artista);

        }
        public void editarAlbum(string id, string nombre, string genero, int stock, DateTime fechaLanzamiento, int id_Artista, decimal precio, string portada)
        {
            al.editarAlbum(Convert.ToInt32(id), nombre, genero, stock, fechaLanzamiento, id_Artista, precio, portada);


        }
        public void eliminarAlbum(string id)
        {

            al.eliminarAlbum(Convert.ToInt32(id));
        }
        public List<EAlbum> ListaAlbum()
        {
            AlbumCPN al = new AlbumCPN();
            DataTable tab = al.MostrarAlbum();
            List<EAlbum> listaAlbum = new List<EAlbum>();
            foreach (DataRow d in tab.Rows)
            {
                EAlbum album = new EAlbum(int.Parse(d["idAlbum"].ToString()), int.Parse(d["stock"].ToString()), d["nombre"].ToString(),
                    d["genero"].ToString(), Convert.ToDateTime(d["fechaLanzamiento"].ToString()), d["portada"].ToString(),
               Convert.ToDecimal(d["precio"].ToString()), int.Parse(d["id_Artista"].ToString()));
                listaAlbum.Add(album);

            }
            return listaAlbum;
        }
    }

}

