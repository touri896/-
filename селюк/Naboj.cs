using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace селюк
{
    internal class Naboj    
    {
        public string direction;
        public int kulkaDoleva;
        public int kulkaDoprava;

        private int rychlost;
        private PictureBox kulka = new PictureBox(); 
        private System.Windows.Forms.Timer timerkulka = new System.Windows.Forms.Timer();

        public void UdelejKulku(Form form)
        {
            kulka.BackColor = Color.White;
            kulka.Size = new Size(5, 5);
            kulka.Tag = "kulka";
            kulka.Left = kulkaDoleva;
            kulka.Top = kulkaDoprava;
            kulka.BringToFront();

            form.Controls.Add(kulka);

            timerkulka.Interval = rychlost;
            timerkulka.Tick += timerkulkaEvent;
            timerkulka.Enabled = true;
        }

        private void timerkulkaEvent(object sender, EventArgs e) //me prestal fungovat i pohyb wtf, a btw kdyz zmacknu mezernik tak spadne to okno 
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
                timerkulka = null;
                kulka = null;
            }
        }
    }
}
