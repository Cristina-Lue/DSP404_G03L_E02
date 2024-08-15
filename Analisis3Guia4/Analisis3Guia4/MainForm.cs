/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 15/08/2024
 * Time: 13:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Analisis3Guia4
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
		
		private void MostrarEstadisticas(List<double> notas)
    {
        double porcentajeDeficientes = notas.Count(n => n < 5.0) * 100.0 / notas.Count;
        int numeroAprobados = notas.Count(n => n >= 6.0);
        double notaMinima = notas.Min();
        double notaMaxima = notas.Max();
        double notaMedia = notas.Average();

        listBox1.Items.Clear();
        listBox1.Items.Add("Porcentaje de Deficientes"+porcentajeDeficientes);
        listBox1.Items.Add("Número de Aprobados:"+numeroAprobados);
        listBox1.Items.Add("Nota Mínima: "+notaMinima);
        listBox1.Items.Add("Nota Máxima: "+notaMaxima);
        listBox1.Items.Add("Nota Media: "+notaMedia);
    }
		void BtnMostrarEstadisticasClick(object sender, EventArgs e)
		{
	// Aquí puedes definir tu lista de notas
        List<double> notas = new List<double> { 4.5, 6.7, 8.2, 3.9, 5.0, 7.1, 9.3 };
         MostrarEstadisticas(notas);
    }
		}
}
		
		
		
		
		
	

