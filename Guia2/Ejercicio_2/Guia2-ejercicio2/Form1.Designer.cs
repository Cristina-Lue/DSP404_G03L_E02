namespace Guia2_ejercicio2
{
    partial class frmCesar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lbltexto = new System.Windows.Forms.Label();
            this.lblllave = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.grOpcion = new System.Windows.Forms.GroupBox();
            this.rdbDesencriptar = new System.Windows.Forms.RadioButton();
            this.rdbEncriptar = new System.Windows.Forms.RadioButton();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(365, 27);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(203, 16);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Encriptamiento por código César";
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(115, 75);
            this.lbltexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(237, 16);
            this.lbltexto.TabIndex = 1;
            this.lbltexto.Text = "Ingrese el texto a Encriptar/Dsencriptar\r\n";
            this.lbltexto.Click += new System.EventHandler(this.lbltexto_Click);
            // 
            // lblllave
            // 
            this.lblllave.AutoSize = true;
            this.lblllave.Location = new System.Drawing.Point(580, 75);
            this.lblllave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblllave.Name = "lblllave";
            this.lblllave.Size = new System.Drawing.Size(192, 16);
            this.lblllave.TabIndex = 2;
            this.lblllave.Text = "Llave (Digite un número entero)";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(115, 369);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 16);
            this.lblresultado.TabIndex = 3;
            // 
            // grOpcion
            // 
            this.grOpcion.Controls.Add(this.rdbDesencriptar);
            this.grOpcion.Controls.Add(this.rdbEncriptar);
            this.grOpcion.Location = new System.Drawing.Point(89, 263);
            this.grOpcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grOpcion.Name = "grOpcion";
            this.grOpcion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grOpcion.Size = new System.Drawing.Size(520, 74);
            this.grOpcion.TabIndex = 4;
            this.grOpcion.TabStop = false;
            this.grOpcion.Text = "Seleccione una opción";
            // 
            // rdbDesencriptar
            // 
            this.rdbDesencriptar.AutoSize = true;
            this.rdbDesencriptar.Location = new System.Drawing.Point(316, 37);
            this.rdbDesencriptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbDesencriptar.Name = "rdbDesencriptar";
            this.rdbDesencriptar.Size = new System.Drawing.Size(105, 20);
            this.rdbDesencriptar.TabIndex = 1;
            this.rdbDesencriptar.Text = "Desencriptar";
            this.rdbDesencriptar.UseVisualStyleBackColor = true;
            this.rdbDesencriptar.CheckedChanged += new System.EventHandler(this.rdbDesencriptar_CheckedChanged);
            // 
            // rdbEncriptar
            // 
            this.rdbEncriptar.AutoSize = true;
            this.rdbEncriptar.Checked = true;
            this.rdbEncriptar.Location = new System.Drawing.Point(29, 37);
            this.rdbEncriptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbEncriptar.Name = "rdbEncriptar";
            this.rdbEncriptar.Size = new System.Drawing.Size(81, 20);
            this.rdbEncriptar.TabIndex = 0;
            this.rdbEncriptar.TabStop = true;
            this.rdbEncriptar.Text = "Encriptar";
            this.rdbEncriptar.UseVisualStyleBackColor = true;
            this.rdbEncriptar.CheckedChanged += new System.EventHandler(this.rdbEncriptar_CheckedChanged);
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(795, 75);
            this.txtLlave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLlave.Multiline = true;
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(132, 20);
            this.txtLlave.TabIndex = 5;
            this.txtLlave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(119, 119);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(719, 117);
            this.txtTexto.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(119, 405);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(749, 133);
            this.txtResultado.TabIndex = 7;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(687, 263);
            this.btnEncriptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(100, 28);
            this.btnEncriptar.TabIndex = 8;
            this.btnEncriptar.Text = "&Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEbcriptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(687, 300);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(687, 337);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.txtLlave);
            this.Controls.Add(this.grOpcion);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblllave);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.lbltitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCesar";
            this.Text = "Encriptador/Desencriptador de codigo de Cesar";
            this.Load += new System.EventHandler(this.frmCesar_Load);
            this.grOpcion.ResumeLayout(false);
            this.grOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Label lblllave;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.GroupBox grOpcion;
        private System.Windows.Forms.RadioButton rdbDesencriptar;
        private System.Windows.Forms.RadioButton rdbEncriptar;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

