using System;
using System.Collections.Generic;
//Deze using toevoegen, zodat de teken-library herkent wordt.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Vorm
    {
        protected Color kleur;
        protected int xCoord;
        protected int yCoord;        
        protected bool isGeselecteerd;

        protected Vorm(int x, int y, Color kleur)
        {
            xCoord = x;
            yCoord = y;
            this.kleur = kleur;
        }

        /// <summary>
        /// Deze methode kan een vorm verplaatsen naar het opgegeven x en y coordinaat
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Verplaats(int x, int y)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Verander de vorm van de kleur met de opgegeven kleur
        /// </summary>
        /// <param name="k"></param>
        public void VeranderKleur(Color k)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Selecteert of deselecteert een vorm
        /// </summary>
        /// <param name="selecteer">True = selecteren, False = deselecteren</param>
        public void Selecteer(bool selecteer)
        {
            isGeselecteerd = selecteer;
        }

        public abstract void Tekenen(Graphics papier);
        public abstract void Groeien();
        public abstract void Krimpen();

    }
}
