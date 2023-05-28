using System;
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
        private System.Windows.Forms.Timer timerkulka = new System.Windows.Forms.Timer(); //neni problem v timeru? jj ja nevim no XD

        public void UdelejKulku(Form form) //co mam delat s tema picture boxama jak se sekaj 
        {
            kulka.BackColor = Color.Green;  //xxxd jako me to taky napadlo no 
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
         
        private void TimerkulkaEvent(object sender, EventArgs e) //shamoona  kdekoliv, narandom to prestane fungovat. ted to pustim a koukej jak narandom budou mizet naboje ale nebude strilet
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

            if (kulka.Left < 10 || kulka.Left > 860 || kulka.Top < 10 || kulka.Top > 600)
            {
                timerkulka.Stop();
                timerkulka.Dispose();
                kulka.Dispose();
            }
        }
    }
}