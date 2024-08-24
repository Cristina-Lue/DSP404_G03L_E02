/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 23/08/2024
 * Hora: 18:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Guia5Mej
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpfechanacc;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.Label lblfechanac;
		private System.Windows.Forms.Label lblapellidos;
		private System.Windows.Forms.Label lblnombres;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DomainUpDown nudisss;
		private System.Windows.Forms.DomainUpDown nudrenta;
		private System.Windows.Forms.TextBox txtsueldoini;
		private System.Windows.Forms.DateTimePicker dtpfechacontrato;
		private System.Windows.Forms.Label lblSSS;
		private System.Windows.Forms.Label lblsueldo;
		private System.Windows.Forms.Label lblrenta;
		private System.Windows.Forms.Label lblcontrato;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnabrirplantilla;
		private System.Windows.Forms.Button btngenerarplantilla;
		private System.Windows.Forms.DataGridView dataGridView1;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpfechanacc = new System.Windows.Forms.DateTimePicker();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.lblfechanac = new System.Windows.Forms.Label();
			this.lblapellidos = new System.Windows.Forms.Label();
			this.lblnombres = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.nudisss = new System.Windows.Forms.DomainUpDown();
			this.nudrenta = new System.Windows.Forms.DomainUpDown();
			this.txtsueldoini = new System.Windows.Forms.TextBox();
			this.dtpfechacontrato = new System.Windows.Forms.DateTimePicker();
			this.lblSSS = new System.Windows.Forms.Label();
			this.lblsueldo = new System.Windows.Forms.Label();
			this.lblrenta = new System.Windows.Forms.Label();
			this.lblcontrato = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnabrirplantilla = new System.Windows.Forms.Button();
			this.btngenerarplantilla = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpfechanacc);
			this.groupBox1.Controls.Add(this.txtApellidos);
			this.groupBox1.Controls.Add(this.txtNombres);
			this.groupBox1.Controls.Add(this.lblfechanac);
			this.groupBox1.Controls.Add(this.lblapellidos);
			this.groupBox1.Controls.Add(this.lblnombres);
			this.groupBox1.Location = new System.Drawing.Point(12, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(269, 134);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos personales de";
			// 
			// dtpfechanacc
			// 
			this.dtpfechanacc.Location = new System.Drawing.Point(117, 79);
			this.dtpfechanacc.Name = "dtpfechanacc";
			this.dtpfechanacc.Size = new System.Drawing.Size(129, 20);
			this.dtpfechanacc.TabIndex = 5;
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(61, 46);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(100, 20);
			this.txtApellidos.TabIndex = 4;
			this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidosKeyPress);
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(61, 20);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(100, 20);
			this.txtNombres.TabIndex = 3;
			this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombresKeyPress);
			// 
			// lblfechanac
			// 
			this.lblfechanac.Location = new System.Drawing.Point(7, 79);
			this.lblfechanac.Name = "lblfechanac";
			this.lblfechanac.Size = new System.Drawing.Size(129, 23);
			this.lblfechanac.TabIndex = 2;
			this.lblfechanac.Text = "Fecha de Nacimiento:";
			// 
			// lblapellidos
			// 
			this.lblapellidos.Location = new System.Drawing.Point(6, 43);
			this.lblapellidos.Name = "lblapellidos";
			this.lblapellidos.Size = new System.Drawing.Size(100, 23);
			this.lblapellidos.TabIndex = 1;
			this.lblapellidos.Text = "Apellidos:";
			// 
			// lblnombres
			// 
			this.lblnombres.Location = new System.Drawing.Point(7, 20);
			this.lblnombres.Name = "lblnombres";
			this.lblnombres.Size = new System.Drawing.Size(100, 23);
			this.lblnombres.TabIndex = 0;
			this.lblnombres.Text = "Nombres:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.nudisss);
			this.groupBox2.Controls.Add(this.nudrenta);
			this.groupBox2.Controls.Add(this.txtsueldoini);
			this.groupBox2.Controls.Add(this.dtpfechacontrato);
			this.groupBox2.Controls.Add(this.lblSSS);
			this.groupBox2.Controls.Add(this.lblsueldo);
			this.groupBox2.Controls.Add(this.lblrenta);
			this.groupBox2.Controls.Add(this.lblcontrato);
			this.groupBox2.Location = new System.Drawing.Point(338, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(321, 134);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// nudisss
			// 
			this.nudisss.Location = new System.Drawing.Point(83, 103);
			this.nudisss.Name = "nudisss";
			this.nudisss.Size = new System.Drawing.Size(120, 20);
			this.nudisss.TabIndex = 10;
			this.nudisss.Text = "domainUpDown2";
			this.nudisss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudisssKeyPress);
			// 
			// nudrenta
			// 
			this.nudrenta.Location = new System.Drawing.Point(83, 68);
			this.nudrenta.Name = "nudrenta";
			this.nudrenta.Size = new System.Drawing.Size(120, 20);
			this.nudrenta.TabIndex = 9;
			this.nudrenta.Text = "domainUpDown1";
			this.nudrenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NudrentaKeyPress);
			// 
			// txtsueldoini
			// 
			this.txtsueldoini.Location = new System.Drawing.Point(89, 40);
			this.txtsueldoini.Name = "txtsueldoini";
			this.txtsueldoini.Size = new System.Drawing.Size(100, 20);
			this.txtsueldoini.TabIndex = 6;
			this.txtsueldoini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtsueldoiniKeyPress);
			// 
			// dtpfechacontrato
			// 
			this.dtpfechacontrato.Location = new System.Drawing.Point(83, 19);
			this.dtpfechacontrato.Name = "dtpfechacontrato";
			this.dtpfechacontrato.Size = new System.Drawing.Size(154, 20);
			this.dtpfechacontrato.TabIndex = 6;
			// 
			// lblSSS
			// 
			this.lblSSS.Location = new System.Drawing.Point(6, 105);
			this.lblSSS.Name = "lblSSS";
			this.lblSSS.Size = new System.Drawing.Size(100, 23);
			this.lblSSS.TabIndex = 8;
			this.lblSSS.Text = "Tasa ISSS:";
			// 
			// lblsueldo
			// 
			this.lblsueldo.Location = new System.Drawing.Point(0, 42);
			this.lblsueldo.Name = "lblsueldo";
			this.lblsueldo.Size = new System.Drawing.Size(100, 18);
			this.lblsueldo.TabIndex = 7;
			this.lblsueldo.Text = "Sueldo base:";
			// 
			// lblrenta
			// 
			this.lblrenta.Location = new System.Drawing.Point(6, 70);
			this.lblrenta.Name = "lblrenta";
			this.lblrenta.Size = new System.Drawing.Size(100, 23);
			this.lblrenta.TabIndex = 7;
			this.lblrenta.Text = "Tasa Renta:";
			// 
			// lblcontrato
			// 
			this.lblcontrato.Location = new System.Drawing.Point(0, 20);
			this.lblcontrato.Name = "lblcontrato";
			this.lblcontrato.Size = new System.Drawing.Size(100, 23);
			this.lblcontrato.TabIndex = 6;
			this.lblcontrato.Text = "Fecha contrato:";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(46, 203);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(102, 23);
			this.btnNuevo.TabIndex = 2;
			this.btnNuevo.Text = "Nuevo empleado";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(168, 203);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(113, 23);
			this.btnAceptar.TabIndex = 3;
			this.btnAceptar.Text = "proximo empleado";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnabrirplantilla
			// 
			this.btnabrirplantilla.Location = new System.Drawing.Point(307, 203);
			this.btnabrirplantilla.Name = "btnabrirplantilla";
			this.btnabrirplantilla.Size = new System.Drawing.Size(75, 23);
			this.btnabrirplantilla.TabIndex = 4;
			this.btnabrirplantilla.Text = "abrir plantilla";
			this.btnabrirplantilla.UseVisualStyleBackColor = true;
			this.btnabrirplantilla.Click += new System.EventHandler(this.BtnabrirplantillaClick);
			// 
			// btngenerarplantilla
			// 
			this.btngenerarplantilla.Location = new System.Drawing.Point(452, 203);
			this.btngenerarplantilla.Name = "btngenerarplantilla";
			this.btngenerarplantilla.Size = new System.Drawing.Size(89, 23);
			this.btngenerarplantilla.TabIndex = 5;
			this.btngenerarplantilla.Text = "generar plantilla";
			this.btngenerarplantilla.UseVisualStyleBackColor = true;
			this.btngenerarplantilla.Click += new System.EventHandler(this.BtngenerarplantillaClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(46, 254);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(535, 150);
			this.dataGridView1.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 416);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btngenerarplantilla);
			this.Controls.Add(this.btnabrirplantilla);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Guia5Mej";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
