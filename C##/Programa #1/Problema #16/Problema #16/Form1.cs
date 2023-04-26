using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema__16
{
    public partial class Form1 : Form
    {
        private int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Agregamos nuevo renglon

            int n = dtgvProductos.Rows.Add();

            // Colocamos la informacion

            dtgvProductos.Rows[n].Cells[0].Value = textCodigo.Text;
            dtgvProductos.Rows[n].Cells[1].Value = textNombre.Text;
            dtgvProductos.Rows[n].Cells[2].Value = textPrecio.Text;

            // Limpiamos los textBox

            textCodigo.Text = "";
            textNombre.Text = "";
            textPrecio.Text = "";
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n!= -1)
            {
                lblInformacion.Text = (string)dtgvProductos.Rows[n].Cells[1].Value;
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n!= -1)
            {
                dtgvProductos.Rows.RemoveAt(n);
            }
        }
    }
}
