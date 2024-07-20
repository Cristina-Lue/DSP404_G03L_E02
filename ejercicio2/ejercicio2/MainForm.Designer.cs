/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 19/07/2024
 * Hora: 14:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ejercicio2
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
			this.gbInformacon = new System.Windows.Forms.GroupBox();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.txtInfo = new System.Windows.Forms.TextBox();
			this.cbtipoinfo = new System.Windows.Forms.ComboBox();
			this.lbedad = new System.Windows.Forms.Label();
			this.Lbdig_info = new System.Windows.Forms.Label();
			this.Lbtipo_info = new System.Windows.Forms.Label();
			this.gbMatriz = new System.Windows.Forms.GroupBox();
			this.dgdatos = new System.Windows.Forms.DataGridView();
			this.gbMantenimiento = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.btPromedio = new System.Windows.Forms.Button();
			this.btLimpiar = new System.Windows.Forms.Button();
			this.btMostrar = new System.Windows.Forms.Button();
			this.btAgregar = new System.Windows.Forms.Button();
			this.gbInformacon.SuspendLayout();
			this.gbMatriz.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
			this.gbMantenimiento.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbInformacon
			// 
			this.gbInformacon.Controls.Add(this.txtEdad);
			this.gbInformacon.Controls.Add(this.txtInfo);
			this.gbInformacon.Controls.Add(this.cbtipoinfo);
			this.gbInformacon.Controls.Add(this.lbedad);
			this.gbInformacon.Controls.Add(this.Lbdig_info);
			this.gbInformacon.Controls.Add(this.Lbtipo_info);
			this.gbInformacon.Location = new System.Drawing.Point(58, 23);
			this.gbInformacon.Name = "gbInformacon";
			this.gbInformacon.Size = new System.Drawing.Size(264, 120);
			this.gbInformacon.TabIndex = 0;
			this.gbInformacon.TabStop = false;
			this.gbInformacon.Text = "Informacion";
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(106, 62);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(121, 20);
			this.txtEdad.TabIndex = 5;
			this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEdadKeyPress);
			// 
			// txtInfo
			// 
			this.txtInfo.Location = new System.Drawing.Point(106, 40);
			this.txtInfo.Name = "txtInfo";
			this.txtInfo.Size = new System.Drawing.Size(121, 20);
			this.txtInfo.TabIndex = 4;
			this.txtInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInfoKeyPress);
			// 
			// cbtipoinfo
			// 
			this.cbtipoinfo.FormattingEnabled = true;
			this.cbtipoinfo.Items.AddRange(new object[] {
									"Nombre",
									"Apellido"});
			this.cbtipoinfo.Location = new System.Drawing.Point(106, 13);
			this.cbtipoinfo.Name = "cbtipoinfo";
			this.cbtipoinfo.Size = new System.Drawing.Size(121, 21);
			this.cbtipoinfo.TabIndex = 3;
			// 
			// lbedad
			// 
			this.lbedad.Location = new System.Drawing.Point(26, 66);
			this.lbedad.Name = "lbedad";
			this.lbedad.Size = new System.Drawing.Size(100, 23);
			this.lbedad.TabIndex = 2;
			this.lbedad.Text = "Edad";
			// 
			// Lbdig_info
			// 
			this.Lbdig_info.Location = new System.Drawing.Point(6, 43);
			this.Lbdig_info.Name = "Lbdig_info";
			this.Lbdig_info.Size = new System.Drawing.Size(106, 23);
			this.Lbdig_info.TabIndex = 1;
			this.Lbdig_info.Text = "Digite la información";
			// 
			// Lbtipo_info
			// 
			this.Lbtipo_info.Location = new System.Drawing.Point(6, 16);
			this.Lbtipo_info.Name = "Lbtipo_info";
			this.Lbtipo_info.Size = new System.Drawing.Size(100, 23);
			this.Lbtipo_info.TabIndex = 0;
			this.Lbtipo_info.Text = "Tipo de información";
			// 
			// gbMatriz
			// 
			this.gbMatriz.Controls.Add(this.dgdatos);
			this.gbMatriz.Location = new System.Drawing.Point(58, 149);
			this.gbMatriz.Name = "gbMatriz";
			this.gbMatriz.Size = new System.Drawing.Size(592, 192);
			this.gbMatriz.TabIndex = 1;
			this.gbMatriz.TabStop = false;
			this.gbMatriz.Text = "Matriz";
			// 
			// dgdatos
			// 
			this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgdatos.Location = new System.Drawing.Point(17, 19);
			this.dgdatos.Name = "dgdatos";
			this.dgdatos.Size = new System.Drawing.Size(569, 167);
			this.dgdatos.TabIndex = 0;
			// 
			// gbMantenimiento
			// 
			this.gbMantenimiento.Controls.Add(this.button5);
			this.gbMantenimiento.Controls.Add(this.btPromedio);
			this.gbMantenimiento.Controls.Add(this.btLimpiar);
			this.gbMantenimiento.Controls.Add(this.btMostrar);
			this.gbMantenimiento.Controls.Add(this.btAgregar);
			this.gbMantenimiento.Location = new System.Drawing.Point(365, 23);
			this.gbMantenimiento.Name = "gbMantenimiento";
			this.gbMantenimiento.Size = new System.Drawing.Size(285, 120);
			this.gbMantenimiento.TabIndex = 1;
			this.gbMantenimiento.TabStop = false;
			this.gbMantenimiento.Text = "Mantenimientos";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Pink;
			this.button5.Location = new System.Drawing.Point(97, 91);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "Salir";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// btPromedio
			// 
			this.btPromedio.BackColor = System.Drawing.Color.Gold;
			this.btPromedio.Location = new System.Drawing.Point(154, 60);
			this.btPromedio.Name = "btPromedio";
			this.btPromedio.Size = new System.Drawing.Size(75, 23);
			this.btPromedio.TabIndex = 3;
			this.btPromedio.Text = "Promedio";
			this.btPromedio.UseVisualStyleBackColor = false;
			this.btPromedio.Click += new System.EventHandler(this.BtPromedioClick);
			// 
			// btLimpiar
			// 
			this.btLimpiar.BackColor = System.Drawing.Color.PeachPuff;
			this.btLimpiar.Location = new System.Drawing.Point(39, 60);
			this.btLimpiar.Name = "btLimpiar";
			this.btLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btLimpiar.TabIndex = 2;
			this.btLimpiar.Text = "Limpiar Matriz";
			this.btLimpiar.UseVisualStyleBackColor = false;
			this.btLimpiar.Click += new System.EventHandler(this.BtLimpiarClick);
			// 
			// btMostrar
			// 
			this.btMostrar.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.btMostrar.Location = new System.Drawing.Point(154, 20);
			this.btMostrar.Name = "btMostrar";
			this.btMostrar.Size = new System.Drawing.Size(75, 23);
			this.btMostrar.TabIndex = 1;
			this.btMostrar.Text = "Mostrar Matriz";
			this.btMostrar.UseVisualStyleBackColor = false;
			this.btMostrar.Click += new System.EventHandler(this.BtMostrarClick);
			// 
			// btAgregar
			// 
			this.btAgregar.BackColor = System.Drawing.Color.Red;
			this.btAgregar.Location = new System.Drawing.Point(39, 19);
			this.btAgregar.Name = "btAgregar";
			this.btAgregar.Size = new System.Drawing.Size(75, 23);
			this.btAgregar.TabIndex = 0;
			this.btAgregar.Text = "Agregar";
			this.btAgregar.UseVisualStyleBackColor = false;
			this.btAgregar.Click += new System.EventHandler(this.BtAgregarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Chocolate;
			this.ClientSize = new System.Drawing.Size(781, 353);
			this.Controls.Add(this.gbMantenimiento);
			this.Controls.Add(this.gbMatriz);
			this.Controls.Add(this.gbInformacon);
			this.Name = "MainForm";
			this.Text = "ejercicio2";
			this.gbInformacon.ResumeLayout(false);
			this.gbInformacon.PerformLayout();
			this.gbMatriz.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
			this.gbMantenimiento.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btAgregar;
		private System.Windows.Forms.Button btMostrar;
		private System.Windows.Forms.Button btLimpiar;
		private System.Windows.Forms.Button btPromedio;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox gbMantenimiento;
		private System.Windows.Forms.DataGridView dgdatos;
		private System.Windows.Forms.GroupBox gbMatriz;
		private System.Windows.Forms.Label Lbtipo_info;
		private System.Windows.Forms.Label Lbdig_info;
		private System.Windows.Forms.Label lbedad;
		private System.Windows.Forms.ComboBox cbtipoinfo;
		private System.Windows.Forms.TextBox txtInfo;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.GroupBox gbInformacon;
	}
}
