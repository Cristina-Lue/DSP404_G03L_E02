/*
 * Created by SharpDevelop.
 * User: MINED
 * Date: 12/08/2024
 * Time: 15:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Eje4
{
	partial class Form2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.TextBox txtdias;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtmontoh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtmontos;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtmontot;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtinteres;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nUDpagar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.txtdias = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtmontoh = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtmontos = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtmontot = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtinteres = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.nUDpagar = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nUDpagar)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Apellidos y Nombres";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Dias de hospedaje";
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(129, 25);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(100, 20);
			this.txtnombre.TabIndex = 2;
			// 
			// txtdias
			// 
			this.txtdias.Location = new System.Drawing.Point(127, 63);
			this.txtdias.Name = "txtdias";
			this.txtdias.Size = new System.Drawing.Size(100, 20);
			this.txtdias.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(35, 137);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(7, 50);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Delegado";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(7, 20);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Turista";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBox3);
			this.groupBox2.Controls.Add(this.checkBox2);
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Location = new System.Drawing.Point(204, 137);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(136, 121);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Servicios";
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(16, 78);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(104, 24);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Bar libre";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(16, 48);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Telefono\\Fax";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(16, 21);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Cable";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 278);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Monto de hospedaje";
			// 
			// txtmontoh
			// 
			this.txtmontoh.Location = new System.Drawing.Point(127, 275);
			this.txtmontoh.Name = "txtmontoh";
			this.txtmontoh.Size = new System.Drawing.Size(100, 20);
			this.txtmontoh.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(21, 310);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Monto de servicio";
			// 
			// txtmontos
			// 
			this.txtmontos.Location = new System.Drawing.Point(127, 306);
			this.txtmontos.Name = "txtmontos";
			this.txtmontos.Size = new System.Drawing.Size(100, 20);
			this.txtmontos.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 340);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Monto total";
			// 
			// txtmontot
			// 
			this.txtmontot.Location = new System.Drawing.Point(127, 337);
			this.txtmontot.Name = "txtmontot";
			this.txtmontot.Size = new System.Drawing.Size(100, 20);
			this.txtmontot.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(233, 275);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "label6";
			// 
			// txtinteres
			// 
			this.txtinteres.Location = new System.Drawing.Point(275, 272);
			this.txtinteres.Name = "txtinteres";
			this.txtinteres.Size = new System.Drawing.Size(100, 20);
			this.txtinteres.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(224, 303);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "label7";
			// 
			// nUDpagar
			// 
			this.nUDpagar.DecimalPlaces = 2;
			this.nUDpagar.Location = new System.Drawing.Point(275, 301);
			this.nUDpagar.Name = "nUDpagar";
			this.nUDpagar.Size = new System.Drawing.Size(120, 20);
			this.nUDpagar.TabIndex = 15;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(300, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(300, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "Nuevo";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(300, 70);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 18;
			this.button3.Text = "Acerca...";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(300, 99);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 19;
			this.button4.Text = "Salir";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 372);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.nUDpagar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtinteres);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtmontot);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtmontos);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtmontoh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtdias);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nUDpagar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
