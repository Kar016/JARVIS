using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__8
{
    public partial class Form2 : Form
    {
        private string Cometario;
        public Form2(String pMensaje)
        {
            InitializeComponent();
            lblMensaje.Text = pMensaje;
        }

        public string Comentario
        {
            set
            {
                Comentario = value;
                lblComentario.Text = Cometario;

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
