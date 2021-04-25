using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace mini_cas_v3
{
    public partial class Form1 : Form
    {
        //funzioni private
        public Form1()
        {
            InitializeComponent();
        }

        public ToolStrip get_toolStrip()
        {
            return barra_strumenti;
        }

        private void disegna_punto(Color colore, bool memorizza)
        {
            Punto p = new Punto(x_inizio, y_inizio, colore, toolStripContainer1.ContentPanel.CreateGraphics());
            p.disegna();
            if (memorizza)
                oggetti.Add(p);
        }

        private void disegna_linea(Color colore, bool memorizza)
        {
            Punto inizio = new Punto(x_inizio, y_inizio, colore, null);
            Punto fine = new Punto(x_fine, y_fine, colore, null);
            Linea l = new Linea(inizio, fine, colore, toolStripContainer1.ContentPanel.CreateGraphics());
            l.disegna();
            if (memorizza)
                oggetti.Add(l);
        }

        private void disegna_rettangolo(Color colore, bool memorizza)
        {
            int Base = x_fine - x_inizio;
            int Altezza = y_fine - y_inizio;
            Rettangolo r = new Rettangolo(new Punto(x_inizio, y_inizio, colore, null), Base, Altezza, colore, toolStripContainer1.ContentPanel.CreateGraphics());
            r.disegna();
            if (memorizza)
                oggetti.Add(r);
        }

        private void disegna_quadrato(Color colore, bool memorizza)
        {
            int lato = x_fine - x_inizio;
            Quadrato q = new Quadrato(new Punto(x_inizio, y_inizio, colore, null), lato, colore, toolStripContainer1.ContentPanel.CreateGraphics());
            q.disegna();
            if (memorizza)
                oggetti.Add(q);
        }

        private void disegna_ellisse(Color colore, bool memorizza)
        {
            int Base = x_fine - x_inizio;
            int Altezza = y_fine - y_inizio;
            if (ctrl)
                Altezza = Base = Math.Max(Base, Altezza);
            Ellisse e = new Ellisse(new Punto(x_inizio, y_inizio, colore, null), Base, Altezza, colore, toolStripContainer1.ContentPanel.CreateGraphics());
            e.disegna();
            if (memorizza)
                oggetti.Add(e);
        }

        private void resetta_punti()
        {
            x_inizio = -1; y_inizio = -1;
            x_fine = -1; y_fine = -1;
        }

        private void carica_figure()
        {
            foreach (Figure f in oggetti)
                f.disegna();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && tavola_colori.ShowDialog() == DialogResult.OK)
                colore = tavola_colori.Color;
            else if(figura_selezionata == Tipo.Punto)
            {
                x_inizio = e.X;
                y_inizio = e.Y;
                disegna_punto(colore, true);
                resetta_punti();
            }
        }

        private void Scegli_figura_Click(object sender, EventArgs e)
        {
            foreach(ToolStripButton bottone in barra_strumenti.Items)
            {
                bottone.Checked = false;
            }

            (sender as ToolStripButton).Checked = true;

            switch((sender as ToolStripButton).Text)
            {
                case "Punto":
                    figura_selezionata = Tipo.Punto;
                    break;
                case "Linea":
                    figura_selezionata = Tipo.Linea;
                    break;
                case "Rettangolo":
                    figura_selezionata = Tipo.Rettangolo;
                    break;
                case "Quadrato":
                    figura_selezionata = Tipo.Quadrato;
                    break;
                case "Ellisse":
                    figura_selezionata = Tipo.Ellisse;
                    break;
            }
        }

        //Funzioni autogenerate
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && figura_selezionata != Tipo.Punto)
            {
                x_inizio = e.X;
                y_inizio = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && figura_selezionata != Tipo.Punto)
            {
                x_fine = e.X;
                y_fine = e.Y;
                switch(figura_selezionata)
                {
                    case Tipo.Linea:
                        disegna_linea(colore, true);
                        break;
                    case Tipo.Rettangolo:
                        disegna_rettangolo(colore, true);
                        break;
                    case Tipo.Quadrato:
                        disegna_quadrato(colore, true);
                        break;
                    case Tipo.Ellisse:
                        disegna_ellisse(colore, true);
                        break;
                }
            }
            resetta_punti();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                switch (figura_selezionata)
                {
                    case Tipo.Punto:
                        x_inizio = e.X; y_inizio = e.Y;
                        disegna_punto(colore, true);
                        break;
                    case Tipo.Linea:
                        disegna_linea(BackColor, false);
                        carica_figure();
                        x_fine = e.X; y_fine = e.Y;
                        disegna_linea(colore, false);
                        break;
                    case Tipo.Rettangolo:
                        disegna_rettangolo(BackColor, false);
                        carica_figure();
                        x_fine = e.X; y_fine = e.Y;
                        disegna_rettangolo(colore, false);
                        break;
                    case Tipo.Quadrato:
                        disegna_quadrato(BackColor, false);
                        carica_figure();
                        x_fine = e.X; y_fine = e.Y;
                        disegna_quadrato(colore, false);
                        break;
                    case Tipo.Ellisse:
                        disegna_ellisse(BackColor, false);
                        carica_figure();
                        x_fine = e.X; y_fine = e.Y;
                        disegna_ellisse(colore, false);
                        break;
                }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            carica_figure();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                ctrl = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control)
                ctrl = false;
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(apri_file.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            apri_file.InitialDirectory = Environment.CurrentDirectory;
        }

        private void opzioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Opzioni(barra_strumenti).ShowDialog();
        }

        //variabili private
        private ArrayList oggetti = new ArrayList();
        private Color colore = Color.Black;
        private int x_inizio = -1; private int y_inizio = -1;
        private int x_fine = -1; private int y_fine = -1;
        private Tipo figura_selezionata = Tipo.Punto; 
        private enum Tipo
        {
            Punto, Linea, Rettangolo, Quadrato, Ellisse
        }
        private bool ctrl = false;
    }
}
