using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enti
{

    public class ECliente
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private string ci;
        private string tarjeta;

        public ECliente(int idCliente, string nombre, string apellido, string ci, string tarjeta)
        {
            this.IdCliente = idCliente;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Ci = ci;
            this.Tarjeta = tarjeta;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Ci { get => ci; set => ci = value; }
        public string Tarjeta { get => tarjeta; set => tarjeta = value; }

        public override string ToString()
        {
            return "Id: " + IdCliente + " Nombre: " + Nombre + " Apellido: " + Apellido;
        }
    }
}