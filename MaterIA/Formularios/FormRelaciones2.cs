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
    public partial class FormRelaciones2 : Form
    {
        private RelacionRecurrencia relacion = new RelacionRecurrencia();
        public FormRelaciones2()
        {
            InitializeComponent();
        }
        private void btnEcuacionCaracteristica_Click(object sender, EventArgs e)
        {
            try
            {
                double c1 = double.Parse(txtC1.Text);
                double c2 = double.Parse(txtC2.Text);
                double raiz1, raiz2;
                bool tieneRaicesReales;
                string resultado = relacion.ResolverEcuacionCaracteristica(c1, c2, out raiz1, out raiz2, out tieneRaicesReales);
                lblResultado.Text = resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa valores válidos para c1 y c2.");
            }
        }

        private void btnHomogenea_Click(object sender, EventArgs e)
        {
            try
            {
                double c1 = double.Parse(txtC1.Text);
                double c2 = double.Parse(txtC2.Text);
                double a0 = double.Parse(txtA0.Text);
                double a1 = double.Parse(txtA1.Text);
                int n = int.Parse(txtN.Text);
                double resultado = relacion.ResolverHomogenea(c1, c2, a0, a1, n);
                lblResultado.Text = $"a({n}) = {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa todos los valores numéricos correctamente.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNoHomogenea_Click(object sender, EventArgs e)
        {
            try
            {
                double c1 = double.Parse(txtC1.Text);
                double c2 = double.Parse(txtC2.Text);
                double d = double.Parse(txtD.Text);
                double a0 = double.Parse(txtA0.Text);
                double a1 = double.Parse(txtA1.Text);
                int n = int.Parse(txtN.Text);
                double resultado = relacion.ResolverNoHomogenea(c1, c2, d, a0, a1, n);
                lblResultado.Text = $"a({n}) = {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa todos los valores numéricos correctamente.");
            }
        }

        private void txtC1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
