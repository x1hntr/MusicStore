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
    public partial class frmArtista : Form
    {
        ArtistaCPN ar = new ArtistaCPN();
        private string id = null;
        bool editar = false;
        public frmArtista()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
           
                ArtistaCPN ar = new ArtistaCPN();
                dgvArtista.DataSource = ar.MostrarArtista();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                ar.insertarArtista(txtNombre.Text, txtNacionalidad.Text);
                txtNacionalidad.Text = "";
                txtNombre.Text = "";
                ArtistaCPN ar1 = new ArtistaCPN();
                dgvArtista.DataSource = ar1.MostrarArtista();
            }
            if (editar == true)
            {

          

            }
        }

        
            private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                    return;
                }
            }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                
                e.Handled = true;
                return;
            }
        }
    }
}
