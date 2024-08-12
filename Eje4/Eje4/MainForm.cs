/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 09/08/2024
 * Time: 17:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Eje4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Boolean validar(string nombre, string pwd)
 {
 string clave = nombre;
 string pasword = "usuario";
 DialogResult respuesta; // variable para capturar el dato que me devuelve el

 if (nombre == clave && pwd == pasword)
 {
 respuesta = MessageBox.Show("Bienvenido" + " " + nombre, "Acceso",
MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
 if (respuesta == DialogResult.OK)
 {
 /* Para llamar a otro formulario(Form5),se debe primero instancia al
nuevo formulario,o es decir creamos el objeto
 * para nuestro caso formulario2 y luego accesamos al método show, para
mostrar el Form5*/
 Form2 formulario2 = new Form2();//instanciando al Form
 formulario2.Show(); // Mostramos el Form2
return true;
 }
 }//Fin de if
 else {
 MessageBox.Show("Contraseña incorrecta","Acceso",MessageBoxButtons.OK,MessageBoxIcon.Error);
 }
 return false;
 }// Fin de Función
		
		
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
	txtusuario.Focus();
		}
		void BtnAceptarClick(object sender, EventArgs e)
		{
	if( validar(txtusuario.Text, txtpwd.Text)){
 // Se llama la función validar declarada.
 this.Hide();
 }// ocultamos el Form4
		}
	}
}
