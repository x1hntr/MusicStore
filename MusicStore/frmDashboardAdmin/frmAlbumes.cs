﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Negocio;

namespace frmDashboardAdmin
{
    public partial class frmAlbumes : Form
    {
        public frmAlbumes()
        {
            InitializeComponent();
        }

        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado disco nuevo", "Ok");
        }

        
    }
}
