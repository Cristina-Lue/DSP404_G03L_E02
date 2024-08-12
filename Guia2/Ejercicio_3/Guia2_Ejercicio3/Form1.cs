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
            // Verificamos si el texto ingresado en txtNumero es numérico y mayor que 0
            if (IsNumeric(txtNumero.Text) && (long.Parse(txtNumero.Text) > 0))
            {
                long numero = long.Parse(txtNumero.Text); // Convertimos el texto a un número largo

                // Inicialización de variables para invertir el número
                long r, div, reves = 0, multi = 1;

                // Mostramos el número original en txtNumero
                txtNumero.Text = numero.ToString();

                // Determinamos el divisor inicial según la cantidad de dígitos del número
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
                    // Si el número está fuera del rango especificado, mostramos un mensaje de error
                    MessageBox.Show("Número fuera de rango (1-999999)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Clear();
                    txtNumero.BackColor = Color.Red;
                    return;
                }

                // Proceso para invertir el número
                do
                {
                    // Capturamos el dígito más significativo
                    r = numero / div;
                    // Restamos ese dígito al número original
                    numero = numero - r * div;
                    // Calculamos el siguiente divisor
                    div = div / 10;
                    // Multiplicamos el dígito según su posición y lo sumamos al número invertido
                    reves = reves + (r * multi);
                    // Calculamos el siguiente multiplicador
                    multi = multi * 10;
                    // El proceso se repite hasta que el número original es igual a 0
                } while (numero != 0);

                // Mostramos el número invertido en txtReves
                txtReves.Text = reves.ToString();
            }
            else
            {
                // Si el texto ingresado no es un número válido, mostramos un mensaje de error
                MessageBox.Show("El dato que ingresó no es un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
