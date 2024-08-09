/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 06/07/2024
 * Hora: 18:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Fomr3
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
			this.lblApe1 = new System.Windows.Forms.Label();
			this.lblApe2 = new System.Windows.Forms.Label();
			this.lblNom = new System.Windows.Forms.Label();
			this.lblCUM = new System.Windows.Forms.Label();
			this.txtApe1 = new System.Windows.Forms.TextBox();
			this.txtApe2 = new System.Windows.Forms.TextBox();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.txtCUM = new System.Windows.Forms.TextBox();
			this.txtResul = new System.Windows.Forms.TextBox();
			this.btnAnalisis = new System.Windows.Forms.Button();
			this.btnFin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblApe1
			// 
			this.lblApe1.Location = new System.Drawing.Point(12, 36);
			this.lblApe1.Name = "lblApe1";
			this.lblApe1.Size = new System.Drawing.Size(100, 23);
			this.lblApe1.TabIndex = 0;
			this.lblApe1.Text = "1er Apellido:";
			// 
			// lblApe2
			// 
			this.lblApe2.Location = new System.Drawing.Point(12, 72);
			this.lblApe2.Name = "lblApe2";
			this.lblApe2.Size = new System.Drawing.Size(100, 23);
			this.lblApe2.TabIndex = 1;
			this.lblApe2.Text = "2do Apellido:";
			// 
			// lblNom
			// 
			this.lblNom.Location = new System.Drawing.Point(23, 105);
			this.lblNom.Name = "lblNom";
			this.lblNom.Size = new System.Drawing.Size(100, 23);
			this.lblNom.TabIndex = 2;
			this.lblNom.Text = "Nombres";
			// 
			// lblCUM
			// 
			this.lblCUM.Location = new System.Drawing.Point(12, 146);
			this.lblCUM.Name = "lblCUM";
			this.lblCUM.Size = new System.Drawing.Size(100, 23);
			this.lblCUM.TabIndex = 3;
			this.lblCUM.Text = "Valor de CUM";
			// 
			// txtApe1
			// 
			this.txtApe1.Location = new System.Drawing.Point(81, 36);
			this.txtApe1.Name = "txtApe1";
			this.txtApe1.Size = new System.Drawing.Size(249, 20);
			this.txtApe1.TabIndex = 4;
			this.txtApe1.Text = "(vacio)";
			// 
			// txtApe2
			// 
			this.txtApe2.Location = new System.Drawing.Point(81, 72);
			this.txtApe2.Name = "txtApe2";
			this.txtApe2.Size = new System.Drawing.Size(249, 20);
			this.txtApe2.TabIndex = 5;
			this.txtApe2.Text = "(vacio)";
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(81, 108);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(249, 20);
			this.txtNom.TabIndex = 6;
			this.txtNom.Text = "vacio)";
			// 
			// txtCUM
			// 
			this.txtCUM.Location = new System.Drawing.Point(81, 146);
			this.txtCUM.Name = "txtCUM";
			this.txtCUM.Size = new System.Drawing.Size(249, 20);
			this.txtCUM.TabIndex = 7;
			this.txtCUM.Text = "0.0";
			// 
			// txtResul
			// 
			this.txtResul.Enabled = false;
			this.txtResul.Location = new System.Drawing.Point(23, 187);
			this.txtResul.Name = "txtResul";
			this.txtResul.Size = new System.Drawing.Size(307, 20);
			this.txtResul.TabIndex = 8;
			this.txtResul.Text = "Resultado de evaluacion";
			// 
			// btnAnalisis
			// 
			this.btnAnalisis.Location = new System.Drawing.Point(38, 226);
			this.btnAnalisis.Name = "btnAnalisis";
			this.btnAnalisis.Size = new System.Drawing.Size(75, 23);
			this.btnAnalisis.TabIndex = 9;
			this.btnAnalisis.Text = "Calcular UV";
			this.btnAnalisis.UseVisualStyleBackColor = true;
			this.btnAnalisis.Click += new System.EventHandler(this.BtnAnalisisClick);
			// 
			// btnFin
			// 
			this.btnFin.Location = new System.Drawing.Point(208, 226);
			this.btnFin.Name = "btnFin";
			this.btnFin.Size = new System.Drawing.Size(75, 23);
			this.btnFin.TabIndex = 10;
			this.btnFin.Text = "Salir del";
			this.btnFin.UseVisualStyleBackColor = true;
			this.btnFin.Click += new System.EventHandler(this.BtnFinClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 261);
			this.Controls.Add(this.btnFin);
			this.Controls.Add(this.btnAnalisis);
			this.Controls.Add(this.txtResul);
			this.Controls.Add(this.txtCUM);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.txtApe2);
			this.Controls.Add(this.txtApe1);
			this.Controls.Add(this.lblCUM);
			this.Controls.Add(this.lblNom);
			this.Controls.Add(this.lblApe2);
			this.Controls.Add(this.lblApe1);
			this.Name = "MainForm";
			this.Text = "Fomr3";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnFin;
		private System.Windows.Forms.Button btnAnalisis;
		private System.Windows.Forms.TextBox txtResul;
		private System.Windows.Forms.TextBox txtCUM;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.TextBox txtApe2;
		private System.Windows.Forms.TextBox txtApe1;
		private System.Windows.Forms.Label lblCUM;
		private System.Windows.Forms.Label lblNom;
		private System.Windows.Forms.Label lblApe2;
		private System.Windows.Forms.Label lblApe1;
	}
}
