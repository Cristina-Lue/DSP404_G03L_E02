
namespace Matriz
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
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.Lbtipo_info = new System.Windows.Forms.Label();
            this.Lbdig_info = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.cbtipoinfo = new System.Windows.Forms.ComboBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btPromedio = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgdatos = new System.Windows.Forms.DataGridView();
            this.gbInformacion.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            this.gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.txtEdad);
            this.gbInformacion.Controls.Add(this.txtInfo);
            this.gbInformacion.Controls.Add(this.cbtipoinfo);
            this.gbInformacion.Controls.Add(this.lbedad);
            this.gbInformacion.Controls.Add(this.Lbdig_info);
            this.gbInformacion.Controls.Add(this.Lbtipo_info);
            this.gbInformacion.Location = new System.Drawing.Point(26, 26);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(271, 155);
            this.gbInformacion.TabIndex = 0;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Informacion";
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.dgdatos);
            this.gbMatriz.Location = new System.Drawing.Point(25, 187);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(555, 241);
            this.gbMatriz.TabIndex = 1;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matriz";
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.button5);
            this.gbMantenimiento.Controls.Add(this.btPromedio);
            this.gbMantenimiento.Controls.Add(this.btLimpiar);
            this.gbMantenimiento.Controls.Add(this.btMostrar);
            this.gbMantenimiento.Controls.Add(this.btAgregar);
            this.gbMantenimiento.Location = new System.Drawing.Point(324, 26);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(236, 155);
            this.gbMantenimiento.TabIndex = 1;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimientos";
            this.gbMantenimiento.Enter += new System.EventHandler(this.gbMantenimiento_Enter);
            // 
            // Lbtipo_info
            // 
            this.Lbtipo_info.AutoSize = true;
            this.Lbtipo_info.Location = new System.Drawing.Point(6, 26);
            this.Lbtipo_info.Name = "Lbtipo_info";
            this.Lbtipo_info.Size = new System.Drawing.Size(101, 13);
            this.Lbtipo_info.TabIndex = 0;
            this.Lbtipo_info.Text = "Tipo de Informacion";
            // 
            // Lbdig_info
            // 
            this.Lbdig_info.AutoSize = true;
            this.Lbdig_info.Location = new System.Drawing.Point(6, 59);
            this.Lbdig_info.Name = "Lbdig_info";
            this.Lbdig_info.Size = new System.Drawing.Size(102, 13);
            this.Lbdig_info.TabIndex = 1;
            this.Lbdig_info.Text = "Digite la informacion";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(6, 90);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(32, 13);
            this.lbedad.TabIndex = 2;
            this.lbedad.Text = "Edad";
            // 
            // cbtipoinfo
            // 
            this.cbtipoinfo.FormattingEnabled = true;
            this.cbtipoinfo.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbtipoinfo.Location = new System.Drawing.Point(113, 23);
            this.cbtipoinfo.Name = "cbtipoinfo";
            this.cbtipoinfo.Size = new System.Drawing.Size(121, 21);
            this.cbtipoinfo.TabIndex = 3;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(114, 55);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(100, 20);
            this.txtInfo.TabIndex = 4;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(73, 87);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.Red;
            this.btAgregar.Location = new System.Drawing.Point(19, 23);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "&Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.BackColor = System.Drawing.Color.LightGreen;
            this.btMostrar.Location = new System.Drawing.Point(119, 21);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 23);
            this.btMostrar.TabIndex = 1;
            this.btMostrar.Text = "Mostrar Matriz";
            this.btMostrar.UseVisualStyleBackColor = false;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.LightSalmon;
            this.btLimpiar.Location = new System.Drawing.Point(19, 56);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 2;
            this.btLimpiar.Text = "Limpiar Matriz";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btPromedio
            // 
            this.btPromedio.BackColor = System.Drawing.Color.Yellow;
            this.btPromedio.Location = new System.Drawing.Point(119, 53);
            this.btPromedio.Name = "btPromedio";
            this.btPromedio.Size = new System.Drawing.Size(75, 23);
            this.btPromedio.TabIndex = 3;
            this.btPromedio.Text = "Promedio";
            this.btPromedio.UseVisualStyleBackColor = false;
            this.btPromedio.Click += new System.EventHandler(this.btPromedio_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Pink;
            this.button5.Location = new System.Drawing.Point(19, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgdatos
            // 
            this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdatos.Location = new System.Drawing.Point(23, 28);
            this.dgdatos.Name = "dgdatos";
            this.dgdatos.Size = new System.Drawing.Size(512, 194);
            this.dgdatos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(632, 452);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gbInformacion);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            this.gbMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ComboBox cbtipoinfo;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label Lbdig_info;
        private System.Windows.Forms.Label Lbtipo_info;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.DataGridView dgdatos;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btPromedio;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btAgregar;
    }
}

