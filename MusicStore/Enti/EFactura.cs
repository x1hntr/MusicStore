using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Enti
{
    public class EFactura
    {
        private int idFactura;
        private int id_Usuario;
        private DateTime fechaCompra;
        private decimal total;

        public EFactura(int idFactura, int id_Usuario, DateTime fechaCompra, decimal total)
        {
            this.IdFactura = idFactura;
            this.Id_Usuario = id_Usuario;
            this.FechaCompra = fechaCompra;
            this.Total = total;
        }

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public decimal Total { get => total; set => total = value; }
        public override string ToString()
        {
            return "Código factura: " + IdFactura + " Id Usuaio: " + Id_Usuario + " fecha compra: " + fechaCompra;
        }

    }
}
