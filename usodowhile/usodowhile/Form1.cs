using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usodowhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtReves.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Intentamos convertir el texto a un número entero
            if (int.TryParse(txtNumero.Text, out int numero) && numero > 0)
            {
                // Convertimos el número entero a long
                long numeroLong = (long)numero;

                // Para poner al revés un número hay que ir dividiendo el número
                // para sacar al dígito más significativo y colocarlo en el nuevo
                // número, o sea, en el dígito menos significativo y así sucesivamente
                long r, div, reves = 0, multi = 1;

                // Determinamos el divisor inicial basado en el rango del número
                if (numeroLong >= 100000 && numeroLong <= 999999)
                {
                    div = 100000;
                }
                else if (numeroLong >= 10000 && numeroLong <= 99999)
                {
                    div = 10000;
                }
                else if (numeroLong >= 1000 && numeroLong <= 9999)
                {
                    div = 1000;
                }
                else if (numeroLong >= 100 && numeroLong <= 999)
                {
                    div = 100;
                }
                else if (numeroLong >= 10 && numeroLong <= 99)
                {
                    div = 10;
                }
                else
                {
                    MessageBox.Show("Número fuera de rango (1-999999)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Clear();
                    txtNumero.BackColor = Color.Red;
                    return;
                }

                // Invertimos el número
                do
                {
                    // Capturamos el dígito más significativo
                    r = numeroLong / div;
                    // Restamos ese dígito al número
                    numeroLong = numeroLong - r * div;
                    // Calculamos el siguiente divisor
                    div = div / 10;
                    // Multiplicamos el dígito según su peso y lo sumamos al nuevo número
                    reves = reves + (r * multi);
                    // Calculamos el siguiente multiplicador
                    multi = multi * 10;
                } while (numeroLong != 0);

                txtReves.Text = reves.ToString();
            }
            else
            {
                MessageBox.Show("El dato que ingresó no es un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                txtNumero.BackColor = Color.Red;
            }
        }


    }
            }
