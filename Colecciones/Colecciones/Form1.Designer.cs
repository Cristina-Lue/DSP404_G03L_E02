
namespace Colecciones
{
    partial class Formulario
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
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.txtSignificado = new System.Windows.Forms.TextBox();
            this.lblpalabra = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.Location = new System.Drawing.Point(41, 26);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(156, 238);
            this.lstPalabras.TabIndex = 0;
            this.lstPalabras.SelectedIndexChanged += new System.EventHandler(this.lstPalabras_SelectedIndexChanged);
            // 
            // txtSignificado
            // 
            this.txtSignificado.Enabled = false;
            this.txtSignificado.Location = new System.Drawing.Point(216, 138);
            this.txtSignificado.Multiline = true;
            this.txtSignificado.Name = "txtSignificado";
            this.txtSignificado.Size = new System.Drawing.Size(215, 126);
            this.txtSignificado.TabIndex = 1;
            this.txtSignificado.TextChanged += new System.EventHandler(this.txtSignificado_TextChanged);
            // 
            // lblpalabra
            // 
            this.lblpalabra.AutoSize = true;
            this.lblpalabra.Location = new System.Drawing.Point(213, 44);
            this.lblpalabra.Name = "lblpalabra";
            this.lblpalabra.Size = new System.Drawing.Size(43, 13);
            this.lblpalabra.TabIndex = 2;
            this.lblpalabra.Text = "Palabra";
            this.lblpalabra.Click += new System.EventHandler(this.lblpalabra_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(123, 303);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(209, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(463, 376);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblpalabra);
            this.Controls.Add(this.txtSignificado);
            this.Controls.Add(this.lstPalabras);
            this.Name = "Formulario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.TextBox txtSignificado;
        private System.Windows.Forms.Label lblpalabra;
        private System.Windows.Forms.Button btnsalir;
    }
}

