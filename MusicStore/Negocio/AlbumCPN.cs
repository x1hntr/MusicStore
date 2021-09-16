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
            al.insertarAlbum(stock, nombre, genero, fechaLanzamiento,  portada,precio,  id_Artista);

        }
        public void editarAlbum(string id,int stock, string nombre, string genero, DateTime fechaLanzamiento, string portada, decimal precio, int id_Artista)
        {
            al.editarAlbum(Convert.ToInt32(id), stock, nombre, genero, fechaLanzamiento, portada, precio, id_Artista);

        }
        public void eliminarAlbum(string id)
        {
            
            al.eliminarAlbum(Convert.ToInt32(id));
        }
    }
}
