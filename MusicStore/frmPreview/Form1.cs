﻿using System;
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
namespace frmPreview
{
    public partial class Form1 : Form
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;
        private List<EAlbum> listaAlbum = new List<EAlbum>();
        private List<EAlbum> listaAlbumtotal = new List<EAlbum>();
        private List<ECancion> listaCancion = new List<ECancion>();
        AlbumCPN al = new AlbumCPN();
        CancionCPN ca = new CancionCPN();
        ClienteCPN cl = new ClienteCPN();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedadeArchivos = new OpenFileDialog();
            CajaDeBusquedadeArchivos.Multiselect = true;
            if (CajaDeBusquedadeArchivos.ShowDialog() == DialogResult.OK) {
                ArchivosMP3 = CajaDeBusquedadeArchivos.SafeFileNames;
                rutasArchivosMP3 = CajaDeBusquedadeArchivos.FileNames;
                foreach (var ArchivoMP3 in ArchivosMP3) {
                    lbCanciones.Items.Add(ArchivoMP3);
                }
                wmPlayer.URL = rutasArchivosMP3[0];
            }
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
            //wmPlayer.URL = rutasArchivosMP3[lbCanciones.SelectedIndex];
            //btnPlay.Image = Properties.Resources.pausa;
            //lbltitulo.Text = ArchivosMP3[lbCanciones.SelectedIndex];
            // cmbAlbum.Items.Add(ArchivosMP3[lbCanciones.SelectedIndex]);
            ECancion ca1 = lbCanciones.SelectedItem as ECancion;
            lbPrueba.Text = ca1.Link;
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


    }

        private void cmbAlbumes_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        public void llenarAlbum()
        {
            listaAlbum = al.ListaAlbum();
            foreach (EAlbum al in listaAlbum)
            {
                cmbAlbumes.Items.Add(al);
            }
        }



    }
}
