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
        public Rechthoek(int x, int y, Color kleur): base()
        {
            xCoord = x;
            yCoord = y;
            this.kleur = kleur;

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
            papier.DrawRectangle(p, xCoord - 50, yCoord - 50, 100, 100);
            papier.FillRectangle(SB, xCoord - 50, yCoord - 50, 100, 100);
        }
    }
}
