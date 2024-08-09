/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 06/07/2024
 * Hora: 18:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fomr3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
		
		
	{
		public MainForm()
		{
			
			
			
			InitializeComponent();
		}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			
			
			
 
 
 
			
			
			
			//
		
		void BtnFinClick(object sender, EventArgs e)
		{
Application.Exit();			
		}
		
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
		}

 private string noms, ape1, ape2;
 private double CUM;
 private int UV;
 //valida que el dato recibido es un numero
 public static Boolean IsNumeric(string valor)
 {
 int result;
 return int.TryParse(valor, out result);
 }
 //evalua el cum
 



			
		
		void BtnAnalisisClick(object sender, EventArgs e)
		{}
  private void EvaluarCUM() {
 //una vez recibidos los nombres del estudiante, asi como su CUM se detemina las UV'

 string nombrecompleto;
 
 nombrecompleto = noms + " " + ape1 + " " + ape2;
 nombrecompleto = nombrecompleto.ToUpper() ;
 if (CUM < 0 | CUM > 10)
 {
 MessageBox.Show("Valor de CUM fuera de rango (0.0 - 10.0)", "Error",
 MessageBoxButtons.OK, MessageBoxIcon.Error);
 txtCUM.Focus();
 }
 else {
 //Usa estructura switch
 switch (Convert.ToInt16(CUM))
 {
 case 8 - 10:
 UV = 32;
break;
 case 7:
 UV = 24;
break;
 case 6:
 UV = 20;
break;
 case 1:
case 2:
case 3:
case 4:
case 5:
 UV = 16;
break;
 default:
 UV = 0;
break;
 }
 txtResul.Text = nombrecompleto + "Puede cursar " + UV + "UV";
 }
 }			
		}
		}
	





		
		
	
		
		
		
		
