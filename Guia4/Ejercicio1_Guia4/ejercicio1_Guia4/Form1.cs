﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1_Guia4
{
    public partial class frmGuia04ejerc1 : Form
    {
        //creacion de subrutina a utilizar
        private void presentacInic()
        {
            //prepara controles antes de mostrar form al usuario
            grbResult.Visible = false;
            nupBase.Focus();
        }
        private void HacerCalculos(Decimal N)
        {
            /*Se prepara a calcular tablas (de multiplicar y potencia)
            segun valor de variable argumentos N*/
            int c;
            decimal res;
            IstTabla2.Items.Clear();
            c = 1;
            do
            {
                res = N * c;
                IstTabla1.Items.Add(N.ToString() + "X" + c.ToString() + "=" + res.ToString());
                c += 1;
            } while (!(c > 10));
            //Genera la portencia de las tablas
            IstTabla2.Items.Clear();
            c = 1;
            do
            {
                res = Elevar(N, c);
                IstTabla2.Items.Add(N.ToString() + " a la " + c.ToString() + "=" + res.ToString());
                c += 1;
            } while (c <= 10);
        }
        private decimal Elevar(decimal B, int expo)
        {
            //remplaza a operador pow que calcula la potencia de argumentos (Bpow(expo))
            int i = 1;
            decimal r = 1;
            do
            {
                r *= B;
                i += 1;
            } while (!(i > expo));
            return r;
        }
  
    public frmGuia04ejerc1()
        {
            InitializeComponent();
        }

        private void frmGuia04ejerc1_Load(object sender, EventArgs e)
        {
            presentacInic();

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            //Invoca a subrituna HacerCalculos
            decimal n = nupBase.Value;
            HacerCalculos(n);
            //Muestra resultados
            grbResult.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}