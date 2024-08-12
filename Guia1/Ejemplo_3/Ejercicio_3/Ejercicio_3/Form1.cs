using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        private string noms, ape1, ape2;
        private double CUM;
        private int UV;

        // Validacion de los datos recibidos son números
        public static bool IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        // Verifica el CUM
        private void EvaluarCUM()
        {
            string nombrecompleto = noms + " " + ape1 + " " + ape2;
            nombrecompleto = nombrecompleto.ToUpper();

            if (CUM < 0 || CUM > 10)
            {
                MessageBox.Show("Valor de CUM fuera del rango establecido (0.0 - 10.0)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
            }
            else
            {
                //Usa estructura switch 
                switch (Convert.ToInt32(CUM))
                {
                    case 8:
                    case 9:
                    case 10:
                        UV = 32;
                        break;
                    case 7:
                        UV = 24;
                        break;
                    case 6:
                        UV = 20;
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        UV = 16;
                        break;
                    default:
                        UV = 0;
                        break;
                }

                txtResult.Text = nombrecompleto + " puede cursar " + UV + " UV";
            }
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            if (IsNumeric(txtResult.Text))
            {
                CUM = double.Parse(txtResult.Text);
                EvaluarCUM();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido para poder calcular el CUM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Focus();
            }
        }
        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lblCUM_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
