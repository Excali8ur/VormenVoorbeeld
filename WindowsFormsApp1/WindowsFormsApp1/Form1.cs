using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Vorm> vormen;
        Graphics papier;

        public Form1()
        {
            InitializeComponent();
            vormen = new List<Vorm>();

            papier = Vlakje.CreateGraphics();
        }

        private void Knopje_Click(object sender, EventArgs e)
        {
            Tekstvak.Text = "Github experts";
        }

        

        private void Vlakje_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Test");
        }

        private void btnMaakRechthoek_Click(object sender, EventArgs e)
        {
            //Nu een vaste plaats en kleur -> Aanpassen zodat dit gekozen kan worden
            Rechthoek rh = new Rechthoek(10,10,Color.Blue);

            //Na het aanmaken van een nieuwe vorm: teken alles
            Tekenen();
        }

        private void Tekenen()
        {
            
            foreach (Vorm v in vormen)
            {
                v.Tekenen(papier);
            }
        }
    }
}
