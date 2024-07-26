using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fecha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDateControls();
        }

        private void InitializeDateControls()
        {
            // Populate months
            cmbMes.Items.AddRange(new object[] {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            });

            // Populate years
            for (int year = 1900; year <= DateTime.Now.Year; year++)
            {
                cmbAnio.Items.Add(year);
            }

            // Add event handlers
            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;
            cmbAnio.SelectedIndexChanged += cmbAnio_SelectedIndexChanged;
            cmbDia.SelectedIndexChanged += cmbDia_SelectedIndexChanged;
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDays();
        }

        private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDays();
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void UpdateDays()
        {
            if (cmbMes.SelectedIndex == -1 || cmbAnio.SelectedIndex == -1)
                return;

            int month = cmbMes.SelectedIndex + 1;
            int year = (int)cmbAnio.SelectedItem;

            int daysInMonth = DateTime.DaysInMonth(year, month);

            cmbDia.Items.Clear();
            for (int day = 1; day <= daysInMonth; day++)
            {
                cmbDia.Items.Add(day);
            }
        }

        private void UpdateLabel()
        {
            if (cmbMes.SelectedIndex == -1 || cmbDia.SelectedIndex == -1 || cmbAnio.SelectedIndex == -1)
                return;

            string month = cmbMes.SelectedItem.ToString();
            int day = (int)cmbDia.SelectedItem;
            int year = (int)cmbAnio.SelectedItem;

            lblFechaSeleccionada.Text = $"Fecha seleccionada: {month} {day}, {year}";
        }

        private void lblFechaSeleccionada_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}