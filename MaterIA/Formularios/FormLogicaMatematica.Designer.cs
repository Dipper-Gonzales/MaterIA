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
            button3 = new Button();
            button4 = new Button();
            buttonNOT = new Button();
            btnNotB = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(166, 285);
            button1.Name = "button1";
            button1.Size = new Size(80, 50);
            button1.TabIndex = 0;
            button1.Text = "AND";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtValorA
            // 
            txtValorA.Location = new Point(73, 87);
            txtValorA.Name = "txtValorA";
            txtValorA.ReadOnly = true;
            txtValorA.Size = new Size(173, 31);
            txtValorA.TabIndex = 1;
            txtValorA.Text = "Presione un numero";
            // 
            // txtValorB
            // 
            txtValorB.Location = new Point(71, 198);
            txtValorB.Name = "txtValorB";
            txtValorB.ReadOnly = true;
            txtValorB.Size = new Size(173, 31);
            txtValorB.TabIndex = 2;
            txtValorB.Text = "Presione un numero";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(524, 87);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(94, 25);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // button2
            // 
            button2.Location = new Point(71, 285);
            button2.Name = "button2";
            button2.Size = new Size(80, 50);
            button2.TabIndex = 4;
            button2.Text = "OR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonpres1
            // 
            buttonpres1.Location = new Point(319, 87);
            buttonpres1.Margin = new Padding(4, 5, 4, 5);
            buttonpres1.Name = "buttonpres1";
            buttonpres1.Size = new Size(49, 37);
            buttonpres1.TabIndex = 5;
            buttonpres1.Text = "1";
            buttonpres1.UseVisualStyleBackColor = true;
            buttonpres1.Click += buttonpres1_Click;
            // 
            // buttonpres0
            // 
            buttonpres0.Location = new Point(253, 87);
            buttonpres0.Margin = new Padding(4, 5, 4, 5);
            buttonpres0.Name = "buttonpres0";
            buttonpres0.Size = new Size(49, 37);
            buttonpres0.TabIndex = 6;
            buttonpres0.Text = "0";
            buttonpres0.UseVisualStyleBackColor = true;
            buttonpres0.Click += buttonpres0_Click;
            // 
            // buttonpress1
            // 
            buttonpress1.Location = new Point(319, 192);
            buttonpress1.Margin = new Padding(4, 5, 4, 5);
            buttonpress1.Name = "buttonpress1";
            buttonpress1.Size = new Size(49, 37);
            buttonpress1.TabIndex = 7;
            buttonpress1.Text = "1";
            buttonpress1.UseVisualStyleBackColor = true;
            buttonpress1.Click += buttonpress1_Click;
            // 
            // buttonpress0
            // 
            buttonpress0.Location = new Point(253, 192);
            buttonpress0.Margin = new Padding(4, 5, 4, 5);
            buttonpress0.Name = "buttonpress0";
            buttonpress0.Size = new Size(49, 37);
            buttonpress0.TabIndex = 8;
            buttonpress0.Text = "0";
            buttonpress0.UseVisualStyleBackColor = true;
            buttonpress0.Click += buttonpress0_Click;
            // 
            // button3
            // 
            button3.Location = new Point(731, 102);
            button3.Name = "button3";
            button3.Size = new Size(213, 127);
            button3.TabIndex = 9;
            button3.Text = "Mostrar tabla de verdad ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 12);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 10;
            button4.Text = "Regresar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonNOT
            // 
            buttonNOT.Location = new Point(264, 285);
            buttonNOT.Name = "buttonNOT";
            buttonNOT.Size = new Size(80, 50);
            buttonNOT.TabIndex = 11;
            buttonNOT.Text = "NOT-A";
            buttonNOT.UseVisualStyleBackColor = true;
            buttonNOT.Click += buttonNOT_Click;
            // 
            // btnNotB
            // 
            btnNotB.Location = new Point(362, 285);
            btnNotB.Name = "btnNotB";
            btnNotB.Size = new Size(80, 50);
            btnNotB.TabIndex = 12;
            btnNotB.Text = "NOT-B";
            btnNotB.UseVisualStyleBackColor = true;
            btnNotB.Click += btnNotB_Click;
            // 
            // FormLogicaMatematica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 547);
            Controls.Add(btnNotB);
            Controls.Add(buttonNOT);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(buttonpress0);
            Controls.Add(buttonpress1);
            Controls.Add(buttonpres0);
            Controls.Add(buttonpres1);
            Controls.Add(button2);
            Controls.Add(lblResultado);
            Controls.Add(txtValorB);
            Controls.Add(txtValorA);
            Controls.Add(button1);
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
        private Button button3;
        private Button button4;
        private Button buttonNOT;
        private Button btnNotB;
    }
}