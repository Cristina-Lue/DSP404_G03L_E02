/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 05/07/2024
 * Time: 01:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Form2
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
			this.labelEmpresa = new System.Windows.Forms.Label();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.lblMonto = new System.Windows.Forms.Label();
			this.txtMonto = new System.Windows.Forms.TextBox();
			this.lblTiempo = new System.Windows.Forms.Label();
			this.txtTiempo = new System.Windows.Forms.TextBox();
			this.lblTasaInter = new System.Windows.Forms.Label();
			this.rdbInteres1 = new System.Windows.Forms.RadioButton();
			this.rdbInteres2 = new System.Windows.Forms.RadioButton();
			this.rdbInteres3 = new System.Windows.Forms.RadioButton();
			this.txtTasaInterEX = new System.Windows.Forms.TextBox();
			this.lstResul = new System.Windows.Forms.ListBox();
			this.btnAnalisis = new System.Windows.Forms.Button();
			this.btnFin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelEmpresa
			// 
			this.labelEmpresa.Location = new System.Drawing.Point(12, 63);
			this.labelEmpresa.Name = "labelEmpresa";
			this.labelEmpresa.Size = new System.Drawing.Size(133, 23);
			this.labelEmpresa.TabIndex = 0;
			this.labelEmpresa.Text = "Nombre de Empresa:";
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Location = new System.Drawing.Point(124, 60);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(463, 20);
			this.txtEmpresa.TabIndex = 1;
			this.txtEmpresa.Text = "(vacio)";
			// 
			// lblMonto
			// 
			this.lblMonto.Location = new System.Drawing.Point(55, 114);
			this.lblMonto.Name = "lblMonto";
			this.lblMonto.Size = new System.Drawing.Size(100, 23);
			this.lblMonto.TabIndex = 2;
			this.lblMonto.Text = "Monto prestamo ($)";
			// 
			// txtMonto
			// 
			this.txtMonto.Location = new System.Drawing.Point(161, 111);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.Size = new System.Drawing.Size(100, 20);
			this.txtMonto.TabIndex = 3;
			this.txtMonto.Text = "(vacio)";
			// 
			// lblTiempo
			// 
			this.lblTiempo.Location = new System.Drawing.Point(337, 119);
			this.lblTiempo.Name = "lblTiempo";
			this.lblTiempo.Size = new System.Drawing.Size(100, 23);
			this.lblTiempo.TabIndex = 4;
			this.lblTiempo.Text = "Tiempo (años)";
			// 
			// txtTiempo
			// 
			this.txtTiempo.Location = new System.Drawing.Point(411, 114);
			this.txtTiempo.Name = "txtTiempo";
			this.txtTiempo.Size = new System.Drawing.Size(100, 20);
			this.txtTiempo.TabIndex = 5;
			this.txtTiempo.Text = "2";
			// 
			// lblTasaInter
			// 
			this.lblTasaInter.Location = new System.Drawing.Point(73, 175);
			this.lblTasaInter.Name = "lblTasaInter";
			this.lblTasaInter.Size = new System.Drawing.Size(100, 23);
			this.lblTasaInter.TabIndex = 6;
			this.lblTasaInter.Text = "Tasa Interes:";
			// 
			// rdbInteres1
			// 
			this.rdbInteres1.Checked = true;
			this.rdbInteres1.Location = new System.Drawing.Point(55, 211);
			this.rdbInteres1.Name = "rdbInteres1";
			this.rdbInteres1.Size = new System.Drawing.Size(63, 24);
			this.rdbInteres1.TabIndex = 7;
			this.rdbInteres1.TabStop = true;
			this.rdbInteres1.Text = "12 %";
			this.rdbInteres1.UseVisualStyleBackColor = true;
			this.rdbInteres1.CheckedChanged += new System.EventHandler(this.RdbInteres1CheckedChanged);
			// 
			// rdbInteres2
			// 
			this.rdbInteres2.Location = new System.Drawing.Point(151, 211);
			this.rdbInteres2.Name = "rdbInteres2";
			this.rdbInteres2.Size = new System.Drawing.Size(104, 24);
			this.rdbInteres2.TabIndex = 8;
			this.rdbInteres2.Text = "23.5 %";
			this.rdbInteres2.UseVisualStyleBackColor = true;
			// 
			// rdbInteres3
			// 
			this.rdbInteres3.Location = new System.Drawing.Point(262, 210);
			this.rdbInteres3.Name = "rdbInteres3";
			this.rdbInteres3.Size = new System.Drawing.Size(104, 24);
			this.rdbInteres3.TabIndex = 9;
			this.rdbInteres3.Text = "Otro, indique:";
			this.rdbInteres3.UseVisualStyleBackColor = true;
			this.rdbInteres3.CheckedChanged += new System.EventHandler(this.RdbInteres3CheckedChanged);
			// 
			// txtTasaInterEX
			// 
			this.txtTasaInterEX.Enabled = false;
			this.txtTasaInterEX.Location = new System.Drawing.Point(411, 210);
			this.txtTasaInterEX.Name = "txtTasaInterEX";
			this.txtTasaInterEX.Size = new System.Drawing.Size(100, 20);
			this.txtTasaInterEX.TabIndex = 10;
			this.txtTasaInterEX.Text = "0";
			// 
			// lstResul
			// 
			this.lstResul.Enabled = false;
			this.lstResul.FormattingEnabled = true;
			this.lstResul.Location = new System.Drawing.Point(55, 252);
			this.lstResul.Name = "lstResul";
			this.lstResul.Size = new System.Drawing.Size(519, 147);
			this.lstResul.TabIndex = 11;
			// 
			// btnAnalisis
			// 
			this.btnAnalisis.Location = new System.Drawing.Point(73, 429);
			this.btnAnalisis.Name = "btnAnalisis";
			this.btnAnalisis.Size = new System.Drawing.Size(138, 23);
			this.btnAnalisis.TabIndex = 12;
			this.btnAnalisis.Text = "Análisis Financiero";
			this.btnAnalisis.UseVisualStyleBackColor = true;
			this.btnAnalisis.Click += new System.EventHandler(this.BtnAnalisisClick);
			// 
			// btnFin
			// 
			this.btnFin.Location = new System.Drawing.Point(390, 429);
			this.btnFin.Name = "btnFin";
			this.btnFin.Size = new System.Drawing.Size(140, 23);
			this.btnFin.TabIndex = 13;
			this.btnFin.Text = "Salir del programa";
			this.btnFin.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 470);
			this.Controls.Add(this.btnFin);
			this.Controls.Add(this.btnAnalisis);
			this.Controls.Add(this.lstResul);
			this.Controls.Add(this.txtTasaInterEX);
			this.Controls.Add(this.rdbInteres3);
			this.Controls.Add(this.rdbInteres2);
			this.Controls.Add(this.rdbInteres1);
			this.Controls.Add(this.lblTasaInter);
			this.Controls.Add(this.txtTiempo);
			this.Controls.Add(this.lblTiempo);
			this.Controls.Add(this.txtMonto);
			this.Controls.Add(this.lblMonto);
			this.Controls.Add(this.txtEmpresa);
			this.Controls.Add(this.labelEmpresa);
			this.Name = "MainForm";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnFin;
		private System.Windows.Forms.Button btnAnalisis;
		private System.Windows.Forms.ListBox lstResul;
		private System.Windows.Forms.TextBox txtTasaInterEX;
		private System.Windows.Forms.RadioButton rdbInteres3;
		private System.Windows.Forms.RadioButton rdbInteres2;
		private System.Windows.Forms.RadioButton rdbInteres1;
		private System.Windows.Forms.Label lblTasaInter;
		private System.Windows.Forms.TextBox txtTiempo;
		private System.Windows.Forms.Label lblTiempo;
		private System.Windows.Forms.TextBox txtMonto;
		private System.Windows.Forms.Label lblMonto;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.Label labelEmpresa;
	}
}
