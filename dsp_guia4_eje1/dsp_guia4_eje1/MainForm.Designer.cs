/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 09/08/2024
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dsp_guia4_eje1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbltema;
		private System.Windows.Forms.NumericUpDown nupBase;
		private System.Windows.Forms.Button btnCalculo;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.ListBox lstTabla2;
		private System.Windows.Forms.ListBox lstTabla1;
		private System.Windows.Forms.GroupBox grbResult;
		
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
			this.grbResult = new System.Windows.Forms.GroupBox();
			this.lstTabla2 = new System.Windows.Forms.ListBox();
			this.lstTabla1 = new System.Windows.Forms.ListBox();
			this.lbltema = new System.Windows.Forms.Label();
			this.nupBase = new System.Windows.Forms.NumericUpDown();
			this.btnCalculo = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.grbResult.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupBase)).BeginInit();
			this.SuspendLayout();
			// 
			// grbResult
			// 
			this.grbResult.Controls.Add(this.lstTabla2);
			this.grbResult.Controls.Add(this.lstTabla1);
			this.grbResult.Location = new System.Drawing.Point(268, 46);
			this.grbResult.Name = "grbResult";
			this.grbResult.Size = new System.Drawing.Size(268, 264);
			this.grbResult.TabIndex = 4;
			this.grbResult.TabStop = false;
			this.grbResult.Text = "Resultados";
			// 
			// lstTabla2
			// 
			this.lstTabla2.FormattingEnabled = true;
			this.lstTabla2.Location = new System.Drawing.Point(142, 28);
			this.lstTabla2.Name = "lstTabla2";
			this.lstTabla2.Size = new System.Drawing.Size(120, 173);
			this.lstTabla2.TabIndex = 1;
			// 
			// lstTabla1
			// 
			this.lstTabla1.FormattingEnabled = true;
			this.lstTabla1.Location = new System.Drawing.Point(6, 28);
			this.lstTabla1.Name = "lstTabla1";
			this.lstTabla1.Size = new System.Drawing.Size(120, 173);
			this.lstTabla1.TabIndex = 0;
			// 
			// lbltema
			// 
			this.lbltema.Location = new System.Drawing.Point(25, 55);
			this.lbltema.Name = "lbltema";
			this.lbltema.Size = new System.Drawing.Size(100, 23);
			this.lbltema.TabIndex = 0;
			this.lbltema.Text = "ingrese numero";
			// 
			// nupBase
			// 
			this.nupBase.Location = new System.Drawing.Point(25, 94);
			this.nupBase.Name = "nupBase";
			this.nupBase.Size = new System.Drawing.Size(120, 20);
			this.nupBase.TabIndex = 1;
			// 
			// btnCalculo
			// 
			this.btnCalculo.Location = new System.Drawing.Point(25, 136);
			this.btnCalculo.Name = "btnCalculo";
			this.btnCalculo.Size = new System.Drawing.Size(116, 46);
			this.btnCalculo.TabIndex = 2;
			this.btnCalculo.Text = "Ver tablas ";
			this.btnCalculo.UseVisualStyleBackColor = true;
			this.btnCalculo.Click += new System.EventHandler(this.BtnCalculoClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(29, 214);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(116, 46);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Finalizar";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(589, 335);
			this.Controls.Add(this.grbResult);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnCalculo);
			this.Controls.Add(this.nupBase);
			this.Controls.Add(this.lbltema);
			this.Name = "MainForm";
			this.Text = "dsp_guia4_eje1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.grbResult.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nupBase)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
