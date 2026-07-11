using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterIA.Logica;

namespace MaterIA.Formularios
{
    public partial class FormSerieDeTaylor : Form
    {
        private SerieTaylor serie = new SerieTaylor();

        public FormSerieDeTaylor()
        {
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnExponencial_Click_1(object sender, EventArgs e)
        {
            double x = double.Parse(txtValorX.Text);
            int terminos = int.Parse(txtTerminos.Text);
            double resultado = serie.CalcularExponencial(x, terminos);
            lblResultado.Text = "Resultado: " + resultado;
        }

        private void btnSeno_Click_1(object sender, EventArgs e)
        {
            double x = double.Parse(txtValorX.Text);
            int terminos = int.Parse(txtTerminos.Text);
            double resultado = serie.CalcularSeno(x, terminos);
            lblResultado.Text = "Resultado: " + resultado;
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtValorX.Text);
            int terminos = int.Parse(txtTerminos.Text);
            double resultado = serie.CalcularCoseno(x, terminos);
            lblResultado.Text = "Resultado: " + resultado;
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtValorX.Text);
            int terminos = int.Parse(txtTerminos.Text);
            double resultado = serie.CalcularLn(x, terminos);
            lblResultado.Text = "Resultado: " + resultado;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            int terminos = int.Parse(txtTerminos.Text);
            double resultado = serie.CalcularPi(terminos);
            lblResultado.Text = "Resultado: " + resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
