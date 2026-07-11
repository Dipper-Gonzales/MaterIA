using MaterIA.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterIA.Formularios
{
    public partial class FormConjuntos : Form
    {
        public FormConjuntos()
        {
            InitializeComponent();
        }
        private List<string> ObtenerLista(ListBox listBox)
        {
            List<string> lista = new List<string>();
            foreach (var item in listBox.Items)
            {
                lista.Add(item.ToString());
            }
            return lista;
        }

        private void MostrarResultado(List<string> resultado)
        {
            listBoxResultado.Items.Clear();
            if (resultado.Count == 0)
            {
                listBoxResultado.Items.Add("(conjunto vacío)");
                return;
            }
            foreach (string elemento in resultado)
            {
                listBoxResultado.Items.Add(elemento);
            }
        }

        private void btnAgregarA_Click(object sender, EventArgs e)
        {
            string elemento = txtElementoA.Text.Trim();
            if (elemento != "" && !listBoxA.Items.Contains(elemento))
            {
                listBoxA.Items.Add(elemento);
                txtElementoA.Clear();
                txtElementoA.Focus();
            }
        }

        private void btnAgregarB_Click(object sender, EventArgs e)
        {
            string elemento = txtElementoB.Text.Trim();
            if (elemento != "" && !listBoxB.Items.Contains(elemento))
            {
                listBoxB.Items.Add(elemento);
                txtElementoB.Clear();
                txtElementoB.Focus();
            }
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            List<string> conjuntoA = ObtenerLista(listBoxA);
            List<string> conjuntoB = ObtenerLista(listBoxB);
            List<string> resultado = ConjuntosLogica.Union(conjuntoA, conjuntoB);
            MostrarResultado(resultado);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            List<string> conjuntoA = ObtenerLista(listBoxA);
            List<string> conjuntoB = ObtenerLista(listBoxB);
            List<string> resultado = ConjuntosLogica.Diferencia(conjuntoA, conjuntoB);
            MostrarResultado(resultado);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            List<string> conjuntoA = ObtenerLista(listBoxA);
            List<string> conjuntoB = ObtenerLista(listBoxB);
            List<string> resultado = ConjuntosLogica.Interseccion(conjuntoA, conjuntoB);
            MostrarResultado(resultado);
        }

        private void btnProductoCartesiano_Click(object sender, EventArgs e)
        {
            List<string> conjuntoA = ObtenerLista(listBoxA);
            List<string> conjuntoB = ObtenerLista(listBoxB);
            List<string> resultado = ConjuntosLogica.ProductoCartesiano(conjuntoA, conjuntoB);
            MostrarResultado(resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
