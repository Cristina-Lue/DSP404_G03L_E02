namespace ejercicio2_Guia4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudN1 = new System.Windows.Forms.NumericUpDown();
            this.nudN2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperaciones = new System.Windows.Forms.ComboBox();
            this.IblResul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Uno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Dos";
            // 
            // nudN1
            // 
            this.nudN1.Location = new System.Drawing.Point(204, 82);
            this.nudN1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudN1.Name = "nudN1";
            this.nudN1.Size = new System.Drawing.Size(160, 22);
            this.nudN1.TabIndex = 2;
            // 
            // nudN2
            // 
            this.nudN2.Location = new System.Drawing.Point(204, 149);
            this.nudN2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudN2.Name = "nudN2";
            this.nudN2.Size = new System.Drawing.Size(160, 22);
            this.nudN2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opciones Disponibles";
            // 
            // cmbOperaciones
            // 
            this.cmbOperaciones.FormattingEnabled = true;
            this.cmbOperaciones.Location = new System.Drawing.Point(432, 151);
            this.cmbOperaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOperaciones.Name = "cmbOperaciones";
            this.cmbOperaciones.Size = new System.Drawing.Size(160, 24);
            this.cmbOperaciones.TabIndex = 5;
            this.cmbOperaciones.SelectedIndexChanged += new System.EventHandler(this.cmbOperaciones_SelectedIndexChanged);
            // 
            // IblResul
            // 
            this.IblResul.AutoSize = true;
            this.IblResul.Location = new System.Drawing.Point(200, 258);
            this.IblResul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IblResul.Name = "IblResul";
            this.IblResul.Size = new System.Drawing.Size(44, 16);
            this.IblResul.TabIndex = 6;
            this.IblResul.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 372);
            this.Controls.Add(this.IblResul);
            this.Controls.Add(this.cmbOperaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudN2);
            this.Controls.Add(this.nudN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudN1;
        private System.Windows.Forms.NumericUpDown nudN2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperaciones;
        private System.Windows.Forms.Label IblResul;
    }
}

