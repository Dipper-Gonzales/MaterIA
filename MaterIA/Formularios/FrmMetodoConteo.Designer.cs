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
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTitulo.Location = new Point(366, 117);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(188, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MÉTODO DE CONTEO";
            lblTitulo.Click += label1_Click;
            // 
            // btnPermutaciones
            // 
            btnPermutaciones.Location = new Point(321, 187);
            btnPermutaciones.Margin = new Padding(4, 5, 4, 5);
            btnPermutaciones.Name = "btnPermutaciones";
            btnPermutaciones.Size = new Size(243, 38);
            btnPermutaciones.TabIndex = 1;
            btnPermutaciones.Text = "Permutaciones";
            btnPermutaciones.UseVisualStyleBackColor = true;
            btnPermutaciones.Click += btnPermutaciones_Click;
            // 
            // btnCombinaciones
            // 
            btnCombinaciones.Location = new Point(321, 263);
            btnCombinaciones.Margin = new Padding(4, 5, 4, 5);
            btnCombinaciones.Name = "btnCombinaciones";
            btnCombinaciones.Size = new Size(243, 38);
            btnCombinaciones.TabIndex = 2;
            btnCombinaciones.Text = "Combinaciones";
            btnCombinaciones.UseVisualStyleBackColor = true;
            btnCombinaciones.Click += btnCombinaciones_Click;
            // 
            // btnVariaciones
            // 
            btnVariaciones.Location = new Point(321, 343);
            btnVariaciones.Margin = new Padding(4, 5, 4, 5);
            btnVariaciones.Name = "btnVariaciones";
            btnVariaciones.Size = new Size(243, 38);
            btnVariaciones.TabIndex = 3;
            btnVariaciones.Text = "Variaciones";
            btnVariaciones.UseVisualStyleBackColor = true;
            btnVariaciones.Click += btnVariaciones_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(130, 36);
            button1.TabIndex = 5;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMetodoConteo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 735);
            Controls.Add(button1);
            Controls.Add(btnVariaciones);
            Controls.Add(btnCombinaciones);
            Controls.Add(btnPermutaciones);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button button1;
    }
}