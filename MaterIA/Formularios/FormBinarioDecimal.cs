using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterIA.Formularios
{
    public partial class FormBinarioDecimal : Form
    {
        public FormBinarioDecimal()
        {
            InitializeComponent();
        }

        private void buttonBinarioDecimal_Click(object sender, EventArgs e)
        {
            string entrada = textEntrada.Text;
            bool esBinarioValido = true;
            foreach (char c in entrada)
            {
                if (c != '0' && c != '1')
                {
                    esBinarioValido = false;
                    break;
                }
            }

            if (entrada == "" || !esBinarioValido)
            {
                labelResultado.Text = "Error: ingresa solo 0s y 1s";
                return;
            }

            int resultado = MaterIA.Logica.ConversorBase.BinarioADecimal(entrada);
            labelResultado.Text = "Resultado: " + resultado.ToString();
        }

        private void buttonDecimalBinario_Click(object sender, EventArgs e)
        {
            string entrada = textEntrada.Text;
            int numero;
            bool esNumeroValido = int.TryParse(entrada, out numero);

            if (!esNumeroValido || numero < 0)
            {
                labelResultado.Text = "Error: ingresa un número entero positivo";
                return;
            }

            string resultado = MaterIA.Logica.ConversorBase.DecimalABinario(numero);
            labelResultado.Text = "Resultado: " + resultado;
        }

        private void textEntrada_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

