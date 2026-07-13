using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterIA.Logica;
namespace MaterIA.Formularios
{
    public partial class FormCombinaciones : Form
    {
        private MetodosConteo conteo = new MetodosConteo();

        public FormCombinaciones()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtN.Text);
                int r = int.Parse(txtR.Text);

                double resultado = conteo.Combinaciones(n, r);

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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
