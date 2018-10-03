using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Rechthoek: Vorm
    {         
        public Rechthoek(int x, int y, int l, int b, Color kleur): base()
        {
            xCoord = x;
            yCoord = y;
            Lengte = l;
            Breedte = b;
            this.kleur = kleur;
            Lengte = 100;
            Breedte = 100;

        }

        public override void Groeien()
        {
            Lengte += 100;
            Breedte += 100;            
        }

        public override void Krimpen()
        {
            Lengte -= 100;
            Breedte -= 100;                        
        }

        public override void Tekenen(Graphics papier)
        {
            SolidBrush SB = new SolidBrush(kleur);
            Pen p = new Pen(kleur);
            papier.DrawRectangle(p, xCoord - 50, yCoord - 50, Lengte, Breedte);
            papier.FillRectangle(SB, xCoord - 50, yCoord - 50, Lengte, Breedte);
        }
    }
}
