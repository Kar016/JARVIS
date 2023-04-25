namespace Problema__5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, r;

            a = 0.0;
            b = 0.0;
            r = 0.0;

            a = Convert.ToDouble(textA.Text);
            b = Convert.ToDouble(textB.Text);

            if (rbSuma.Checked == true)
            {
                r = a + b;
            }

            if (rbResta.Checked == true)
            {
                r = a - b;
            }

            if (rbMultiplicar.Checked == true)
            {
                r = a * b;
            }

            if (rbDividir.Checked == true)
            {
                r = a / b;
            }

            lblResultado.Text = r.ToString();
        }
    }
}