using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2_ejercicio2
{
    public partial class frmCesar : Form
    {
        public static Boolean IsNumeric(string valor) { 
            int result; return int.TryParse(valor, out result); 
        }
        public frmCesar()
        {
            InitializeComponent();
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void lbltexto_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtLlave.BackColor = Color.White;
        }

        private void frmCesar_Load(object sender, EventArgs e)
        {

        }

        private void btnEbcriptar_Click(object sender, EventArgs e)
        {
            // Verificamos que la llave contenga un número y que sea positivo
            if (IsNumeric(txtLlave.Text) && (Convert.ToInt16(txtLlave.Text) > 0))
            {
                txtResultado.Clear(); // Limpiamos el cuadro de texto de resultados
                int ascii;

                // Recorremos cada caracter en el texto ingresado
                foreach (int c in txtTexto.Text)
                {
                    // Verificamos si el usuario desea encriptar o desencriptar el texto
                    if (rdbEncriptar.Checked)
                    {
                        // Convertimos el caracter extraído a su equivalente número ASCII y sumamos la llave
                        ascii = (int)c + Convert.ToInt16(txtLlave.Text);
                    }
                    else
                    {
                        // Convertimos el caracter extraído a su equivalente número ASCII y restamos la llave
                        ascii = (int)c - Convert.ToInt16(txtLlave.Text);
                    }

                    // Convertimos el resultado ASCII nuevamente a caracter y lo añadimos al resultado
                    txtResultado.Text += (char)ascii;
                }

                lblresultado.Text = "Texto encriptado:"; // Actualizamos la etiqueta de resultado
            }
            else
            {
                // Mostramos un mensaje de error si la llave no es válida (no es numérica o es negativa)
                MessageBox.Show("El dato introducido en la llave es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Ponemos el foco en el cuadro de texto de la llave y limpiamos su contenido
                txtLlave.Focus();
                txtLlave.Clear();
                txtLlave.BackColor = Color.Red; // Cambiamos el color de fondo del cuadro de texto de la llave a rojo
            }

        }

        private void rdbEncriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEncriptar.Checked == true) 
            { btnEncriptar.Text = "Encriptar"; 
            }
        }

        private void rdbDesencriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEncriptar.Checked == true)
            {
                btnEncriptar.Text = "Desencriptar";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            txtResultado.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
