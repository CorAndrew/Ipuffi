using System;
using System.Drawing;
using System.Windows.Forms;

namespace I_puffi
{
    public partial class Form1 : Form
    {
        int velocita = 10;
        int puntiPuffo = 0;
        int puntiGargamella = 0;
        int turno = 0;
        int passi = 0;
        Random rnd = new Random();

        Panel[] alberi;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            alberi = new Panel[] { albero1, albero2, albero3, albero4, albero5, albero6, albero7, albero8, albero9, albero10 };

            PosizionaTutto();
        }

        private void PosizionaTutto()
        {
            int maxX = Background.Width - 40;
            int maxY = Background.Height - 40;

            Casa.Location = new Point(rnd.Next(0, maxX), rnd.Next(0, maxY));

            foreach (Panel albero in alberi)
            {
                albero.Location = new Point(rnd.Next(0, maxX), rnd.Next(0, maxY));
                albero.SendToBack(); // Gli alberi stanno dietro
            }

            // Personaggi sempre davanti
            panel1.BringToFront();
            puffo1.BringToFront();
        }

        private bool ToccaAlbero(Panel giocatore)
        {
            foreach (Panel albero in alberi)
            {
                if (giocatore.Bounds.IntersectsWith(albero.Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        private void ControllaCollisione()
        {
            // il puffo tocca la casa
            if (panel1.Bounds.IntersectsWith(Casa.Bounds))
            {
                puntiPuffo++;
                Punteggio1.Text = "Punteggio Puffo: " + puntiPuffo;

                PosizionaTutto();

                passi = 0;
                turno = 1;
                lblTurno.Text = "Turno di Gargamella";
            }
            // Gargamella tocca il puffo
            else if (puffo1.Bounds.IntersectsWith(panel1.Bounds))
            {
                // Gargamella guadagna un punto
                puntiGargamella++;
                Punteggio2.Text = "Punteggio Gargamella: " + puntiGargamella;

                // Il Puffo perde un punto
                puntiPuffo--;
                if (puntiPuffo < 0)
                {
                    puntiPuffo = 0; // Evita punteggi negativi
                    Punteggio1.Text = "Punteggio Puffo: " + puntiPuffo;
                }

                // Sposta il Puffo in una posizione casuale
                int maxX = Background.Width - panel1.Width;
                int maxY = Background.Height - panel1.Height;
                panel1.Location = new Point(rnd.Next(0, maxX), rnd.Next(0, maxY));

                // Cambio turno e reset passi
                passi = 0;
                if (turno == 0)
                {
                    turno = 1;
                    lblTurno.Text = "Turno di Gargamella";
                }
                else
                {
                    turno = 0;
                    lblTurno.Text = "Turno del Puffo";
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (turno == 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.W: if (panel1.Top > 0) panel1.Top -= velocita; break;
                    case Keys.S: if (panel1.Bottom < Background.Height) panel1.Top += velocita; break;
                    case Keys.A: if (panel1.Left > 0) panel1.Left -= velocita; break;
                    case Keys.D: if (panel1.Right < Background.Width) panel1.Left += velocita; break;
                }

                if (ToccaAlbero(panel1))
                {
                    passi = 10;
                }
                else
                {
                    passi++;
                }
            }
            else if (turno == 1)
            {
                switch (e.KeyCode)
                {
                    case Keys.I: if (puffo1.Top > 0) puffo1.Top -= velocita; break;
                    case Keys.K: if (puffo1.Bottom < Background.Height) puffo1.Top += velocita; break;
                    case Keys.J: if (puffo1.Left > 0) puffo1.Left -= velocita; break;
                    case Keys.L: if (puffo1.Right < Background.Width) puffo1.Left += velocita; break;
                }

                if (ToccaAlbero(puffo1))
                { 
                    passi = 10;
                }
                else
                {
                    passi++;
                }
            }

            if (passi >= 10)
            {
                passi = 0;
                if (turno == 0)
                {
                    turno = 1;
                    lblTurno.Text = "Turno di Gargamella";
                }
                else
                {
                    turno = 0;
                    lblTurno.Text = "Turno del Puffo";
                }
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