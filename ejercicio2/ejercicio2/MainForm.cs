/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 14:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ejercicio2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		
		//Declaración de matriz
 string[,] matriz = new string[3, 3];
 //variables para movernos dentro de las posiciones de la matriz
 public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i;
 public static bool IsNumeric(string valor)
 {
 //Determina si parametro valor puede convertirse a numero entero
 int result;
 return int.TryParse(valor, out result);
 }
 
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			fila1 = fila2 = fila3 = 0;
   			 colum1 = 0;
   			 colum2 = 1;
    	     colum3 = 2;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void TxtInfoKeyPress(object sender, KeyPressEventArgs e)
		{
			
		if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char) Keys.Back))
 {
 MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK,
 MessageBoxIcon.Exclamation);
 e.Handled = true;
 return;
 }	

 
			
			
			
			
							
		}
		
		void TxtEdadKeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar)){e.Handled = false;}
 else if (Char.IsControl(e.KeyChar)){e.Handled = false;}
 else if (Char.IsSeparator(e.KeyChar)){e.Handled = false;}
 else { e.Handled = true;
 MessageBox.Show("Solo se permiten Números", "Advertencia",
 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 }
		

 
			
			
		}
		
		void BtAgregarClick(object sender, EventArgs e)
		{

colum1 = 0;
 colum2 = 1;
 colum3 = 2;
 //verificamos el combobox1
 if (cbtipoinfo.SelectedIndex == 0)
 {
 if (txtInfo.Text == "")
 txtInfo.BackColor = Color.Bisque;
 else
 {
 if (fila1 < 3)
 {
 //agregamos el dato en la posicion [fila1,column1] de la matriz
 matriz[fila1, colum1] = txtInfo.Text;
 //pasamos a la siguiente fila de la matriz
 fila1 += 1;
 MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
 txtInfo.Clear();//limpiamos el texboxt1
 }
 else

 MessageBox.Show("No se pueden agregar mas nombres", "Alerta",
 MessageBoxButtons.OK, MessageBoxIcon.Information);
 }
 }
 else
 {
 if (cbtipoinfo.SelectedIndex == 1)
 if (txtInfo.Text == "")
 txtInfo.BackColor = Color.Bisque;
 else
 if (fila2 < 3)
 {
 //Agregamos el dato en la posicion (fila2,colum2) de la matriz
 matriz[fila2, colum2] = txtInfo.Text;
//pasamos a la siguiente fila de la matriz
fila2 += 1;
MessageBox.Show("Apellido ingresado exitosamente");
 txtInfo.Clear();
 }
else
 MessageBox.Show("No se pueden agregar mas apellidos");
 else
 MessageBox.Show("Seleccione una opción");

 }
 if (IsNumeric(txtEdad.Text) == true)
 if (fila3 < 3)
 {
 //Agregamos el dato en la posicion [fila3,colum3] de la matriz
 matriz[fila3, colum3] = txtEdad.Text;
 //pasamos a la siguiente fila de la matriz
 fila3 += 1;
 MessageBox.Show("Edad ingresada exitosamente");
 txtEdad.Clear(); //limpiamos el textbox1
 countergen += 1;
 }
 else
 MessageBox.Show("No se pueden agregar mas edades");
 else
 txtEdad.BackColor = Color.Beige;



			
		}
		
		void BtMostrarClick(object sender, EventArgs e)
		{

				dgdatos.Columns.Clear();
 //creando columnas
 dgdatos.ColumnCount = 3;
 dgdatos.Columns[0].Name = "Nombre";
 dgdatos.Columns[1].Name = "Apellido";
 dgdatos.Columns[2].Name = "Edad";
 dgdatos.Rows.Add();
 dgdatos.Rows.Add();
 //agregando datos a grilla
 //Mostrando nombres
 dgdatos.Rows[0].Cells[0].Value = matriz[0,0];
 dgdatos.Rows[0].Cells[1].Value = matriz[0, 1];
 dgdatos.Rows[0].Cells[2].Value = matriz[0, 2];

 //Mostrando apellidos
 dgdatos.Rows[1].Cells[0].Value = matriz[1, 0];
 dgdatos.Rows[1].Cells[1].Value = matriz[1, 1];
 dgdatos.Rows[1].Cells[2].Value = matriz[1, 2];
 //Mostrando edades
 dgdatos.Rows[2].Cells[0].Value = matriz[2, 0];
 dgdatos.Rows[2].Cells[1].Value = matriz[2, 1];
 dgdatos.Rows[2].Cells[2].Value = matriz[2, 2];


			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
					
			Application.Exit();
		}
		
		
		
		
		
		
		void BtLimpiarClick(object sender, EventArgs e)
		{
		
			
			for (int fila = 0; fila < matriz.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz.GetLength(1); columna++)
        {
            matriz[fila, columna] = null; // O cualquier otro valor de limpieza que desees
        }
    }
			
			
			
			
			dgdatos.Columns.Clear();
			dgdatos.Rows.Clear();
		}
		
		void BtPromedioClick(object sender, EventArgs e)
		{
				
			 int sumaEdades = 0;
    int cantidadEdades = 0;

    for (int fila = 0; fila < matriz.GetLength(0); fila++)
    {
        if (IsNumeric(matriz[fila, colum3]))
        {
            sumaEdades += int.Parse(matriz[fila, colum3]);
            cantidadEdades++;
        }
    }

    double promedioEdades = cantidadEdades > 0 ? (double)sumaEdades / cantidadEdades : 0;

   
  MessageBox.Show("El promedio de las edades es:"+promedioEdades, "Promedio de Edades", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			
			
			
			
		}
		}
	}

