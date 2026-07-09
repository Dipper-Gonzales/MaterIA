using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TuProyecto.Logica;

namespace MaterIA.Formularios
{
    public partial class FrmPermutaciones : Form
    {
        public FrmPermutaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            lblResultado.Text = MetodoConteo.Permutacion(n).ToString();
        }
    }
}
