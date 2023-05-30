using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace селюк
{
    public partial class Form3 : Form
    {
        bool left, right, up, down, gameOver;  //if score 100 tak ПЕРЕМОГА 
        bool Jumping = false;
        string facing = "up";
        int zdravi = 100;
        int rychlost = 10;
        int naboje = 15;
        int rychlostZombiku = 2;
        int skore;
        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();
        private Label lbLevel1; // Deklarace labelu
        private Label lbLevel2;
        private Label lbLevel3;
        private Label lbLevel4;

        public Form3()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();
            RestartujHru();

            lbLevel1 = new Label();
            lbLevel2 = new Label();
            lbLevel3 = new Label();
            lbLevel4 = new Label();

            // Inicializace a konfigurace labelu lbLevel1
            lbLevel1.Text = "EASY LEVEL";
            lbLevel1.Font = new Font("Arial", 14, FontStyle.Bold);
            lbLevel1.ForeColor = Color.Red;
            lbLevel1.AutoSize = true;
            lbLevel1.Location = new Point(150, 20);
            this.Controls.Add(lbLevel1);

            // Inicializace a konfigurace labelu lbLevel2
            lbLevel2.Text = "MEDIUM LEVEL";
            lbLevel2.Font = new Font("Arial", 14, FontStyle.Bold);
            lbLevel2.ForeColor = Color.Red;
            lbLevel2.AutoSize = true;
            lbLevel2.Location = new Point(150, 20);
            this.Controls.Add(lbLevel2);

            // Inicializace a konfigurace labelu lbLevel3
            lbLevel3.Text = "HARD LEVEL";
            lbLevel3.Font = new Font("Arial", 14, FontStyle.Bold);
            lbLevel3.ForeColor = Color.Red;
            lbLevel3.AutoSize = true;
            lbLevel3.Location = new Point(150, 20);
            this.Controls.Add(lbLevel3);

            // Inicializace a konfigurace labelu lbLevel4
            lbLevel4.Text = "DONBAS LEVEL";
            lbLevel4.Font = new Font("Arial", 14, FontStyle.Bold);
            lbLevel4.ForeColor = Color.Red;
            lbLevel4.AutoSize = true;
            lbLevel4.Location = new Point(150, 20);
            this.Controls.Add(lbLevel4);

            lbLevel1.Visible = false;
            lbLevel2.Visible = false;
            lbLevel3.Visible = false;
            lbLevel4.Visible = false;

        }

        private void MainTimer(object sender, EventArgs e)
        {
            if (zdravi > 1)
            {
                pgZdravi.Value = zdravi;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
            }

            lbNaboje.Text = "Náboje: " + naboje;
            lbSkore.Text = "Počet zabití: " + skore;

            if (left == true && player.Left > 0)
            {
                player.Left -= rychlost;
            }

            if (right == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += rychlost;
            }

            if (up == true && player.Top > 55)
            {
                player.Top -= rychlost;
            }

            if (down == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += rychlost;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "naboje") //zbirani nabojů
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        naboje += 5;
                    }
                } //if intersects width, than select new way possiblr

                if (x is PictureBox && (string)x.Tag == "zombie")  
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        zdravi -= 1;
                    }
                    if (x.Left > player.Left)
                    {
                        x.Left -= rychlostZombiku;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += rychlostZombiku;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= rychlostZombiku;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += rychlostZombiku;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "kulka" && x is PictureBox && (string)x.Tag == "zombie")   
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            skore++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x));
                            SpawniZombiky();
                        }
                    }
                }
            }

            if (skore >= 0 && skore < 20)
            {
                lbLevel1.Visible = true;
                lbLevel2.Visible = false;
                lbLevel3.Visible = false;
                lbLevel4.Visible = false;
            }
            else if (skore >= 20 && skore < 40)
            {
                lbLevel1.Visible = false;
                lbLevel2.Visible = true;
                lbLevel3.Visible = false;
                lbLevel4.Visible = false;
                rychlostZombiku = 3;
            }
            else if (skore >= 40 && skore < 60)
            {
                lbLevel1.Visible = false;
                lbLevel2.Visible = false;
                lbLevel3.Visible = true;
                lbLevel4.Visible = false;
                rychlostZombiku = 4;
            }
            else if (skore >= 60)
            {
                lbLevel1.Visible = false;
                lbLevel2.Visible = false;
                lbLevel3.Visible = false;
                lbLevel4.Visible = true;
                rychlostZombiku = 5;
            }
        }

        private int jumpHeight = 30;
        private int jumpSpeed = 5;
        private int originalX;
        private int originalY;

        private void KlavesaDolu(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                right = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                up = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                down = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }

            if (e.KeyCode == Keys.ControlKey)
            {
                if (!Jumping)
                {
                    originalX = player.Left;
                    originalY = player.Top;
                    Jump();
                }
            }
            

            if (e.KeyCode == Keys.Escape)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }           
        }

        private void KlavesaNahoru(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }

            if (e.KeyCode == Keys.Space && naboje > 0 && gameOver == false)
            {
                naboje--;
                Strilet(facing);

                if (naboje < 1)
                {
                    SpawnNaboju();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartujHru();
                lbLevel1.Text = ""; // Skrytí textu labelu lbLevel1
            }
        }

        private void Jump()
        {
            Jumping = true;

            int jumpDistance = 20;
            int jumpHeight = 100;

            if (facing == "up" && player.Top > jumpHeight)
            {
                player.Top -= jumpDistance;
            }
            else if (facing == "down" && player.Top + player.Height < this.ClientSize.Height - jumpHeight)
            {
                player.Top += jumpDistance;
            }
            else if (facing == "left" && player.Left > jumpHeight)
            {
                player.Left -= jumpDistance;
            }
            else if (facing == "right" && player.Left + player.Width < this.ClientSize.Width - jumpHeight)
            {
                player.Left += jumpDistance;
            }

            System.Threading.Thread.Sleep(10);

            Jumping = false;
        }

        private void Strilet(string direction)
        {
            Naboj vystrelitKulku = new Naboj();
            vystrelitKulku.direction = direction;
            vystrelitKulku.kulkaDoleva = player.Left + (player.Width / 2);
            vystrelitKulku.kulkaDoprava = player.Top + (player.Height / 2);
            vystrelitKulku.UdelejKulku(this);
        }

        private void SpawniZombiky()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void SpawnNaboju()
        {
            PictureBox naboje = new PictureBox();
            naboje.Image = Properties.Resources.ammo_Image;
            naboje.SizeMode = PictureBoxSizeMode.AutoSize;
            naboje.Left = randNum.Next(10, this.ClientSize.Width - naboje.Width);
            naboje.Top = randNum.Next(60, this.ClientSize.Height - naboje.Height);
            naboje.Tag = "naboje";
            this.Controls.Add(naboje);
            naboje.BringToFront();
            player.BringToFront();
        }

        private void RestartujHru()
        {
            player.Image = Properties.Resources.up;

            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();

            for (int i = 0; i < 3; i++)
            {
                SpawniZombiky();
            }

            left = false;
            right = false;
            up = false;
            down = false;
            gameOver = false;

            // Skrýt všechny level labely
            lbLevel1.Visible = false;
            lbLevel2.Visible = false;
            lbLevel3.Visible = false;
            lbLevel4.Visible = false;

            zdravi = 100;
            skore = 0;
            naboje = 10;
            rychlostZombiku = 2;
            GameTimer.Start();
        }
    }
}