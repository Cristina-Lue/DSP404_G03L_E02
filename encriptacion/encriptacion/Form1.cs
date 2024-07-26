using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encriptacion
{
    public partial class frmCesar : Form
    {
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public frmCesar()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdEncriptar.Checked == true)
            {
                btnEncriptar.Text = "Encriptar";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            // Intentamos convertir el valor de txtLlave a un número entero
            if (int.TryParse(txtLlave.Text, out int llave) && llave > 0)
            {
                txtResultado.Clear();
                int ascii;

                // Para cada carácter en el objeto txtTexto
                foreach (char c in txtTexto.Text)
                {
                    // Verificamos si el usuario desea encriptar o desencriptar el texto
                    if (rbdEncriptar.Checked)
                    {
                        // Convertimos el carácter extraído a su equivalente número ASCII y le sumamos la llave
                        ascii = (int)c + llave;
                    }
                    else
                    {
                        // Convertimos el carácter extraído a su equivalente número ASCII y le restamos la llave
                        ascii = (int)c - llave;
                    }

                    // Agregamos el carácter encriptado o desencriptado al resultado
                    txtResultado.Text += (char)ascii;
                }

                lblResultado.Text = "Texto encriptado:";
            }
            else
            {
                MessageBox.Show("El dato introducido en la llave es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLlave.Focus();
                txtLlave.Clear();
                txtLlave.BackColor = Color.Red;
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLlave_TextChanged(object sender, EventArgs e)
        {
            txtLlave.BackColor = Color.White;
        }

        private void rbdDesencriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdDesencriptar.Checked == true)
            {
                btnEncriptar.Text = "Desencriptar";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtTexto.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
