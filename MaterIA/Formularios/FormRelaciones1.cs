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
    public partial class FormRelaciones1 : Form
    {
        public FormRelaciones1()
        {
            InitializeComponent();
        }

        private void FormRelaciones1_Load(object sender, EventArgs e)
        {
            comboTipo.Items.Add("Depende de 1 término anterior");
            comboTipo.Items.Add("Depende de 2 términos anteriores");
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.SelectedIndex = 0;
            ActualizarCamposVisibles();
        }

        private void ActualizarCamposVisibles()
        {
            bool usaDosTerminos = (comboTipo.SelectedIndex == 1);
            txtC2.Enabled = usaDosTerminos;
            txtA2.Enabled = usaDosTerminos;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                bool usaDosTerminos = (comboTipo.SelectedIndex == 1);

                long c1 = long.Parse(txtC1.Text);
                long c2 = usaDosTerminos ? long.Parse(txtC2.Text) : 0;
                long k = long.Parse(txtK.Text);
                long a1 = long.Parse(txtA1.Text);
                long a2 = usaDosTerminos ? long.Parse(txtA2.Text) : 0;
                int n = int.Parse(txtN.Text);

                if (n < 1 || (usaDosTerminos && n < 2))
                {
                    MessageBox.Show("El término 'n' debe ser mayor o igual a los valores iniciales dados.");
                    return;
                }

                List<long> sucesion = RecurrenciaLogica.CalcularSucesion(usaDosTerminos, c1, c2, k, a1, a2, n);

                listBoxResultado.Items.Clear();
                for (int i = 0; i < sucesion.Count; i++)
                {
                    listBoxResultado.Items.Add("a(" + (i + 1) + ") = " + sucesion[i]);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifica que todos los campos tengan números válidos.");
            }
        }

        private void comboTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarCamposVisibles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
