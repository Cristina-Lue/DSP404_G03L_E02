using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace numeros
{
    public partial class Form1 : Form
    {
        private List<int> numeros = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(txtNum.Text, out numero) && numero >= -40 && numero <= 45)
            {
                numeros.Add(numero);
                ActualizarInformacion();
                txtNum.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entre -40 y 45.");
            }
        }

        private void ActualizarInformacion()
        {
            int mayorNegativo = int.MinValue;
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;
            int sumaNegativos = 0;

            foreach (int num in numeros)
            {
                if (num < 0)
                {
                    if (num > mayorNegativo)
                        mayorNegativo = num;
                    negativos++;
                    sumaNegativos += num;
                }
                else if (num > 0)
                {
                    positivos++;
                }
                else
                {
                    ceros++;
                }
            }

            double promedioNegativos = negativos > 0 ? (double)sumaNegativos / negativos : 0;
            int totalNumeros = numeros.Count;
            double porcentajePositivos = (double)positivos / totalNumeros * 100;
            double porcentajeNegativos = (double)negativos / totalNumeros * 100;
            double porcentajeCeros = (double)ceros / totalNumeros * 100;

            lblMayorNegativo.Text = "Mayor número negativo: " + (mayorNegativo == int.MinValue ? "N/A" : mayorNegativo.ToString());
            lblCantidadPositivos.Text = "Cantidad de números positivos: " + positivos;
            lblPromediosNegativos.Text = "Promedio de números negativos: " + promedioNegativos.ToString("F2");
            lblPorcentajePositivos.Text = "Porcentaje de positivos: " + porcentajePositivos.ToString("F2") + "%";
            lblPorcentajeNegativos.Text = "Porcentaje de negativos: " + porcentajeNegativos.ToString("F2") + "%";
            lblPorcentajeCeros.Text = "Porcentaje de ceros: " + porcentajeCeros.ToString("F2") + "%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Este evento puede ser dejado vacío si no se necesita.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Este evento puede ser dejado vacío si no se necesita.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Este evento puede ser dejado vacío si no se necesita.
        }

        private void lblPorcentajeCeros_Click(object sender, EventArgs e)
        {
            // Este evento puede ser dejado vacío si no se necesita.
        }

        private void lblPorcentajePositivos_Click(object sender, EventArgs e)
        {
            // Este evento puede ser dejado vacío si no se necesita.
        }

        private void lblPorcentajeNegativos_Click(object sender, EventArgs e)
        {
            // Este evento puede ser dejado vacío si no se necesita.
        }

        private void lblCantidadPositivos_Click(object sender, EventArgs e)
        {
            // Este evento puede ser dejado vacío si no se necesita.
        }

        private void lblMayorNegativo_Click(object sender, EventArgs e)
        {
            // Este evento puede ser dejado vacío si no se necesita.
        }
    }
}