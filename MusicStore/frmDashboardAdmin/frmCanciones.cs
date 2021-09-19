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
    public partial class frmCanciones : Form
    {

        AlbumCPN al = new AlbumCPN();
        CancionCPN cl = new CancionCPN();

        private string id = null;
        bool editar = false;

        public frmCanciones()
        {
            InitializeComponent();
        }

        private void frmCanciones_Load(object sender, EventArgs e)
        {
            txtAlbum.Enabled = false;
            txtGenero.Enabled = false;
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            AlbumCPN al = new AlbumCPN();
            dgvAlbum.DataSource = al.MostrarAlbum();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtGenero.Text != "" && txtAlbum.Text != "" && txtLink.Text != "")
            {
                if (editar == false)
                {
                    
                    cl.insertarCancion(txtNombre.Text, txtLink.Text, txtGenero.Text, int.Parse(txtAlbum.Text));
                    MessageBox.Show("Se ha insertado un nuevo álbum corretamente");
                    txtAlbum.Text = "";
                    txtNombre.Text = "";
                    txtLink.Text = "";
                    txtGenero.Text = "";

                    CancionCPN cl1 = new CancionCPN();
                  //  dgvCanciones.DataSource = cl1.MostrarCancion();

                }
                if (editar == true)
                {

                    {
                 

                    }
                }
            }
            else
                MessageBox.Show("Llene todos los campos para continuar", "Alert");
        }

        private void dgvAlbum_Click(object sender, EventArgs e)
        {
            if (dgvAlbum.SelectedRows.Count != 0) {
                txtAlbum.Text = dgvAlbum.CurrentRow.Cells["idAlbum"].Value.ToString();
                txtGenero.Text = dgvAlbum.CurrentRow.Cells["genero"].Value.ToString();
            }
        }
    }
    
}
