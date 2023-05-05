using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__42
{
    public partial class Form1 : Form
    {
        private int x = 0;
        private int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDibuja_Click(object sender, EventArgs e)
        {
            // Obtenemos el objeto graphics en medio del handle de la ventana
            Graphics g = Graphics.FromHwnd(this.Handle);

            // Creamos un texto
            Font fuente = new Font("Times New Roman", 35);

            // Dibujamos un texto
            g.DrawString("En metodo", fuente, Brushes.Green, 50, 75);

            // Tenemos que liberar los recursos administrativos
            // Si lo creamos directamente hacemos dispone
            // Si es una referencia a un objeto graphics ya exixtente
            // No hace falta dispone

            g.Dispose();
        }

        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            x += 5;
            y += 17;

            Invalidate(new Rectangle (0,0,100,120));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Obtenemos el objeto graphics
            Graphics g = e.Graphics;

            // Creacion una fuente
            Font fuente = new Font("Times New Roman", 35);

            // Dibujo de un texto
            g.DrawString("Hola a todos", fuente, Brushes.Red, x, y);
        }
    }
}
