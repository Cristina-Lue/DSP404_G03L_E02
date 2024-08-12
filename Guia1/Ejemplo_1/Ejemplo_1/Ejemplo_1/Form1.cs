using System;
using System.Windows.Forms;
namespace Ejemplo_1
{
    public partial class Form1 : Form
    {

        private string mensa;
        //private int conta;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mensa = "Todavia no ha presionado botón Contar";
            label1.Text = mensa;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int conta = 0;
            //Acumulador, Total veces que presiona botón 
            conta = conta + 1;
            //conta+=1; //En forma de operador abreviado 
            mensa = "Ha presionado el botón Contar, un total de " + Convert.ToString(conta) + " veces";//convert me pase mi variable conta de int a string 
            label1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            //conta = 0;
            //mensa = "Presionaste el boton Contar, un total de" + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();//finaliza aplicación 
        }
    }
}
