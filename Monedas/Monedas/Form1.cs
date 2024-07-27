using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monedas
{
    public partial class Form1 : Form
    {
       
               private Dictionary<string, double> tasasDeCambio = new Dictionary<string, double>
    {
        { "USD", 1.0 },
        { "EUR", 0.85 },
        { "GBP", 0.75 },
        { "JPY", 110.0 },
        { "AUD", 1.35 }
    };

        public Form1()
        {
            InitializeComponent();
            CargarMonedas();
        }

        private void CargarMonedas()
        {
            cmbMonedaOrigen.Items.AddRange(tasasDeCambio.Keys.ToArray());
            cmbMonedaDestino.Items.AddRange(tasasDeCambio.Keys.ToArray());
            cmbMonedaOrigen.SelectedIndex = 0;
            cmbMonedaDestino.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(txtCantidad.Text);
                string monedaOrigen = cmbMonedaOrigen.SelectedItem.ToString();
                string monedaDestino = cmbMonedaDestino.SelectedItem.ToString();

                double resultado = ConvertirMoneda(cantidad, monedaOrigen, monedaDestino);
                lblResultado.Text = $"{cantidad} {monedaOrigen} = {resultado} {monedaDestino}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private double ConvertirMoneda(double cantidad, string monedaOrigen, string monedaDestino)
        {
            double tasaOrigen = tasasDeCambio[monedaOrigen];
            double tasaDestino = tasasDeCambio[monedaDestino];
            return cantidad * (tasaDestino / tasaOrigen);
        }
    }
}
