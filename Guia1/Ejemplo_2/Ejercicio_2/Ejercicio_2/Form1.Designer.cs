namespace Ejercicio_2
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
            lblEmpresa = new Label();
            lblMonto = new Label();
            lblTiempo = new Label();
            lblTasaInter = new Label();
            txtEmpresa = new TextBox();
            txtMonto = new TextBox();
            txtTiempo = new TextBox();
            rdbInteres1 = new RadioButton();
            rdbInteres2 = new RadioButton();
            rdbInteres3 = new RadioButton();
            txtTasaInterEX = new TextBox();
            lstResul = new ListBox();
            btnAnalisis = new Button();
            btnFin = new Button();
            SuspendLayout();
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(12, 50);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(153, 20);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Nombre de Empresa: ";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(12, 115);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(142, 20);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "Monto prestamo ($)";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(427, 115);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(109, 20);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo (años) ";
            // 
            // lblTasaInter
            // 
            lblTasaInter.AutoSize = true;
            lblTasaInter.Location = new Point(22, 181);
            lblTasaInter.Name = "lblTasaInter";
            lblTasaInter.Size = new Size(113, 20);
            lblTasaInter.TabIndex = 3;
            lblTasaInter.Text = "Tasa de Interes: ";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(162, 47);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(603, 27);
            txtEmpresa.TabIndex = 4;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(162, 111);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(246, 27);
            txtMonto.TabIndex = 5;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(542, 111);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(223, 27);
            txtTiempo.TabIndex = 6;
            txtTiempo.Text = "2";
            // 
            // rdbInteres1
            // 
            rdbInteres1.AutoSize = true;
            rdbInteres1.Checked = true;
            rdbInteres1.Location = new Point(134, 181);
            rdbInteres1.Name = "rdbInteres1";
            rdbInteres1.Size = new Size(58, 24);
            rdbInteres1.TabIndex = 7;
            rdbInteres1.TabStop = true;
            rdbInteres1.Text = "12%";
            rdbInteres1.UseVisualStyleBackColor = true;
            rdbInteres1.CheckedChanged += rdbInteres1_CheckedChanged;
            // 
            // rdbInteres2
            // 
            rdbInteres2.AutoSize = true;
            rdbInteres2.Location = new Point(230, 181);
            rdbInteres2.Name = "rdbInteres2";
            rdbInteres2.Size = new Size(69, 24);
            rdbInteres2.TabIndex = 8;
            rdbInteres2.Text = "23.5%";
            rdbInteres2.UseVisualStyleBackColor = true;
            rdbInteres2.CheckedChanged += rdbInteres2_CheckedChanged;
            // 
            // rdbInteres3
            // 
            rdbInteres3.AutoSize = true;
            rdbInteres3.Location = new Point(380, 179);
            rdbInteres3.Name = "rdbInteres3";
            rdbInteres3.Size = new Size(120, 24);
            rdbInteres3.TabIndex = 9;
            rdbInteres3.Text = "Otro, Indique:";
            rdbInteres3.UseVisualStyleBackColor = true;
            rdbInteres3.CheckedChanged += rdbInteres3_CheckedChanged;
            // 
            // txtTasaInterEX
            // 
            txtTasaInterEX.Enabled = false;
            txtTasaInterEX.Location = new Point(528, 178);
            txtTasaInterEX.Name = "txtTasaInterEX";
            txtTasaInterEX.Size = new Size(225, 27);
            txtTasaInterEX.TabIndex = 10;
            // 
            // lstResul
            // 
            lstResul.Enabled = false;
            lstResul.FormattingEnabled = true;
            lstResul.Location = new Point(50, 251);
            lstResul.Name = "lstResul";
            lstResul.Size = new Size(683, 104);
            lstResul.TabIndex = 11;
            // 
            // btnAnalisis
            // 
            btnAnalisis.Location = new Point(202, 389);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(154, 29);
            btnAnalisis.TabIndex = 12;
            btnAnalisis.Text = "Análisis Financiero ";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(399, 389);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(149, 29);
            btnFin.TabIndex = 13;
            btnFin.Text = "Salir del programa ";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFin);
            Controls.Add(btnAnalisis);
            Controls.Add(lstResul);
            Controls.Add(txtTasaInterEX);
            Controls.Add(rdbInteres3);
            Controls.Add(rdbInteres2);
            Controls.Add(rdbInteres1);
            Controls.Add(txtTiempo);
            Controls.Add(txtMonto);
            Controls.Add(txtEmpresa);
            Controls.Add(lblTasaInter);
            Controls.Add(lblTiempo);
            Controls.Add(lblMonto);
            Controls.Add(lblEmpresa);
            Name = "Form1";
            Text = "Calculo del Monto a pagar por un Prestamo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpresa;
        private Label lblMonto;
        private Label lblTiempo;
        private Label lblTasaInter;
        private TextBox txtEmpresa;
        private TextBox txtMonto;
        private TextBox txtTiempo;
        private RadioButton rdbInteres1;
        private RadioButton rdbInteres2;
        private RadioButton rdbInteres3;
        private TextBox txtTasaInterEX;
        private ListBox lstResul;
        private Button btnAnalisis;
        private Button btnFin;
    }
}
