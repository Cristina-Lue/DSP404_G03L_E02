/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 20:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DReje3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		 private double[,] notas = new double[6, 5];
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			 CargarDatosEjemplo();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	
	 private void CargarDatosEjemplo()
        {
            // Ejemplo: asignar algunas notas (puedes hacerlo dinámicamente)
            notas[0, 0] = 7.5;
            notas[0, 1] = 8.0;
            notas[0, 2] = 6.5;
            // ... (continúa con las demás notas)
        }
		
	private void CalcularMedias()
        {
            double[] mediasPorAlumno = new double[6];
            for (int i = 0; i < 6; i++)
            {
                double sumaNotas = 0;
                for (int j = 0; j < 5; j++)
                {
                    sumaNotas += notas[i, j];
                }
                mediasPorAlumno[i] = sumaNotas / 5;
            }

            // Mostrar las medias en el DataGridView
            dataGridViewNotas.DataSource = mediasPorAlumno.Select((media, index) => new { Alumno = "Alumno"+index+1 , Media = media }).ToList();
        }

        private void FormNotasColegio_Load(object sender, EventArgs e)
        {
            // Configuración inicial del DataGridView
            dataGridViewNotas.AutoGenerateColumns = true;
            dataGridViewNotas.Columns.Add("Alumno", "Alumno");
            dataGridViewNotas.Columns.Add("Media", "Media");
            CalcularMedias();
	
	
        }
	
			
			
			
		
		
		
		void BtnCalcularMediaClick(object sender, EventArgs e)
		{
			 notas[1, 0] = 9.0;
            notas[1, 1] = 7.8;
            // ... (continúa con las demás notas)

            CalcularMedias();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		}
	}
