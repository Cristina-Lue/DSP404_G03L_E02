/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 20:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DReje2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		 private int[,] matrizOriginal;
        private int[,] matrizTraspuesta;
        
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
		
		void BtnGenerarMatrizClick(object sender, EventArgs e)
		{
			
			 int dimension = Convert.ToInt32(txtDimension.Text);
            matrizOriginal = new int[dimension, dimension];
            matrizTraspuesta = new int[dimension, dimension];

            Random random = new Random();

            // Llenar la matriz original con valores aleatorios
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matrizOriginal[i, j] = random.Next(1, 100); // Rango de valores aleatorios
                }
            }

            // Calcular la traspuesta
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matrizTraspuesta[j, i] = matrizOriginal[i, j];
                }
            }

            // Mostrar la matriz traspuesta en un DataGridView
            dataGridView1.RowCount = dimension;
            dataGridView1.ColumnCount = dimension;
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrizTraspuesta[i, j];
			
			
			
			
			
		}
	}
}
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}