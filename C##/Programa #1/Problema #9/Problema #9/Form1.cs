using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            String cotizacion = "";

            cotizacion = "Cotizacion de auto para " + textNombre.Text+ "\r\n";

            // Obtener costo inicial
            costo = Convert.ToDouble(textConteo.Text);

            // Verificar seguros

            if (rbBasico.Checked == true)
            {
                costo += 500.0;
                cotizacion += "lleva seguro basico de $500\r\n";
            }

            if (rbTerceros.Checked == true)
            {
                costo += 700.0;
                cotizacion += "lleva seguro A terceros de $700\r\n";
            }

            if (rbTotal.Checked == true)
            {
                costo += 1000.0;
                cotizacion += "lleva seguro total de $1000\r\n";
            }

            // Verficar equipos

            if (chkAire.Checked == true)
            {
                costo += 500.0;
                cotizacion += "Con Aire acondicionado de $500\r\n";
            }

            if (chkAudio.Checked == true)
            {
                costo +=7500.0;
                cotizacion += "Con Sistema de audio de $500\r\n";
            }

            // Mostracion total

            cotizacion += "El total al pagar es de " + costo.ToString();

            textCotizacion.Text = cotizacion;

        }
    }
}
