namespace MaterIA.Formularios
{
    partial class FormVariaciones
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
            btnCalcular = new Button();
            Resultado = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtN
            // 
            txtN.Location = new Point(476, 68);
            txtN.Name = "txtN";
            txtN.Size = new Size(114, 31);
            txtN.TabIndex = 0;
            // 
            // txtR
            // 
            txtR.Location = new Point(476, 134);
            txtR.Name = "txtR";
            txtR.Size = new Size(114, 31);
            txtR.TabIndex = 1;
            txtR.TextChanged += txtR_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(224, 67);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(84, 32);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(804, 79);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(94, 25);
            Resultado.TabIndex = 3;
            Resultado.Text = "Resultado:";
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(95, 36);
            button2.TabIndex = 4;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormVariaciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 644);
            Controls.Add(button2);
            Controls.Add(Resultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtR);
            Controls.Add(txtN);
            Name = "FormVariaciones";
            Text = "FormVariaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN;
        private TextBox txtR;
        private Button btnCalcular;
        private Label Resultado;
        private Button button2;
    }
}