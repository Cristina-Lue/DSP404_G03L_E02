/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 13:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ejercicio1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int[] matriz = new int[5];
		int i;
		
		public MainForm()
		{
			
			InitializeComponent();	
		}
		
		
		
		
			
			
			
			void BtAgregarClick(object sender, EventArgs e)
		{
			
			

if(i<=5){

 matriz[i]=Convert.ToInt16(txtNum.Text);
 lstdesorden.Items.Add(matriz[i]);
 i+=1;
 txtNum.Clear();
 txtNum.Select();
 } else{
 MessageBox.Show("No se puede ingresar mas datos", "Advertencia", MessageBoxButtons.OK,
MessageBoxIcon.Information);
 
			
		}
			
	}
		
		
		void BtOrdenarClick(object sender, EventArgs e)
		{

		int j, k, count;
 double valor;
 int Tam = 5;
 
 for (j = 0; j < Tam;j++ )
 {
 for (k = 0; k < (Tam - 1);k++ )
 {
 if(matriz[k]>matriz[k+1]){
valor = matriz[k];
matriz[k] = matriz[k + 1];
matriz[k + 1] = Convert.ToInt16(valor);}
 }
 }
 lstOrdenada.Items.Clear();
 for (count = 0; count < Tam;count++ )
 {
 lstOrdenada.Items.Add(matriz[count]);
 }
			
		}
		
		
		
		

			
		}
	}


	