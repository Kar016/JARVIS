namespace Programa__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";   // Esta funcion sirve para borrar el label1 a la hora de ejercutarlo.
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "HOLA A TODOS!";
        }

        private void btnDespedida_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "ADIOS!";
            this.Text = "BYE";  // Sirve para cambiar el nombre del titulo del programa
        }
    }
}