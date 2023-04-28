using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Problema__21
{
    public partial class Form1 : Form
    {
       private ListViewGroup Frutas = new ListViewGroup("Frutas", HorizontalAlignment.Left);
       private ListViewGroup Carne = new ListViewGroup("Carne", HorizontalAlignment.Left);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Creacion de un imagelist
            ImageList misImagenes = new ImageList();
            misImagenes.ImageSize = new Size(200, 200); // Tama;o de la imagen

            // Obtener dirrecion de las imagenes
            string[] archivos = Directory.GetFiles("imagenes");

            // Cargamos los archivos
            try
            {
                foreach (string archivo in archivos)
                    misImagenes.Images.Add(Image.FromFile(archivo));
            }
            catch
            {
                MessageBox.Show("Algo salio mal al cargar.");
            }

            lvAlimentos.SmallImageList = misImagenes;

            lvAlimentos.Items.Add(new ListViewItem("Manzana",0, Frutas));
            lvAlimentos.Items.Add(new ListViewItem("Pera",1, Frutas));
            lvAlimentos.Items.Add(new ListViewItem("Sandia",2, Frutas));
            lvAlimentos.Items.Add(new ListViewItem("Banana",3, Frutas));
            lvAlimentos.Items.Add(new ListViewItem("Melon",4, Frutas));
            lvAlimentos.Items.Add(new ListViewItem("Fresa",5, Frutas));
            lvAlimentos.Items.Add(new ListViewItem("Chinola",6, Frutas));

            ListViewItem miElemento = new ListViewItem("pollo", Carne);
            lvAlimentos.Items.Add(miElemento);

            lvAlimentos.Items.Add(new ListViewItem("Cerdo", Carne));
            lvAlimentos.Items.Add(new ListViewItem("Res", Carne));
            lvAlimentos.Items.Add(new ListViewItem("Pescado", Carne));
            lvAlimentos.Items.Add(new ListViewItem("Chivo", Carne));

            lvAlimentos.Groups.Add(Frutas);
            lvAlimentos.Groups.Add(Carne);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (rbFrutas.Checked == true)
            {
                lvAlimentos.Items.Add(new ListViewItem(textAlimentos.Text, Frutas));
            }

            if (rbCarne.Checked == true)
            {
                lvAlimentos.Items.Add(new ListViewItem(textAlimentos.Text, Carne));
            }
        }

        private void lvAlimentos_MouseClick(object sender, MouseEventArgs e)
        {
            lblSelecionado.Text = lvAlimentos.SelectedItems[0].SubItems[0].Text;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvAlimentos.Items.Clear();
            lblSelecionado.Text = "";
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
           // lvAlimentos.SelectedItems[0].SubItems[0].Text = textElemento.Text;
           // lvAlimentos.SelectedItems[0].ImageIndex = Convert.ToInt32(textImagen.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lvAlimentos.Items.RemoveAt(lvAlimentos.SelectedIndices[0]);
        }
    }
}
