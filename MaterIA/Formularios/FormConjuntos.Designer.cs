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
            SuspendLayout();
            // 
            // txtElementoA
            // 
            txtElementoA.Location = new Point(39, 30);
            txtElementoA.Name = "txtElementoA";
            txtElementoA.Size = new Size(100, 23);
            txtElementoA.TabIndex = 0;
            // 
            // btnAgregarA
            // 
            btnAgregarA.Location = new Point(163, 16);
            btnAgregarA.Name = "btnAgregarA";
            btnAgregarA.Size = new Size(84, 48);
            btnAgregarA.TabIndex = 1;
            btnAgregarA.Text = "Agregar al conjunto A";
            btnAgregarA.UseVisualStyleBackColor = true;
            btnAgregarA.Click += btnAgregarA_Click;
            // 
            // listBoxA
            // 
            listBoxA.FormattingEnabled = true;
            listBoxA.Location = new Point(274, 16);
            listBoxA.Name = "listBoxA";
            listBoxA.Size = new Size(120, 94);
            listBoxA.TabIndex = 2;
            // 
            // txtElementoB
            // 
            txtElementoB.Location = new Point(39, 155);
            txtElementoB.Name = "txtElementoB";
            txtElementoB.Size = new Size(100, 23);
            txtElementoB.TabIndex = 3;
            // 
            // btnAgregarB
            // 
            btnAgregarB.Location = new Point(163, 155);
            btnAgregarB.Name = "btnAgregarB";
            btnAgregarB.Size = new Size(84, 48);
            btnAgregarB.TabIndex = 4;
            btnAgregarB.Text = "Agregar al conjunto B";
            btnAgregarB.UseVisualStyleBackColor = true;
            btnAgregarB.Click += btnAgregarB_Click;
            // 
            // listBoxB
            // 
            listBoxB.FormattingEnabled = true;
            listBoxB.Location = new Point(274, 155);
            listBoxB.Name = "listBoxB";
            listBoxB.Size = new Size(120, 94);
            listBoxB.TabIndex = 5;
            // 
            // btnUnion
            // 
            btnUnion.Location = new Point(441, 51);
            btnUnion.Name = "btnUnion";
            btnUnion.Size = new Size(83, 23);
            btnUnion.TabIndex = 6;
            btnUnion.Text = "Union";
            btnUnion.UseVisualStyleBackColor = true;
            btnUnion.Click += btnUnion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 16);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 7;
            label1.Text = "Operaciones";
            // 
            // btnDiferencia
            // 
            btnDiferencia.Location = new Point(441, 80);
            btnDiferencia.Name = "btnDiferencia";
            btnDiferencia.Size = new Size(83, 23);
            btnDiferencia.TabIndex = 8;
            btnDiferencia.Text = "Diferencia";
            btnDiferencia.UseVisualStyleBackColor = true;
            btnDiferencia.Click += btnDiferencia_Click;
            // 
            // btnInterseccion
            // 
            btnInterseccion.Location = new Point(441, 109);
            btnInterseccion.Name = "btnInterseccion";
            btnInterseccion.Size = new Size(83, 23);
            btnInterseccion.TabIndex = 9;
            btnInterseccion.Text = "Interseccion";
            btnInterseccion.UseVisualStyleBackColor = true;
            btnInterseccion.Click += btnInterseccion_Click;
            // 
            // btnProductoCartesiano
            // 
            btnProductoCartesiano.Location = new Point(441, 138);
            btnProductoCartesiano.Name = "btnProductoCartesiano";
            btnProductoCartesiano.Size = new Size(83, 23);
            btnProductoCartesiano.TabIndex = 10;
            btnProductoCartesiano.Text = "Producto";
            btnProductoCartesiano.UseVisualStyleBackColor = true;
            btnProductoCartesiano.Click += btnProductoCartesiano_Click;
            // 
            // listBoxResultado
            // 
            listBoxResultado.FormattingEnabled = true;
            listBoxResultado.Location = new Point(559, 16);
            listBoxResultado.Name = "listBoxResultado";
            listBoxResultado.Size = new Size(136, 124);
            listBoxResultado.TabIndex = 11;
            // 
            // FormConjuntos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}