using System;
using System.Windows.Forms;
using MaterIA.Formularios;

namespace MaterIA
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonBinarioDecimal_Click(object sender, EventArgs e)
        {
            FormLogicaMatematica formulario = new FormLogicaMatematica();
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSistemasNumericos formulario = new FormSistemasNumericos();
            formulario.Show();
        }
    }
}