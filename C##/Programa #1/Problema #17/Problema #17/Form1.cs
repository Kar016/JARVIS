using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dudFrutas.Items.Add("Melon");
            dudFrutas.Items.Add("Manzana");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dudFrutas.Items.Add(textFruta.Text);

            textFruta.Text = "";
        }

        private void dudFrutas_SelectedItemChanged(object sender, EventArgs e)
        {
            string fruta = (string) dudFrutas.SelectedItem;

            lblMensaje.Text = string.Format("Tu fruta favorita es {0}, es muy sabrosa",fruta);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int indice = dudFrutas.SelectedIndex;

            dudFrutas.Items.RemoveAt(indice);
            dudFrutas.SelectedIndex = 0;
        }
    }
}
