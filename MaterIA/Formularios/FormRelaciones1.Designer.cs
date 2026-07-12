namespace MaterIA.Formularios
{
    partial class FormRelaciones1
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
            btnCalcular = new Button();
            comboTipo = new ComboBox();
            txtC1 = new TextBox();
            txtC2 = new TextBox();
            txtK = new TextBox();
            txtA1 = new TextBox();
            txtA2 = new TextBox();
            txtN = new TextBox();
            listBoxResultado = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(489, 79);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // comboTipo
            // 
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.FormattingEnabled = true;
            comboTipo.Location = new Point(464, 22);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(121, 23);
            comboTipo.TabIndex = 1;
            comboTipo.SelectedIndexChanged += comboTipo_SelectedIndexChanged_1;
            // 
            // txtC1
            // 
            txtC1.Location = new Point(71, 49);
            txtC1.Name = "txtC1";
            txtC1.Size = new Size(100, 23);
            txtC1.TabIndex = 2;
            // 
            // txtC2
            // 
            txtC2.Location = new Point(196, 49);
            txtC2.Name = "txtC2";
            txtC2.Size = new Size(100, 23);
            txtC2.TabIndex = 3;
            // 
            // txtK
            // 
            txtK.Location = new Point(71, 105);
            txtK.Name = "txtK";
            txtK.Size = new Size(100, 23);
            txtK.TabIndex = 4;
            // 
            // txtA1
            // 
            txtA1.Location = new Point(71, 168);
            txtA1.Name = "txtA1";
            txtA1.Size = new Size(100, 23);
            txtA1.TabIndex = 5;
            // 
            // txtA2
            // 
            txtA2.Location = new Point(196, 168);
            txtA2.Name = "txtA2";
            txtA2.Size = new Size(100, 23);
            txtA2.TabIndex = 6;
            // 
            // txtN
            // 
            txtN.Location = new Point(71, 233);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 7;
            // 
            // listBoxResultado
            // 
            listBoxResultado.FormattingEnabled = true;
            listBoxResultado.Location = new Point(617, 22);
            listBoxResultado.Name = "listBoxResultado";
            listBoxResultado.Size = new Size(120, 184);
            listBoxResultado.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 22);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 9;
            label1.Text = "C1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 22);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 10;
            label2.Text = "C2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 87);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 11;
            label3.Text = "K:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 147);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 12;
            label4.Text = "a1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 147);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 13;
            label5.Text = "a2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(109, 210);
            label6.Name = "label6";
            label6.Size = new Size(20, 20);
            label6.TabIndex = 14;
            label6.Text = "n:";
            // 
            // FormRelaciones1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxResultado);
            Controls.Add(txtN);
            Controls.Add(txtA2);
            Controls.Add(txtA1);
            Controls.Add(txtK);
            Controls.Add(txtC2);
            Controls.Add(txtC1);
            Controls.Add(comboTipo);
            Controls.Add(btnCalcular);
            Name = "FormRelaciones1";
            Text = "FormRelaciones1";
            Load += FormRelaciones1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private ComboBox comboTipo;
        private TextBox txtC1;
        private TextBox txtC2;
        private TextBox txtK;
        private TextBox txtA1;
        private TextBox txtA2;
        private TextBox txtN;
        private ListBox listBoxResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}