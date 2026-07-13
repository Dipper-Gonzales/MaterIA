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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMetodoConteo));
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
            lblTitulo.Location = new Point(325, 58);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 13);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MÉTODO DE CONTEO";
            lblTitulo.Click += label1_Click;
            // 
            // btnPermutaciones
            // 
            btnPermutaciones.BackColor = SystemColors.Highlight;
            btnPermutaciones.Location = new Point(300, 132);
            btnPermutaciones.Name = "btnPermutaciones";
            btnPermutaciones.Size = new Size(170, 54);
            btnPermutaciones.TabIndex = 1;
            btnPermutaciones.Text = "Permutaciones";
            btnPermutaciones.UseVisualStyleBackColor = false;
            btnPermutaciones.Click += btnPermutaciones_Click;
            // 
            // btnCombinaciones
            // 
            btnCombinaciones.BackColor = SystemColors.ActiveCaption;
            btnCombinaciones.Location = new Point(300, 209);
            btnCombinaciones.Name = "btnCombinaciones";
            btnCombinaciones.Size = new Size(170, 56);
            btnCombinaciones.TabIndex = 2;
            btnCombinaciones.Text = "Combinaciones";
            btnCombinaciones.UseVisualStyleBackColor = false;
            btnCombinaciones.Click += btnCombinaciones_Click;
            // 
            // btnVariaciones
            // 
            btnVariaciones.BackColor = SystemColors.InactiveCaption;
            btnVariaciones.Location = new Point(300, 289);
            btnVariaciones.Name = "btnVariaciones";
            btnVariaciones.Size = new Size(170, 54);
            btnVariaciones.TabIndex = 3;
            btnVariaciones.Text = "Variaciones";
            btnVariaciones.UseVisualStyleBackColor = false;
            btnVariaciones.Click += btnVariaciones_Click;
            // 
            // button1
            // 
            button1.Location = new Point(8, 7);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(91, 22);
            button1.TabIndex = 5;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMetodoConteo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(821, 441);
            Controls.Add(button1);
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
        private Button button1;
    }
}