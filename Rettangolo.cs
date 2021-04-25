using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mini_cas_v3
{
    class Rettangolo : Figure
    {
        //Funzioni pubbliche
        public Rettangolo(Punto angolo_sin, int Base, int Altezza, Color colore, Graphics grafico) : base(grafico, colore)
        {
            this.angolo_sin = angolo_sin;
            this.Altezza = Altezza;
            this.Base = Base;
        }

        override public void disegna()
        {
            grafico.DrawRectangle(penna, angolo_sin.get_x(), angolo_sin.get_y(), Base, Altezza);
        }

        //variabili private
        protected Punto angolo_sin = null;
        protected int Base = 0;
        protected int Altezza = 0;
    }
}
