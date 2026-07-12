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
            btnrelaciones1 = new Button();
            btnrelaciones2 = new Button();
            SuspendLayout();
            // 
            // btnrelaciones1
            // 
            btnrelaciones1.Location = new Point(156, 180);
            btnrelaciones1.Name = "btnrelaciones1";
            btnrelaciones1.Size = new Size(97, 56);
            btnrelaciones1.TabIndex = 0;
            btnrelaciones1.Text = "Relaciones de recurrencia 1";
            btnrelaciones1.UseVisualStyleBackColor = true;
            btnrelaciones1.Click += btnrelaciones1_Click;
            // 
            // btnrelaciones2
            // 
            btnrelaciones2.Location = new Point(350, 180);
            btnrelaciones2.Name = "btnrelaciones2";
            btnrelaciones2.Size = new Size(97, 56);
            btnrelaciones2.TabIndex = 1;
            btnrelaciones2.Text = "Relaciones de recurrencia 2";
            btnrelaciones2.UseVisualStyleBackColor = true;
            btnrelaciones2.Click += btnrelaciones2_Click;
            // 
            // FormRelacionesRecurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnrelaciones2);
            Controls.Add(btnrelaciones1);
            Name = "FormRelacionesRecurrencia";
            Text = "FormRelacionesRecurrencia";
            ResumeLayout(false);
        }

        #endregion

        private Button btnrelaciones1;
        private Button btnrelaciones2;
    }
}