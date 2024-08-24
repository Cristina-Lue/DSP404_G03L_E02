/*
 * Creado por SharpDevelop.
 * Usuario: MINED
 * Fecha: 23/08/2024
 * Hora: 18:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Guia5Mej
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		clsPlanilla planillaEPSON = new clsPlanilla();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
			try {
 //define fecha min y max que podra seleccionar en dtpFechaNac
 DateTime fecha = DateTime.Now;
 dtpFechaNac.MinDate = fecha.AddYears(-70);
 dtpFechaNac.MaxDate = fecha.AddYears(15);
 groupBox1.Enabled = false;
 groupBox2.Enabled = false;
 btnNuevo.Enabled = false;
 btnAceptar.Enabled = false;
 btnGenerarPlanilla.Enabled = false;
 btnNuevo.Focus();
}
catch(Exception ex){
 MessageBox.Show(ex.Message);
}
			
		}
		void BtnAceptarClick(object sender, EventArgs e)
		{
	try {
 // Se prepara a registrar un nuevo empleado
 clsEmpleado trabajador = new clsEmpleado();//Crea un objeto de la clase ClsEmpleado
 trabajador.DefinirDatosPersonales(txtNombres.Text, txtApellidos.Text,
 dtpFechaNac.Value);
 //Empleado será aceptado hasta que objeto trabajador lo confirme
 if (trabajador.datospersonales_aceptados)
 {
 /*Tranfiere datos laborales, para que confirme si son correctos
 evalua si ha escrito mal el sueldo inicial*/
 if (!(Int32.Parse(txtSueldoini.Text) >= 0))
 {
 MessageBox.Show("ERROR, Sueldo inicial no valido");
 txtSueldoini.Focus();
 
 return;
 }
 //evalua si valor tasa isss es incorrecto
 if (nudRenta.Value <= 0.0m)
 {
 MessageBox.Show("ERROR, revise tasa renta");
 nudRenta.Focus();
 return;
 }
 //evalua si valor tasa isss es incorrecto
 if (nudISSS.Value <= 0.0m)
 {
 MessageBox.Show("ERROR, revise tasa ISSS");
 nudISSS.Focus();
 return;
 }
 trabajador.DefinirDatosLaborales(dtpFechaContrato.Value,
 Convert.ToDecimal(txtSueldoini.Text));
 if (trabajador.datoslaborales_aceptados)
 {
 trabajador.AsignarDescuentos(Convert.ToDecimal(nudISSS.Text),
 Convert.ToDecimal(nudRenta.Text));
 planillaEPSON.RecibirEmpleado(trabajador);
 groupBox1.Enabled = false;
 groupBox2.Enabled = false;
 btnNuevo.Enabled = true;
 btnAceptar.Enabled = false;
 btnNuevo.Focus();
 }
 else
 {
 txtNombres.Focus();
 }
 }
 else
 {
 txtNombres.Focus();
 }
}
catch (Exception e) {
 MessageBox.Show(e.Message);
}
 
 
 
 
		}
		void BtnabrirplantillaClick(object sender, EventArgs e)
		{
	btnNuevo.Enabled = true;
 btnGenerarPlanilla.Enabled = true;
 //Activa planilla actual, para que se agreguen los N empleados
 planillaEPSON.AbrirPlanilla(DateTime.Now,"Epson Internacional");

		}
		void BtngenerarplantillaClick(object sender, EventArgs e)
		{
	planillaEPSON.GenerarListado(ref dataGridView1);
		}
		void BtnNuevoClick(object sender, EventArgs e)
		{
	txtNombres.Clear();
 txtApellidos.Clear();
 txtSueldoini.Clear();
 nudISSS.Value = 0;
 nudRenta.Value = 0;
 dtpFechaContrato.Value = DateTime.Now;
 dtpFechaNac.Value = DateTime.Now;
 groupBox1.Enabled = true;
 groupBox2.Enabled = true;
 btnNuevo.Enabled = false;
 btnAceptar.Enabled = true;
 txtNombres.Focus();
		}
		void TxtNombresKeyPress(object sender, KeyPressEventArgs e)
		{
	if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
 {
 MessageBox.Show("Solo se permiten letras", "Advertencia",
 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 e.Handled = true;
 return;
 }
		}
		void TxtApellidosKeyPress(object sender, KeyPressEventArgs e)
		{
	if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
 {
 MessageBox.Show("Solo se permiten letras", "Advertencia",
 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 e.Handled = true;
 return;
 }
		}
		void NudrentaKeyPress(object sender, KeyPressEventArgs e)
		{
	if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
 {
 MessageBox.Show("Solo se permiten numeros", "Advertencia",
 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 e.Handled = true;
 return;
 }
		}
		void NudisssKeyPress(object sender, KeyPressEventArgs e)
		{
	if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
 {
 MessageBox.Show("Solo se permiten numeros", "Advertencia",
 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 e.Handled = true;
 return;
 }
		}
		void TxtsueldoiniKeyPress(object sender, KeyPressEventArgs e)
		{
	if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
 {
 MessageBox.Show("Solo se permiten numeros", "Advertencia",
 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 e.Handled = true;
 return;
 }
		}
		
		
		
		
	
		
		
		
		
		
		
		
	}
}
