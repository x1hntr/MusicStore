using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Entidades
{
    public class ECancion
    {
        private int idCancion;
        private string link;
        private string nombre;
        private string genero;
        private int id_Album;

        public ECancion(int idCancion, string link, string nombre, string genero, int id_Album)
        {
            this.IdCancion = idCancion;
            this.Link = link;
            this.Nombre = nombre;
            this.Genero = genero;
            this.Id_Album = id_Album;
        }

        public int IdCancion { get => idCancion; set => idCancion = value; }
        public string Link { get => link; set => link = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Id_Album { get => id_Album; set => id_Album = value; }

        public override string ToString()
        {
            return "ID: " + IdCancion + " Canción: " + Nombre;
        }


    }
}
