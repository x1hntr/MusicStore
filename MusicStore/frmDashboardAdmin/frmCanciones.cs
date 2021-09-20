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

       
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

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
            CancionCPN cl1 = new CancionCPN();
            dgvCanciones.DataSource = cl1.MostrarCancion();
            AlbumCPN al1 = new AlbumCPN();
            dgvAlbum.DataSource = al1.MostrarAlbum();
            txtLink.Enabled = false;
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
                    
                    cl.insertarCancion(txtLink.Text, txtNombre.Text, txtGenero.Text, int.Parse(txtAlbum.Text));
                    MessageBox.Show("Se ha insertado un nuevo álbum corretamente");
                    txtAlbum.Text = "";
                    txtNombre.Text = "";
                    txtLink.Text = "";
                    txtGenero.Text = "";

                    CancionCPN cl1 = new CancionCPN();
                   dgvCanciones.DataSource = cl1.MostrarCancion();

                }
                if (editar == true)
                {

                    cl.editarCancion(id, txtNombre.Text, txtLink.Text, txtGenero.Text, txtAlbum.Text);
                    MessageBox.Show("Se ha Editado un nuevo álbum corretamente");
                    txtAlbum.Text = "";
                    txtNombre.Text = "";
                    txtLink.Text = "";
                    txtGenero.Text = "";
                    CancionCPN cl1 = new CancionCPN();
                    dgvCanciones.DataSource = cl1.MostrarCancion();
                    editar = false;


                }
            }
            else
                MessageBox.Show("Llene todos los campos para continuar", "Alert");
        }

      

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            id = dgvCanciones.CurrentRow.Cells["idCancion"].Value.ToString();
            cl.eliminarCancion(id);
            MessageBox.Show("Eliminado correctamente");
            CancionCPN cl1 = new CancionCPN();
            dgvCanciones.DataSource = cl1.MostrarCancion();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedadeArchivos = new OpenFileDialog();
            CajaDeBusquedadeArchivos.Multiselect = false;
            if (CajaDeBusquedadeArchivos.ShowDialog() == DialogResult.OK)
            {
                ArchivosMP3 = CajaDeBusquedadeArchivos.SafeFileNames;
                rutasArchivosMP3 = CajaDeBusquedadeArchivos.FileNames;
                foreach (var ArchivoMP3 in ArchivosMP3)
                {
                    txtLink.Text = ArchivoMP3.ToString();
                }
                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCanciones.SelectedRows.Count > 0)
            {
                editar = true;
                id = dgvCanciones.CurrentRow.Cells["idCancion"].Value.ToString();
                txtNombre.Text = dgvCanciones.CurrentRow.Cells["nombre"].Value.ToString();
                txtLink.Text = dgvCanciones.CurrentRow.Cells["link"].Value.ToString();
                txtGenero.Text = dgvCanciones.CurrentRow.Cells["genero"].Value.ToString();
                txtAlbum.Text = dgvCanciones.CurrentRow.Cells["id_Album"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }

        private void dgvAlbum_Click_1(object sender, EventArgs e)
        {
            if (dgvAlbum.SelectedRows.Count != 0)
            {
                txtAlbum.Text = dgvAlbum.CurrentRow.Cells["idAlbum"].Value.ToString();
                txtGenero.Text = dgvAlbum.CurrentRow.Cells["genero"].Value.ToString();

            }
        }
    }
    
}
