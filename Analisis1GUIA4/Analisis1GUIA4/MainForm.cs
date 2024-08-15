using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Analisis1GUIA4
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        private ListaSimulada listaSimulada;

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            listaSimulada = new ListaSimulada();

        }

        void BtnCrearListaClick(object sender, EventArgs e)
        {
            listaSimulada.CrearListaVacia();
        }

        void BtnMostrarListaClick(object sender, EventArgs e)
        {
            listaSimulada.MostrarListado(listBox1);
        }

        void BtnInsertarElementoClick(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            listaSimulada.InsertarElemento(valor);
        }

        void BtnRemoverElementoClick(object sender, EventArgs e)
        {
            int? elementoRemovido = listaSimulada.RemoverElemento();
            if (elementoRemovido.HasValue)
            {
                MessageBox.Show("Elemento removido: " + elementoRemovido.Value);
            }
            else
            {
                MessageBox.Show("La lista está vacía.");
            }
        }
    }

    public class ListaSimulada
    {
        private int[] lista;

        // a) Crear lista vacía
        public void CrearListaVacia()
        {
            lista = new int[0];
        }

        // b) Mostrar listado de elementos de la lista
        public void MostrarListado(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (int elemento in lista)
            {
                listBox.Items.Add(elemento);
            }
        }

        // c) Insertar elemento en la lista
        public void InsertarElemento(int valor)
        {
            int[] nuevaLista = new int[lista.Length + 1];
            for (int i = 0; i < lista.Length; i++)
            {
                nuevaLista[i] = lista[i];
            }
            nuevaLista[lista.Length] = valor;
            lista = nuevaLista;
        }

        // d) Remover elemento
        public int? RemoverElemento()
        {
            if (lista.Length == 0)
            {
                return null;
            }
            int elementoRemovido = lista[0];
            int[] nuevaLista = new int[lista.Length - 1];
            for (int i = 1; i < lista.Length; i++)
            {
                nuevaLista[i - 1] = lista[i];
            }
            lista = nuevaLista;
            return elementoRemovido;
        }
    }
}
