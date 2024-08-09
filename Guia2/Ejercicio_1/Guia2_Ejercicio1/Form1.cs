namespace Guia2_Ejercicio1
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        // La Función IsNumeric esta fuera de la clase Form1 pero sigue dentro del namespace. namespace= (espacios de nombres) herramienta de organización en el framework de .NET que nos permite agrupar bajo un mismo nombre clases y otros elementos de programación relacionados.
        public static bool IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Aquí se realizan las inicializaciones adicionales, no siempre aplica
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaración de variables
            long factorial = 1;
            int i;

            //con la funcion IsNumeric verificamos que el TxtNumero contenga un dato numerico 
            if (IsNumeric(txtNumero.Text))
            {
                //ser realizar un for desde el número ingresado hasta llegar a uno
                for (i = Convert.ToInt32(txtNumero.Text); i >= 1; i--)
                {
                    // Se multiplica el factorial por todos los números menores 
                    // factorial = factorial*i;
                    factorial *= i;
                }

                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                //Para recordar:
                // Si no ingresamos un número válido, se mostrara un mensaje de error
                txtNumero.BackColor = Color.Red; // Tambien, cambiamos el color de fondo de txtNumero a rojo
                MessageBox.Show("Debe ingresar un número!", "Informacion", MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            // Cambiamos el color de fondo a blanco cuando causamos que se cambie el texto
            txtNumero.BackColor = Color.White;
        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();        
        }
    }
}
