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
        Color kleur;

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
            // coördinatie bepalen met tekstbox
            int rhX = Convert.ToInt32(this.tbXcoordRh.Text);
            int rhY = Convert.ToInt32(this.tbYcoordRh.Text);
            //Nu een vaste plaats en kleur -> Aanpassen zodat dit gekozen kan worden
            Rechthoek rh = new Rechthoek(rhX, rhY, 100, 100, kleur);           
            vormen.Add(rh);
            //Na het aanmaken van een nieuwe vorm: teken alles
            Tekenen();            
            
            
        }

        private void btnMaakCirkel_Click(object sender, EventArgs e)
        {
            // coördinatie bepalen met tekstbox
            int cX = Convert.ToInt32(this.tbXcoordC.Text);
            int cY = Convert.ToInt32(this.tbYcoordC.Text);
            // Nieuw object aanmaken Cirkel
            Cirkel C = new Cirkel(cX, cY, 100, 100, kleur);
            // object Cirkel in vormen opnemen
            vormen.Add(C);
            // Na het aanmaken van een nieuwe vorm: teken alles
            Tekenen();            
        }

        private void Tekenen()
        {
            
            foreach (Vorm v in vormen)
            {
                v.Tekenen(papier);                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            kleur = colorDialog1.Color;
        }

        private void tbXcoord_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbYcoord_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Verklein_Click(object sender, EventArgs e)
        {
            Vlakje.Invalidate();            
            Krimpen();            
        }

        private void Vergroot_Click(object sender, EventArgs e)
        {
            Groeien();
        }

        private void Groeien()
        {
            foreach (Vorm g in vormen)
            {
                g.Groeien();
                Tekenen();                
            }

        }

        private void Krimpen()
        {
            foreach (Vorm k in vormen)
            {                
                k.Krimpen();
                Tekenen();                
            }

        }

    }
}
