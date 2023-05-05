namespace Problema__46
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

            // Una curva cerrada y rellena con la brocha
            Point[] puntos = { new Point(30, 45), new Point(110, 75), new Point(175, 200) };
            g.FillClosedCurve(Brushes.Aquamarine, puntos);

            // Dibujo de una ecplise rellena
            g.FillEllipse(Brushes.BlueViolet, new Rectangle(75, 20, 100, 25));

            // Dibujo de pie de relleno
            g.FillPie(Brushes.Blue, new Rectangle(100, 100, 100, 100), 45, 120);

            // Dibujo de poligono relleno
            Point[] puntos2 = { new Point(20, 145), new Point(150, 75), new Point(200, 220) };
            g.FillPolygon(Brushes.DarkKhaki, puntos2);

            // Dibujo de un rectangulo relleno
            g.FillRectangle(Brushes.DarkOliveGreen, new Rectangle(150, 100, 30, 75));

        }
    }
}