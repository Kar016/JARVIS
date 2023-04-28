using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adicionar elementos

            lbFrutas.Items.Add("Banana");
            lbFrutas.Items.Add("Aguacate");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lbFrutas.Items.Add(textFruta.Text);

            textFruta.Text = "";
        }

        private void lbFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFrutas.SelectedIndex!= -1)
            {
                lblFruta.Text = (string)lbFrutas.Items[lbFrutas.SelectedIndex];
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int indice = lbFrutas.SelectedIndex;

            if (indice!= -1)
            {
                lbFrutas.Items.RemoveAt(indice);
            }
        }
    }
}
