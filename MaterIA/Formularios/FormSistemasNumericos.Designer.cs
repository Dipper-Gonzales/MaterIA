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
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(77, 87);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(149, 88);
            button1.TabIndex = 0;
            button1.Text = "Conversiones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonConjuntos
            // 
            buttonConjuntos.Location = new Point(281, 87);
            buttonConjuntos.Margin = new Padding(4, 5, 4, 5);
            buttonConjuntos.Name = "buttonConjuntos";
            buttonConjuntos.Size = new Size(149, 88);
            buttonConjuntos.TabIndex = 1;
            buttonConjuntos.Text = "Conjuntos";
            buttonConjuntos.UseVisualStyleBackColor = true;
            buttonConjuntos.Click += buttonConjuntos_Click;
            // 
            // buttonCalculadora
            // 
            buttonCalculadora.Location = new Point(487, 87);
            buttonCalculadora.Margin = new Padding(4, 5, 4, 5);
            buttonCalculadora.Name = "buttonCalculadora";
            buttonCalculadora.Size = new Size(149, 88);
            buttonCalculadora.TabIndex = 2;
            buttonCalculadora.Text = "Calculadora";
            buttonCalculadora.UseVisualStyleBackColor = true;
            buttonCalculadora.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // FormSistemasNumericos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_990787448_1024x1024;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 659);
            Controls.Add(button2);
            Controls.Add(buttonCalculadora);
            Controls.Add(buttonConjuntos);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormSistemasNumericos";
            Text = "FormSistemasNumericos";
            Load += FormSistemasNumericos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button buttonConjuntos;
        private Button buttonCalculadora;
        private Button button2;
    }
}