/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 09/08/2024
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dsp_guia4_eje1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private void presentacInic() {
 //prepara controles antes de mostrar form al usuario
 grbResult.Visible = false;
 nupBase.Focus();
 }
		
		private void HacerCalculos(Decimal N) {
 /*Se prepara a calcular tablas (de multiplicar y potencia)
 segun valor de variable argumentos N*/
 int c;
 decimal res;
 lstTabla1.Items.Clear();
 c = 1;
 do
 {
 res = N * c;
 lstTabla1.Items.Add(N.ToString() + "X" +c.ToString()+"="+res.ToString());
 c += 1;
 } while (! (c > 10));
 //Genera la portencia de las tablas
 lstTabla2.Items.Clear();
 c = 1;
 do{
 res = Elevar(N, c);
lstTabla2.Items.Add(N.ToString() + " a la " + c.ToString() + "=" + res.ToString());
 c += 1;
 }while(c<= 10);
 }
 private decimal Elevar(decimal B, int expo) {
 //remplaza a operador pow que calcula la potencia de argumentos (Bpow(expo))
 int i = 1;
 decimal r = 1;
 do{
 r *= B;


 i += 1;
 }while(!(i>expo));
 return r;
 }
		
		
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
	
		}
		void BtnCalculoClick(object sender, EventArgs e)
		{
	//Invoca a subrituna HacerCalculos
decimal n = nupBase.Value;
HacerCalculos(n);
//Muestra resultados
grbResult.Visible = true;
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
