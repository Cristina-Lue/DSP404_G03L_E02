
namespace MatrizCuadrada
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
            this.textBoxDimension = new System.Windows.Forms.TextBox();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.dataGridViewOriginal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTranspuesta = new System.Windows.Forms.DataGridView();
            this.labelOriginal = new System.Windows.Forms.Label();
            this.labelTranspuesta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranspuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la dimension de la matriz (Cuadrada):";
            // 
            // textBoxDimension
            // 
            this.textBoxDimension.Location = new System.Drawing.Point(259, 23);
            this.textBoxDimension.Name = "textBoxDimension";
            this.textBoxDimension.Size = new System.Drawing.Size(100, 20);
            this.textBoxDimension.TabIndex = 1;
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(194, 79);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerar.TabIndex = 2;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // dataGridViewOriginal
            // 
            this.dataGridViewOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOriginal.Location = new System.Drawing.Point(29, 156);
            this.dataGridViewOriginal.Name = "dataGridViewOriginal";
            this.dataGridViewOriginal.Size = new System.Drawing.Size(270, 187);
            this.dataGridViewOriginal.TabIndex = 3;
            // 
            // dataGridViewTranspuesta
            // 
            this.dataGridViewTranspuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTranspuesta.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTranspuesta.Location = new System.Drawing.Point(333, 156);
            this.dataGridViewTranspuesta.Name = "dataGridViewTranspuesta";
            this.dataGridViewTranspuesta.Size = new System.Drawing.Size(275, 187);
            this.dataGridViewTranspuesta.TabIndex = 4;
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(56, 125);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(76, 13);
            this.labelOriginal.TabIndex = 5;
            this.labelOriginal.Text = "Matriz Original:";
            // 
            // labelTranspuesta
            // 
            this.labelTranspuesta.AutoSize = true;
            this.labelTranspuesta.Location = new System.Drawing.Point(314, 125);
            this.labelTranspuesta.Name = "labelTranspuesta";
            this.labelTranspuesta.Size = new System.Drawing.Size(100, 13);
            this.labelTranspuesta.TabIndex = 6;
            this.labelTranspuesta.Text = "Matriz Transpuesta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 432);
            this.Controls.Add(this.labelTranspuesta);
            this.Controls.Add(this.labelOriginal);
            this.Controls.Add(this.dataGridViewTranspuesta);
            this.Controls.Add(this.dataGridViewOriginal);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.textBoxDimension);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranspuesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDimension;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.DataGridView dataGridViewOriginal;
        private System.Windows.Forms.DataGridView dataGridViewTranspuesta;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelTranspuesta;
    }
}

