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
            labelResultado = new Label();
            comboTipoConversion = new ComboBox();
            buttonConvertir = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(42, 28);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(182, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Introduzca su numero a convertir";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // textEntrada
            // 
            textEntrada.Location = new Point(42, 61);
            textEntrada.Name = "textEntrada";
            textEntrada.Size = new Size(178, 23);
            textEntrada.TabIndex = 1;
            textEntrada.TextChanged += textEntrada_TextChanged;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(42, 116);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(65, 15);
            labelResultado.TabIndex = 4;
            labelResultado.Text = "Resultado: ";
            // 
            // comboTipoConversion
            // 
            comboTipoConversion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoConversion.FormattingEnabled = true;
            comboTipoConversion.Location = new Point(240, 61);
            comboTipoConversion.Name = "comboTipoConversion";
            comboTipoConversion.Size = new Size(206, 23);
            comboTipoConversion.TabIndex = 5;
            // 
            // buttonConvertir
            // 
            buttonConvertir.Location = new Point(466, 61);
            buttonConvertir.Name = "buttonConvertir";
            buttonConvertir.Size = new Size(75, 23);
            buttonConvertir.TabIndex = 6;
            buttonConvertir.Text = "Convertir";
            buttonConvertir.UseVisualStyleBackColor = true;
            buttonConvertir.Click += buttonConvertir_Click;
            // 
            // FormBinarioDecimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConvertir);
            Controls.Add(comboTipoConversion);
            Controls.Add(labelResultado);
            Controls.Add(textEntrada);
            Controls.Add(labelTitulo);
            Name = "FormBinarioDecimal";
            Text = "FormBinarioDecimal";
            Load += FormBinarioDecimal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox textEntrada;
        private Label labelResultado;
        private ComboBox comboTipoConversion;
        private Button buttonConvertir;
    }
}