using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas
{
    public partial class Form1 : Form
    {
        // Matriz de notas de los alumnos
        private int[,] notas = new int[6, 5]
        {
            { 85, 90, 78, -1, -1 },
            { 92, 88, -1, -1, -1 },
            { 76, 85, 90, 82, 88 },
            { 60, 70, 65, -1, -1 },
            { 80, 77, 85, 90, -1 },
            { 93, 89, 94, 88, 90 }
        };

        public Form1()
        {
            InitializeComponent();
            MostrarNotas();
        }

        private void MostrarNotas()
        {
            // Configuración del DataGridView
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Alumno";
            dataGridView1.Columns[1].Name = "Asignatura 1";
            dataGridView1.Columns[2].Name = "Asignatura 2";
            dataGridView1.Columns[3].Name = "Asignatura 3";
            dataGridView1.Columns[4].Name = "Asignatura 4";
            dataGridView1.Columns[5].Name = "Asignatura 5";
            dataGridView1.Columns.Add("Media", "Media");

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                int sum = 0;
                int count = 0;
                string[] row = new string[7];
                row[0] = "Alumno " + (i + 1);

                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (notas[i, j] != -1)
                    {
                        row[j + 1] = notas[i, j].ToString();
                        sum += notas[i, j];
                        count++;
                    }
                    else
                    {
                        row[j + 1] = "";
                    }
                }

                double media = count > 0 ? (double)sum / count : 0;
                row[6] = media.ToString("F2");

                dataGridView1.Rows.Add(row);
            }
        }
    }
}
