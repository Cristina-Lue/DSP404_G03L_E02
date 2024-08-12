namespace Guia2_Ejercicio3
{
    public partial class frmReves : Form
    {
        private bool IsNumeric(string input)
        {
            int number;
            bool isNumeric = int.TryParse(input, out number);
            return isNumeric;
        }
        public frmReves()
        {
            InitializeComponent();
        }

        private void frmReves_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificamos si el texto ingresado en txtNumero es num�rico y mayor que 0
            if (IsNumeric(txtNumero.Text) && (long.Parse(txtNumero.Text) > 0))
            {
                long numero = long.Parse(txtNumero.Text); // Convertimos el texto a un n�mero largo

                // Inicializaci�n de variables para invertir el n�mero
                long r, div, reves = 0, multi = 1;

                // Mostramos el n�mero original en txtNumero
                txtNumero.Text = numero.ToString();

                // Determinamos el divisor inicial seg�n la cantidad de d�gitos del n�mero
                if (numero >= 100000 && numero <= 999999)
                {
                    div = 100000;
                }
                else if (numero >= 10000 && numero <= 99999)
                {
                    div = 10000;
                }
                else if (numero >= 1000 && numero <= 9999)
                {
                    div = 1000;
                }
                else if (numero >= 100 && numero <= 999)
                {
                    div = 100;
                }
                else if (numero >= 10 && numero <= 99)
                {
                    div = 10;
                }
                else
                {
                    // Si el n�mero est� fuera del rango especificado, mostramos un mensaje de error
                    MessageBox.Show("N�mero fuera de rango (1-999999)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Clear();
                    txtNumero.BackColor = Color.Red;
                    return;
                }

                // Proceso para invertir el n�mero
                do
                {
                    // Capturamos el d�gito m�s significativo
                    r = numero / div;
                    // Restamos ese d�gito al n�mero original
                    numero = numero - r * div;
                    // Calculamos el siguiente divisor
                    div = div / 10;
                    // Multiplicamos el d�gito seg�n su posici�n y lo sumamos al n�mero invertido
                    reves = reves + (r * multi);
                    // Calculamos el siguiente multiplicador
                    multi = multi * 10;
                    // El proceso se repite hasta que el n�mero original es igual a 0
                } while (numero != 0);

                // Mostramos el n�mero invertido en txtReves
                txtReves.Text = reves.ToString();
            }
            else
            {
                // Si el texto ingresado no es un n�mero v�lido, mostramos un mensaje de error
                MessageBox.Show("El dato que ingres� no es un n�mero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                txtNumero.BackColor = Color.Red;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtReves.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
