/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 15/08/2024
 * Time: 12:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Analisis1GUIA4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button BtnMostrarLista;
		private System.Windows.Forms.Button BtnInsertarElemento;
		private System.Windows.Forms.Button BtnRemoverElemento;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Button BtnCrearLista;
		
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
			this.BtnCrearLista = new System.Windows.Forms.Button();
			this.BtnMostrarLista = new System.Windows.Forms.Button();
			this.BtnInsertarElemento = new System.Windows.Forms.Button();
			this.BtnRemoverElemento = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.txtValor = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BtnCrearLista
			// 
			this.BtnCrearLista.Location = new System.Drawing.Point(72, 58);
			this.BtnCrearLista.Name = "BtnCrearLista";
			this.BtnCrearLista.Size = new System.Drawing.Size(75, 23);
			this.BtnCrearLista.TabIndex = 0;
			this.BtnCrearLista.Text = "Crear Lista";
			this.BtnCrearLista.UseVisualStyleBackColor = true;
			this.BtnCrearLista.Click += new System.EventHandler(this.BtnCrearListaClick);
			// 
			// BtnMostrarLista
			// 
			this.BtnMostrarLista.Location = new System.Drawing.Point(72, 110);
			this.BtnMostrarLista.Name = "BtnMostrarLista";
			this.BtnMostrarLista.Size = new System.Drawing.Size(75, 23);
			this.BtnMostrarLista.TabIndex = 1;
			this.BtnMostrarLista.Text = "MostrarLista";
			this.BtnMostrarLista.UseVisualStyleBackColor = true;
			this.BtnMostrarLista.Click += new System.EventHandler(this.BtnMostrarListaClick);
			// 
			// BtnInsertarElemento
			// 
			this.BtnInsertarElemento.Location = new System.Drawing.Point(189, 58);
			this.BtnInsertarElemento.Name = "BtnInsertarElemento";
			this.BtnInsertarElemento.Size = new System.Drawing.Size(114, 23);
			this.BtnInsertarElemento.TabIndex = 2;
			this.BtnInsertarElemento.Text = "Insertar Elemento";
			this.BtnInsertarElemento.UseVisualStyleBackColor = true;
			this.BtnInsertarElemento.Click += new System.EventHandler(this.BtnInsertarElementoClick);
			// 
			// BtnRemoverElemento
			// 
			this.BtnRemoverElemento.Location = new System.Drawing.Point(189, 110);
			this.BtnRemoverElemento.Name = "BtnRemoverElemento";
			this.BtnRemoverElemento.Size = new System.Drawing.Size(114, 23);
			this.BtnRemoverElemento.TabIndex = 3;
			this.BtnRemoverElemento.Text = "Remover Elemento";
			this.BtnRemoverElemento.UseVisualStyleBackColor = true;
			this.BtnRemoverElemento.Click += new System.EventHandler(this.BtnRemoverElementoClick);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(94, 171);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 95);
			this.listBox1.TabIndex = 4;
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(105, 289);
			this.txtValor.Name = "txtValor";
			this.txtValor.Size = new System.Drawing.Size(100, 20);
			this.txtValor.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 321);
			this.Controls.Add(this.txtValor);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.BtnRemoverElemento);
			this.Controls.Add(this.BtnInsertarElemento);
			this.Controls.Add(this.BtnMostrarLista);
			this.Controls.Add(this.BtnCrearLista);
			this.Name = "MainForm";
			this.Text = "Analisis1GUIA4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
