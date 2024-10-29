using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class Form1 : Form
    {
        // Declaración de matriz
        string[,] matriz = new string[3, 3];
        // Variables para movernos dentro de las posiciones de la matriz
        public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i;

        public Form1()
        {
            InitializeComponent();
            txtEdad.KeyPress += new KeyPressEventHandler(txtEdad_KeyPress);
            txtInfo.KeyPress += new KeyPressEventHandler(txtInfo_KeyPress);
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            // Limpiando grilla
            dgdatos.Columns.Clear();
            // Creando columnas
            dgdatos.ColumnCount = 3;
            dgdatos.Columns[0].Name = "Nombre";
            dgdatos.Columns[1].Name = "Apellido";
            dgdatos.Columns[2].Name = "Edad";

            // Agregando datos a grilla
            for (int i = 0; i < 3; i++)
            {
                dgdatos.Rows.Add(matriz[i, 0], matriz[i, 1], matriz[i, 2]);
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar la matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = string.Empty;
                }
            }

            // Inicializar las variables de fila y columna a cero
            fila1 = fila2 = fila3 = 0;

            // Limpiar la grilla
            dgdatos.Columns.Clear();
            dgdatos.Rows.Clear();

            MessageBox.Show("Datos limpiados exitosamente", "", MessageBoxButtons.OK);
        }

        private void btPromedio_Click(object sender, EventArgs e)
        {
            int suma = 0, contador = 0;

            for (int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(matriz[i, 2]) && IsNumeric(matriz[i, 2]))
                {
                    suma += int.Parse(matriz[i, 2]);
                    contador++;
                }
            }

            if (contador > 0)
            {
                double promedio = (double)suma / contador;
                MessageBox.Show($"El promedio de edades es: {promedio}", "Promedio", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No hay edades para promediar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            // Posiciones de la columna de la matriz
            colum1 = 0;
            colum2 = 1;
            colum3 = 2;
            // Verificamos el combobox1
            if (cbtipoinfo.SelectedIndex == 0)
            {
                if (txtInfo.Text == "")
                    txtInfo.BackColor = Color.Bisque;
                else
                {
                    if (fila1 < 3)
                    {
                        // Agregamos el dato en la posicion [fila1, colum1] de la matriz
                        matriz[fila1, colum1] = txtInfo.Text;
                        // Pasamos a la siguiente fila de la matriz
                        fila1 += 1;
                        MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
                        txtInfo.Clear(); // Limpiamos el texboxt1
                    }
                    else
                        MessageBox.Show("No se pueden agregar mas nombres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (cbtipoinfo.SelectedIndex == 1)
                {
                    if (txtInfo.Text == "")
                        txtInfo.BackColor = Color.Bisque;
                    else if (fila2 < 3)
                    {
                        // Agregamos el dato en la posicion (fila2, colum2) de la matriz
                        matriz[fila2, colum2] = txtInfo.Text;
                        // Pasamos a la siguiente fila de la matriz
                        fila2 += 1;
                        MessageBox.Show("Apellido ingresado exitosamente");
                        txtInfo.Clear();
                    }
                    else
                        MessageBox.Show("No se pueden agregar mas apellidos");
                }
                else
                    MessageBox.Show("Seleccione una opción");
            }

            if (IsNumeric(txtEdad.Text) == true)
            {
                if (fila3 < 3)
                {
                    // Agregamos el dato en la posicion [fila3, colum3] de la matriz
                    matriz[fila3, colum3] = txtEdad.Text;
                    // Pasamos a la siguiente fila de la matriz
                    fila3 += 1;
                    MessageBox.Show("Edad ingresada exitosamente");
                    txtEdad.Clear(); // Limpiamos el textbox1
                    countergen += 1;
                }
                else
                    MessageBox.Show("No se pueden agregar mas edades");
            }
            else
            {
                txtEdad.BackColor = Color.Beige;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes poner la lógica que deseas ejecutar cuando el texto de txtInfo cambie
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes poner la lógica que deseas ejecutar cuando el texto de txtEdad cambie
        }

        public static bool IsNumeric(string valor)
        {
            // Determina si el parametro valor puede convertirse a numero entero
            int result;
            return int.TryParse(valor, out result);
        }

        private void gbMantenimiento_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}