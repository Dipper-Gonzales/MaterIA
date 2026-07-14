using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaterIA.Formularios
{
    public partial class FormRelacionesRecurrencia : Form
    {
        public FormRelacionesRecurrencia()
        {
            InitializeComponent();
        }

        private void btnrelaciones1_Click(object sender, EventArgs e)
        {
            FormRelaciones1 formulario = new FormRelaciones1();
            formulario.ShowDialog();
        }

        private void btnrelaciones2_Click(object sender, EventArgs e)
        {
            FormRelaciones2 formulario = new FormRelaciones2();
            formulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
