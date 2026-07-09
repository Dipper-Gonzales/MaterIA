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
    }
}
