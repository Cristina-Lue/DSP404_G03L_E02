/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 20:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace DReje3
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
			this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
			this.btnCalcularMedia = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewNotas
			// 
			this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewNotas.Location = new System.Drawing.Point(47, 12);
			this.dataGridViewNotas.Name = "dataGridViewNotas";
			this.dataGridViewNotas.Size = new System.Drawing.Size(385, 266);
			this.dataGridViewNotas.TabIndex = 0;
			// 
			// btnCalcularMedia
			// 
			this.btnCalcularMedia.Location = new System.Drawing.Point(47, 295);
			this.btnCalcularMedia.Name = "btnCalcularMedia";
			this.btnCalcularMedia.Size = new System.Drawing.Size(161, 23);
			this.btnCalcularMedia.TabIndex = 1;
			this.btnCalcularMedia.Text = "Calcular Medias";
			this.btnCalcularMedia.UseVisualStyleBackColor = true;
			this.btnCalcularMedia.Click += new System.EventHandler(this.BtnCalcularMediaClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(271, 295);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(161, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 340);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnCalcularMedia);
			this.Controls.Add(this.dataGridViewNotas);
			this.Name = "MainForm";
			this.Text = "DReje3";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnCalcularMedia;
		private System.Windows.Forms.DataGridView dataGridViewNotas;
	}
}
