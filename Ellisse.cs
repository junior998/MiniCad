using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mini_cas_v3
{
    class Ellisse : Figure
    {
        //Funzioni pubbliche
        public Ellisse(Punto angolo_sin, int Base, int Altezza, Color colore, Graphics grafico) : base(grafico, colore)
        {
            this.angolo_sin = angolo_sin;
            this.Base = Base;
            this.Altezza = Altezza;
        }

        override public void disegna()
        {
            grafico.DrawEllipse(penna, angolo_sin.get_x(), angolo_sin.get_y(), Base, Altezza);
        }

        //variabili private
        private Punto angolo_sin = null;
        private int Base = 0;
        private int Altezza = 0;
    }
}
