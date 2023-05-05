using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Problema__47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Obtener el objeto graphics
            Graphics g = e.Graphics;

            // Creacion de un color
            Color miColor = Color.FromArgb(120, 150, 30);

            // Creacion la brocha solida
            SolidBrush miBrocha = new SolidBrush(miColor);

            g.FillRectangle(miBrocha, new Rectangle(10, 10, 150, 50));

            // Seleccion del entramado
            HatchStyle entramado = HatchStyle.BackwardDiagonal;

            // Creacion de una brocha con entramado
            miColor = Color.FromArgb(200, 0, 30);
            HatchBrush brochaEnt = new HatchBrush(entramado, miColor);

            g.FillRectangle(brochaEnt, new Rectangle(10, 70, 150, 50));

            // Creacion de una brocha con entramado a dos colores
            miColor = Color.FromArgb(200, 255, 150);
            Color miColor2 = Color.FromArgb(0, 200, 130);
            HatchBrush brochaEnt2 = new HatchBrush(entramado, miColor, miColor2);

            g.FillRectangle(brochaEnt2, new Rectangle(10, 130, 150, 50));

            // Creacion de una brocha con imagen

            Image imagen = new Bitmap("C:\\Users\\pc\\OneDrive\\Documentos\\Karen\\C#\\Problema #47\\Problema #47\\bin\\Debug\\Imagen.png");
            Brush brochaIm = new TextureBrush(imagen);

            g.FillRectangle(brochaIm, new Rectangle(100, 200, 250, 500));

            // Creacion de una brocha con gradiente
            Point inicio = new Point(10, 10);
            Point final = new Point(50, 25);

            LinearGradientBrush brochaG = new LinearGradientBrush(inicio, final, miColor, miColor2);
            g.FillRectangle(brochaG, new Rectangle(10, 250, 150, 50));

            // Con seleccion del tipo de gradiente

            LinearGradientMode gradiente = LinearGradientMode.Horizontal;

            LinearGradientBrush brochaG2 = new LinearGradientBrush(new Rectangle(0, 0, 100, 100), miColor, miColor2, gradiente);
            g.FillRectangle(brochaG2, new Rectangle(10, 310, 150, 50));
        }
    }
}