/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 09/08/2024
 * Time: 19:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Desafio_eje2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lblMensaje;
		private System.Windows.Forms.TextBox txtCuenta;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtCuentaDestino;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
		
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
		/// 
		private void InitializeComponent()
		{
			this.button2 = new System.Windows.Forms.Button();
			this.lblMensaje = new System.Windows.Forms.Label();
			this.txtCuenta = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtCuentaDestino = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(28, 22);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "Iniciar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// lblMensaje
			// 
			this.lblMensaje.Location = new System.Drawing.Point(340, 9);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(323, 23);
			this.lblMensaje.TabIndex = 2;
			this.lblMensaje.Text = "Mensaje";
			// 
			// txtCuenta
			// 
			this.txtCuenta.Location = new System.Drawing.Point(374, 80);
			this.txtCuenta.Name = "txtCuenta";
			this.txtCuenta.Size = new System.Drawing.Size(100, 20);
			this.txtCuenta.TabIndex = 4;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(374, 128);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 20);
			this.txtCantidad.TabIndex = 6;
			// 
			// txtCuentaDestino
			// 
			this.txtCuentaDestino.Location = new System.Drawing.Point(374, 198);
			this.txtCuentaDestino.Name = "txtCuentaDestino";
			this.txtCuentaDestino.Size = new System.Drawing.Size(100, 20);
			this.txtCuentaDestino.TabIndex = 7;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(49, 127);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(149, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(374, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "ingrese el numero de cuenta";
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Location = new System.Drawing.Point(162, 22);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(114, 34);
			this.btnConfirmar.TabIndex = 11;
			this.btnConfirmar.Text = "confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(374, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "ingrese la cantidad";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(374, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "ingrese la cuenta de destino";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(665, 304);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.txtCuentaDestino);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtCuenta);
			this.Controls.Add(this.lblMensaje);
			this.Controls.Add(this.button2);
			this.Name = "MainForm";
			this.Text = "Desafio_eje2";
			this.ResumeLayout(false);
			this.PerformLayout();

		// 
			
		
		}
	}
}  
