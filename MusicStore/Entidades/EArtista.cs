using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Entidades
{
    public class EArtista
    {
        private int idArtista;
        private string nombre;
        private string nacionalidad;

        public EArtista(int idArtista, string nombre, string nacionalidad)
        {
            this.IdArtista = idArtista;
            this.Nombre = nombre;
            this.Nacionalidad = nacionalidad;
        }

        public int IdArtista { get => idArtista; set => idArtista = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }



    }
}
