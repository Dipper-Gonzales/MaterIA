namespace MaterIA.Formularios
{
    partial class FrmMetodoConteo
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
            btnPermutaciones = new Button();
            btnCombinaciones = new Button();
            btnVariaciones = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnPermutaciones
            // 
            btnPermutaciones.Anchor = AnchorStyles.None;
            btnPermutaciones.BackColor = SystemColors.Highlight;
            btnPermutaciones.Font = new Font("Impact", 12F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            btnPermutaciones.Location = new Point(511, 61);
            btnPermutaciones.Margin = new Padding(4, 5, 4, 5);
            btnPermutaciones.Name = "btnPermutaciones";
            btnPermutaciones.Size = new Size(837, 159);
            btnPermutaciones.TabIndex = 1;
            btnPermutaciones.Text = "Permutaciones";
            btnPermutaciones.UseVisualStyleBackColor = false;
            btnPermutaciones.Click += btnPermutaciones_Click;
            // 
            // btnCombinaciones
            // 
            btnCombinaciones.Anchor = AnchorStyles.None;
            btnCombinaciones.BackColor = SystemColors.ActiveCaption;
            btnCombinaciones.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCombinaciones.Location = new Point(253, 300);
            btnCombinaciones.Margin = new Padding(4, 5, 4, 5);
            btnCombinaciones.Name = "btnCombinaciones";
            btnCombinaciones.Size = new Size(693, 179);
            btnCombinaciones.TabIndex = 2;
            btnCombinaciones.Text = "Combinaciones";
            btnCombinaciones.UseVisualStyleBackColor = false;
            btnCombinaciones.Click += btnCombinaciones_Click;
            // 
            // btnVariaciones
            // 
            btnVariaciones.Anchor = AnchorStyles.None;
            btnVariaciones.BackColor = SystemColors.InactiveCaption;
            btnVariaciones.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVariaciones.Location = new Point(13, 556);
            btnVariaciones.Margin = new Padding(4, 5, 4, 5);
            btnVariaciones.Name = "btnVariaciones";
            btnVariaciones.Size = new Size(741, 165);
            btnVariaciones.TabIndex = 3;
            btnVariaciones.Text = "Variaciones";
            btnVariaciones.UseVisualStyleBackColor = false;
            btnVariaciones.Click += btnVariaciones_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 12);
            button1.Name = "button1";
            button1.Size = new Size(130, 37);
            button1.TabIndex = 5;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmMetodoConteo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_07_13_at_11_36_28_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1361, 735);
            Controls.Add(button1);
            Controls.Add(btnVariaciones);
            Controls.Add(btnCombinaciones);
            Controls.Add(btnPermutaciones);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMetodoConteo";
            Text = "FrmMetodoConteo";
            Load += FrmMetodoConteo_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnPermutaciones;
        private Button btnCombinaciones;
        private Button btnVariaciones;
        private Button button1;
    }
}