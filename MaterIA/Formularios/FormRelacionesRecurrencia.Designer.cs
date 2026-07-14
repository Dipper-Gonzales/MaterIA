namespace MaterIA.Formularios
{
    partial class FormRelacionesRecurrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelacionesRecurrencia));
            btnrelaciones1 = new Button();
            btnrelaciones2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnrelaciones1
            // 
            btnrelaciones1.Location = new Point(223, 300);
            btnrelaciones1.Margin = new Padding(4, 5, 4, 5);
            btnrelaciones1.Name = "btnrelaciones1";
            btnrelaciones1.Size = new Size(139, 93);
            btnrelaciones1.TabIndex = 0;
            btnrelaciones1.Text = "Relaciones de recurrencia 1";
            btnrelaciones1.UseVisualStyleBackColor = false;
            btnrelaciones1.Click += btnrelaciones1_Click;
            // 
            // btnrelaciones2
            // 
            btnrelaciones2.Location = new Point(500, 300);
            btnrelaciones2.Margin = new Padding(4, 5, 4, 5);
            btnrelaciones2.Name = "btnrelaciones2";
            btnrelaciones2.Size = new Size(139, 93);
            btnrelaciones2.TabIndex = 1;
            btnrelaciones2.Text = "Relaciones de recurrencia 2";
            btnrelaciones2.UseVisualStyleBackColor = false;
            btnrelaciones2.Click += btnrelaciones2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 32);
            button1.TabIndex = 2;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormRelacionesRecurrencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(btnrelaciones2);
            Controls.Add(btnrelaciones1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormRelacionesRecurrencia";
            Text = "FormRelacionesRecurrencia";
            ResumeLayout(false);
        }

        #endregion

        private Button btnrelaciones1;
        private Button btnrelaciones2;
        private Button button1;
    }
}