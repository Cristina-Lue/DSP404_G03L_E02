using System;
using System.Drawing;
using System.Windows.Forms;

namespace Factorial
{
    public partial class frmFactorial : Form
    {
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaración de variables
            long factorial = 1;
            int number;

            // Usamos int.TryParse para verificar si el texto es un número
            if (int.TryParse(txtNuumero.Text, out number))
            {
                // Se realiza un for desde el número ingresado hasta llegar a uno
                for (int i = number; i >= 1; i--)
                {
                    // Se multiplica el factorial por todos los números menores
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                txtNuumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "Información", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNuumero.Clear();
                txtFactorial.Clear();
                txtNuumero.Focus();
            }
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void txtNuumero_TextChanged(object sender, EventArgs e)
        {
            txtNuumero.BackColor = Color.White;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}