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
    public class FacturaCPN
    {
        private FacturaDAL fac = new FacturaDAL();
        public DataTable mostrarFactura1()
        {
            DataTable tabla = new DataTable();
            tabla = fac.mostrarFactura();
            return tabla;
        }
        public DataTable mostrarFactura2(string id)
        {
            DataTable tabla = new DataTable();
            tabla = fac.mostrarFactura(int.Parse(id));
            return tabla;
        }

        public void insertarFactura(int id_Cliente, DateTime fechaCompra, decimal total)
        {
            fac.insertarFactura(id_Cliente, fechaCompra, total);

        }
        public void editarFactura(int id, int id_Cliente, DateTime fechaCompra, decimal total)
        {
            fac.editarFactura(id, id_Cliente, fechaCompra, total);

        }

        public void eliminarFactura(int id)
        {
            fac.eliminarFactura(id);
        }
        public List<EFactura> ListaFactura()
        {
            FacturaCPN ar = new FacturaCPN();
            DataTable tab = ar.mostrarFactura1();
            List<EFactura> listaFactura = new List<EFactura>();
            foreach (DataRow d in tab.Rows)
            {
                EFactura factura = new EFactura(int.Parse(d["idFactura"].ToString()), int.Parse(d["id_Cliente"].ToString()),
                Convert.ToDateTime(d["fechaCompra"].ToString()), Convert.ToDecimal(d["total"].ToString()));
                listaFactura.Add(factura);

            }
            return listaFactura;
        }
    }
}
