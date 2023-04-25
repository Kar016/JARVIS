namespace Problema__8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Form2 miForma2 = new Form2(textMensaje.Text);

            miForma2.Comentario = "Hasta luego";

            miForma2.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}