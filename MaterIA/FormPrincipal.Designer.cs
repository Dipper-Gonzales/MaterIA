namespace MaterIA
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            buttonBinarioDecimal = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(346, 23);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(115, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Matematica Discreta";
            // 
            // buttonBinarioDecimal
            // 
            buttonBinarioDecimal.Location = new Point(64, 68);
            buttonBinarioDecimal.Name = "buttonBinarioDecimal";
            buttonBinarioDecimal.Size = new Size(97, 48);
            buttonBinarioDecimal.TabIndex = 1;
            buttonBinarioDecimal.Text = "Logica Matematica";
            buttonBinarioDecimal.UseVisualStyleBackColor = true;
            buttonBinarioDecimal.Click += buttonBinarioDecimal_Click;
            // 
            // button1
            // 
            button1.Location = new Point(210, 68);
            button1.Name = "button1";
            button1.Size = new Size(89, 48);
            button1.TabIndex = 2;
            button1.Text = "Sitemas Numericos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(346, 68);
            button2.Name = "button2";
            button2.Size = new Size(85, 48);
            button2.TabIndex = 3;
            button2.Text = "Metodos de conteo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 453);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonBinarioDecimal);
            Controls.Add(labelTitulo);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button buttonBinarioDecimal;
        private Button button1;
        private Button button2;
    }
}
