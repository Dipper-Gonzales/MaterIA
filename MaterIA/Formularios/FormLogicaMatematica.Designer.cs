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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(183, 40);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "AND";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtValorA
            // 
            txtValorA.Location = new Point(136, 209);
            txtValorA.Name = "txtValorA";
            txtValorA.Size = new Size(150, 31);
            txtValorA.TabIndex = 1;
            // 
            // txtValorB
            // 
            txtValorB.Location = new Point(463, 209);
            txtValorB.Name = "txtValorB";
            txtValorB.Size = new Size(150, 31);
            txtValorB.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(524, 65);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 25);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
            // 
            // FormLogicaMatematica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}