/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 15/08/2024
 * Time: 13:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Analisis2GUIA4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	 int[,] matriz = GenerarMatriz(1, 100); // Ejemplo de límites
            MostrarMatriz(dataGridView1, matriz);
		}
		
		
		private int[,] GenerarMatriz(int min, int max)
        {
            Random random = new Random();
            int[,] matriz = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(min, max);
                }
            }
            return matriz;
        }

        private void MostrarMatriz(DataGridView dataGridView, int[,] matriz)
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
