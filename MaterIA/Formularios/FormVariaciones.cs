using MaterIA.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterIA.Formularios
{

    public partial class FormVariaciones : Form
    {
        private MetodosConteo conteo = new MetodosConteo();
        public FormVariaciones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtN.Text);
                int r = int.Parse(txtR.Text);

                double resultado = conteo.Variaciones(n, r);

                Resultado.Text = "Resultado: " + resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa números válidos.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
