using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterIA.Formularios
{
    public partial class FrmMetodoConteo : Form
    {
        public FrmMetodoConteo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPermutaciones_Click(object sender, EventArgs e)
        {
            FrmPermutaciones formulario = new FrmPermutaciones();
            formulario.Show();
        }

        private void btnCombinaciones_Click(object sender, EventArgs e)
        {
            FormCombinaciones formulario = new FormCombinaciones();
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void btnVariaciones_Click(object sender, EventArgs e)
        {
            FormVariaciones formulario = new FormVariaciones();
            formulario.Show();
        }

        private void FrmMetodoConteo_Load(object sender, EventArgs e)
        {

        }
    }
}
