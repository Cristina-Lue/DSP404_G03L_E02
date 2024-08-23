using System;
using System.Windows.Forms;
using System.Threading;

namespace Desafio_eje2
{
    public partial class MainForm : Form
    {
        private int[] cuentas = { 1000001, 1000002, 1000004 };
        private decimal[] saldos = { 400m, 200m, 500m };

        public MainForm()
        {
        	InitializeComponent();
            comboBox1.Items.Add("Consulta de saldo");
            comboBox1.Items.Add("Retiro de fondos");
            comboBox1.Items.Add("Consignaciones");
            comboBox1.Items.Add("Transferencias");
            comboBox1.Items.Add("Salir");
            
        }

        private void Button2Click(object sender, EventArgs e)
        {
            try
            {
                int cuenta = int.Parse(txtCuenta.Text);
                int indice = Array.IndexOf(cuentas, cuenta);
                if (indice >= 0)
                {
                    lblMensaje.Text = "¡Bienvenido!";
                    MostrarMenu(indice);
                }
                else
                {
                    lblMensaje.Text = "Cuenta no encontrada.";
                }
            }
            catch (FormatException)
            {
                lblMensaje.Text = "El número de cuenta debe ser un valor numérico.";
            }
        }

        private void MostrarMenu(int indice)
        {
            
        }

        private void Button1Click(object sender, EventArgs e)
        {
        	
        	
            try
            {
                int opcion = comboBox1.SelectedIndex + 1; 
                int cuenta = int.Parse(txtCuenta.Text);
                int indice = Array.IndexOf(cuentas, cuenta);

                switch (opcion)
                {
                    case 1:
                		lblMensaje.Text = "El saldo actual de la cuenta 	"+	cuenta +" es de	"+		saldos[indice];
                        break;
                    case 2:
                        RetirarFondos(indice);
                        break;
                    case 3:
                        ConsignarFondos(indice);
                        break;
                    case 4:
                        TransferirFondos(indice);
                        break;
                    case 5:
                        lblMensaje.Text = "Gracias por usar el cajero automático.";
                        Application.DoEvents(); // Permite que el mensaje se actualice antes de la pausa
                Thread.Sleep(2000); // Espera 2 segundos
                Application.Exit();
                        break;
                    default:
                        lblMensaje.Text = "Opción no válida.";
                        break;
                }
            }
            catch (FormatException)
            {
                lblMensaje.Text = "Por favor, seleccione una opción válida.";
            }
        }

        private void RetirarFondos(int indice)
        {
            try
            {
                decimal cantidad = decimal.Parse(txtCantidad.Text);
                if (saldos[indice] >= cantidad)
                {
                    saldos[indice] -= cantidad;
                    lblMensaje.Text = "Has retirado"+cantidad+ "El saldo actual es"+saldos[indice];
                }
                else
                {
                    lblMensaje.Text = "Fondos insuficientes.";
                }
            }
            catch (FormatException)
            {
                lblMensaje.Text = "La cantidad debe ser un valor numérico.";
            }
        }

        private void ConsignarFondos(int indice)
        {
            try
            {
                decimal cantidad = decimal.Parse(txtCantidad.Text);
                saldos[indice] += cantidad;
                lblMensaje.Text = "Has consignado"+cantidad+" El saldo actual es"+saldos[indice];
            }
            catch (FormatException)
            {
                lblMensaje.Text = "La cantidad debe ser un valor numérico.";
            }
        }

        private void TransferirFondos(int indice)
        {
            try
            {
                int cuentaDestino = int.Parse(txtCuentaDestino.Text);
                int indiceDestino = Array.IndexOf(cuentas, cuentaDestino);
                decimal cantidad = decimal.Parse(txtCantidad.Text);

                if (indiceDestino >= 0 && saldos[indice] >= cantidad)
                {
                    saldos[indice] -= cantidad;
                    saldos[indiceDestino] += cantidad;
                    lblMensaje.Text = "Has transferido"+cantidad + "a la cuenta"+cuentaDestino+" El saldo actual es"+saldos[indice];
                }
                else
                {
                    lblMensaje.Text = "Fondos insuficientes o cuenta destino no encontrada.";
                }
            }
            catch (FormatException)
            {
                lblMensaje.Text = "La cantidad y el número de cuenta destino deben ser valores numéricos.";
            }
        }
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
    }
}
