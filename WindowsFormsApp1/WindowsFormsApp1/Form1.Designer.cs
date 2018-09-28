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
            this.tbXcoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMaakCirkel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vlakje
            // 
            this.Vlakje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Vlakje.Location = new System.Drawing.Point(38, 27);
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
            // tbXcoord
            // 
            this.tbXcoord.Location = new System.Drawing.Point(471, 211);
            this.tbXcoord.Name = "tbXcoord";
            this.tbXcoord.Size = new System.Drawing.Size(100, 20);
            this.tbXcoord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "x coord";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kleurtje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMaakCirkel
            // 
            this.btnMaakCirkel.Location = new System.Drawing.Point(662, 283);
            this.btnMaakCirkel.Name = "btnMaakCirkel";
            this.btnMaakCirkel.Size = new System.Drawing.Size(123, 52);
            this.btnMaakCirkel.TabIndex = 5;
            this.btnMaakCirkel.Text = "Maak Cirkel";
            this.btnMaakCirkel.UseVisualStyleBackColor = true;
            this.btnMaakCirkel.Click += new System.EventHandler(this.btnMaakCirkel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaakCirkel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbXcoord);
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
        private System.Windows.Forms.TextBox tbXcoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMaakCirkel;
    }
}

