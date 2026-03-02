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
            Punteggio1 = new Label();
            Punteggio2 = new Label();
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
            // Punteggio1
            // 
            Punteggio1.AutoSize = true;
            Punteggio1.Location = new Point(1151, 4);
            Punteggio1.Name = "Punteggio1";
            Punteggio1.Size = new Size(97, 15);
            Punteggio1.TabIndex = 2;
            Punteggio1.Text = "Punteggio puffo:";
            Punteggio1.Visible = false;
            // 
            // Punteggio2
            // 
            Punteggio2.AutoSize = true;
            Punteggio2.Location = new Point(189, 4);
            Punteggio2.Name = "Punteggio2";
            Punteggio2.Size = new Size(128, 15);
            Punteggio2.TabIndex = 3;
            Punteggio2.Text = "Punteggio Gargamella:";
            Punteggio2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 749);
            Controls.Add(Punteggio2);
            Controls.Add(Punteggio1);
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
        private Label Punteggio1;
        private Panel Casa;
        private Label Punteggio2;
    }
}
