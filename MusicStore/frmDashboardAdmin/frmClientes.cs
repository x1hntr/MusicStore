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
    }
}
