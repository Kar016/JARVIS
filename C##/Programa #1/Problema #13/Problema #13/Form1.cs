using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__13
{
    public partial class Form1 : Form
    {
        private int conteo;

        public Form1()
        {
            InitializeComponent();
            conteo = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblValor.Text = conteo.ToString();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            trbIntervalo.Value = trbIntervalo.Minimum;
            lblTValor.Text = trbIntervalo.Value.ToString();
            timer1.Interval = trbIntervalo.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void trbIntervalo_Scroll(object sender, EventArgs e)
        {
            lblTValor.Text = trbIntervalo.Value.ToString();
            timer1.Interval = trbIntervalo.Value; // Sirve para cambiar la frecuencia del intervalo
        }
    }
}
