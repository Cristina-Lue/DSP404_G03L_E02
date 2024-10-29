using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizCuadrada
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

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            int dimension;
            if (int.TryParse(textBoxDimension.Text, out dimension) && dimension > 0)
            {
                int[,] matriz = new int[dimension, dimension];
                Random rand = new Random();

                // Llenar la matriz con valores aleatorios
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        matriz[i, j] = rand.Next(1, 101); // Números aleatorios entre 1 y 100
                    }
                }

                // Mostrar la matriz original
                MostrarMatriz(matriz, dataGridViewOriginal);

                // Calcular y mostrar la matriz traspuesta
                int[,] matrizTraspuesta = new int[dimension, dimension];
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        matrizTraspuesta[j, i] = matriz[i, j];
                    }
                }
                MostrarMatriz(matrizTraspuesta, dataGridViewTranspuesta);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void MostrarMatriz(int[,] matriz, DataGridView dataGridView)
            {
                dataGridView.ColumnCount = matriz.GetLength(1);
                dataGridView.RowCount = matriz.GetLength(0);

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        dataGridView.Rows[i].Cells[j].Value = matriz[i, j];
                    }
                }
            }
        }
    }
