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
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(699, 132);
            btnCalcular.Margin = new Padding(4, 5, 4, 5);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 38);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // comboTipo
            // 
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.FormattingEnabled = true;
            comboTipo.Location = new Point(663, 37);
            comboTipo.Margin = new Padding(4, 5, 4, 5);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(171, 33);
            comboTipo.TabIndex = 1;
            comboTipo.SelectedIndexChanged += comboTipo_SelectedIndexChanged_1;
            // 
            // txtC1
            // 
            txtC1.Location = new Point(101, 82);
            txtC1.Margin = new Padding(4, 5, 4, 5);
            txtC1.Name = "txtC1";
            txtC1.Size = new Size(141, 31);
            txtC1.TabIndex = 2;
            // 
            // txtC2
            // 
            txtC2.Location = new Point(280, 82);
            txtC2.Margin = new Padding(4, 5, 4, 5);
            txtC2.Name = "txtC2";
            txtC2.Size = new Size(141, 31);
            txtC2.TabIndex = 3;
            // 
            // txtK
            // 
            txtK.Location = new Point(101, 175);
            txtK.Margin = new Padding(4, 5, 4, 5);
            txtK.Name = "txtK";
            txtK.Size = new Size(141, 31);
            txtK.TabIndex = 4;
            // 
            // txtA1
            // 
            txtA1.Location = new Point(101, 280);
            txtA1.Margin = new Padding(4, 5, 4, 5);
            txtA1.Name = "txtA1";
            txtA1.Size = new Size(141, 31);
            txtA1.TabIndex = 5;
            // 
            // txtA2
            // 
            txtA2.Location = new Point(280, 280);
            txtA2.Margin = new Padding(4, 5, 4, 5);
            txtA2.Name = "txtA2";
            txtA2.Size = new Size(141, 31);
            txtA2.TabIndex = 6;
            // 
            // txtN
            // 
            txtN.Location = new Point(101, 388);
            txtN.Margin = new Padding(4, 5, 4, 5);
            txtN.Name = "txtN";
            txtN.Size = new Size(141, 31);
            txtN.TabIndex = 7;
            // 
            // listBoxResultado
            // 
            listBoxResultado.FormattingEnabled = true;
            listBoxResultado.Location = new Point(881, 37);
            listBoxResultado.Margin = new Padding(4, 5, 4, 5);
            listBoxResultado.Name = "listBoxResultado";
            listBoxResultado.Size = new Size(170, 304);
            listBoxResultado.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 9;
            label1.Text = "C1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 10;
            label2.Text = "C2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 145);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 25);
            label3.TabIndex = 11;
            label3.Text = "K:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 245);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(35, 25);
            label4.TabIndex = 12;
            label4.Text = "a1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 245);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(35, 25);
            label5.TabIndex = 13;
            label5.Text = "a2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(156, 350);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 30);
            label6.TabIndex = 14;
            label6.Text = "n:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 15;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormRelaciones1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Button button1;
    }
}