using System.Drawing.Drawing2D;

namespace Problema__45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Creacion de una pluma propia de color rojo y 5 de ancho
            Pen pluma1 = new Pen(Color.Red, 5);
            g.DrawLine(pluma1, 50, 50, 200, 50);

            // Pluma con estilo de guion predeterminado
            Pen pluma2 = new Pen(Color.Green, 7);
            pluma2.DashStyle = DashStyle.DashDotDot; 
            g.DrawLine(pluma2, 50, 70, 200, 70);

            // Creacion de estilo de guion
            Pen pluma3 = new Pen(Color.Orange, 10);
            float[] guiones = { 1.0f, 1.0f, 2.0f, 1.0f, 3.0f, 1.0f };

            pluma3.DashPattern = guiones;
            g.DrawLine(pluma3, 50, 90, 200, 90);

            // Poner terminal 1

            Pen pluma4 = new Pen(Color.OliveDrab, 15);
            pluma4.StartCap = LineCap.ArrowAnchor;
            pluma4.EndCap = LineCap.DiamondAnchor;
            g.DrawLine(pluma4, 50, 120, 200, 120);
        }
    }
}