/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 18:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ejercicio3hoy
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
	
		
		Dictionary<string, string> palabras = new Dictionary<string, string>();
		
		
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

			palabras.Add("Manzana", "Fruta pomácea comestible, fruto\n del manzano doméstico (Malusdomestica)\n, otros manzanos (especies del género\n Malus).");
			
			palabras.Add("Pera", "Fruta comestible que procede del Pyrus communis, un árbol que se conoce coloquialmente como peral común. Existen, de todas maneras, muchas clases de peras, que son producidas por otros árboles del género Pyrus.");
			
			palabras.Add("Melocotón", "Fruto del melocotonero. Es una drupa de olor agradable, esférica, de seis a ocho centímetros de diámetro, con un surco profundo que ocupa media circunferencia, epicarpio delgado, velloso, de color amarillo con manchas encarnadas, mesocarpio amarillento, de sabor agradable y adherido a un hueso pardo, duro y rugoso, que encierra una almendra muy amarga.");
			
			foreach(var item in palabras.Keys){
 			lstPalabras.Items.Add(item);
 }
		}
		
		void LstPalabrasSelectedIndexChanged(object sender, EventArgs e)
		{
			string buscar;
			
			buscar=lstPalabras.Text;
 //buscamos dato de la lista dentro del diccionario
 for (int i = 0; i < palabras.Count;i++ )
 {
 			var item =palabras.ElementAt(i);
 			if (buscar== item.Key){
 			lblpalabra.Text = item.Key;
			txtsignificado.Text = item.Value;
			break;
 }
 }
			
		}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
				
			Application.Exit();
		}	
	}
}
