namespace MaterIA.Formularios
{
    partial class FormSistemasNumericos
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
            button1 = new Button();
            buttonConjuntos = new Button();
            buttonCalculadora = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(54, 52);
            button1.Name = "button1";
            button1.Size = new Size(104, 53);
            button1.TabIndex = 0;
            button1.Text = "Conversiones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonConjuntos
            // 
            buttonConjuntos.Location = new Point(197, 52);
            buttonConjuntos.Name = "buttonConjuntos";
            buttonConjuntos.Size = new Size(104, 53);
            buttonConjuntos.TabIndex = 1;
            buttonConjuntos.Text = "Conjuntos";
            buttonConjuntos.UseVisualStyleBackColor = true;
            buttonConjuntos.Click += buttonConjuntos_Click;
            // 
            // buttonCalculadora
            // 
            buttonCalculadora.Location = new Point(341, 52);
            buttonCalculadora.Name = "buttonCalculadora";
            buttonCalculadora.Size = new Size(104, 53);
            buttonCalculadora.TabIndex = 2;
            buttonCalculadora.Text = "Calculadora";
            buttonCalculadora.UseVisualStyleBackColor = true;
            buttonCalculadora.Click += button2_Click;
            // 
            // FormSistemasNumericos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalculadora);
            Controls.Add(buttonConjuntos);
            Controls.Add(button1);
            Name = "FormSistemasNumericos";
            Text = "FormSistemasNumericos";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button buttonConjuntos;
        private Button buttonCalculadora;
    }
}