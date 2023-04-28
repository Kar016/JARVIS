using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            bool error = false;

            foreach (char caracter in textDato.Text)  // Desgloza el dato ingresado
            {
                if (char.IsDigit(caracter))  // Identifica si en el dato hay un numero
                {
                    error = true;  // Marca un error cuando hay un numero
                    break;
                }
            }

            if (error) 
            {
                errorProvider1.SetError(textDato, "No se admiten numeros");
            }
            else
            { errorProvider1.Clear(); }
        }

        private void textDato_TextChanged(object sender, EventArgs e)
        {
            bool error = false;

            foreach (char caracter in textDato.Text)  // Desgloza el dato ingresado
            {
                if (char.IsDigit(caracter))  // Identifica si en el dato hay un numero
                {
                    error = true;  // Marca un error cuando hay un numero
                    break;
                }
            }

            if (error)
            {
                errorProvider1.SetError(textDato, "No se admiten numeros");
            }
            else
            { errorProvider1.Clear(); }
        }
    }
}
