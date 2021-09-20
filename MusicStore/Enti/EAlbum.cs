using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

using System.Data;

namespace Enti
{
    public class EAlbum
    {
        private int idAlbum;
        private string Nombre;
        private string genero;
        private decimal stock;
        private DateTime fechaLanzamiento;
        private int id_Artista;
        private decimal precio;
        private string portada;

        public EAlbum(int idAlbum, decimal stock, string nombre, string genero, DateTime fechaLanzamiento, string portada, decimal precio, int id_Artista)
        {
            this.idAlbum = idAlbum;
            this.Nombre = nombre;
            this.Genero = genero;
            this.Stock = stock;
            this.FechaLanzamiento = fechaLanzamiento;
            this.Id_Artista = id_Artista;
            this.Precio = precio;
            this.Portada = portada;
        }


        public int IdAlbum { get => idAlbum; set => idAlbum = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public decimal Stock { get => stock; set => stock = value; }
        public DateTime FechaLanzamiento { get => fechaLanzamiento; set => fechaLanzamiento = value; }
        public int Id_Artista { get => id_Artista; set => id_Artista = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Portada { get => portada; set => portada = value; }


        public override string ToString()
        {
            return "ID: " + IdAlbum + " Albúm: " + Nombre + " Precio: " + Precio;
        }
    }
}
