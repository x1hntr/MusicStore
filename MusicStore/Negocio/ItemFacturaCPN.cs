using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using Entidades;
namespace Negocio
{
    public class ItemFacturaCPN
    {
        private ItemFacturaDAL item = new ItemFacturaDAL();
        public DataTable MostrarItemFactura()
        {
            DataTable tabla = new DataTable();
            tabla = item.mostraritemFactura();
            return tabla;
        }

        public void insertaritemFactura(int id_Factura, int id_Album)
        {
            item.insertaritemFactura(id_Factura, id_Album);

        }
        public void editaritemFactura(int id, int id_Factura, int id_Album)
        {
            item.editaritemFactura(id, id_Factura, id_Album);

        }
        public void eliminaritemFactura(int id)
        {
            item.eliminaritemFactura(id);
        }

        public List<EItemFactura> ListaFactura()
        {
            ItemFacturaCPN ar = new ItemFacturaCPN();
            DataTable tab = ar.MostrarItemFactura();
            List<EItemFactura> listaItemFactura = new List<EItemFactura>();
            foreach (DataRow d in tab.Rows)
            {
                EItemFactura itemfactura = new EItemFactura(int.Parse(d["idItem"].ToString()), int.Parse(d["id_Factura"].ToString()),
                     int.Parse(d["id_Album"].ToString()));
                listaItemFactura.Add(itemfactura);

            }
            return listaItemFactura;
        }
    }
}
