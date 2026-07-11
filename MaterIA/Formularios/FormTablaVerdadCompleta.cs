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
    public partial class FormTablaVerdadCompleta : Form
    {
        private LogicaMatematica logica = new LogicaMatematica();

        public FormTablaVerdadCompleta()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void CargarTabla()
        {
            var tabla = logica.TablaVerdadCompleta();

            dgvTablaVerdad.Columns.Clear();
            dgvTablaVerdad.Rows.Clear();

            dgvTablaVerdad.Columns.Add("A", "A");
            dgvTablaVerdad.Columns.Add("B", "B");
            dgvTablaVerdad.Columns.Add("AND", "A AND B");
            dgvTablaVerdad.Columns.Add("OR", "A OR B");

            foreach (var fila in tabla)
            {
                dgvTablaVerdad.Rows.Add(fila);
            }

        }
        private void dgvTablaVerdad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
