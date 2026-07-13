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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSistemasNumericos));
            button1 = new Button();
            buttonConjuntos = new Button();
            buttonCalculadora = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(368, 380);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(623, 115);
            button1.TabIndex = 0;
            button1.Text = "Conversiones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonConjuntos
            // 
            buttonConjuntos.Anchor = AnchorStyles.None;
            buttonConjuntos.FlatStyle = FlatStyle.Flat;
            buttonConjuntos.Location = new Point(368, 236);
            buttonConjuntos.Margin = new Padding(4, 5, 4, 5);
            buttonConjuntos.Name = "buttonConjuntos";
            buttonConjuntos.Size = new Size(623, 115);
            buttonConjuntos.TabIndex = 1;
            buttonConjuntos.Text = "Conjuntos";
            buttonConjuntos.UseVisualStyleBackColor = true;
            buttonConjuntos.Click += buttonConjuntos_Click;
            // 
            // buttonCalculadora
            // 
            buttonCalculadora.Anchor = AnchorStyles.None;
            buttonCalculadora.FlatStyle = FlatStyle.Flat;
            buttonCalculadora.Location = new Point(368, 95);
            buttonCalculadora.Margin = new Padding(4, 5, 4, 5);
            buttonCalculadora.Name = "buttonCalculadora";
            buttonCalculadora.Size = new Size(623, 115);
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
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(368, 526);
            button3.Name = "button3";
            button3.Size = new Size(628, 115);
            button3.TabIndex = 4;
            button3.Text = "Serie de taylor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(227, 135);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 5;
            button4.Text = "1";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(227, 276);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 6;
            button5.Text = "2";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Location = new Point(227, 420);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 7;
            button6.Text = "3";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.Location = new Point(227, 566);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 8;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = true;
            // 
            // FormSistemasNumericos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 750);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
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
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}