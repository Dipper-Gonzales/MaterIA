namespace MaterIA.Formularios
{
    partial class FrmMetodoConteo
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
            lblTitulo = new Label();
            btnPermutaciones = new Button();
            btnCombinaciones = new Button();
            btnVariaciones = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTitulo.Location = new Point(256, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 13);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MÉTODO DE CONTEO";
            lblTitulo.Click += label1_Click;
            // 
            // btnPermutaciones
            // 
            btnPermutaciones.Location = new Point(225, 112);
            btnPermutaciones.Name = "btnPermutaciones";
            btnPermutaciones.Size = new Size(170, 23);
            btnPermutaciones.TabIndex = 1;
            btnPermutaciones.Text = "Permutaciones";
            btnPermutaciones.UseVisualStyleBackColor = true;
            btnPermutaciones.Click += btnPermutaciones_Click;
            // 
            // btnCombinaciones
            // 
            btnCombinaciones.Location = new Point(225, 158);
            btnCombinaciones.Name = "btnCombinaciones";
            btnCombinaciones.Size = new Size(170, 23);
            btnCombinaciones.TabIndex = 2;
            btnCombinaciones.Text = "Combinaciones";
            btnCombinaciones.UseVisualStyleBackColor = true;
            // 
            // btnVariaciones
            // 
            btnVariaciones.Location = new Point(225, 206);
            btnVariaciones.Name = "btnVariaciones";
            btnVariaciones.Size = new Size(170, 23);
            btnVariaciones.TabIndex = 3;
            btnVariaciones.Text = "Variaciones";
            btnVariaciones.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(225, 255);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(170, 23);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // FrmMetodoConteo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 441);
            Controls.Add(btnRegresar);
            Controls.Add(btnVariaciones);
            Controls.Add(btnCombinaciones);
            Controls.Add(btnPermutaciones);
            Controls.Add(lblTitulo);
            Name = "FrmMetodoConteo";
            Text = "FrmMetodoConteo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnPermutaciones;
        private Button btnCombinaciones;
        private Button btnVariaciones;
        private Button btnRegresar;
    }
}