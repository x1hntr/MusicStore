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
    

    public partial class frmUsuario : Form
    {
        UsuarioCPN us = new UsuarioCPN();
        private string id = null;
        bool editar = false;
        int administrador;
        public frmUsuario()
        {
            InitializeComponent();
           
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
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
                    us.editarUsuario(int.Parse(id), txtNombre.Text, txtApellido.Text, txtUsername.Text, administrador, txtPassword.Text);
                    MessageBox.Show("Se ha insertado un nuevo usuario corretamente");
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    UsuarioCPN us1 = new UsuarioCPN();
                    dgvUsuario.DataSource = us1.MostrarUsuarios();
                    editar = false;
                }
            }
            else
                MessageBox.Show("Llene todos los campos para continuar", "Alert");
        }
            
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                id = dgvUsuario.CurrentRow.Cells["idUsuario"].Value.ToString();
                us.eliminarUsuario(int.Parse((id)));
                MessageBox.Show("eliminado correctamente");
                UsuarioCPN us1 = new UsuarioCPN();
                dgvUsuario.DataSource = us1.MostrarUsuarios();

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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            UsuarioCPN us = new UsuarioCPN();
            dgvUsuario.DataSource = us.MostrarUsuarios();
        }
    }
}
