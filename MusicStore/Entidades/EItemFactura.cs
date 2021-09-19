using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;


namespace Entidades
{
    public class EItemFactura
    {
        private int idItem;
        private int id_Factura;
        private int id_Album;

        public EItemFactura(int idItem, int id_Factura, int id_Album)
        {
            this.IdItem = idItem;
            this.Id_Factura = id_Factura;
            this.Id_Album = id_Album;
        }

        public int IdItem { get => idItem; set => idItem = value; }
        public int Id_Factura { get => id_Factura; set => id_Factura = value; }
        public int Id_Album { get => id_Album; set => id_Album = value; }

        public override string ToString()
        {
            return "Código item: " + IdItem + " Código Factura: " + Id_Factura;
        }


    }
}
