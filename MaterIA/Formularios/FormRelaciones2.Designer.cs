namespace MaterIA.Formularios
{
    partial class FormRelaciones2
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
            txtC1 = new TextBox();
            txtC2 = new TextBox();
            txtA0 = new TextBox();
            txtA1 = new TextBox();
            txtN = new TextBox();
            txtD = new TextBox();
            btnEcuacionCaracteristica = new Button();
            btnHomogenea = new Button();
            btnNoHomogenea = new Button();
            lblResultado = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtC1
            // 
            txtC1.Location = new Point(441, 63);
            txtC1.Name = "txtC1";
            txtC1.Size = new Size(101, 31);
            txtC1.TabIndex = 0;
            txtC1.TextChanged += txtC1_TextChanged;
            // 
            // txtC2
            // 
            txtC2.Location = new Point(441, 128);
            txtC2.Name = "txtC2";
            txtC2.Size = new Size(101, 31);
            txtC2.TabIndex = 1;
            // 
            // txtA0
            // 
            txtA0.Location = new Point(441, 190);
            txtA0.Name = "txtA0";
            txtA0.Size = new Size(101, 31);
            txtA0.TabIndex = 2;
            // 
            // txtA1
            // 
            txtA1.Location = new Point(441, 252);
            txtA1.Name = "txtA1";
            txtA1.Size = new Size(101, 31);
            txtA1.TabIndex = 3;
            // 
            // txtN
            // 
            txtN.Location = new Point(441, 314);
            txtN.Name = "txtN";
            txtN.Size = new Size(101, 31);
            txtN.TabIndex = 4;
            // 
            // txtD
            // 
            txtD.Location = new Point(441, 376);
            txtD.Name = "txtD";
            txtD.Size = new Size(101, 31);
            txtD.TabIndex = 5;
            // 
            // btnEcuacionCaracteristica
            // 
            btnEcuacionCaracteristica.Location = new Point(52, 61);
            btnEcuacionCaracteristica.Name = "btnEcuacionCaracteristica";
            btnEcuacionCaracteristica.Size = new Size(165, 64);
            btnEcuacionCaracteristica.TabIndex = 6;
            btnEcuacionCaracteristica.Text = "Ecuacion Caracteristica";
            btnEcuacionCaracteristica.UseVisualStyleBackColor = true;
            btnEcuacionCaracteristica.Click += btnEcuacionCaracteristica_Click;
            // 
            // btnHomogenea
            // 
            btnHomogenea.Location = new Point(46, 161);
            btnHomogenea.Name = "btnHomogenea";
            btnHomogenea.Size = new Size(171, 34);
            btnHomogenea.TabIndex = 7;
            btnHomogenea.Text = "Homogenea";
            btnHomogenea.UseVisualStyleBackColor = true;
            btnHomogenea.Click += btnHomogenea_Click;
            // 
            // btnNoHomogenea
            // 
            btnNoHomogenea.Location = new Point(46, 233);
            btnNoHomogenea.Name = "btnNoHomogenea";
            btnNoHomogenea.Size = new Size(171, 31);
            btnNoHomogenea.TabIndex = 8;
            btnNoHomogenea.Text = "No Homogenea";
            btnNoHomogenea.UseVisualStyleBackColor = true;
            btnNoHomogenea.Click += btnNoHomogenea_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(714, 81);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(94, 25);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(106, 33);
            button1.TabIndex = 10;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(468, 35);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 11;
            label1.Text = "C:1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 100);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 12;
            label2.Text = "C:2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 162);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 13;
            label3.Text = "A:0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 224);
            label4.Name = "label4";
            label4.Size = new Size(38, 25);
            label4.TabIndex = 14;
            label4.Text = "A:1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 286);
            label5.Name = "label5";
            label5.Size = new Size(25, 25);
            label5.TabIndex = 15;
            label5.Text = "N";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 348);
            label6.Name = "label6";
            label6.Size = new Size(25, 25);
            label6.TabIndex = 16;
            label6.Text = "D";
            // 
            // FormRelaciones2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 704);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblResultado);
            Controls.Add(btnNoHomogenea);
            Controls.Add(btnHomogenea);
            Controls.Add(btnEcuacionCaracteristica);
            Controls.Add(txtD);
            Controls.Add(txtN);
            Controls.Add(txtA1);
            Controls.Add(txtA0);
            Controls.Add(txtC2);
            Controls.Add(txtC1);
            Name = "FormRelaciones2";
            Text = "FormRelacionRecurrencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtC1;
        private TextBox txtC2;
        private TextBox txtA0;
        private TextBox txtA1;
        private TextBox txtN;
        private TextBox txtD;
        private Button btnEcuacionCaracteristica;
        private Button btnHomogenea;
        private Button btnNoHomogenea;
        private Label lblResultado;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}