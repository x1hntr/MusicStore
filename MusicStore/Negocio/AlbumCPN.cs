using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

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
        public void eliminarAlbum(int id)
        {
            al.eliminarAlbum(id);
        }
    }
}
