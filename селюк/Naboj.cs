﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace селюк
{
    internal class Naboj
    {
        public string direction = "up";
        public int kulkaDoleva = 0;
        public int kulkaDoprava = 0;

        private int rychlost = 5;
        private PictureBox kulka = new PictureBox();
        private System.Windows.Forms.Timer timerkulka = new System.Windows.Forms.Timer(); 

        public void UdelejKulku(Form form)  
        {
            kulka.BackColor = Color.Orange;  
            kulka.Size = new Size(5, 5);
            kulka.Tag = "kulka";
            kulka.Left = kulkaDoleva;
            kulka.Top = kulkaDoprava;
            kulka.BringToFront();

            form.Controls.Add(kulka);

            timerkulka.Interval = rychlost;
            timerkulka.Tick += TimerkulkaEvent;
            timerkulka.Enabled = true;
        }
         
        private void TimerkulkaEvent(object sender, EventArgs e) 
        {
            if (direction == "left")
            {
                kulka.Left -= rychlost;
            }
            else if (direction == "right")
            {
                kulka.Left += rychlost;
            }
            else if (direction == "up")
            {
                kulka.Top -= rychlost;
            }
            else if (direction == "down")
            {
                kulka.Top += rychlost;
            }

            if (kulka.Left < 10 || kulka.Left > 1132 || kulka.Top < 10 || kulka.Top > 600)
            {
                timerkulka.Stop();
                timerkulka.Dispose();
                kulka.Dispose();
            }
        }
    }
}