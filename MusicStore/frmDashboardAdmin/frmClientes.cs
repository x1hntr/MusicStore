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
        UsuarioCPN us = new UsuarioCPN();
        private string id = null;
        bool editar = false;
        int administrador;
        public frmClientes()
        {
            InitializeComponent();
           
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            UsuarioCPN us = new UsuarioCPN();
            dgvUsuario.DataSource = us.MostrarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (chkAdministrador.Checked)
            {
                administrador = 1;
            }
            else
                administrador = 0;
            if (editar == false)
            {
                us.insertarUsuario(txtNombre.Text, txtApellido.Text, txtUsername.Text, administrador, txtPassword.Text);
                MessageBox.Show("Se ha insertado un nuevo usuario corretamente");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                UsuarioCPN us1 = new UsuarioCPN();
                dgvUsuario.DataSource = us1.MostrarUsuarios();

            }
            if (editar == true)
            {

                

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                id = dgvUsuario.CurrentRow.Cells["idUsuario"].Value.ToString();
                us.eliminarUsuario(id);
                MessageBox.Show("eliminado correctamente");
                AlbumCPN al1 = new AlbumCPN();
                dgvUsuario.DataSource = al1.MostrarAlbum();

            }
            else
                MessageBox.Show("Seleccione una fila para eliminar");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                editar = true;
                id =dgvUsuario.CurrentRow.Cells["idUsuario"].Value.ToString();
                txtNombre.Text = dgvUsuario.CurrentRow.Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvUsuario.CurrentRow.Cells["apellido"].Value.ToString();
                txtPassword.Text = dgvUsuario.CurrentRow.Cells["contrasenia"].Value.ToString();
                txtUsername.Text = dgvUsuario.CurrentRow.Cells["username"].Value.ToString();
                if (dgvUsuario.CurrentRow.Cells["administrador"].Value.ToString() == "1") {
                    chkAdministrador.Checked = true;
                }
                
            }
            else
                MessageBox.Show("Seleccione una fila para editar");
        }
    }
}
