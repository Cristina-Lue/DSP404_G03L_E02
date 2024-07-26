
namespace Ejemplo1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTasaInter = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtTasaInterEX = new System.Windows.Forms.TextBox();
            this.rbdInteres1 = new System.Windows.Forms.RadioButton();
            this.rbdInteres2 = new System.Windows.Forms.RadioButton();
            this.rbdInteres3 = new System.Windows.Forms.RadioButton();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(30, 30);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(117, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Nombre de la Empresa:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(30, 90);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(98, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto prestamo ($)";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(308, 90);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(74, 13);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo (años)";
            // 
            // lblTasaInter
            // 
            this.lblTasaInter.AutoSize = true;
            this.lblTasaInter.Location = new System.Drawing.Point(30, 155);
            this.lblTasaInter.Name = "lblTasaInter";
            this.lblTasaInter.Size = new System.Drawing.Size(69, 13);
            this.lblTasaInter.TabIndex = 3;
            this.lblTasaInter.Text = "Tasa Interes:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(149, 27);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(306, 20);
            this.txtEmpresa.TabIndex = 4;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(134, 87);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(162, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(388, 87);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(162, 20);
            this.txtTiempo.TabIndex = 6;
            this.txtTiempo.Text = "2";
            // 
            // txtTasaInterEX
            // 
            this.txtTasaInterEX.Enabled = false;
            this.txtTasaInterEX.Location = new System.Drawing.Point(431, 188);
            this.txtTasaInterEX.Name = "txtTasaInterEX";
            this.txtTasaInterEX.Size = new System.Drawing.Size(162, 20);
            this.txtTasaInterEX.TabIndex = 7;
            this.txtTasaInterEX.Text = "0";
            // 
            // rbdInteres1
            // 
            this.rbdInteres1.AutoSize = true;
            this.rbdInteres1.Checked = true;
            this.rbdInteres1.Location = new System.Drawing.Point(33, 189);
            this.rbdInteres1.Name = "rbdInteres1";
            this.rbdInteres1.Size = new System.Drawing.Size(45, 17);
            this.rbdInteres1.TabIndex = 8;
            this.rbdInteres1.TabStop = true;
            this.rbdInteres1.Text = "12%";
            this.rbdInteres1.UseVisualStyleBackColor = true;
            this.rbdInteres1.CheckedChanged += new System.EventHandler(this.rbdInteres1_CheckedChanged);
            // 
            // rbdInteres2
            // 
            this.rbdInteres2.AutoSize = true;
            this.rbdInteres2.Location = new System.Drawing.Point(159, 189);
            this.rbdInteres2.Name = "rbdInteres2";
            this.rbdInteres2.Size = new System.Drawing.Size(54, 17);
            this.rbdInteres2.TabIndex = 9;
            this.rbdInteres2.Text = "23.5%";
            this.rbdInteres2.UseVisualStyleBackColor = true;
            this.rbdInteres2.CheckedChanged += new System.EventHandler(this.rbdInteres2_CheckedChanged);
            // 
            // rbdInteres3
            // 
            this.rbdInteres3.AutoSize = true;
            this.rbdInteres3.Location = new System.Drawing.Point(325, 189);
            this.rbdInteres3.Name = "rbdInteres3";
            this.rbdInteres3.Size = new System.Drawing.Size(88, 17);
            this.rbdInteres3.TabIndex = 10;
            this.rbdInteres3.Text = "Otro, indique:";
            this.rbdInteres3.UseVisualStyleBackColor = true;
            this.rbdInteres3.CheckedChanged += new System.EventHandler(this.rbdInteres3_CheckedChanged);
            // 
            // lstResult
            // 
            this.lstResult.Enabled = false;
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Items.AddRange(new object[] {
            "(Resultados)"});
            this.lstResult.Location = new System.Drawing.Point(56, 237);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(517, 121);
            this.lstResult.TabIndex = 11;
            this.lstResult.SelectedIndexChanged += new System.EventHandler(this.lstResult_SelectedIndexChanged);
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(149, 380);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(114, 23);
            this.btnAnalisis.TabIndex = 12;
            this.btnAnalisis.Text = "Análisis Financiero";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(358, 380);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(108, 23);
            this.btnFin.TabIndex = 13;
            this.btnFin.Text = "Salir del programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.rbdInteres3);
            this.Controls.Add(this.rbdInteres2);
            this.Controls.Add(this.rbdInteres1);
            this.Controls.Add(this.txtTasaInterEX);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblTasaInter);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "Form2";
            this.Text = "Calculo del Monto a pagar por un Prestamo";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTasaInter;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtTasaInterEX;
        private System.Windows.Forms.RadioButton rbdInteres1;
        private System.Windows.Forms.RadioButton rbdInteres2;
        private System.Windows.Forms.RadioButton rbdInteres3;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnFin;
    }
}