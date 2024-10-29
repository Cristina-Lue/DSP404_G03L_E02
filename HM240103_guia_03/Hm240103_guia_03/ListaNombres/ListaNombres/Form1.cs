using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaNombres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                listBoxNombre.Items.Add(nombre);
                textBoxNombre.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (listBoxNombre.SelectedItem != null)
            {
                listBoxNombre.Items.Remove(listBoxNombre.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un nombre para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (listBoxNombre.SelectedItem != null)
            {
                string nombre = textBoxNombre.Text.Trim();
                if (!string.IsNullOrEmpty(nombre))
                {
                    int index = listBoxNombre.SelectedIndex;
                    listBoxNombre.Items[index] = nombre;
                    textBoxNombre.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un nuevo nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un nombre para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
