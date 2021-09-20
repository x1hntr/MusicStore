using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace frmDashboardAdmin
{
    public partial class frmFactura : Form
    {

        FacturaCPN fa = new FacturaCPN();


        public frmFactura()
        {
            InitializeComponent();
        }

     

        private void frmFactura_Load(object sender, EventArgs e)
        {
            dtgFacturas.DataSource = fa.mostrarFactura1();
            lbNombre.Visible = false;
            lbApellido.Visible = false;
            lbTotal.Visible = false;
            lbCedula.Visible = false;
            lbFecha.Visible = false;
            btnImprimir.Enabled = false;
        }

        private void dtgFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtgFacturas.CurrentRow;
            lbNombre.Text = fila.Cells["nombre"].Value.ToString();
            lbApellido.Text = fila.Cells["apellido"].Value.ToString();
            lbTotal.Text = fila.Cells["total"].Value.ToString();
            lbCedula.Text = fila.Cells["ci"].Value.ToString();
            DateTime fecha = Convert.ToDateTime(fila.Cells["fechaCompra"].Value.ToString());
            lbFecha.Text = fecha.Date.ToShortDateString();
            lbNombre.Visible = true;
            lbApellido.Visible = true;
            lbTotal.Visible = true;
            lbCedula.Visible = true;
            btnImprimir.Enabled = true;
            lbFecha.Visible = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La factura ha sido impresa");
        }

       
        }
    }

