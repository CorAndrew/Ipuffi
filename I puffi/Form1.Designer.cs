namespace I_puffi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Background = new Panel();
            Casa = new Panel();
            panel1 = new Panel();
            puffo1 = new Panel();
            inizia = new Button();
            Punteggio = new Label();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.BackColor = Color.FromArgb(128, 255, 128);
            Background.Controls.Add(Casa);
            Background.Controls.Add(panel1);
            Background.Controls.Add(puffo1);
            Background.Location = new Point(12, 22);
            Background.Name = "Background";
            Background.Size = new Size(1551, 696);
            Background.TabIndex = 0;
            Background.Visible = false;
            // 
            // Casa
            // 
            Casa.BackColor = Color.Red;
            Casa.Location = new Point(1118, 222);
            Casa.Name = "Casa";
            Casa.Size = new Size(63, 63);
            Casa.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(188, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 163);
            panel1.TabIndex = 1;
            // 
            // puffo1
            // 
            puffo1.BackColor = SystemColors.MenuHighlight;
            puffo1.BackgroundImage = (Image)resources.GetObject("puffo1.BackgroundImage");
            puffo1.Location = new Point(446, 117);
            puffo1.Name = "puffo1";
            puffo1.Size = new Size(156, 233);
            puffo1.TabIndex = 0;
            // 
            // inizia
            // 
            inizia.Location = new Point(771, 0);
            inizia.Name = "inizia";
            inizia.Size = new Size(75, 23);
            inizia.TabIndex = 1;
            inizia.Text = "inizia";
            inizia.UseVisualStyleBackColor = true;
            inizia.Click += inizia_Click;
            // 
            // Punteggio
            // 
            Punteggio.AutoSize = true;
            Punteggio.Location = new Point(1151, 4);
            Punteggio.Name = "Punteggio";
            Punteggio.Size = new Size(97, 15);
            Punteggio.TabIndex = 2;
            Punteggio.Text = "Punteggio puffo:";
            Punteggio.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 749);
            Controls.Add(Punteggio);
            Controls.Add(inizia);
            Controls.Add(Background);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Background.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Background;
        private Panel puffo1;
        private Button inizia;
        private Panel panel1;
        private Label Punteggio;
        private Panel Casa;
    }
}
