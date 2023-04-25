namespace Problema__7
{
    public partial class Screen1 : Form
    {
        public Screen1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Screen2 miforma = new Screen2();  // Solicito al documento de la forma 2

            //miforma.Show(); // Se muestra el documento
            miforma.ShowDialog(); // El showDialog al abrir la segunda ventana o documento. El primer documento no se selecciona sino cierra el segundo
        }
    }
}