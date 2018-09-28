﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cirkel: Vorm
    {
        public Cirkel(int x, int y, Color kleur) : base(x, y, kleur)
        {
            x = 50;
            y = 50;
        }
        public override void Groeien()
        {
            throw new NotImplementedException();
            
        }

        public override void Krimpen()
        {
            throw new NotImplementedException();
        }

        public override void Tekenen(Graphics papier)
        {
            SolidBrush SB = new SolidBrush(kleur);
            Pen p = new Pen(kleur);
            papier.DrawEllipse(p, xCoord - 50, yCoord - 50, 100, 100);
            papier.FillEllipse(SB, xCoord - 50, yCoord - 50, 100, 100);
           
        }
    }
}
