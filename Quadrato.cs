using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace mini_cas_v3
{
    class Quadrato : Rettangolo
    {
        //funzioni pubbliche
        public Quadrato(Punto angolo_sin, int lato, Color colore, Graphics grafico) : base(angolo_sin, lato, lato, colore, grafico)
        {

        }
    }
}
