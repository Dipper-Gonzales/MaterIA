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
            button1 = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(60, 60);
            labelTitulo.Margin = new Padding(4, 0, 4, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(274, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Introduzca su numero a convertir";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // textEntrada
            // 
            textEntrada.Location = new Point(60, 102);
            textEntrada.Margin = new Padding(4, 5, 4, 5);
            textEntrada.Name = "textEntrada";
            textEntrada.Size = new Size(253, 31);
            textEntrada.TabIndex = 1;
            textEntrada.TextChanged += textEntrada_TextChanged;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(60, 193);
            labelResultado.Margin = new Padding(4, 0, 4, 0);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(99, 25);
            labelResultado.TabIndex = 4;
            labelResultado.Text = "Resultado: ";
            // 
            // comboTipoConversion
            // 
            comboTipoConversion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoConversion.FormattingEnabled = true;
            comboTipoConversion.Location = new Point(343, 102);
            comboTipoConversion.Margin = new Padding(4, 5, 4, 5);
            comboTipoConversion.Name = "comboTipoConversion";
            comboTipoConversion.Size = new Size(293, 33);
            comboTipoConversion.TabIndex = 5;
            // 
            // buttonConvertir
            // 
            buttonConvertir.Location = new Point(666, 102);
            buttonConvertir.Margin = new Padding(4, 5, 4, 5);
            buttonConvertir.Name = "buttonConvertir";
            buttonConvertir.Size = new Size(107, 38);
            buttonConvertir.TabIndex = 6;
            buttonConvertir.Text = "Convertir";
            buttonConvertir.UseVisualStyleBackColor = true;
            buttonConvertir.Click += buttonConvertir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormBinarioDecimal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(buttonConvertir);
            Controls.Add(comboTipoConversion);
            Controls.Add(labelResultado);
            Controls.Add(textEntrada);
            Controls.Add(labelTitulo);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button button1;
    }
}