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
using Enti;
namespace frmDashboardAdmin
{
    public partial class Login : Form
    {
        UsuarioCPN us = new UsuarioCPN();
        List<EUsuario> ListaUsuarios = new List<EUsuario>();
        bool loginI = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            frmDashboardAdmin.Form1 dash = new frmDashboardAdmin.Form1();
            frmDashboardAdmin.Login log = new frmDashboardAdmin.Login();

            ListaUsuarios = us.ListaUsuario();

            if (txtPass.Text != "" && txtUser.Text != "")
            {
                foreach (EUsuario us1 in ListaUsuarios)
                {
                    if (loginI == false)
                    {
                        if (txtUser.Text == us1.UserName && txtPass.Text == us1.Contrasenia)
                        {
                            loginI = true;
                            MessageBox.Show("Inicio de sesion exitoso");
                            this.Hide();
                            dash.ShowDialog();
                            this.Close();
                        }
                        else
                            loginI = false;
                    }
                }

                if (loginI == false) {
                    MessageBox.Show("Vuelva a ingresar sus credeniales");
                }

            }
            else
                MessageBox.Show("Por favor Ingrese todos los parametros");
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
