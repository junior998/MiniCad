using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mini_cas_v3
{
    class Punto : Figure
    {
        //funzioni pubbliche
        public Punto(int x, int y, Color colore, Graphics grafico) : base(grafico, colore)
        {
            this.x = x;
            this.y = y;
        }

        override public void disegna()
        {
            grafico.DrawRectangle(penna, x, y, 1, 1);
        }

        public int get_x()
        {
            return x;
        }

        public int get_y()
        {
            return y;
        }

        //variabili private
        private int x = 0;
        private int y = 0;
    }
}
