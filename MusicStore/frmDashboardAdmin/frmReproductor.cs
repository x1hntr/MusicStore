using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace frmDashboardAdmin
{
    public partial class frmReproductor : Form
    {

      
        private List<EAlbum> listaAlbum = new List<EAlbum>();
        private List<ECancion> listaCancion = new List<ECancion>();
        AlbumCPN al = new AlbumCPN();
        CancionCPN ca = new CancionCPN();


        public frmReproductor()
        {
            InitializeComponent();
        }

        public void llenarAlbum() {
            listaAlbum = al.ListaAlbum();
            foreach (EAlbum al in listaAlbum)
            {
                
                cmbAlbumes.Items.Add(al);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            EAlbum ca1 = cmbAlbumes.SelectedItem as EAlbum;
            lstCarrito.Items.Add(ca1);
        }

        private void cbmAlbumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCanciones.Items.Clear();
            EAlbum ca1 = cmbAlbumes.SelectedItem as EAlbum;
            listaCancion = ca.ListaCancion();
            foreach (ECancion ca2 in listaCancion)
            {
                if (ca2.Id_Album == ca1.IdAlbum)
                {
                    lstCanciones.Items.Add(ca2);
                }

            }
        }

        private void frmReproductor_Load(object sender, EventArgs e)
        {
            llenarAlbum();
        }
    }
}
