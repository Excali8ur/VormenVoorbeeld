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
        public Cirkel(int x, int y, Color kleur) : base(x, y, kleur)
        {

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
            throw new NotImplementedException();
        }
    }
}
