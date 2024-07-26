using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeros
{
    public partial class Form1 : Form
    {
        private double TasaI; // Variable privada declarada en el contexto de la clase
        private List<double> numeros; // Lista para almacenar los números ingresados

        public Form1()
        {
            InitializeComponent();
            numeros = new List<double>();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void lblNum1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            AgregarNumero(txtNum1.Text);
        }

        private void Num2_Click(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            AgregarNumero(txtNum2.Text);
        }

        private void lblNum3_Click(object sender, EventArgs e)
        {

        }

        private void txtNum3_TextChanged(object sender, EventArgs e)
        {
            AgregarNumero(txtNum3.Text);
        }

        private void lblNum4_Click(object sender, EventArgs e)
        {

        }

        private void txtNum4_TextChanged(object sender, EventArgs e)
        {
            AgregarNumero(txtNum4.Text);
        }

        private void lblNum5_Click(object sender, EventArgs e)
        {

        }

        private void txtNum5_TextChanged(object sender, EventArgs e)
        {
            AgregarNumero(txtNum5.Text);
        }

        private void lblNum7_Click(object sender, EventArgs e)
        {

        }

        private void txtNum7_TextChanged(object sender, EventArgs e)
        {
            AgregarNumero(txtNum7.Text);
        }

        private void lblNum8_Click(object sender, EventArgs e)
        {

        }

        private void txtNum8_TextChanged(object sender, EventArgs e)
        {
            AgregarNumero(txtNum8.Text);
        }

        private void lblNum9_Click(object sender, EventArgs e)
        {

        }

        private void txtNum9_TextChanged(object sender, EventArgs e)
        {
            AgregarNumero(txtNum9.Text);
        }

        private void txtNum6_TextChanged(object sender, EventArgs e)
        {
            AgregarNumero(txtNum6.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            var numerosNegativos = numeros.Where(n => n < 0).ToList();
            if (numerosNegativos.Any())
            {
                double numeroMayor = numerosNegativos.Max();
                double numeroMenor = numerosNegativos.Min();
                MessageBox.Show($"Número Mayor Negativo: {numeroMayor}, Número Menor Negativo: {numeroMenor}");
            }
            else
            {
                MessageBox.Show("No hay números negativos en la lista.");
            }

            var numerosPositivos = numeros.Where(n => n > 0).ToList();
            if (numerosPositivos.Any())
            {
                double promedioPositivos = numerosPositivos.Average();
                MessageBox.Show($"Promedio de Números Positivos: {promedioPositivos}");
            }
            else
            {
                MessageBox.Show("No hay números positivos en la lista.");
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (numeros.Any())
            {
                double media = numeros.Average();
                MessageBox.Show($"Media de toda la serie: {media}");
            }
            else
            {
                MessageBox.Show("No hay números en la lista.");
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstResul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPro_Click(object sender, EventArgs e)
        {

        }
        private void AgregarNumero(string numeroTexto)
        {
            if (double.TryParse(numeroTexto, out double numero))
            {
                numeros.Add(numero);
            }
        }
    }
}
