﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPreview
{
    public partial class Form1 : Form
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

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
                    lstCanciones.Items.Add(ArchivoMP3);
                }
                wmPlayer.URL = rutasArchivosMP3[0];
            }
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmPlayer.URL = rutasArchivosMP3[lstCanciones.SelectedIndex];
            btnPlay.Image = Properties.Resources.pausa;
            lbltitulo.Text = ArchivosMP3[lstCanciones.SelectedIndex];
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
    }
}
