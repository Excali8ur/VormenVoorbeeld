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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

