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
    public partial class FrmPermutaciones : Form
    {
        private MetodosConteo conteo = new MetodosConteo();

        public FrmPermutaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);

                double resultado = conteo.PermutacionesSimple(n);

                lblResultado.Text = "Resultado: " + resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa un número válido.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPermutaciones_Load(object sender, EventArgs e)
        {

        }
    }
}