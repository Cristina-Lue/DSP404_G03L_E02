
namespace numeros
{
    partial class Form1
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPorcentajeCeros = new System.Windows.Forms.Label();
            this.lblPorcentajePositivos = new System.Windows.Forms.Label();
            this.lblPorcentajeNegativos = new System.Windows.Forms.Label();
            this.lblCantidadPositivos = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblMayorNegativo = new System.Windows.Forms.Label();
            this.lblPromediosNegativos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(144, 36);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el numero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPorcentajeCeros
            // 
            this.lblPorcentajeCeros.AutoSize = true;
            this.lblPorcentajeCeros.Location = new System.Drawing.Point(12, 93);
            this.lblPorcentajeCeros.Name = "lblPorcentajeCeros";
            this.lblPorcentajeCeros.Size = new System.Drawing.Size(103, 13);
            this.lblPorcentajeCeros.TabIndex = 2;
            this.lblPorcentajeCeros.Text = "Porcentaje de Ceros";
            this.lblPorcentajeCeros.Click += new System.EventHandler(this.lblPorcentajeCeros_Click);
            // 
            // lblPorcentajePositivos
            // 
            this.lblPorcentajePositivos.AutoSize = true;
            this.lblPorcentajePositivos.Location = new System.Drawing.Point(200, 93);
            this.lblPorcentajePositivos.Name = "lblPorcentajePositivos";
            this.lblPorcentajePositivos.Size = new System.Drawing.Size(103, 13);
            this.lblPorcentajePositivos.TabIndex = 3;
            this.lblPorcentajePositivos.Text = "Porcentaje Positivos";
            this.lblPorcentajePositivos.Click += new System.EventHandler(this.lblPorcentajePositivos_Click);
            // 
            // lblPorcentajeNegativos
            // 
            this.lblPorcentajeNegativos.AutoSize = true;
            this.lblPorcentajeNegativos.Location = new System.Drawing.Point(374, 93);
            this.lblPorcentajeNegativos.Name = "lblPorcentajeNegativos";
            this.lblPorcentajeNegativos.Size = new System.Drawing.Size(109, 13);
            this.lblPorcentajeNegativos.TabIndex = 4;
            this.lblPorcentajeNegativos.Text = "Porcentaje Negativos";
            this.lblPorcentajeNegativos.Click += new System.EventHandler(this.lblPorcentajeNegativos_Click);
            // 
            // lblCantidadPositivos
            // 
            this.lblCantidadPositivos.AutoSize = true;
            this.lblCantidadPositivos.Location = new System.Drawing.Point(12, 131);
            this.lblCantidadPositivos.Name = "lblCantidadPositivos";
            this.lblCantidadPositivos.Size = new System.Drawing.Size(94, 13);
            this.lblCantidadPositivos.TabIndex = 5;
            this.lblCantidadPositivos.Text = "Cantidad Positivos";
            this.lblCantidadPositivos.Click += new System.EventHandler(this.lblCantidadPositivos_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(268, 36);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblMayorNegativo
            // 
            this.lblMayorNegativo.AutoSize = true;
            this.lblMayorNegativo.Location = new System.Drawing.Point(200, 131);
            this.lblMayorNegativo.Name = "lblMayorNegativo";
            this.lblMayorNegativo.Size = new System.Drawing.Size(82, 13);
            this.lblMayorNegativo.TabIndex = 7;
            this.lblMayorNegativo.Text = "Mayor Negativo";
            this.lblMayorNegativo.Click += new System.EventHandler(this.lblMayorNegativo_Click);
            // 
            // lblPromediosNegativos
            // 
            this.lblPromediosNegativos.AutoSize = true;
            this.lblPromediosNegativos.Location = new System.Drawing.Point(374, 131);
            this.lblPromediosNegativos.Name = "lblPromediosNegativos";
            this.lblPromediosNegativos.Size = new System.Drawing.Size(82, 13);
            this.lblPromediosNegativos.TabIndex = 8;
            this.lblPromediosNegativos.Text = "Mayor Negativo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 374);
            this.Controls.Add(this.lblPromediosNegativos);
            this.Controls.Add(this.lblMayorNegativo);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblCantidadPositivos);
            this.Controls.Add(this.lblPorcentajeNegativos);
            this.Controls.Add(this.lblPorcentajePositivos);
            this.Controls.Add(this.lblPorcentajeCeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPorcentajeCeros;
        private System.Windows.Forms.Label lblPorcentajePositivos;
        private System.Windows.Forms.Label lblPorcentajeNegativos;
        private System.Windows.Forms.Label lblCantidadPositivos;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblMayorNegativo;
        private System.Windows.Forms.Label lblPromediosNegativos;
    }
}

