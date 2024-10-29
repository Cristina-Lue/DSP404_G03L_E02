
namespace ListaNombres
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
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.listBoxNombre = new System.Windows.Forms.ListBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(35, 102);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(75, 23);
            this.buttonAñadir.TabIndex = 0;
            this.buttonAñadir.Text = "&Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(35, 155);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "&Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(35, 211);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 2;
            this.buttonBorrar.Text = "&Eliminar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(35, 272);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "&Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // listBoxNombre
            // 
            this.listBoxNombre.FormattingEnabled = true;
            this.listBoxNombre.Location = new System.Drawing.Point(154, 102);
            this.listBoxNombre.Name = "listBoxNombre";
            this.listBoxNombre.Size = new System.Drawing.Size(158, 186);
            this.listBoxNombre.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(186, 40);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(171, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese/modifique un nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.listBoxNombre);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAñadir);
            this.Name = "Form1";
            this.Text = "Lista de nombre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ListBox listBoxNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
    }
}

