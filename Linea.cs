using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mini_cas_v3
{
    class Linea : Figure
    {
        //funzioni pubbliche
        public Linea(Punto inizio, Punto fine, Color colore, Graphics grafico) : base(grafico, colore)
        {
            this.inizio = inizio;
            this.fine = fine;
        }

        override public void disegna()
        {
            grafico.DrawLine(penna, inizio.get_x(), inizio.get_y(), fine.get_x(), fine.get_y());
        }

        //variabili private
        Punto inizio = null;
        Punto fine = null;
    }
}
