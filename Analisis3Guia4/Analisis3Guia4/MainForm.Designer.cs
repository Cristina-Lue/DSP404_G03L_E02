/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 15/08/2024
 * Time: 13:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Analisis3Guia4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnMostrarEstadisticas;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnMostrarEstadisticas = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(34, 52);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(172, 134);
			this.listBox1.TabIndex = 0;
			// 
			// btnMostrarEstadisticas
			// 
			this.btnMostrarEstadisticas.Location = new System.Drawing.Point(44, 192);
			this.btnMostrarEstadisticas.Name = "btnMostrarEstadisticas";
			this.btnMostrarEstadisticas.Size = new System.Drawing.Size(152, 23);
			this.btnMostrarEstadisticas.TabIndex = 1;
			this.btnMostrarEstadisticas.Text = "Mostrar Estadisticas";
			this.btnMostrarEstadisticas.UseVisualStyleBackColor = true;
			this.btnMostrarEstadisticas.Click += new System.EventHandler(this.BtnMostrarEstadisticasClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnMostrarEstadisticas);
			this.Controls.Add(this.listBox1);
			this.Name = "MainForm";
			this.Text = "Analisis3Guia4";
			this.ResumeLayout(false);

		}
	}
}
