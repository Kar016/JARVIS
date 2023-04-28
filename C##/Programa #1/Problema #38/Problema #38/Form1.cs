using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Problema__38.Properties;

namespace Problema__38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textMensaje.Text = (String)Settings.Default["Mensaje"];

            ckbImportado.Checked = (bool)Settings.Default["Importado"];
            ckbOrganico.Checked = (bool)Settings.Default["Organico"];

            this.Size = (Size)Settings.Default["Tamaño"];

            switch((int)Settings.Default["Frutas"])
            {
                case 0:
                    rbManzana.Checked = true;
                    rbPera.Checked = false;
                    rbCereza.Checked = false;
                    break;

                    case 1:
                    rbManzana.Checked = false;
                    rbPera.Checked = true;
                    rbCereza.Checked = false;
                    break;

                    case 2:
                    rbManzana.Checked = false;
                    rbPera.Checked = false;
                    rbCereza.Checked = true;
                    break;

            }
        }

        private void textMensaje_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["Mensaje"] = textMensaje.Text;
            Settings.Default.Save();
        }

        private void ckbImportado_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["Importado"] = ckbImportado.Checked;
            Settings.Default.Save();
        }

        private void ckbOrganico_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["Organico"] = ckbOrganico.Checked;
            Settings.Default.Save();
        }

        private void rbManzana_CheckedChanged(object sender, EventArgs e)
        {
           if (rbManzana.Checked == true)
            {
                Settings.Default["Frutas"] = 0;
                Settings.Default.Save();
            }
        }

        private void rbPera_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPera.Checked == true)
            {
                Settings.Default["Frutas"] = 1;
                Settings.Default.Save();
            }
        }

        private void rbCereza_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCereza.Checked == true)
            {
                Settings.Default["Frutas"] = 2;
                Settings.Default.Save();
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Settings.Default["Tamaño"] = this.Size;
            Settings.Default.Save();
        }
    }
}
