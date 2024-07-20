/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 19:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace DReje1
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
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.lstNombres = new System.Windows.Forms.ListBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(36, 50);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 0;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(263, 50);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(75, 23);
			this.btnBorrar.TabIndex = 1;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(36, 103);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(73, 31);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(263, 107);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// lstNombres
			// 
			this.lstNombres.FormattingEnabled = true;
			this.lstNombres.Location = new System.Drawing.Point(132, 166);
			this.lstNombres.Name = "lstNombres";
			this.lstNombres.Size = new System.Drawing.Size(120, 95);
			this.lstNombres.TabIndex = 4;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(152, 94);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 299);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lstNombres);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnAgregar);
			this.Name = "MainForm";
			this.Text = "DReje1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.ListBox lstNombres;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnAgregar;
	}
}
