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

        private void btnRead_Click(object sender, EventArgs e)
        {
            AlbumCPN al = new AlbumCPN();
            dataGridView1.DataSource = al.MostrarAlbum();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                id = dataGridView1.CurrentRow.Cells["idAlbum"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txtGenero.Text = dataGridView1.CurrentRow.Cells["genero"].Value.ToString();
                mtbFecha.Text = dataGridView1.CurrentRow.Cells["fechaLanzamiento"].Value.ToString();
                txtPortada.Text = dataGridView1.CurrentRow.Cells["portada"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
                txtIdArtista.Text = dataGridView1.CurrentRow.Cells["id_Artista"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells["idAlbum"].Value.ToString();
                al.eliminarAlbum(Int32.Parse(id));
                MessageBox.Show("eliminado correctamente");
                AlbumCPN al1 = new AlbumCPN();
                dataGridView1.DataSource = al1.MostrarAlbum();

            }
            else
                MessageBox.Show("Seleccione una fila para eliminar");
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (editar == false)
            {
                al.insertarAlbum(Int32.Parse(txtStock.Text), txtNombre.Text, txtGenero.Text, Convert.ToDateTime(mtbFecha.Text), txtPortada.Text, Convert.ToDecimal(txtPrecio.Text), Int32.Parse(txtIdArtista.Text));
                MessageBox.Show("Se ha insertado un nuevo álbum corretamente");
                txtStock.Text = "";
                txtNombre.Text = "";
                txtGenero.Text = "";
                mtbFecha.Text = "";
                txtPortada.Text = "";
                txtPrecio.Text = "";
                txtIdArtista.Text = "";
                AlbumCPN al1 = new AlbumCPN();
                dataGridView1.DataSource = al1.MostrarAlbum();

            }
            if (editar == true)
            {

                

                al.editarAlbum(id, txtNombre.Text, txtGenero.Text, Int32.Parse(txtStock.Text), Convert.ToDateTime(mtbFecha.Text), Int32.Parse(txtIdArtista.Text), decimal.Parse(txtPrecio.Text), txtPortada.Text);
                    MessageBox.Show("Se ha modificado el álbum corretamente");
                    txtStock.Text = "";
                    txtNombre.Text = "";
                    txtGenero.Text = "";
                    mtbFecha.Text = "";
                    txtPortada.Text = "";
                    txtPrecio.Text = "";
                    txtIdArtista.Text = "";
                    AlbumCPN al1 = new AlbumCPN();
                    dataGridView1.DataSource = al1.MostrarAlbum();

                
            }
        }
        }
}
