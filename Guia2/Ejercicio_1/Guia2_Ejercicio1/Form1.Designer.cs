namespace Guia2_Ejercicio1
{
    partial class frmFactorial
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
            btnCalcular = new Button();
            btnFin = new Button();
            lblNumero = new Label();
            lblFactorial = new Label();
            txtNumero = new TextBox();
            txtFactorial = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(220, 257);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "&Calcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(469, 257);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(94, 29);
            btnFin.TabIndex = 1;
            btnFin.Text = "&Salir";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(244, 72);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(70, 20);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número: ";
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Location = new Point(479, 72);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(68, 20);
            lblFactorial.TabIndex = 3;
            lblFactorial.Text = "Factorial:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(211, 152);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 4;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // txtFactorial
            // 
            txtFactorial.Enabled = false;
            txtFactorial.Location = new Point(455, 152);
            txtFactorial.Name = "txtFactorial";
            txtFactorial.Size = new Size(125, 27);
            txtFactorial.TabIndex = 5;
            // 
            // frmFactorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 439);
            Controls.Add(txtFactorial);
            Controls.Add(txtNumero);
            Controls.Add(lblFactorial);
            Controls.Add(lblNumero);
            Controls.Add(btnFin);
            Controls.Add(btnCalcular);
            Name = "frmFactorial";
            Text = "Calculando el factorial de un número";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnFin;
        private Label lblNumero;
        private Label lblFactorial;
        private TextBox txtNumero;
        private TextBox txtFactorial;
    }
}
