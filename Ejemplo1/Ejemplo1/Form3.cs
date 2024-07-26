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
    public partial class Form3 : Form
    {
        private string noms, ape1, ape2;
        private double CUM;
        private int UV;
        //valida que el dato recibido es un numero
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        //evalua el cum
        private void EvaluarCUM()
        {
            //una vez recibidos los nombres del estudiante, asi como su CUM se detemina las UV' solicitadas
            string nombrecompleto;
            nombrecompleto = noms + " " + ape1 + " " + ape2;
            nombrecompleto = nombrecompleto.ToUpper();
            if (CUM < 0 | CUM > 10)
            {
                MessageBox.Show("Valor de CUM fuera de rango (0.0 - 10.0)", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
            }
            else
            {
                //Usa estructura switch
                switch (Convert.ToInt16(CUM))
                {
                    case 8 - 10:
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
                txtResul.Text = nombrecompleto + "Puede cursar " + UV + "UV";
            }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnalisi_Click(object sender, EventArgs e)
        {
            //validar
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtApe1.Text) ||
                string.IsNullOrWhiteSpace(txtApe2.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de nombre.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtCUM.Text, out CUM))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el CUM.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
                return;
            }

            noms = txtNom.Text;
            ape1 = txtApe1.Text;
            ape2 = txtApe2.Text;

            EvaluarCUM();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
