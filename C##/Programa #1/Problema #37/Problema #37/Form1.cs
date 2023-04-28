using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirNotepad_Click(object sender, EventArgs e)
        {
            // Nos permitimos recibir eventos del notepad
            pNotePad.EnableRaisingEvents = true;

            // Arrcancamos el proceso
            pNotePad.Start();

            lblEstado.Text = "NotePad arrancando";
        }

        private void btnCerrarNotePad_Click(object sender, EventArgs e)
        {
            pNotePad.Kill();  // Kill se encargada de cerrar el bloc de nota.
        }

        private void pNotePad_Exited(object sender, EventArgs e)
        {
            // Esta funcion sucede cuando cierra el proceso
            lblEstado.Text = "NotePad cerrado";

            notifyIcon1.ShowBalloonTip(100, "Alerta", "Notepad Cerrado", ToolTipIcon.Info);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show(); // Mostrar la forma
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconder la forma
        }
    }
}
