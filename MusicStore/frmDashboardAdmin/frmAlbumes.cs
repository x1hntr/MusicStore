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

    

    public partial class frmAlbumes : Form
    {
        AlbumCPN al = new AlbumCPN();
        private string id = null;
        bool editar = false;

        public frmAlbumes()
        {
            InitializeComponent();
        } 


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlbum.SelectedRows.Count > 0)
            {
                editar = true;
                id = dgvAlbum.CurrentRow.Cells["idAlbum"].Value.ToString();
                txtStock.Text = dgvAlbum.CurrentRow.Cells["stock"].Value.ToString();
                txtNombre.Text = dgvAlbum.CurrentRow.Cells["nombre"].Value.ToString();
                txtGenero.Text = dgvAlbum.CurrentRow.Cells["genero"].Value.ToString();
               
                txtPortada.Text = dgvAlbum.CurrentRow.Cells["portada"].Value.ToString();
                txtPrecio.Text = dgvAlbum.CurrentRow.Cells["precio"].Value.ToString();
                txtIdArtista.Text = dgvAlbum.CurrentRow.Cells["id_Artista"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlbum.SelectedRows.Count > 0)
            {
                id = dgvAlbum.CurrentRow.Cells["idAlbum"].Value.ToString();
                al.eliminarAlbum(id);
                MessageBox.Show("eliminado correctamente");
                AlbumCPN al1 = new AlbumCPN();
                dgvAlbum.DataSource = al1.MostrarAlbum();

            }
            else
                MessageBox.Show("Seleccione una fila para eliminar");
        }

       
        private void txtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtIdArtista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void frmAlbumes_Load(object sender, EventArgs e)
        {
            txtIdArtista.Enabled = false;
            AlbumCPN al = new AlbumCPN();
            ArtistaCPN ar = new ArtistaCPN();
            dgvAlbum.DataSource = al.MostrarAlbum();
            dgvArtista.DataSource = ar.MostrarArtista();
        }

        private void dgvArtista_Click(object sender, EventArgs e)
        {
            if (dgvArtista.SelectedRows.Count != 0)
            {
                txtIdArtista.Text = dgvArtista.CurrentRow.Cells["idArtista"].Value.ToString();
                
            }
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtGenero.Text != "" && txtPrecio.Text != "" && txtIdArtista.Text != "" && txtStock.Text != "" && txtPortada.Text != "")
            {
                if (editar == false)
                {
                    al.insertarAlbum(Int32.Parse(txtStock.Text), txtNombre.Text, txtGenero.Text, Convert.ToDateTime(dtpFecha.Value.ToString()), txtPortada.Text, Convert.ToDecimal(txtPrecio.Text), Int32.Parse(txtIdArtista.Text));
                    MessageBox.Show("Se ha insertado un nuevo álbum corretamente");
                    txtStock.Text = "";
                    txtNombre.Text = "";
                    txtGenero.Text = "";

                    txtPortada.Text = "";
                    txtPrecio.Text = "";
                    txtIdArtista.Text = "";
                    AlbumCPN al1 = new AlbumCPN();
                    dgvAlbum.DataSource = al1.MostrarAlbum();

                }
                if (editar == true)
                {

                    {
                        al.editarAlbum(id, txtNombre.Text, txtGenero.Text, Int32.Parse(txtStock.Text), Convert.ToDateTime(dtpFecha.Value.ToString()), Int32.Parse(txtIdArtista.Text), Int32.Parse(txtPrecio.Text), txtPortada.Text);
                        MessageBox.Show("Se ha modificado el álbum corretamente");
                        txtStock.Text = "";
                        txtNombre.Text = "";
                        txtGenero.Text = "";

                        txtPortada.Text = "";
                        txtPrecio.Text = "";
                        txtIdArtista.Text = "";
                        AlbumCPN al1 = new AlbumCPN();
                        dgvAlbum.DataSource = al1.MostrarAlbum();

                    }
                }
            }
            else
                MessageBox.Show("Llene todos los campos para continuar", "Alert");
        }
    }
}
