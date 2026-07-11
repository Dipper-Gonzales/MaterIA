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
    public partial class FormBinarioDecimal : Form
    {
        public FormBinarioDecimal()
        {
            InitializeComponent();
        }



        private void textEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FormBinarioDecimal_Load(object sender, EventArgs e)
        {
            comboTipoConversion.Items.Add("Binario a Decimal");
            comboTipoConversion.Items.Add("Decimal a Binario");
            comboTipoConversion.Items.Add("Decimal a Hexadecimal");
            comboTipoConversion.Items.Add("Hexadecimal a Decimal");
            comboTipoConversion.Items.Add("Binario a Hexadecimal");
            comboTipoConversion.Items.Add("Hexadecimal a Binario");
            comboTipoConversion.SelectedIndex = 0; // selecciona la primera opción por defecto
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            string entrada = textEntrada.Text.Trim();
            string tipoSeleccionado = comboTipoConversion.SelectedItem.ToString();

            if (entrada == "")
            {
                labelResultado.Text = "Error: ingresa un valor";
                return;
            }

            try
            {
                switch (tipoSeleccionado)
                {
                    case "Binario a Decimal":
                        if (!EsBinarioValido(entrada))
                        {
                            labelResultado.Text = "Error: ingresa solo 0s y 1s";
                            return;
                        }
                        labelResultado.Text = "Resultado: " + ConversorBase.BinarioADecimal(entrada);
                        break;

                    case "Decimal a Binario":
                        int numDecimal = int.Parse(entrada);
                        labelResultado.Text = "Resultado: " + ConversorBase.DecimalABinario(numDecimal);
                        break;

                    case "Decimal a Hexadecimal":
                        int numDecimal2 = int.Parse(entrada);
                        labelResultado.Text = "Resultado: " + ConversorBase.DecimalAHexadecimal(numDecimal2);
                        break;

                    case "Hexadecimal a Decimal":
                        if (!EsHexadecimalValido(entrada))
                        {
                            labelResultado.Text = "Error: ingresa solo 0-9 y A-F";
                            return;
                        }
                        labelResultado.Text = "Resultado: " + ConversorBase.HexadecimalADecimal(entrada);
                        break;

                    case "Binario a Hexadecimal":
                        if (!EsBinarioValido(entrada))
                        {
                            labelResultado.Text = "Error: ingresa solo 0s y 1s";
                            return;
                        }
                        labelResultado.Text = "Resultado: " + ConversorBase.BinarioAHexadecimal(entrada);
                        break;

                    case "Hexadecimal a Binario":
                        if (!EsHexadecimalValido(entrada))
                        {
                            labelResultado.Text = "Error: ingresa solo 0-9 y A-F";
                            return;
                        }
                        labelResultado.Text = "Resultado: " + ConversorBase.HexadecimalABinario(entrada);
                        break;
                }
            }
            catch (FormatException)
            {
                labelResultado.Text = "Error: valor numérico inválido";
            }
        }
        private bool EsBinarioValido(string texto)
        {
            foreach (char c in texto)
            {
                if (c != '0' && c != '1') return false;
            }
            return true;
        }

        private bool EsHexadecimalValido(string texto)
        {
            string digitosValidos = "0123456789ABCDEFabcdef";
            foreach (char c in texto)
            {
                if (!digitosValidos.Contains(c)) return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

