namespace Problema__44
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

            // Ejemplo 1

            // Dibujo de un arco
            g.DrawArc(Pens.Coral, new Rectangle(50, 50, 100, 100), 45, 180);

            // Dibujo de una linea
            g.DrawLine(Pens.Blue, 125, 25, 150, 200);

            // Dibujo de un rectangulo
            g.DrawRectangle(Pens.Orange, new Rectangle(75, 75, 200, 25));

            // Dibujo de una serie de lineas
            Point[] puntos = { new Point(30, 45), new Point(110, 75), new Point(175, 200) };
            g.DrawLines(Pens.Green, puntos);

            // Fin del ejemplo 1

            // Ejemplo 2

            // Dibujo de un Bezier con 4 puntos
            g.DrawBezier(Pens.Blue, 100, 100, 130, 175, 147, 20, 200, 230);

            // Dibujo de una curva cerrada
            Point[] points = { new Point(30, 45), new Point(110, 75), new Point(175, 200) };
            g.DrawCurve(Pens.Red, puntos);

            // Dibujo de una curva
            Point[] points2 = { new Point(10, 25), new Point(50, 200), new Point(150, 230) };
            g.DrawClosedCurve(Pens.Red, points2);

            // Dibujo de un segmento de pie
            g.DrawPie(Pens.Green, new Rectangle(100, 100, 100, 100), 30, 90);

            Point[] points3 = { new Point(10, 175), new Point(70, 50), new Point(150, 30) };
            g.DrawPolygon(Pens.Orange, points3); ;

            // Fin del ejemplo 2
        }
    }
}