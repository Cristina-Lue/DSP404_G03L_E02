using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form2 : Form
    {
        private Label lblEmpresa;
        private Label lblMonto;
        private Label lblTiempo;
        private Label lblTasaInter;
        private RadioButton rdbInteres1;
        private RadioButton rbdInteres2;
        private RadioButton rbdInteres3;
        private TextBox txtEmpresa;
        private TextBox txtMonto;
        private TextBox txtTiempo;
        private TextBox txtTasaInterEx;
        private Button btnAnalisis;
        private Button btnFin;
        private ListBox lstResul;
        private double TasaI;
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rbdInteres3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdInteres3.Checked == true)
            {
                txtTasaInterEx.Enabled = true;
                txtTasaInterEx.Focus();
            }
            else
            {
                txtTasaInterEx.Text = "0";
                txtTasaInterEx.Enabled = false;
            }
        }

        private void rbdInteres1_CheckedChanged(object sender, EventArgs e)
        {
            TasaI = 0.12;
        }

        private void rbdInteres2_CheckedChanged(object sender, EventArgs e)
        {
            TasaI = 0.235;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            //Declaracion de variables a utilizar
            string NomEmpre;
            double MontoInic = 0, MontoFin = 0;
            int Tiempo;

            NomEmpre = txtEmpresa.Text;
            NomEmpre = NomEmpre.Trim();//Quita el espacio-blanco al inicio-final

            if (NomEmpre.Length == 0)
            {
                //si no hay caracteres en nombre empresa
                MessageBox.Show("Debe indicar Nombre de la empresa", "ERROR",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Focus(); //metodo que indica que control txtEmpresa recibira cursor
                return;//sale del procedimiento btnanalisis

                if (!(IsNumeric(txtMonto.Text)))
                {
                    MessageBox.Show("Valor Monto incorrecto", "ERROR", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    txtMonto.Focus(); //metodo que indica que control txtEmpresa recibira cursor
                    return;
                }
                else
                {
                    MontoInic = Convert.ToDouble(txtMonto.Text);
                    if (!(MontoInic > 0))
                    {
                        MessageBox.Show("Valor Monto no puede ser negativo", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMonto.Focus(); //metodo que indica que control txtEmpresa recibira cursor
                        return;
                    }
                }

                Tiempo = Convert.ToInt32(txtTiempo.Text);
                //si selcciono Tasa interes 3, valida que sea correcta
                txtTasaInterEx.Text = txtTasaInterEx.Text.Trim();

                if (rbdInteres3.Checked == true)
                {
                    if (txtTasaInterEx.Text.Length > 0)
                    {
                        if (!(IsNumeric(txtTasaInterEx.Text) == true))
                        {
                            MessageBox.Show("Tasa interes incorrecto", "ERROR", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                            txtTasaInterEx.Text = "0";
                            txtTasaInterEx.Focus();
                            return;
                        }
                        else
                        {
                            TasaI = Convert.ToDouble(txtTasaInterEx.Text) / 100;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Aun no ha indicado una tasa interes", "ERROR",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTasaInterEx.Focus();
                        return;
                    }
                }

                //Hace el cálculo esperado
                MontoFin = (1 + TasaI);
                MontoFin = MontoInic * (Math.Pow(Convert.ToDouble(MontoFin), Tiempo));
                TasaI *= 100;
                //Muestra la respuesta (Monto a pagar)
                lstResul.Items.Clear();
                lstResul.Items.Add("Empresa: " + txtEmpresa.Text);
                lstResul.Items.Add("Monto: $" + MontoInic + ", Tasa anual: " + TasaI);
                lstResul.Items.Add("Monto a pagar: $" + MontoFin);
            }
            }

        private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTasaInter = new System.Windows.Forms.Label();
            this.rdbInteres1 = new System.Windows.Forms.RadioButton();
            this.rbdInteres2 = new System.Windows.Forms.RadioButton();
            this.rbdInteres3 = new System.Windows.Forms.RadioButton();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtTasaInterEx = new System.Windows.Forms.TextBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.lstResul = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(25, 21);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(106, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Nombre de Empresa:";
            this.lblEmpresa.Click += new System.EventHandler(this.lblEmpresa_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(25, 73);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(95, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto prestamo($)";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(299, 76);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(74, 13);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo (años)";
            this.lblTiempo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTasaInter
            // 
            this.lblTasaInter.AutoSize = true;
            this.lblTasaInter.Location = new System.Drawing.Point(25, 132);
            this.lblTasaInter.Name = "lblTasaInter";
            this.lblTasaInter.Size = new System.Drawing.Size(69, 13);
            this.lblTasaInter.TabIndex = 3;
            this.lblTasaInter.Text = "Tasa Interes:";
            // 
            // rdbInteres1
            // 
            this.rdbInteres1.AutoSize = true;
            this.rdbInteres1.Checked = true;
            this.rdbInteres1.Location = new System.Drawing.Point(46, 158);
            this.rdbInteres1.Name = "rdbInteres1";
            this.rdbInteres1.Size = new System.Drawing.Size(45, 17);
            this.rdbInteres1.TabIndex = 4;
            this.rdbInteres1.TabStop = true;
            this.rdbInteres1.Text = "12%";
            this.rdbInteres1.UseVisualStyleBackColor = true;
            // 
            // rbdInteres2
            // 
            this.rbdInteres2.AutoSize = true;
            this.rbdInteres2.Location = new System.Drawing.Point(163, 158);
            this.rbdInteres2.Name = "rbdInteres2";
            this.rbdInteres2.Size = new System.Drawing.Size(54, 17);
            this.rbdInteres2.TabIndex = 5;
            this.rbdInteres2.Text = "23.5%";
            this.rbdInteres2.UseVisualStyleBackColor = true;
            // 
            // rbdInteres3
            // 
            this.rbdInteres3.AutoSize = true;
            this.rbdInteres3.Location = new System.Drawing.Point(285, 158);
            this.rbdInteres3.Name = "rbdInteres3";
            this.rbdInteres3.Size = new System.Drawing.Size(88, 17);
            this.rbdInteres3.TabIndex = 6;
            this.rbdInteres3.Text = "Otro, indique:";
            this.rbdInteres3.UseVisualStyleBackColor = true;
            this.rbdInteres3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(137, 18);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtEmpresa.TabIndex = 7;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(137, 70);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 8;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(394, 73);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 9;
            this.txtTiempo.Text = "2";
            // 
            // txtTasaInterEx
            // 
            this.txtTasaInterEx.Location = new System.Drawing.Point(379, 158);
            this.txtTasaInterEx.Name = "txtTasaInterEx";
            this.txtTasaInterEx.Size = new System.Drawing.Size(100, 20);
            this.txtTasaInterEx.TabIndex = 10;
            this.txtTasaInterEx.Text = "0";
            this.txtTasaInterEx.TextChanged += new System.EventHandler(this.txtTasaInterEx_TextChanged);
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(106, 341);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(111, 23);
            this.btnAnalisis.TabIndex = 11;
            this.btnAnalisis.Text = "Análisis Financiero";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(285, 341);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(110, 23);
            this.btnFin.TabIndex = 12;
            this.btnFin.Text = "Salir del programa";
            this.btnFin.UseVisualStyleBackColor = true;
            // 
            // lstResul
            // 
            this.lstResul.Enabled = false;
            this.lstResul.FormattingEnabled = true;
            this.lstResul.Items.AddRange(new object[] {
            "(Resultados)"});
            this.lstResul.Location = new System.Drawing.Point(61, 198);
            this.lstResul.Name = "lstResul";
            this.lstResul.Size = new System.Drawing.Size(312, 121);
            this.lstResul.TabIndex = 13;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(518, 405);
            this.Controls.Add(this.lstResul);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.txtTasaInterEx);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.rbdInteres3);
            this.Controls.Add(this.rbdInteres2);
            this.Controls.Add(this.rdbInteres1);
            this.Controls.Add(this.lblTasaInter);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "Form2";
            this.Text = "Calculo del Monto a pagar por un Prestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTasaInterEx_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmpresa_Click(object sender, EventArgs e)
        {

        }
    }
}
