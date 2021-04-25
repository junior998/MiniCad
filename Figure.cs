using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mini_cas_v3
{
    class Figure
    {
        //funzioni pubbliche
        public Figure(Graphics grafico, Color colore)
        {
            this.grafico = grafico;
            this.colore = colore;
            penna = new Pen(colore);
        }

        virtual public void disegna()
        {

        }

        //variabili protette
        protected Pen penna = null;
        protected Graphics grafico = null;
        protected Color colore = Color.Black;
    }
}
