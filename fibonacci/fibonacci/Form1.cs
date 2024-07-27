using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //obtener valor
            if (int.TryParse(txtValorMaximo.Text, out int valorMaximo))
            {
                //Establecer el valor maximo y acticar boton

                btnGenerar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Introduxca un valor númerico valido.");

                btnGenerar.Enabled = false;
            }
            }
    

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstFibonacci.Items.Clear();
            if (int.TryParse(txtValorMaximo.Text, out int valorMaximo))
            {
                var serieFibonacci = GenerarFibonacci(valorMaximo);

                foreach (var numero in serieFibonacci)
                {
                    lstFibonacci.Items.Add(numero);
                }
            }
        }

        private List<int> GenerarFibonacci(int valorMaximo)
        {
            var serie = new List<int>();

            if (valorMaximo < 0)
                return serie;

            int a = 0, b = 1;
            serie.Add(a);

            while (b <= valorMaximo)
            {
                serie.Add(b);
                int temp = a + b;
                a = b;
                b = temp;
            }

            return serie;
        }
    }
}
