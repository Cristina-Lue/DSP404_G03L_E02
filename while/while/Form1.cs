using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificar que el usuario haya ingresado un número válido
            if (int.TryParse(txtnumero.Text, out int numero))
            {
                // Crear una lista para almacenar la sucesión
                List<int> sucesion = new List<int>();

                // Iniciar la sucesión con el número ingresado
                sucesion.Add(numero);

                // Calcular la sucesión utilizando un bucle while
                while (numero != 1)
                {
                    if (numero % 2 == 0)
                    {
                        numero = numero / 2;
                    }
                    else
                    {
                        numero = 3 * numero + 1;
                    }
                    sucesion.Add(numero);
                }

                // Mostrar la sucesión en la lista (lstLista)
                lstLista.Items.Clear();
                foreach (int n in sucesion)
                {
                    lstLista.Items.Add(n);
                }
            }
            else
            {
                // Mostrar un mensaje de error si el usuario no ingresó un número válido
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstLista.ClearSelected();
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
