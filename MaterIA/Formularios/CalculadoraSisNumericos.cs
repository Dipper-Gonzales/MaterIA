using MaterIA.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MaterIA.Formularios
{
    public partial class CalculadoraSisNumericos : Form
    {
        private int operandoPendiente = 0;
        private string operadorPendiente = "";
        private bool esperandoNuevoNumero = true;
        public CalculadoraSisNumericos()
        {
            InitializeComponent();
        }

        private void CalculadoraSisNumericos_Load(object sender, EventArgs e)
        {
            comboBase.Items.Add("Binario");
            comboBase.Items.Add("Octal");
            comboBase.Items.Add("Decimal");
            comboBase.Items.Add("Hexadecimal");
            comboBase.SelectedIndex = 2; // Decimal por defecto

            txtPantalla.Text = "0";
            ActualizarBotonesDisponibles();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            esperandoNuevoNumero = true;
            ActualizarBotonesDisponibles();
        }
        private void ActualizarBotonesDisponibles()
        {
            string base_ = comboBase.SelectedItem.ToString();

            // Por defecto, deshabilita todos los dígitos, luego habilita según la base
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = (base_ != "Binario");
            btn3.Enabled = (base_ != "Binario");
            btn4.Enabled = (base_ != "Binario");
            btn5.Enabled = (base_ != "Binario");
            btn6.Enabled = (base_ != "Binario");
            btn7.Enabled = (base_ != "Binario");
            btn8.Enabled = (base_ == "Decimal" || base_ == "Hexadecimal");
            btn9.Enabled = (base_ == "Decimal" || base_ == "Hexadecimal");

            bool esHex = (base_ == "Hexadecimal");
            A.Enabled = esHex;
            B.Enabled = esHex;
            C.Enabled = esHex;
            D.Enabled = esHex;
            E.Enabled = esHex;
            F.Enabled = esHex;
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void F_Click(object sender, EventArgs e)
        {

        }

        private void btnDigito_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            string digito = botonPresionado.Text;

            if (esperandoNuevoNumero || txtPantalla.Text == "0")
            {
                txtPantalla.Text = digito;
                esperandoNuevoNumero = false;
            }
            else
            {
                txtPantalla.Text += digito;
            }
        }

        private void btn_Operador_click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            string operador = botonPresionado.Text;
            string base_ = comboBase.SelectedItem.ToString();

            operandoPendiente = CalculadoraLogica.ATexto_a_Decimal(txtPantalla.Text, base_);
            operadorPendiente = operador;
            esperandoNuevoNumero = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string base_ = comboBase.SelectedItem.ToString();

            try
            {
                int operandoActual = CalculadoraLogica.ATexto_a_Decimal(txtPantalla.Text, base_);
                int resultado = CalculadoraLogica.Calcular(operandoPendiente, operandoActual, operadorPendiente);
                txtPantalla.Text = CalculadoraLogica.Decimal_a_Texto(resultado, base_);
                esperandoNuevoNumero = true;
            }
            catch (DivideByZeroException)
            {
                txtPantalla.Text = "Error: div/0";
                esperandoNuevoNumero = true;
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            operandoPendiente = 0;
            operadorPendiente = "";
            esperandoNuevoNumero = true;
        }
    }
}
