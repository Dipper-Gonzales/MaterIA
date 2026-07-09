namespace MaterIA.Formularios
{
    partial class FormLogicaMatematica
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
            txtValorA = new TextBox();
            txtValorB = new TextBox();
            lblResultado = new Label();
            button2 = new Button();
            buttonpres1 = new Button();
            buttonpres0 = new Button();
            buttonpress1 = new Button();
            buttonpress0 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(135, 143);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(56, 30);
            button1.TabIndex = 0;
            button1.Text = "AND";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtValorA
            // 
            txtValorA.Location = new Point(50, 24);
            txtValorA.Margin = new Padding(2);
            txtValorA.Name = "txtValorA";
            txtValorA.ReadOnly = true;
            txtValorA.Size = new Size(122, 23);
            txtValorA.TabIndex = 1;
            txtValorA.Text = "Presione un numero";
            // 
            // txtValorB
            // 
            txtValorB.Location = new Point(50, 78);
            txtValorB.Margin = new Padding(2);
            txtValorB.Name = "txtValorB";
            txtValorB.Size = new Size(122, 23);
            txtValorB.TabIndex = 2;
            txtValorB.Text = "Presione un numero";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(367, 39);
            lblResultado.Margin = new Padding(2, 0, 2, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // button2
            // 
            button2.Location = new Point(50, 143);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(56, 30);
            button2.TabIndex = 4;
            button2.Text = "OR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonpres1
            // 
            buttonpres1.Location = new Point(217, 25);
            buttonpres1.Name = "buttonpres1";
            buttonpres1.Size = new Size(34, 22);
            buttonpres1.TabIndex = 5;
            buttonpres1.Text = "1";
            buttonpres1.UseVisualStyleBackColor = true;
            buttonpres1.Click += buttonpres1_Click;
            // 
            // buttonpres0
            // 
            buttonpres0.Location = new Point(177, 25);
            buttonpres0.Name = "buttonpres0";
            buttonpres0.Size = new Size(34, 22);
            buttonpres0.TabIndex = 6;
            buttonpres0.Text = "0";
            buttonpres0.UseVisualStyleBackColor = true;
            buttonpres0.Click += buttonpres0_Click;
            // 
            // buttonpress1
            // 
            buttonpress1.Location = new Point(217, 79);
            buttonpress1.Name = "buttonpress1";
            buttonpress1.Size = new Size(34, 22);
            buttonpress1.TabIndex = 7;
            buttonpress1.Text = "1";
            buttonpress1.UseVisualStyleBackColor = true;
            buttonpress1.Click += buttonpress1_Click;
            // 
            // buttonpress0
            // 
            buttonpress0.Location = new Point(177, 79);
            buttonpress0.Name = "buttonpress0";
            buttonpress0.Size = new Size(34, 22);
            buttonpress0.TabIndex = 8;
            buttonpress0.Text = "0";
            buttonpress0.UseVisualStyleBackColor = true;
            buttonpress0.Click += buttonpress0_Click;
            // 
            // FormLogicaMatematica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 328);
            Controls.Add(buttonpress0);
            Controls.Add(buttonpress1);
            Controls.Add(buttonpres0);
            Controls.Add(buttonpres1);
            Controls.Add(button2);
            Controls.Add(lblResultado);
            Controls.Add(txtValorB);
            Controls.Add(txtValorA);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "FormLogicaMatematica";
            Text = "FormLogicaMatematica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtValorA;
        private TextBox txtValorB;
        private Label lblResultado;
        private Button button2;
        private Button buttonpres1;
        private Button buttonpres0;
        private Button buttonpress1;
        private Button buttonpress0;
    }
}