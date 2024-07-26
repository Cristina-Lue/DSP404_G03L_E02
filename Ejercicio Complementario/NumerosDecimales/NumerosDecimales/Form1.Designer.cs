namespace NumerosDecimales
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.ListBox lstPositiveNumbers;
        private System.Windows.Forms.ListBox lstNegativeNumbers;
        private System.Windows.Forms.Label lblMinNegative;
        private System.Windows.Forms.Label lblAveragePositive;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.lstPositiveNumbers = new System.Windows.Forms.ListBox();
            this.lstNegativeNumbers = new System.Windows.Forms.ListBox();
            this.lblMinNegative = new System.Windows.Forms.Label();
            this.lblAveragePositive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(12, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(118, 10);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(75, 23);
            this.btnAddNumber.TabIndex = 1;
            this.btnAddNumber.Text = "Agregar";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // lstPositiveNumbers
            // 
            this.lstPositiveNumbers.FormattingEnabled = true;
            this.lstPositiveNumbers.Location = new System.Drawing.Point(15, 45);
            this.lstPositiveNumbers.Name = "lstPositiveNumbers";
            this.lstPositiveNumbers.Size = new System.Drawing.Size(156, 173);
            this.lstPositiveNumbers.TabIndex = 2;
            // 
            // lstNegativeNumbers
            // 
            this.lstNegativeNumbers.FormattingEnabled = true;
            this.lstNegativeNumbers.Location = new System.Drawing.Point(187, 45);
            this.lstNegativeNumbers.Name = "lstNegativeNumbers";
            this.lstNegativeNumbers.Size = new System.Drawing.Size(165, 160);
            this.lstNegativeNumbers.TabIndex = 3;
            // 
            // lblMinNegative
            // 
            this.lblMinNegative.AutoSize = true;
            this.lblMinNegative.Location = new System.Drawing.Point(12, 192);
            this.lblMinNegative.Name = "lblMinNegative";
            this.lblMinNegative.Size = new System.Drawing.Size(0, 13);
            this.lblMinNegative.TabIndex = 4;
            // 
            // lblAveragePositive
            // 
            this.lblAveragePositive.AutoSize = true;
            this.lblAveragePositive.Location = new System.Drawing.Point(12, 217);
            this.lblAveragePositive.Name = "lblAveragePositive";
            this.lblAveragePositive.Size = new System.Drawing.Size(0, 13);
            this.lblAveragePositive.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 261);
            this.Controls.Add(this.lblAveragePositive);
            this.Controls.Add(this.lblMinNegative);
            this.Controls.Add(this.lstNegativeNumbers);
            this.Controls.Add(this.lstPositiveNumbers);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Números Decimales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
