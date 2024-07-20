/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 13:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ejercicio1
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
			this.lblnumero = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btAgregar = new System.Windows.Forms.Button();
			this.btOrdenar = new System.Windows.Forms.Button();
			this.lstdesorden = new System.Windows.Forms.ListBox();
			this.lstOrdenada = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lblnumero
			// 
			this.lblnumero.Location = new System.Drawing.Point(13, 57);
			this.lblnumero.Name = "lblnumero";
			this.lblnumero.Size = new System.Drawing.Size(100, 23);
			this.lblnumero.TabIndex = 0;
			this.lblnumero.Text = "Ingresar Numero:";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(102, 57);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(100, 20);
			this.txtNum.TabIndex = 1;
			// 
			// btAgregar
			// 
			this.btAgregar.Location = new System.Drawing.Point(312, 34);
			this.btAgregar.Name = "btAgregar";
			this.btAgregar.Size = new System.Drawing.Size(75, 23);
			this.btAgregar.TabIndex = 2;
			this.btAgregar.Text = "Agregar";
			this.btAgregar.UseVisualStyleBackColor = true;
			this.btAgregar.Click += new System.EventHandler(this.BtAgregarClick);
			// 
			// btOrdenar
			// 
			this.btOrdenar.Location = new System.Drawing.Point(312, 90);
			this.btOrdenar.Name = "btOrdenar";
			this.btOrdenar.Size = new System.Drawing.Size(75, 23);
			this.btOrdenar.TabIndex = 3;
			this.btOrdenar.Text = "Ordenar";
			this.btOrdenar.UseVisualStyleBackColor = true;
			this.btOrdenar.Click += new System.EventHandler(this.BtOrdenarClick);
			// 
			// lstdesorden
			// 
			this.lstdesorden.FormattingEnabled = true;
			this.lstdesorden.Location = new System.Drawing.Point(62, 143);
			this.lstdesorden.Name = "lstdesorden";
			this.lstdesorden.Size = new System.Drawing.Size(120, 95);
			this.lstdesorden.TabIndex = 4;
			// 
			// lstOrdenada
			// 
			this.lstOrdenada.FormattingEnabled = true;
			this.lstOrdenada.Location = new System.Drawing.Point(267, 143);
			this.lstOrdenada.Name = "lstOrdenada";
			this.lstOrdenada.Size = new System.Drawing.Size(120, 95);
			this.lstOrdenada.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(447, 261);
			this.Controls.Add(this.lstOrdenada);
			this.Controls.Add(this.lstdesorden);
			this.Controls.Add(this.btOrdenar);
			this.Controls.Add(this.btAgregar);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.lblnumero);
			this.Name = "MainForm";
			this.Text = "ejercicio1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListBox lstOrdenada;
		private System.Windows.Forms.ListBox lstdesorden;
		private System.Windows.Forms.Button btOrdenar;
		private System.Windows.Forms.Button btAgregar;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label lblnumero;
	}
}
