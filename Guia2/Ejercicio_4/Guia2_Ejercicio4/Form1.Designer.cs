namespace Guia2_Ejercicio4
{
    partial class frmULAM
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
            label2 = new Label();
            lstLista = new ListBox();
            txtNumero = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnFin = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(452, 104);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(132, 20);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Suseción de ULAM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 43);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese un número positivo:";
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(311, 140);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(397, 164);
            lstLista.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(311, 43);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(397, 27);
            txtNumero.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(113, 140);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "&Calcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(111, 205);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(113, 276);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(94, 29);
            btnFin.TabIndex = 6;
            btnFin.Text = "&Salir";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // frmULAM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFin);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero);
            Controls.Add(lstLista);
            Controls.Add(label2);
            Controls.Add(lblNumero);
            Name = "frmULAM";
            Text = "Suseción de ULAM";
            Load += frmULAM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label label2;
        private ListBox lstLista;
        private TextBox txtNumero;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnFin;
    }
}
