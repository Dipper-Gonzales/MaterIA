namespace MaterIA.Formularios
{
    partial class FormTablaVerdadCompleta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTablaVerdad = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTablaVerdad).BeginInit();
            SuspendLayout();
            // 
            // dgvTablaVerdad
            // 
            dgvTablaVerdad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaVerdad.Location = new Point(106, 101);
            dgvTablaVerdad.Name = "dgvTablaVerdad";
            dgvTablaVerdad.RowHeadersWidth = 62;
            dgvTablaVerdad.Size = new Size(987, 435);
            dgvTablaVerdad.TabIndex = 0;
            dgvTablaVerdad.CellContentClick += dgvTablaVerdad_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormTablaVerdadCompleta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 733);
            Controls.Add(button1);
            Controls.Add(dgvTablaVerdad);
            Name = "FormTablaVerdadCompleta";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvTablaVerdad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTablaVerdad;
        private Button button1;
    }
}