namespace ejercicio1_Guia4
{
    partial class frmGuia04ejerc1
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
            this.IbItema = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.nupBase = new System.Windows.Forms.NumericUpDown();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.IstTabla1 = new System.Windows.Forms.ListBox();
            this.IstTabla2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).BeginInit();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // IbItema
            // 
            this.IbItema.AutoSize = true;
            this.IbItema.Location = new System.Drawing.Point(35, 42);
            this.IbItema.Name = "IbItema";
            this.IbItema.Size = new System.Drawing.Size(80, 13);
            this.IbItema.TabIndex = 0;
            this.IbItema.Text = "Ingrese numero";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(38, 133);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(120, 33);
            this.btnCalculo.TabIndex = 1;
            this.btnCalculo.Text = "Ver tablas";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(38, 202);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 31);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Finalizar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // nupBase
            // 
            this.nupBase.Location = new System.Drawing.Point(38, 78);
            this.nupBase.Name = "nupBase";
            this.nupBase.Size = new System.Drawing.Size(120, 20);
            this.nupBase.TabIndex = 3;
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.IstTabla2);
            this.grbResult.Controls.Add(this.IstTabla1);
            this.grbResult.Location = new System.Drawing.Point(211, 31);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(312, 349);
            this.grbResult.TabIndex = 4;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "groupBox1";
            // 
            // IstTabla1
            // 
            this.IstTabla1.FormattingEnabled = true;
            this.IstTabla1.Location = new System.Drawing.Point(15, 19);
            this.IstTabla1.Name = "IstTabla1";
            this.IstTabla1.Size = new System.Drawing.Size(129, 290);
            this.IstTabla1.TabIndex = 5;
            // 
            // IstTabla2
            // 
            this.IstTabla2.FormattingEnabled = true;
            this.IstTabla2.Location = new System.Drawing.Point(161, 19);
            this.IstTabla2.Name = "IstTabla2";
            this.IstTabla2.Size = new System.Drawing.Size(127, 290);
            this.IstTabla2.TabIndex = 6;
            // 
            // frmGuia04ejerc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 392);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.nupBase);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.IbItema);
            this.Name = "frmGuia04ejerc1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGuia04ejerc1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).EndInit();
            this.grbResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbItema;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NumericUpDown nupBase;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.ListBox IstTabla2;
        private System.Windows.Forms.ListBox IstTabla1;
    }
}

