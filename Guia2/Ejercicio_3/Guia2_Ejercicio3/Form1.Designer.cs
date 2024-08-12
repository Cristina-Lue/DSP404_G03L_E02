namespace Guia2_Ejercicio3
{
    partial class frmReves
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtReves = new TextBox();
            lblReves = new Label();
            btnCalcular = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(92, 49);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(92, 89);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(615, 27);
            txtNumero.TabIndex = 1;
            // 
            // txtReves
            // 
            txtReves.Location = new Point(92, 206);
            txtReves.Name = "txtReves";
            txtReves.Size = new Size(615, 27);
            txtReves.TabIndex = 2;
            // 
            // lblReves
            // 
            lblReves.AutoSize = true;
            lblReves.Location = new Point(92, 158);
            lblReves.Name = "lblReves";
            lblReves.Size = new Size(64, 20);
            lblReves.TabIndex = 3;
            lblReves.Text = "Al reves:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(201, 324);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "&Calcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(511, 324);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(355, 324);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmReves
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(lblReves);
            Controls.Add(txtReves);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "frmReves";
            Text = "Mostrar un número al reves";
            Load += frmReves_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtReves;
        private Label lblReves;
        private Button btnCalcular;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}
