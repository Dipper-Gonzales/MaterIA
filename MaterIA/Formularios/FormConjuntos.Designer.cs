namespace MaterIA.Formularios
{
    partial class FormConjuntos
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
            txtElementoA = new TextBox();
            btnAgregarA = new Button();
            listBoxA = new ListBox();
            txtElementoB = new TextBox();
            btnAgregarB = new Button();
            listBoxB = new ListBox();
            btnUnion = new Button();
            label1 = new Label();
            btnDiferencia = new Button();
            btnInterseccion = new Button();
            btnProductoCartesiano = new Button();
            listBoxResultado = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtElementoA
            // 
            txtElementoA.Location = new Point(56, 57);
            txtElementoA.Margin = new Padding(4, 5, 4, 5);
            txtElementoA.Name = "txtElementoA";
            txtElementoA.Size = new Size(141, 31);
            txtElementoA.TabIndex = 0;
            // 
            // btnAgregarA
            // 
            btnAgregarA.Location = new Point(233, 27);
            btnAgregarA.Margin = new Padding(4, 5, 4, 5);
            btnAgregarA.Name = "btnAgregarA";
            btnAgregarA.Size = new Size(120, 80);
            btnAgregarA.TabIndex = 1;
            btnAgregarA.Text = "Agregar al conjunto A";
            btnAgregarA.UseVisualStyleBackColor = true;
            btnAgregarA.Click += btnAgregarA_Click;
            // 
            // listBoxA
            // 
            listBoxA.FormattingEnabled = true;
            listBoxA.Location = new Point(391, 27);
            listBoxA.Margin = new Padding(4, 5, 4, 5);
            listBoxA.Name = "listBoxA";
            listBoxA.Size = new Size(170, 154);
            listBoxA.TabIndex = 2;
            // 
            // txtElementoB
            // 
            txtElementoB.Location = new Point(56, 258);
            txtElementoB.Margin = new Padding(4, 5, 4, 5);
            txtElementoB.Name = "txtElementoB";
            txtElementoB.Size = new Size(141, 31);
            txtElementoB.TabIndex = 3;
            // 
            // btnAgregarB
            // 
            btnAgregarB.Location = new Point(233, 258);
            btnAgregarB.Margin = new Padding(4, 5, 4, 5);
            btnAgregarB.Name = "btnAgregarB";
            btnAgregarB.Size = new Size(120, 80);
            btnAgregarB.TabIndex = 4;
            btnAgregarB.Text = "Agregar al conjunto B";
            btnAgregarB.UseVisualStyleBackColor = true;
            btnAgregarB.Click += btnAgregarB_Click;
            // 
            // listBoxB
            // 
            listBoxB.FormattingEnabled = true;
            listBoxB.Location = new Point(391, 258);
            listBoxB.Margin = new Padding(4, 5, 4, 5);
            listBoxB.Name = "listBoxB";
            listBoxB.Size = new Size(170, 154);
            listBoxB.TabIndex = 5;
            // 
            // btnUnion
            // 
            btnUnion.Location = new Point(630, 85);
            btnUnion.Margin = new Padding(4, 5, 4, 5);
            btnUnion.Name = "btnUnion";
            btnUnion.Size = new Size(119, 38);
            btnUnion.TabIndex = 6;
            btnUnion.Text = "Union";
            btnUnion.UseVisualStyleBackColor = true;
            btnUnion.Click += btnUnion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(630, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 7;
            label1.Text = "Operaciones";
            // 
            // btnDiferencia
            // 
            btnDiferencia.Location = new Point(630, 133);
            btnDiferencia.Margin = new Padding(4, 5, 4, 5);
            btnDiferencia.Name = "btnDiferencia";
            btnDiferencia.Size = new Size(119, 38);
            btnDiferencia.TabIndex = 8;
            btnDiferencia.Text = "Diferencia";
            btnDiferencia.UseVisualStyleBackColor = true;
            btnDiferencia.Click += btnDiferencia_Click;
            // 
            // btnInterseccion
            // 
            btnInterseccion.Location = new Point(630, 182);
            btnInterseccion.Margin = new Padding(4, 5, 4, 5);
            btnInterseccion.Name = "btnInterseccion";
            btnInterseccion.Size = new Size(119, 38);
            btnInterseccion.TabIndex = 9;
            btnInterseccion.Text = "Interseccion";
            btnInterseccion.UseVisualStyleBackColor = true;
            btnInterseccion.Click += btnInterseccion_Click;
            // 
            // btnProductoCartesiano
            // 
            btnProductoCartesiano.Location = new Point(630, 230);
            btnProductoCartesiano.Margin = new Padding(4, 5, 4, 5);
            btnProductoCartesiano.Name = "btnProductoCartesiano";
            btnProductoCartesiano.Size = new Size(119, 38);
            btnProductoCartesiano.TabIndex = 10;
            btnProductoCartesiano.Text = "Producto";
            btnProductoCartesiano.UseVisualStyleBackColor = true;
            btnProductoCartesiano.Click += btnProductoCartesiano_Click;
            // 
            // listBoxResultado
            // 
            listBoxResultado.FormattingEnabled = true;
            listBoxResultado.Location = new Point(799, 27);
            listBoxResultado.Margin = new Padding(4, 5, 4, 5);
            listBoxResultado.Name = "listBoxResultado";
            listBoxResultado.Size = new Size(193, 254);
            listBoxResultado.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(96, 37);
            button1.TabIndex = 12;
            button1.Text = "Regresar";
            button1.TextAlign = ContentAlignment.TopRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormConjuntos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(listBoxResultado);
            Controls.Add(btnProductoCartesiano);
            Controls.Add(btnInterseccion);
            Controls.Add(btnDiferencia);
            Controls.Add(label1);
            Controls.Add(btnUnion);
            Controls.Add(listBoxB);
            Controls.Add(btnAgregarB);
            Controls.Add(txtElementoB);
            Controls.Add(listBoxA);
            Controls.Add(btnAgregarA);
            Controls.Add(txtElementoA);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormConjuntos";
            Text = "FormConjuntos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtElementoA;
        private Button btnAgregarA;
        private ListBox listBoxA;
        private TextBox txtElementoB;
        private Button btnAgregarB;
        private ListBox listBoxB;
        private Button btnUnion;
        private Label label1;
        private Button btnDiferencia;
        private Button btnInterseccion;
        private Button btnProductoCartesiano;
        private ListBox listBoxResultado;
        private Button button1;
    }
}