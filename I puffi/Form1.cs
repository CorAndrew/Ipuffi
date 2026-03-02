using System;
using System.Drawing;
using System.Windows.Forms;

namespace I_puffi
{
    public partial class Form1 : Form
    {
        int velocita = 10;
        int punti = 0;
        int puntiGargamella = 0;
        Random rnd = new Random();

        public struct punto
        {
            public int X;
            public int Y;
            public punto(int x, int y) { X = x; Y = y; }
        }

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            PosizionaCasaCasuale();
        }

        private void PosizionaCasaCasuale()
        {
            int maxX = this.ClientSize.Width - Casa.Width;
            int maxY = this.ClientSize.Height - Casa.Height;
            Casa.Location = new Point(rnd.Next(0, maxX), rnd.Next(0, maxY));
        }

        private void ControllaCollisione()
        {
            if (panel1.Bounds.IntersectsWith(Casa.Bounds))
            {
                punti++;
                Punteggio1.Visible = true;
                Punteggio1.Text = "Punteggi Puffo: " + punti;
                PosizionaCasaCasuale();
            }
            else if (puffo1.Bounds.IntersectsWith(Casa.Bounds))
            {
                puntiGargamella++;
                Punteggio2.Visible = true;
                Punteggio2.Text = "Punteggio Gargamella: " + puntiGargamella;
                PosizionaCasaCasuale();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (panel1.Top > 0) panel1.Top -= velocita;
                    break;
                case Keys.S:
                    if (panel1.Bottom < this.ClientSize.Height) panel1.Top += velocita;
                    break;
                case Keys.A:
                    if (panel1.Left > 0) panel1.Left -= velocita;
                    break;
                case Keys.D:
                    if (panel1.Right < this.ClientSize.Width) panel1.Left += velocita;
                    break;

                case Keys.I:
                    if (puffo1.Top > 0) puffo1.Top -= velocita;
                    break;
                case Keys.K:
                    if (puffo1.Bottom < this.ClientSize.Height) puffo1.Top += velocita;
                    break;
                case Keys.J:
                    if (puffo1.Left > 0) puffo1.Left -= velocita;
                    break;
                case Keys.L:
                    if (puffo1.Right < this.ClientSize.Width) puffo1.Left += velocita;
                    break;
            }
            ControllaCollisione();
        }

        private void inizia_Click(object sender, EventArgs e)
        {
            Background.Visible = true;
            inizia.Visible = false;
            this.Focus();
        }
    }
}