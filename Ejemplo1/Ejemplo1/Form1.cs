using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {

        private string mensa= "Aun no ha presionado botón Contar";
        private int conta;
        public Form1()
        {
            InitializeComponent();

            // Evento se ejecuta al iniciar ejecución de Form1
            label1.Text = mensa;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            //int conta = 0;
            //ACumulador, Total veces que presiona botón
                 conta++;
            //conta+=1; //En forma de operador abreviado
            mensa = "Presiono boton contar, un total de " + conta.ToString() + " veces";
            label1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            //Restaura conteo clic realizado a button1
            conta = 0;
            mensa = "Presiono boton Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
