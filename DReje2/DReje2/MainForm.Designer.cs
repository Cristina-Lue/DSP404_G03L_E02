/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 20:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace DReje2
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
			this.btnGenerarMatriz = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtDimension = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGenerarMatriz
			// 
			this.btnGenerarMatriz.Location = new System.Drawing.Point(35, 274);
			this.btnGenerarMatriz.Name = "btnGenerarMatriz";
			this.btnGenerarMatriz.Size = new System.Drawing.Size(132, 23);
			this.btnGenerarMatriz.TabIndex = 0;
			this.btnGenerarMatriz.Text = "Generar Matriz";
			this.btnGenerarMatriz.UseVisualStyleBackColor = true;
			this.btnGenerarMatriz.Click += new System.EventHandler(this.BtnGenerarMatrizClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(56, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(288, 150);
			this.dataGridView1.TabIndex = 1;
			// 
			// txtDimension
			// 
			this.txtDimension.Location = new System.Drawing.Point(128, 210);
			this.txtDimension.Name = "txtDimension";
			this.txtDimension.Size = new System.Drawing.Size(100, 20);
			this.txtDimension.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(225, 274);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 326);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtDimension);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnGenerarMatriz);
			this.Name = "MainForm";
			this.Text = "DReje2";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtDimension;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnGenerarMatriz;
	}
}
