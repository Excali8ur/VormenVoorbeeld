﻿using System;
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
        public Form1()
        {
            InitializeComponent();
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
    }
}
