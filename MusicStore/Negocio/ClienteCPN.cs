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
    public class ClienteCPN
    {
        private ClienteDAL cl = new ClienteDAL();
        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = cl.mostrarCliente();
            return tabla;
        }

        public void insertarCliente(string nombre, string apellido, string ci, string tarjeta)
        {
            cl.insertarCliente(nombre, apellido, ci, tarjeta);


        }
        public void editarCliente(string id, string nombre, string apellido, string ci, string tarjeta)
        {
            cl.editarCliente(Convert.ToInt32(id), nombre, apellido, ci, tarjeta);


        }
        public void eliminarCliente(string id)
        {

            cl.eliminarCliente(Convert.ToInt32(id));
        }
        public List<ECliente> ListaClientes()
        {
            ClienteCPN ar = new ClienteCPN();
            DataTable tab = ar.MostrarCliente();
            List<ECliente> listaClientes = new List<ECliente>();
            foreach (DataRow d in tab.Rows)
            {
                ECliente cliente = new ECliente(int.Parse(d["idCliente"].ToString()), d["nombre"].ToString(),
                    d["apellido"].ToString(), d["ci"].ToString(), d["tarjeta"].ToString());
                listaClientes.Add(cliente);

            }
            return listaClientes;
        }
    }
}