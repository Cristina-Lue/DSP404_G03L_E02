namespace Ejemplo_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnContar = new Button();
            btnReinicio = new Button();
            btnSalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnContar
            // 
            btnContar.Location = new Point(119, 75);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(94, 29);
            btnContar.TabIndex = 0;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnReinicio
            // 
            btnReinicio.Location = new Point(465, 75);
            btnReinicio.Name = "btnReinicio";
            btnReinicio.Size = new Size(133, 29);
            btnReinicio.TabIndex = 1;
            btnReinicio.Text = "Reiniciar conteo";
            btnReinicio.UseVisualStyleBackColor = true;
            btnReinicio.Click += btnReinicio_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(465, 227);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir programa ";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 167);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(720, 388);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnReinicio);
            Controls.Add(btnContar);
            Name = "Form1";
            Text = "Pruebas de ámbito de variables";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContar;
        private Button btnReinicio;
        private Button btnSalir;
        private Label label1;
    }
}
