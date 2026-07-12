namespace MaterIA.Formularios
{
    partial class FormSerieDeTaylor
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
            txtValorX = new TextBox();
            txtTerminos = new TextBox();
            btnExponencial = new Button();
            btnSeno = new Button();
            btnCoseno = new Button();
            btnLn = new Button();
            btnPi = new Button();
            lblResultado = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtValorX
            // 
            txtValorX.Location = new Point(742, 94);
            txtValorX.Name = "txtValorX";
            txtValorX.Size = new Size(143, 31);
            txtValorX.TabIndex = 0;
            // 
            // txtTerminos
            // 
            txtTerminos.Location = new Point(742, 145);
            txtTerminos.Name = "txtTerminos";
            txtTerminos.Size = new Size(143, 31);
            txtTerminos.TabIndex = 1;
            // 
            // btnExponencial
            // 
            btnExponencial.Location = new Point(263, 72);
            btnExponencial.Name = "btnExponencial";
            btnExponencial.Size = new Size(143, 36);
            btnExponencial.TabIndex = 2;
            btnExponencial.Text = "calcular e^x";
            btnExponencial.UseVisualStyleBackColor = true;
            btnExponencial.Click += btnExponencial_Click_1;
            // 
            // btnSeno
            // 
            btnSeno.Location = new Point(263, 117);
            btnSeno.Name = "btnSeno";
            btnSeno.Size = new Size(143, 35);
            btnSeno.TabIndex = 3;
            btnSeno.Text = "calcular sen(x)";
            btnSeno.UseVisualStyleBackColor = true;
            btnSeno.Click += btnSeno_Click_1;
            // 
            // btnCoseno
            // 
            btnCoseno.Location = new Point(263, 158);
            btnCoseno.Name = "btnCoseno";
            btnCoseno.Size = new Size(143, 40);
            btnCoseno.TabIndex = 4;
            btnCoseno.Text = "calcular cos(x)";
            btnCoseno.UseVisualStyleBackColor = true;
            btnCoseno.Click += btnCoseno_Click;
            // 
            // btnLn
            // 
            btnLn.Location = new Point(263, 204);
            btnLn.Name = "btnLn";
            btnLn.Size = new Size(143, 38);
            btnLn.TabIndex = 5;
            btnLn.Text = "calcular ln(x)";
            btnLn.UseVisualStyleBackColor = true;
            btnLn.Click += btnLn_Click;
            // 
            // btnPi
            // 
            btnPi.Location = new Point(263, 248);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(143, 38);
            btnPi.TabIndex = 6;
            btnPi.Text = "calcular Pi";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += btnPi_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(949, 72);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(94, 25);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            lblResultado.Click += lblResultado_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(120, 30);
            button1.TabIndex = 8;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormSerieDeTaylor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 626);
            Controls.Add(button1);
            Controls.Add(lblResultado);
            Controls.Add(btnPi);
            Controls.Add(btnLn);
            Controls.Add(btnCoseno);
            Controls.Add(btnSeno);
            Controls.Add(btnExponencial);
            Controls.Add(txtTerminos);
            Controls.Add(txtValorX);
            Name = "FormSerieDeTaylor";
            Text = "FormSerieDeTaylor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorX;
        private TextBox txtTerminos;
        private Button btnExponencial;
        private Button btnSeno;
        private Button btnCoseno;
        private Button btnLn;
        private Button btnPi;
        private Label lblResultado;
        private Button button1;
    }
}