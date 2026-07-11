using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterIA.Formularios
{
    public partial class FormSistemasNumericos : Form
    {
        public FormSistemasNumericos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBinarioDecimal formulario = new FormBinarioDecimal();
            formulario.ShowDialog();
        }

        private void buttonConjuntos_Click(object sender, EventArgs e)
        {
            FormConjuntos formulario = new FormConjuntos();
            formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculadoraSisNumericos formulario = new CalculadoraSisNumericos();
            formulario.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
