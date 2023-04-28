using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarNodo_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(textNodo.Text);
            textNodo.Text = "";
        }

        private void btnAdicionarElemento_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textElemento.Text);
            textElemento.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
    }
}
