﻿namespace Arreglo
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.lstdesorden = new System.Windows.Forms.ListBox();
            this.lstOrdenada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(12, 29);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(88, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Ingresar Numero:";
            this.lblnumero.Click += new System.EventHandler(this.lblnumero_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(116, 26);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.Lime;
            this.btAgregar.Location = new System.Drawing.Point(339, 26);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btOrdenar
            // 
            this.btOrdenar.BackColor = System.Drawing.Color.Yellow;
            this.btOrdenar.Location = new System.Drawing.Point(339, 75);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btOrdenar.TabIndex = 3;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = false;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // lstdesorden
            // 
            this.lstdesorden.FormattingEnabled = true;
            this.lstdesorden.Location = new System.Drawing.Point(72, 172);
            this.lstdesorden.Name = "lstdesorden";
            this.lstdesorden.Size = new System.Drawing.Size(144, 160);
            this.lstdesorden.TabIndex = 4;
            // 
            // lstOrdenada
            // 
            this.lstOrdenada.FormattingEnabled = true;
            this.lstOrdenada.Location = new System.Drawing.Point(279, 172);
            this.lstOrdenada.Name = "lstOrdenada";
            this.lstOrdenada.Size = new System.Drawing.Size(144, 160);
            this.lstOrdenada.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(465, 383);
            this.Controls.Add(this.lstOrdenada);
            this.Controls.Add(this.lstdesorden);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblnumero);
            this.Name = "Form1";
            this.Text = "Ordenar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.ListBox lstdesorden;
        private System.Windows.Forms.ListBox lstOrdenada;
    }
}

