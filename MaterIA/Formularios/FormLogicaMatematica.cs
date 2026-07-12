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
    public partial class FormLogicaMatematica : Form
    {
        private LogicaMatematica logica = new LogicaMatematica();
        public FormLogicaMatematica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorA = int.Parse(txtValorA.Text);
            int valorB = int.Parse(txtValorB.Text);

            int resultado = logica.OperacionAnd(valorA, valorB);

            lblResultado.Text = "Resultado: " + resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valorA = int.Parse(txtValorA.Text);
            int valorB = int.Parse(txtValorB.Text);

            int resultado = logica.OperacionOr(valorA, valorB);

            lblResultado.Text = "Resultado: " + resultado;
        }

        private void buttonpres1_Click(object sender, EventArgs e)
        {
            txtValorA.Text = "1";
        }

        private void buttonpres0_Click(object sender, EventArgs e)
        {
            txtValorA.Text = "0";
        }

        private void buttonpress0_Click(object sender, EventArgs e)
        {
            txtValorB.Text = "0";
        }

        private void buttonpress1_Click(object sender, EventArgs e)
        {
            txtValorB.Text = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTablaVerdadCompleta formTabla = new FormTablaVerdadCompleta();
            formTabla.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                    }
    }
}
