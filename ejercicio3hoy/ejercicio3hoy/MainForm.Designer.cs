/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 18:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ejercicio3hoy
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.lstPalabras = new System.Windows.Forms.ListBox();
			this.lblpalabra = new System.Windows.Forms.Label();
			this.btnsalir = new System.Windows.Forms.Button();
			this.txtsignificado = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lstPalabras
			// 
			this.lstPalabras.FormattingEnabled = true;
			this.lstPalabras.Location = new System.Drawing.Point(30, 46);
			this.lstPalabras.Name = "lstPalabras";
			this.lstPalabras.Size = new System.Drawing.Size(120, 160);
			this.lstPalabras.TabIndex = 0;
			this.lstPalabras.SelectedIndexChanged += new System.EventHandler(this.LstPalabrasSelectedIndexChanged);
			// 
			// lblpalabra
			// 
			this.lblpalabra.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblpalabra.Location = new System.Drawing.Point(235, 33);
			this.lblpalabra.Name = "lblpalabra";
			this.lblpalabra.Size = new System.Drawing.Size(100, 23);
			this.lblpalabra.TabIndex = 1;
			this.lblpalabra.Text = "Palabra";
			// 
			// btnsalir
			// 
			this.btnsalir.Location = new System.Drawing.Point(63, 260);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(327, 31);
			this.btnsalir.TabIndex = 3;
			this.btnsalir.Text = "Salir";
			this.btnsalir.UseVisualStyleBackColor = true;
			this.btnsalir.Click += new System.EventHandler(this.BtnsalirClick);
			// 
			// txtsignificado
			// 
			this.txtsignificado.Enabled = false;
			this.txtsignificado.Location = new System.Drawing.Point(206, 46);
			this.txtsignificado.Multiline = true;
			this.txtsignificado.Name = "txtsignificado";
			this.txtsignificado.Size = new System.Drawing.Size(166, 200);
			this.txtsignificado.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(452, 324);
			this.Controls.Add(this.txtsignificado);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.lblpalabra);
			this.Controls.Add(this.lstPalabras);
			this.Name = "MainForm";
			this.Text = "ejercicio3hoy";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtsignificado;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Label lblpalabra;
		private System.Windows.Forms.ListBox lstPalabras;
	}
}
