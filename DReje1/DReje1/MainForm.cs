/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 19:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DReje1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private List<string> nombres = new List<string>();
		
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
		
		
		
		
		
		void BtnSalirClick(object sender, EventArgs e)
		{
					Application.Exit();	
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			 nombres.Add("Juan");
            nombres.Add("María");
            nombres.Add("Pedro");

            // Actualiza el ListBox con los nombres
            ActualizarListBox();
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			
			string nuevoNombre = txtNombre.Text.Trim();
            if (!string.IsNullOrEmpty(nuevoNombre))
            {
                nombres.Add(nuevoNombre);
                ActualizarListBox();
                
            }
            
            
			
		}
		
		void BtnBorrarClick(object sender, EventArgs e)
		{
			 if (lstNombres.SelectedIndex >= 0)
            {
                nombres.RemoveAt(lstNombres.SelectedIndex);
                ActualizarListBox();
                txtNombre.Clear();
            }
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			
			if (lstNombres.SelectedIndex >= 0)
            {
                string nombreModificado = txtNombre.Text.Trim();
                if (!string.IsNullOrEmpty(nombreModificado))
                {
                    nombres[lstNombres.SelectedIndex] = nombreModificado;
                    ActualizarListBox();
                    txtNombre.Clear();
                }
            }
			
			
			
		}
		
		 private void ActualizarListBox()
        {
            lstNombres.Items.Clear();
            foreach (string nombre in nombres)
            {
                lstNombres.Items.Add(nombre);
            }
        }
		
	}
}
