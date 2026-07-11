namespace MaterIA.Formularios
{
    partial class CalculadoraSisNumericos
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
            txtPantalla = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnSuma = new Button();
            btnResta = new Button();
            A = new Button();
            B = new Button();
            C = new Button();
            D = new Button();
            E = new Button();
            F = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            comboBase = new ComboBox();
            btnIgual = new Button();
            btnLimpiar = new Button();
            btnBorrarTodo = new Button();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.Location = new Point(75, 12);
            txtPantalla.Multiline = true;
            txtPantalla.Name = "txtPantalla";
            txtPantalla.ReadOnly = true;
            txtPantalla.Size = new Size(258, 71);
            txtPantalla.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Location = new Point(75, 116);
            btn7.Name = "btn7";
            btn7.Size = new Size(41, 39);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnDigito_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(122, 116);
            btn8.Name = "btn8";
            btn8.Size = new Size(41, 39);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnDigito_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(169, 116);
            btn9.Name = "btn9";
            btn9.Size = new Size(41, 39);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnDigito_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(75, 175);
            btn4.Name = "btn4";
            btn4.Size = new Size(41, 39);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnDigito_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(122, 175);
            btn5.Name = "btn5";
            btn5.Size = new Size(41, 39);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnDigito_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(169, 175);
            btn6.Name = "btn6";
            btn6.Size = new Size(41, 39);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnDigito_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(75, 230);
            btn1.Name = "btn1";
            btn1.Size = new Size(41, 39);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnDigito_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(122, 230);
            btn2.Name = "btn2";
            btn2.Size = new Size(41, 39);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnDigito_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(169, 230);
            btn3.Name = "btn3";
            btn3.Size = new Size(41, 39);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnDigito_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(75, 284);
            btn0.Name = "btn0";
            btn0.Size = new Size(41, 39);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnDigito_Click;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(325, 116);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(41, 39);
            btnSuma.TabIndex = 11;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btn_Operador_click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(325, 175);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(41, 39);
            btnResta.TabIndex = 12;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btn_Operador_click;
            // 
            // A
            // 
            A.Location = new Point(222, 116);
            A.Name = "A";
            A.Size = new Size(41, 39);
            A.TabIndex = 13;
            A.Text = "A";
            A.UseVisualStyleBackColor = true;
            A.Click += btnDigito_Click;
            // 
            // B
            // 
            B.Location = new Point(222, 175);
            B.Name = "B";
            B.Size = new Size(41, 39);
            B.TabIndex = 14;
            B.Text = "B";
            B.UseVisualStyleBackColor = true;
            B.Click += btnDigito_Click;
            // 
            // C
            // 
            C.Location = new Point(222, 230);
            C.Name = "C";
            C.Size = new Size(41, 39);
            C.TabIndex = 15;
            C.Text = "C";
            C.UseVisualStyleBackColor = true;
            C.Click += btnDigito_Click;
            // 
            // D
            // 
            D.Location = new Point(269, 230);
            D.Name = "D";
            D.Size = new Size(41, 39);
            D.TabIndex = 16;
            D.Text = "D";
            D.UseVisualStyleBackColor = true;
            D.Click += btnDigito_Click;
            // 
            // E
            // 
            E.Location = new Point(269, 116);
            E.Name = "E";
            E.Size = new Size(41, 39);
            E.TabIndex = 17;
            E.Text = "E";
            E.UseVisualStyleBackColor = true;
            E.Click += btnDigito_Click;
            // 
            // F
            // 
            F.Location = new Point(269, 175);
            F.Name = "F";
            F.Size = new Size(41, 39);
            F.TabIndex = 18;
            F.Text = "F";
            F.UseVisualStyleBackColor = true;
            F.Click += btnDigito_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(325, 230);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(41, 39);
            btnMultiplicar.TabIndex = 19;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btn_Operador_click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(325, 284);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(41, 39);
            btnDividir.TabIndex = 20;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btn_Operador_click;
            // 
            // comboBase
            // 
            comboBase.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBase.FormattingEnabled = true;
            comboBase.Location = new Point(75, 89);
            comboBase.Name = "comboBase";
            comboBase.Size = new Size(258, 23);
            comboBase.TabIndex = 21;
            comboBase.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(384, 284);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(41, 39);
            btnIgual.TabIndex = 22;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(169, 284);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(55, 39);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(122, 284);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(41, 39);
            btnBorrarTodo.TabIndex = 24;
            btnBorrarTodo.Text = "AC";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // CalculadoraSisNumericos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIgual);
            Controls.Add(comboBase);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(F);
            Controls.Add(E);
            Controls.Add(D);
            Controls.Add(C);
            Controls.Add(B);
            Controls.Add(A);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtPantalla);
            Name = "CalculadoraSisNumericos";
            Text = "CalculadoraSisNumericos";
            Load += CalculadoraSisNumericos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPantalla;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnSuma;
        private Button btnResta;
        private Button A;
        private Button B;
        private Button C;
        private Button D;
        private Button E;
        private Button F;
        private Button btnMultiplicar;
        private Button btnDividir;
        private ComboBox comboBase;
        private Button btnIgual;
        private Button btnLimpiar;
        private Button btnBorrarTodo;
    }
}