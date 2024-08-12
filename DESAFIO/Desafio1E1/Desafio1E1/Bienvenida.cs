namespace Desafio1E1
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Inicio_sesion inicio = new Inicio_sesion();
            inicio.Show();
        }
    }
}
