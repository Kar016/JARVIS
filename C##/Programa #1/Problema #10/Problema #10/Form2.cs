using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__10
{
    public partial class Form2 : Form
    {
        private string mensaje;
        private string contenido;

        public Form2()
        {
            InitializeComponent();
        }

        public string Mensaje // Publicar el mensaje
        {
            get { return mensaje; }
        }

        public string Contendio // Publicar el mensaje
        {
            get { return contenido; }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            mensaje = textMensaje.Text;
            contenido = textContenido.Text;
            this.Close();  // Para cerrar la ventana
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mensaje = textMensaje.Text;
            contenido = textContenido.Text;
            this.Close();  // Para cerrar la ventana
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
