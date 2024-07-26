using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosDecimales
{
    public partial class Form1 : Form
    {
        private List<double> positiveNumbers = new List<double>();
        private List<double> negativeNumbers = new List<double>();
        private int numberCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            if (numberCount >= 10)
            {
                MessageBox.Show("Ya se han ingresado 10 números.");
                return;
            }

            if (double.TryParse(txtNumber.Text, out double number))
            {
                if (number >= 0)
                {
                    positiveNumbers.Add(number);
                    lstPositiveNumbers.Items.Add(number);
                }
                else
                {
                    negativeNumbers.Add(number);
                    lstNegativeNumbers.Items.Add(number);
                }

                numberCount++;
                txtNumber.Clear();

                if (numberCount == 10)
                {
                    ShowResults();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void ShowResults()
        {
            if (negativeNumbers.Any())
            {
                double minNegative = negativeNumbers.Min();
                lblMinNegative.Text = $"Menor número negativo: {minNegative}";
            }
            else
            {
                lblMinNegative.Text = "No se ingresaron números negativos.";
            }

            if (positiveNumbers.Any())
            {
                double averagePositive = positiveNumbers.Average();
                lblAveragePositive.Text = $"Promedio de números positivos: {averagePositive:F2}";
            }
            else
            {
                lblAveragePositive.Text = "No se ingresaron números positivos.";
            }
        }
    }
}