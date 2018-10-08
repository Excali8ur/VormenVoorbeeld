namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Vlakje = new System.Windows.Forms.Panel();
            this.Knopje = new System.Windows.Forms.Button();
            this.Tekstvak = new System.Windows.Forms.TextBox();
            this.btnMaakRechthoek = new System.Windows.Forms.Button();
            this.tbXcoordRh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMaakCirkel = new System.Windows.Forms.Button();
            this.tbYcoordRh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbXcoordC = new System.Windows.Forms.TextBox();
            this.tbYcoordC = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Vergroot = new System.Windows.Forms.Button();
            this.Verklein = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vlakje
            // 
            this.Vlakje.AutoScroll = true;
            this.Vlakje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Vlakje.Location = new System.Drawing.Point(18, 27);
            this.Vlakje.Name = "Vlakje";
            this.Vlakje.Size = new System.Drawing.Size(405, 379);
            this.Vlakje.TabIndex = 0;
            this.Vlakje.Paint += new System.Windows.Forms.PaintEventHandler(this.Vlakje_Paint);
            // 
            // Knopje
            // 
            this.Knopje.Location = new System.Drawing.Point(662, 107);
            this.Knopje.Name = "Knopje";
            this.Knopje.Size = new System.Drawing.Size(75, 23);
            this.Knopje.TabIndex = 0;
            this.Knopje.Text = "Knopje";
            this.Knopje.UseVisualStyleBackColor = true;
            this.Knopje.Click += new System.EventHandler(this.Knopje_Click);
            // 
            // Tekstvak
            // 
            this.Tekstvak.Location = new System.Drawing.Point(552, 54);
            this.Tekstvak.Name = "Tekstvak";
            this.Tekstvak.Size = new System.Drawing.Size(185, 20);
            this.Tekstvak.TabIndex = 0;
            // 
            // btnMaakRechthoek
            // 
            this.btnMaakRechthoek.Location = new System.Drawing.Point(662, 341);
            this.btnMaakRechthoek.Name = "btnMaakRechthoek";
            this.btnMaakRechthoek.Size = new System.Drawing.Size(123, 65);
            this.btnMaakRechthoek.TabIndex = 1;
            this.btnMaakRechthoek.Text = "Maak Rechthoek";
            this.btnMaakRechthoek.UseVisualStyleBackColor = true;
            this.btnMaakRechthoek.Click += new System.EventHandler(this.btnMaakRechthoek_Click);
            // 
            // tbXcoordRh
            // 
            this.tbXcoordRh.Location = new System.Drawing.Point(552, 376);
            this.tbXcoordRh.Name = "tbXcoordRh";
            this.tbXcoordRh.Size = new System.Drawing.Size(100, 20);
            this.tbXcoordRh.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "x coord Rechthoek";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kleurtje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMaakCirkel
            // 
            this.btnMaakCirkel.Location = new System.Drawing.Point(662, 273);
            this.btnMaakCirkel.Name = "btnMaakCirkel";
            this.btnMaakCirkel.Size = new System.Drawing.Size(123, 62);
            this.btnMaakCirkel.TabIndex = 5;
            this.btnMaakCirkel.Text = "Maak Cirkel";
            this.btnMaakCirkel.UseVisualStyleBackColor = true;
            this.btnMaakCirkel.Click += new System.EventHandler(this.btnMaakCirkel_Click);
            // 
            // tbYcoordRh
            // 
            this.tbYcoordRh.Location = new System.Drawing.Point(552, 350);
            this.tbYcoordRh.Name = "tbYcoordRh";
            this.tbYcoordRh.Size = new System.Drawing.Size(100, 20);
            this.tbYcoordRh.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "y coord Rechthoek";
            // 
            // tbXcoordC
            // 
            this.tbXcoordC.Location = new System.Drawing.Point(552, 308);
            this.tbXcoordC.Name = "tbXcoordC";
            this.tbXcoordC.Size = new System.Drawing.Size(100, 20);
            this.tbXcoordC.TabIndex = 8;
            // 
            // tbYcoordC
            // 
            this.tbYcoordC.Location = new System.Drawing.Point(552, 280);
            this.tbYcoordC.Name = "tbYcoordC";
            this.tbYcoordC.Size = new System.Drawing.Size(100, 20);
            this.tbYcoordC.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "x coord Cirkel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "y coord Cirkel";
            // 
            // Vergroot
            // 
            this.Vergroot.Location = new System.Drawing.Point(730, 244);
            this.Vergroot.Name = "Vergroot";
            this.Vergroot.Size = new System.Drawing.Size(55, 23);
            this.Vergroot.TabIndex = 12;
            this.Vergroot.Text = "Vergroot";
            this.Vergroot.UseVisualStyleBackColor = true;
            this.Vergroot.Click += new System.EventHandler(this.Vergroot_Click);
            // 
            // Verklein
            // 
            this.Verklein.Location = new System.Drawing.Point(662, 244);
            this.Verklein.Name = "Verklein";
            this.Verklein.Size = new System.Drawing.Size(62, 23);
            this.Verklein.TabIndex = 13;
            this.Verklein.Text = "Verklein";
            this.Verklein.UseVisualStyleBackColor = true;
            this.Verklein.Click += new System.EventHandler(this.Verklein_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Verklein);
            this.Controls.Add(this.Vergroot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbYcoordC);
            this.Controls.Add(this.tbXcoordC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbYcoordRh);
            this.Controls.Add(this.btnMaakCirkel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbXcoordRh);
            this.Controls.Add(this.btnMaakRechthoek);
            this.Controls.Add(this.Tekstvak);
            this.Controls.Add(this.Vlakje);
            this.Controls.Add(this.Knopje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Vlakje;

        private System.Windows.Forms.Button Knopje;
        private System.Windows.Forms.TextBox Tekstvak;
        private System.Windows.Forms.Button btnMaakRechthoek;
        private System.Windows.Forms.TextBox tbXcoordRh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMaakCirkel;
        private System.Windows.Forms.TextBox tbYcoordRh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbXcoordC;
        private System.Windows.Forms.TextBox tbYcoordC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Vergroot;
        private System.Windows.Forms.Button Verklein;
    }
}

