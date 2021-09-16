using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace Negocio
{
    public class FacturaCPN
    {
        private FacturaDAL fac = new FacturaDAL();
        public DataTable MostrarFactura()
        {
            DataTable tabla = new DataTable();
            tabla = fac.mostrarFactura();
            return tabla;
        }

        public void insertarFactura(int id_Usuario, DateTime fechaCompra, decimal total)
        {
            fac.insertarFactura(id_Usuario, fechaCompra, total);

        }
        public void editarFactura(int id, int id_Usuario, DateTime fechaCompra, decimal total)
        {
            fac.editarFactura(id, id_Usuario, fechaCompra, total);

        }
        public void eliminarFactura(int id)
        {
            fac.eliminarFactura(id);
        }
    }
}
