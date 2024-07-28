using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promedio_desviacion
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Leer numeros
                double num1 = double.Parse(txtNumero1.Text);
                double num2 = double.Parse(txtNumero2.Text);
                double num3 = double.Parse(txtNumero3.Text);
                double num4 = double.Parse(txtNumero4.Text);

                double[] numeros = { num1, num2, num3, num4 };

                //Calculo del promedio

                double promedio = numeros.Average();

                //Calculo de desviacion tipica

                double varianza = numeros.Average(v => Math.Pow(v - promedio, 2));
                double desviacionTipica = Math.Pow(Math.Sqrt(varianza),2);

                //Mostrar

                lblPromedio.Text = "Promedio: " + promedio;

                lblDesviacionTipica.Text = "Desviación Típica: " + desviacionTipica;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese números válidos.", "Error de formato",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
