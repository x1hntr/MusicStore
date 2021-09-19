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

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text !="" && txtNacionalidad.Text != "")
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
                    ar.editarArtista(int.Parse(id), txtNombre.Text, txtNacionalidad.Text);
                    MessageBox.Show("Se ha modificado el artista corretamente");
                    txtNacionalidad.Text = "";
                    txtNombre.Text = "";
                    editar = false;
                    ArtistaCPN ar1 = new ArtistaCPN();
                    dgvArtista.DataSource = ar1.MostrarArtista();
                    
                }
            }else
                MessageBox.Show("Llene todos los campos para continuar", "Alert");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArtista.SelectedRows.Count > 0)
            {
                id = dgvArtista.CurrentRow.Cells["idArtista"].Value.ToString();
                ar.eliminarArtista(int.Parse(id));
                MessageBox.Show("Eliminado correctamente");
                ArtistaCPN al1 = new ArtistaCPN();
               dgvArtista.DataSource = al1.MostrarArtista();

            }
            else
                MessageBox.Show("Seleccione una fila para eliminar");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvArtista.SelectedRows.Count > 0)
            {
                editar = true;
                id = dgvArtista.CurrentRow.Cells["idArtista"].Value.ToString();
                txtNombre.Text = dgvArtista.CurrentRow.Cells["nombre"].Value.ToString();
                txtNacionalidad.Text = dgvArtista.CurrentRow.Cells["Nacionalidad"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }

        private void frmArtista_Load(object sender, EventArgs e)
        {
            ArtistaCPN ar = new ArtistaCPN();
            dgvArtista.DataSource = ar.MostrarArtista();
        }
    }
}
