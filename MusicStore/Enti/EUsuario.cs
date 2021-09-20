using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace Enti
{
    public class EUsuario
    {
        private int idUsuario;
        private string nombre;
        private string apellido;
        private string userName;
        private string contrasenia;
        private int administrador;

        public EUsuario(int idUsuario, string nombre, string apellido, string userName, string contrasenia, int administrador)
        {
            this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.UserName = userName;
            this.Contrasenia = contrasenia;
            this.Administrador = administrador;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public int Administrador { get => administrador; set => administrador = value; }

        public override string ToString()
        {
            return "Id: " + IdUsuario + " Nombre: " + Nombre + " Apellido: " + Apellido + " User Name: " + userName;
        }
    }
}
