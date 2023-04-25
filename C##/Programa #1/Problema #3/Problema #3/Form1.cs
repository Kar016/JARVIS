namespace Problema__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            textA.Text = "0";
            textB.Text = "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double a, b, r;

            a = Convert.ToDouble(textA.Text);  // Convertir el tipo de texto de caracteres a numeros.
            b = Convert.ToDouble(textB.Text);

            r = a + b;

            lblResultado.Text = r.ToString();  // Mostrar el resultado
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double a, b, r;

            a = Convert.ToDouble(textA.Text);  // Convertir el tipo de texto de caracteres a numeros.
            b = Convert.ToDouble(textB.Text);

            r = a - b;

            lblResultado.Text = r.ToString();  // Mostrar el resultado
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double a, b, r;

            a = Convert.ToDouble(textA.Text);  // Convertir el tipo de texto de caracteres a numeros.
            b = Convert.ToDouble(textB.Text);

            r = a * b;

            lblResultado.Text = r.ToString();  // Mostrar el resultado
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double a, b, r;

            a = Convert.ToDouble(textA.Text);  // Convertir el tipo de texto de caracteres a numeros.
            b = Convert.ToDouble(textB.Text);

            r = a / b;

            lblResultado.Text = r.ToString();  // Mostrar el resultado
        }
    }
}