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
using System.IO;

namespace frmPreview
{
    public partial class Form1 : Form
    {
        bool Play = false;
        
        private List<EAlbum> listaAlbum = new List<EAlbum>();
        private List<EAlbum> listaAlbumtotal = new List<EAlbum>();
        private List<ECancion> listaCancion = new List<ECancion>();
        private List<ECliente> listaClientes = new List<ECliente>();
        private List<EFactura> listaFacturas = new List<EFactura>();
        AlbumCPN al = new AlbumCPN();
        CancionCPN ca = new CancionCPN();
        ClienteCPN cl = new ClienteCPN();
        ItemFacturaCPN item = new ItemFacturaCPN();
        FacturaCPN fact = new FacturaCPN();

        string Path = @"C:\Users\x1dxn\OneDrive\Documentos\AudiosPBE";

        string PathM;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (Play) {
                case true:
                    wmPlayer.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.play;
                    Play = false;
                    break;
                case false:
                    wmPlayer.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.pausa;
                    Play = true;
                    break;
            }
        }

        private void timerDuracion_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            mtbDuracion.Value = (int)wmPlayer.Ctlcontrols.currentPosition;
            mtbVolumen.Value = wmPlayer.settings.volume;
        }
        public void ActualizarDatosTrack() {
            if (wmPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying) {
                mtbDuracion.Maximum = (int)wmPlayer.Ctlcontrols.currentItem.duration;
                timerDuracion.Start();
            } else if (wmPlayer.playState == WMPLib.WMPPlayState.wmppsPaused) {
                timerDuracion.Stop();
            } else if (wmPlayer.playState == WMPLib.WMPPlayState.wmppsStopped) {
                timerDuracion.Stop();
                mtbDuracion.Value = 0;
            }
        }

        private void wmPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }



        private void mtbVolumen_ValueChanged(object sender, decimal value)
        {
            wmPlayer.settings.volume = mtbVolumen.Value;
        }

        private void mtbDuracion_MouseDown(object sender, MouseEventArgs e)
        {
            if (wmPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wmPlayer.Ctlcontrols.currentPosition = wmPlayer.currentMedia.duration * e.X / mtbDuracion.Width;
            }
        }

        private void lstArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ECancion ca1 = lbCanciones.SelectedItem as ECancion;
            
          
            for (int tam = 0; tam < Directory.EnumerateFiles(Path).Count(); tam++) 
            {
                FileInfo fk = new FileInfo(Directory.GetFiles(Path)[tam]);

                if (ca1.Link == fk.Name) {
                    PathM = fk.FullName;
                    lbltitulo.Text = ca1.Link;
                }
               
            }
            wmPlayer.URL = PathM;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            EAlbum ca1 = cmbAlbumes.SelectedItem as EAlbum;

            listaAlbumtotal.Add(ca1);
            lbCarrito.Items.Add(ca1);
            foreach (EAlbum al2 in listaAlbumtotal)
            {
                total = al2.Precio + total;


            }
            lblTotal.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarAlbum();
            btnAgregar.Enabled = false;
            btnFinalizar.Enabled = false;

    }

   

        public void llenarAlbum()
        {
            listaAlbum = al.ListaAlbum();
            foreach (EAlbum al in listaAlbum)
            {
                cmbAlbumes.Items.Add(al);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtCedula.Text != "" && txtTarjeta.Text != "")
            {
                cl.insertarCliente(txtNombre.Text, txtApellido.Text, txtCedula.Text, txtTarjeta.Text);
                MessageBox.Show("Se ha registrado una venta corretamente");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCedula.Text = "";
                txtTarjeta.Text = "";
                listaClientes = cl.ListaClientes();
                ECliente cli1 = listaClientes.LastOrDefault();
                fact.insertarFactura(cli1.IdCliente, DateTime.Now, Convert.ToDecimal(lblTotal.Text));
                listaFacturas = fact.ListaFactura();

                EFactura fact1 = listaFacturas.LastOrDefault();
                foreach (EAlbum album in lbCarrito.Items)
                {
                    item.insertaritemFactura(fact1.IdFactura, album.IdAlbum);

                }
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCedula.Text = "";
                txtTarjeta.Text = "";
                lbCarrito.Items.Clear();

                txtApellido.Enabled = false;
                txtNombre.Enabled = false;
                txtCedula.Enabled = false;
                txtTarjeta.Enabled = false;
            }
            else
                MessageBox.Show("Llene correctamente los datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void cmbAlbumes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnFinalizar.Enabled = true;

            lbCanciones.Items.Clear();
            EAlbum ca1 = cmbAlbumes.SelectedItem as EAlbum;
            listaCancion = ca.ListaCancion();
            foreach (ECancion ca2 in listaCancion)
            {
                if (ca2.Id_Album == ca1.IdAlbum)
                {
                    lbCanciones.Items.Add(ca2);
                }

            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
