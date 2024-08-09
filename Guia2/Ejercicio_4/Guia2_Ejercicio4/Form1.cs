namespace Guia2_Ejercicio4
{
    public partial class frmULAM : Form
    {

        public frmULAM()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int numeroInicial))
            {
                MessageBox.Show("Por favor ingrese un número válido.");
                return;
            }

            // Limpiar la lista antes de mostrar nuevos resultados
            lstLista.Items.Clear();

            // Mostrar el primer número de la secuencia Ulam en la lista
            lstLista.Items.Add(numeroInicial);

            // Calcular la secuencia Ulam
            int numeroActual = numeroInicial;

            while (numeroActual != 1)
            {
                // Calcular el siguiente número de la secuencia Ulam
                if (numeroActual % 2 == 0)
                {
                    numeroActual /= 2;
                }
                else
                {
                    numeroActual = 3 * numeroActual + 1;
                }

                // Mostrar el número actual en la lista
                lstLista.Items.Add(numeroActual);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lstLista.Text = "";
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmULAM_Load(object sender, EventArgs e)
        {

        }
    }
}

