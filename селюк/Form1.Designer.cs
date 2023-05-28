namespace селюк
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btStart = new Button();
            btOvladani = new Button();
            btKonec = new Button();
            pictureCesko = new PictureBox();
            pictureBritanie = new PictureBox();
            pictureUkrajina = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureCesko).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBritanie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUkrajina).BeginInit();
            SuspendLayout();
            // 
            // btStart
            // 
            btStart.BackColor = Color.Black;
            btStart.BackgroundImage = Properties.Resources.pozadí;
            btStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btStart.ForeColor = Color.FromArgb(0, 192, 0);
            btStart.Location = new Point(186, 301);
            btStart.Name = "btStart";
            btStart.Size = new Size(138, 55);
            btStart.TabIndex = 0;
            btStart.Text = "START";
            btStart.UseVisualStyleBackColor = false;
            btStart.Click += btStart_Click;
            // 
            // btOvladani
            // 
            btOvladani.BackColor = Color.Black;
            btOvladani.BackgroundImage = Properties.Resources.pozadí;
            btOvladani.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btOvladani.ForeColor = Color.FromArgb(0, 192, 0);
            btOvladani.Location = new Point(186, 362);
            btOvladani.Name = "btOvladani";
            btOvladani.Size = new Size(138, 55);
            btOvladani.TabIndex = 1;
            btOvladani.Text = "OVLÁDÁNÍ";
            btOvladani.UseVisualStyleBackColor = false;
            btOvladani.Click += btOvladani_Click;
            // 
            // btKonec
            // 
            btKonec.BackColor = Color.Black;
            btKonec.BackgroundImage = Properties.Resources.pozadí;
            btKonec.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btKonec.ForeColor = Color.FromArgb(0, 192, 0);
            btKonec.Location = new Point(186, 423);
            btKonec.Name = "btKonec";
            btKonec.Size = new Size(138, 55);
            btKonec.TabIndex = 2;
            btKonec.Text = "KONEC";
            btKonec.UseVisualStyleBackColor = false;
            btKonec.Click += btKonec_Click;
            // 
            // pictureCesko
            // 
            pictureCesko.Image = Properties.Resources.vlajkaČeskéRepubliky;
            pictureCesko.Location = new Point(918, 12);
            pictureCesko.Name = "pictureCesko";
            pictureCesko.Size = new Size(58, 34);
            pictureCesko.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCesko.TabIndex = 3;
            pictureCesko.TabStop = false;
            pictureCesko.Click += pictureCesko_Click;
            // 
            // pictureBritanie
            // 
            pictureBritanie.Image = Properties.Resources.vlajkaVelkeBritanie;
            pictureBritanie.Location = new Point(982, 12);
            pictureBritanie.Name = "pictureBritanie";
            pictureBritanie.Size = new Size(58, 34);
            pictureBritanie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBritanie.TabIndex = 4;
            pictureBritanie.TabStop = false;
            pictureBritanie.Click += pictureBritanie_Click;
            // 
            // pictureUkrajina
            // 
            pictureUkrajina.Image = Properties.Resources.vlajkaUkrajiny;
            pictureUkrajina.Location = new Point(1046, 12);
            pictureUkrajina.Name = "pictureUkrajina";
            pictureUkrajina.Size = new Size(58, 34);
            pictureUkrajina.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUkrajina.TabIndex = 5;
            pictureUkrajina.TabStop = false;
            pictureUkrajina.Click += pictureUkrajina_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pozadí;
            ClientSize = new Size(1116, 635);
            Controls.Add(pictureUkrajina);
            Controls.Add(pictureBritanie);
            Controls.Add(pictureCesko);
            Controls.Add(btKonec);
            Controls.Add(btOvladani);
            Controls.Add(btStart);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureCesko).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBritanie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUkrajina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btStart;
        private Button btOvladani;
        private Button btKonec;
        private PictureBox pictureCesko;
        private PictureBox pictureBritanie;
        private PictureBox pictureUkrajina;
    }
}