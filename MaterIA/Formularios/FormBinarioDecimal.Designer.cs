namespace MaterIA.Formularios
{
    partial class FormBinarioDecimal
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
            labelTitulo = new Label();
            textEntrada = new TextBox();
            buttonBinarioDecimal = new Button();
            buttonDecimalBinario = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(42, 26);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(177, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Conversion Binario <-> Decimal";
            // 
            // textEntrada
            // 
            textEntrada.Location = new Point(69, 56);
            textEntrada.Name = "textEntrada";
            textEntrada.Size = new Size(100, 23);
            textEntrada.TabIndex = 1;
            // 
            // buttonBinarioDecimal
            // 
            buttonBinarioDecimal.Location = new Point(246, 22);
            buttonBinarioDecimal.Name = "buttonBinarioDecimal";
            buttonBinarioDecimal.Size = new Size(225, 23);
            buttonBinarioDecimal.TabIndex = 2;
            buttonBinarioDecimal.Text = "Convertir Binario a Decimal";
            buttonBinarioDecimal.UseVisualStyleBackColor = true;
            buttonBinarioDecimal.Click += buttonBinarioDecimal_Click;
            // 
            // buttonDecimalBinario
            // 
            buttonDecimalBinario.Location = new Point(246, 56);
            buttonDecimalBinario.Name = "buttonDecimalBinario";
            buttonDecimalBinario.Size = new Size(225, 23);
            buttonDecimalBinario.TabIndex = 3;
            buttonDecimalBinario.Text = "Convertir Decimal a Binario";
            buttonDecimalBinario.UseVisualStyleBackColor = true;
            buttonDecimalBinario.Click += buttonDecimalBinario_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(521, 44);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(13, 15);
            labelResultado.TabIndex = 4;
            labelResultado.Text = "0";
            // 
            // FormBinarioDecimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultado);
            Controls.Add(buttonDecimalBinario);
            Controls.Add(buttonBinarioDecimal);
            Controls.Add(textEntrada);
            Controls.Add(labelTitulo);
            Name = "FormBinarioDecimal";
            Text = "FormBinarioDecimal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox textEntrada;
        private Button buttonBinarioDecimal;
        private Button buttonDecimalBinario;
        private Label labelResultado;
    }
}