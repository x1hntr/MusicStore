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
    

    public partial class frmClientes : Form
    {
        UsuarioCPN usuario = new UsuarioCPN();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnCargarInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear usuario", "ok");
            UsuarioCPN user = new UsuarioCPN();
            dataGridView1.DataSource = user.MostrarUsuarios();
        }
    }
}
