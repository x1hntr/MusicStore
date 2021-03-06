using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace frmDashboardAdmin
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            txtZona.Text = "Resumen";
            abrirFormularioHijo(new frmResumen());
        }
       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void abrirFormularioHijo(object formHijo) {
            if (this.pnlContenedor.Controls.Count > 0) {
                     this.pnlContenedor.Controls.RemoveAt(0);
                Form fh = formHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pnlContenedor.Controls.Add(fh);
                this.pnlContenedor.Tag = fh;
                fh.Show(); 
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            txtZona.Text = "Información";
            abrirFormularioHijo(new frmInformacion());
            
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            txtZona.Text = "Resumen";
            abrirFormularioHijo(new frmResumen());
           
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmVentas());
            Form rep = new frmReproductor();
            rep.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            txtZona.Text = "Usuarios";
            abrirFormularioHijo(new frmUsuario());

        }

        private void btnAlbumes_Click(object sender, EventArgs e)
        {
            txtZona.Text = "Álbumes";
            abrirFormularioHijo(new frmAlbumes());
            
        }

        private void btnArtista_Click(object sender, EventArgs e)
        {
            txtZona.Text = "Artistas";
            abrirFormularioHijo(new frmArtista());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtZona.Text = "Canciones";
            abrirFormularioHijo(new frmCanciones());
            
        }
    }
}
