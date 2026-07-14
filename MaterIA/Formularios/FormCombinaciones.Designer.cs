namespace MaterIA.Formularios
{
    partial class FormCombinaciones
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
            txtN = new TextBox();
            txtR = new TextBox();
            calcular = new Button();
            Resultado = new Label();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // txtN
            // 
            txtN.Location = new Point(320, 81);
            txtN.Name = "txtN";
            txtN.Size = new Size(129, 31);
            txtN.TabIndex = 0;
            // 
            // txtR
            // 
            txtR.Location = new Point(320, 134);
            txtR.Name = "txtR";
            txtR.Size = new Size(129, 31);
            txtR.TabIndex = 1;
            // 
            // calcular
            // 
            calcular.Location = new Point(85, 74);
            calcular.Name = "calcular";
            calcular.Size = new Size(128, 38);
            calcular.TabIndex = 2;
            calcular.Text = "Calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(647, 74);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(94, 25);
            Resultado.TabIndex = 3;
            Resultado.Text = "Resultado:";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(110, 31);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regrasar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FormCombinaciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(Resultado);
            Controls.Add(calcular);
            Controls.Add(txtR);
            Controls.Add(txtN);
            Name = "FormCombinaciones";
            Text = "FormCombinaciones";
            Load += FormCombinaciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN;
        private TextBox txtR;
        private Button calcular;
        private Label Resultado;
        private Button btnRegresar;
    }
}