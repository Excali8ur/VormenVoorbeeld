﻿namespace WindowsFormsApp1
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
            this.Knopje = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Knopje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Knopje;
    }
}

