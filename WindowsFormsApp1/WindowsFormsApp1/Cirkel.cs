using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cirkel: Vorm
    {
        public Cirkel(int x, int y, int l, int b, Color kleur) : base(x, y, l, b, kleur)
        {
            x = 50;
            y = 50;
        }
        public override void Groeien()
        {
            xCoord += 100;
            yCoord += 100;
        }

        public override void Krimpen()
        {
            xCoord -= 100;
            yCoord -= 100;
        }

        public override void Tekenen(Graphics papier)
        {
            SolidBrush SB = new SolidBrush(kleur);
            Pen p = new Pen(kleur);
            papier.DrawEllipse(p, xCoord - 50, yCoord - 50, Lengte, Breedte);
            papier.FillEllipse(SB, xCoord - 50, yCoord - 50, Lengte, Breedte);
           
        }
    }
}
