using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Negocio;


namespace frmDashboardAdmin
{
    

    public partial class frmClientes : Form
    {
        Usuario usuarioCN = new Usuario();
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
           // dataGridView1.DataSource = user.MostrarUsuarios();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se mostro los usuarios", "Ok");
            Usuario user = new Usuario();
          //  dataGridView1.DataSource = user.MostrarUsuarios();
            
        }
    }
}
