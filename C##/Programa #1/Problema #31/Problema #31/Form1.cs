using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
            {
                new DateTime(2023,5,15),
                new DateTime(2023,7,10),
                DateTime.Today.AddDays(5)
            };
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            DateTime inicio = monthCalendar1.SelectionStart; // Fecha de inicio
            DateTime final = monthCalendar1.SelectionEnd; // Fecha final

            lblInicio.Text = inicio.ToString();
            lblFinal.Text = final.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblSeleccion.Text = monthCalendar1.SelectionRange.ToString();
        }
    }
}
