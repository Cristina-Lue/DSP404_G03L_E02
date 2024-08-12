using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Controls.Primitives;
using LiveCharts.Configurations;
using System.Drawing.Imaging;

namespace Desafio1E1
{
    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        { }
        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            // Verifica si el gráfico ya está inicializado
            if (cartesianChart1 != null)
            {
                // Configura el gráfico
                cartesianChart1.Series = new LiveCharts.SeriesCollection
        {
            new LineSeries
            {
                Title = "Datos de Ejemplo",
                Values = new ChartValues<double> { 3, 5, 7, 4 }
            }
        };

                cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Eje X",
                    Labels = new[] { "Enero", "Febrero", "Marzo", "Abril" }
                });

                cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Eje Y"
                });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
