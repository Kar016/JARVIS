﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = mtxDato.Text;
        }

        private void mtxDato_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblMensaje.Text = "Error al introducir el dato";
        }
    }
}
