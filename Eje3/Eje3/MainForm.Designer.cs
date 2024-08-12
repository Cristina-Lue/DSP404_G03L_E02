/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 09/08/2024
 * Time: 16:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Eje3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudN1;
		private System.Windows.Forms.NumericUpDown nudN2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbOperaciones;
		private System.Windows.Forms.Label lblResul;
		private System.Windows.Forms.Button button1;
		
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
		{   this.buttonConfirmar.Click += new System.EventHandler(this.Button1Click);

			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nudN1 = new System.Windows.Forms.NumericUpDown();
			this.nudN2 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbOperaciones = new System.Windows.Forms.ComboBox();
			this.lblResul = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudN1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudN2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(56, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "numero uno";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(56, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero dos";
			// 
			// nudN1
			// 
			this.nudN1.Location = new System.Drawing.Point(119, 84);
			this.nudN1.Name = "nudN1";
			this.nudN1.Size = new System.Drawing.Size(120, 20);
			this.nudN1.TabIndex = 3;
			// 
			// nudN2
			// 
			this.nudN2.Location = new System.Drawing.Point(119, 126);
			this.nudN2.Name = "nudN2";
			this.nudN2.Size = new System.Drawing.Size(120, 20);
			this.nudN2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(313, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Opciones Disponibles";
			// 
			// cmbOperaciones
			// 
			this.cmbOperaciones.FormattingEnabled = true;
			this.cmbOperaciones.Location = new System.Drawing.Point(313, 125);
			this.cmbOperaciones.Name = "cmbOperaciones";
			this.cmbOperaciones.Size = new System.Drawing.Size(121, 21);
			this.cmbOperaciones.TabIndex = 6;
			this.cmbOperaciones.SelectedIndexChanged += new System.EventHandler(this.CmbOperacionesSelectedIndexChanged);
			// 
			// lblResul
			// 
			this.lblResul.Location = new System.Drawing.Point(180, 200);
			this.lblResul.Name = "lblResul";
			this.lblResul.Size = new System.Drawing.Size(189, 23);
			this.lblResul.TabIndex = 7;
			this.lblResul.Text = "label4";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(180, 252);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCoral;
			this.ClientSize = new System.Drawing.Size(557, 312);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblResul);
			this.Controls.Add(this.cmbOperaciones);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nudN2);
			this.Controls.Add(this.nudN1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Eje3";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.nudN1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudN2)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
