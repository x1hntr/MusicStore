using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDashboardAdmin
{
    public partial class frmAlbumes : Form
    {
        public frmAlbumes()
        {
            InitializeComponent();
        }

        private void bntCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado disco nuevo", "Ok");
        }
    }
}
