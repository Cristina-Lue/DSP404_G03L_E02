/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 12/08/2024
 * Time: 15:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eje4
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
		
		
	{
		
		
		const float Pago_turista = 50, Pago_Delegado = 70;
float interes = 0.18f;
private float calculo_hospedaje(int dias) // Función recibe un paramétro y retorna un valor.
 {
 float calculo = 0f;
 if (radioButton1.Checked)
 {
 calculo = Convert.ToInt32(txtdias.Text) * Pago_turista;
 }
 else
 {
 calculo = Convert.ToInt32(txtdias.Text) * Pago_Delegado;
 }

 return calculo;
 }
 private int calculo_servicio()// Función no recibe parámetros pero devuelve un valor
 {
 int acum = 0;
/* Usar CheckBox sin tanto if. Para ello se recorre la colección ControlCollection de la
propiedad Controls,
después se verifica si el control es un CheckBox y de serlo, verificar su valor.
Cuando damos click en el boton calcular se invoca esta función y se recorren todos los controles
del formulario,y si un control es un CheckBox, entonces se verifica su valor y si es verdadero
acumulamos el valor del servicio*/
 foreach (Control contr in this.groupBox2.Controls)
 {
 CheckBox checkbox = contr as CheckBox;
 if (checkbox.Checked)
 acum += 20;
 }// fin de primer if dentro de foreach
 return acum;
 } 
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Form2Load(object sender, EventArgs e)
		{
	txtnombre.Focus();

 txtmontoh.Enabled = false;
 txtmontos.Enabled = false;
 txtmontot.Enabled = false;
 txtinteres.Enabled = false;
 nUDpagar.Enabled = false;
 radioButton1.Checked = true;
 checkBox1.Checked = false;
 checkBox2.Checked = false;
 checkBox3.Checked = false;
		}
		void Button1Click(object sender, EventArgs e)
		{
	txtnombre.Focus();

 txtmontoh.Enabled = false;
 txtmontos.Enabled = false;
 txtmontot.Enabled = false;
 txtinteres.Enabled = false;
 nUDpagar.Enabled = false;
 radioButton1.Checked = true;
 checkBox1.Checked = false;
 checkBox2.Checked = false;
 checkBox3.Checked = false;
		}
		void Button2Click(object sender, EventArgs e)
		{
	txtnombre.Text = "";
 txtnombre.Focus();
 txtdias.Text = " ";
 txtmontoh.Text = "";
 txtmontos.Text ="";
 txtmontot.Text = "";
 txtinteres.Text = "";
 nUDpagar.Value =0;
 radioButton1.Checked = true;
 checkBox1.Checked = false;
 checkBox2.Checked = false;
 checkBox3.Checked = false;
		}
		void Button4Click(object sender, EventArgs e)
		{
	this.Close();
		}
	}
}
