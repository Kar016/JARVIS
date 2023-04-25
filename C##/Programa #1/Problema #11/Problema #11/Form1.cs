using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo para menu");
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a, b, r;

            a = Convert.ToDouble(textA.Text);
            b = Convert.ToDouble(textB.Text);

            r = a + b;

            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() +" B=" + b.ToString();
            slblOperaciones.Text = "Suma";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a, b, r;

            a = Convert.ToDouble(textA.Text);
            b = Convert.ToDouble(textB.Text);

            r = a - b;

            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperaciones.Text = "Resta";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a, b, r;

            a = Convert.ToDouble(textA.Text);
            b = Convert.ToDouble(textB.Text);

            r = a * b;

            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperaciones.Text = "Multplicacion";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a, b, r;

            a = Convert.ToDouble(textA.Text);
            b = Convert.ToDouble(textB.Text);

            r = a / b;

            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperaciones.Text = "Division";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void habilitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            textA.Enabled = habilitarToolStripMenuItem.Checked;
            textB.Enabled = habilitarToolStripMenuItem.Checked;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textA.Text = "0";
        }

        private void aleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int valor = rnd.Next(0, 100);
            textA.Text = valor.ToString();
        }

        private void slblValores_Click(object sender, EventArgs e)
        {

        }
    }
}
