namespace Problema__6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("La vida es bella");  // Esta funcion es para mostrar un mensaje

            // MessageBox.Show("Esta lloviendo hoy", "Mi MessageBox"); // Muestra un mensaje y despues de la coma un titulo

            DialogResult r = MessageBox.Show("Saludos Jean Luis", "Mi MessageBox", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand); // Muestra un mensaje y despues de la coma un titulo, despues de la otra como muestra botones

            // Sirve para declarar r

            if (r == DialogResult.OK) // Boton
            {
                lblMensaje.Text = "Pasa buena tarde";  // Al presionar el boton muestra este mensaje
            }


            if (r == DialogResult.Cancel)
            {
                lblMensaje.Text = "Pasa buena vida";
            }
        }
    }
}