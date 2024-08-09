/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 05/07/2024
 * Time: 01:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Form2
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
		
		public static Boolean IsNumeric(string valor)
 {
 int result;
 return int.TryParse(valor, out result);
 }
		
		void RdbInteres3CheckedChanged(object sender, EventArgs e)
		{

			if (rdbInteres3.Checked == true)
 {
 txtTasaInterEX.Enabled = true;
 txtTasaInterEX.Focus();
 }
 else {
 txtTasaInterEX.Text = "0";
 txtTasaInterEX.Enabled = false;
 }

			
		}
		
		void BtnAnalisisClick(object sender, EventArgs e)
		{



			//Declaracion de variables a utilizar
 string NomEmpre;
 double MontoInic=0, MontoFin=0, TasaI=0;
 int Tiempo;
 NomEmpre = txtEmpresa.Text;
 NomEmpre = NomEmpre.Trim();//Quita el espacio-blanco al inicio-final
 if (NomEmpre.Length == 0) {
 //si no hay caracteres en nombre empresa
 MessageBox.Show("Debe indicar Nombre de la empresa", "ERROR",
MessageBoxButtons.OK, MessageBoxIcon.Information);
 txtMonto.Focus(); //metodo que indica que control txtEmpresa recibira cursor
 return;//sale del procedimiento btnanalisis

}
 if (!(IsNumeric(txtMonto.Text)))
 {
 MessageBox.Show("Valor Monto incorrecto", "ERROR", MessageBoxButtons.OK,
MessageBoxIcon.Error);
 txtMonto.Focus(); //metodo que indica que control txtEmpresa recibira cursor
 return;
 }
 else {
 MontoInic = Convert.ToDouble(txtMonto.Text);
 if (!(MontoInic >0)){
 MessageBox.Show("Valor Monto no puede ser negativo", "ERROR",
MessageBoxButtons.OK, MessageBoxIcon.Error);
 txtMonto.Focus(); //metodo que indica que control txtEmpresa recibira cursor
 return;
 }
 }
 Tiempo = Convert.ToInt32(txtTiempo.Text);
 //si selcciono Tasa interes 3, valida que sea correcta
 txtTasaInterEX.Text = txtTasaInterEX.Text.Trim();
 if (rdbInteres3.Checked == true) {
 if (txtTasaInterEX.Text.Length > 0){
 if (!(IsNumeric(txtTasaInterEX.Text) == true))
 {
 MessageBox.Show("Tasa interes incorrecto", "ERROR", MessageBoxButtons.OK,
MessageBoxIcon.Error);
 txtTasaInterEX.Text = "0";
txtTasaInterEX.Focus();
 return;
 }
else {
 TasaI = Convert.ToDouble(txtTasaInterEX.Text) / 100;
 }
 }

 else
 {
 MessageBox.Show("Aun no ha indicado una tasa interes", "ERROR",
MessageBoxButtons.OK, MessageBoxIcon.Information);
 txtTasaInterEX.Focus();
 return;
 }
 }
 //Hace el cálculo esperado
 MontoFin =(1+TasaI);
 MontoFin = MontoInic*(Math.Pow(Convert.ToDouble(MontoFin), Tiempo));
 TasaI *= 100;
 //Muestra la respuesta (Monto a pagar)
 lstResul.Items.Clear();
 lstResul.Items.Add("Empresa: "+ txtEmpresa.Text);
 lstResul.Items.Add("Monto: $" + MontoInic +", Tasa anual: "+ TasaI);
 lstResul.Items.Add("Monto a pagar: $"+ MontoFin); 
		}
		
		void RdbInteres1CheckedChanged(object sender, EventArgs e)
		{
			double TasaI=0.12;
    		
		}
	}
}
