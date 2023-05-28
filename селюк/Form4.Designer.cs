namespace селюк
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureCesko = new PictureBox();
            pictureBritanie = new PictureBox();
            pictureUkrajina = new PictureBox();
            btZpet = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureCesko).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBritanie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUkrajina).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(103, 186, 36);
            label1.Location = new Point(459, 28);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 12;
            label1.Text = "OVLÁDÁNÍ";
            // 
            // pictureCesko
            // 
            pictureCesko.Image = Properties.Resources.vlajkaČeskéRepubliky;
            pictureCesko.Location = new Point(918, 12);
            pictureCesko.Name = "pictureCesko";
            pictureCesko.Size = new Size(58, 34);
            pictureCesko.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCesko.TabIndex = 18;
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
            pictureBritanie.TabIndex = 19;
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
            pictureUkrajina.TabIndex = 20;
            pictureUkrajina.TabStop = false;
            pictureUkrajina.Click += pictureUkrajina_Click;
            // 
            // btZpet
            // 
            btZpet.BackColor = Color.Black;
            btZpet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btZpet.ForeColor = Color.FromArgb(0, 192, 0);
            btZpet.Location = new Point(12, 12);
            btZpet.Name = "btZpet";
            btZpet.Size = new Size(76, 29);
            btZpet.TabIndex = 21;
            btZpet.Text = "Zpět";
            btZpet.UseVisualStyleBackColor = false;
            btZpet.Click += btZpet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(103, 186, 36);
            label2.Location = new Point(274, 86);
            label2.Name = "label2";
            label2.Size = new Size(526, 25);
            label2.TabIndex = 22;
            label2.Text = "Vítejte ve hře! Zde je detailní návod k ovládání postavičky:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(103, 186, 36);
            label3.Location = new Point(33, 125);
            label3.Name = "label3";
            label3.Size = new Size(1036, 294);
            label3.TabIndex = 23;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(103, 186, 36);
            label4.Location = new Point(74, 471);
            label4.Name = "label4";
            label4.Size = new Size(902, 21);
            label4.TabIndex = 24;
            label4.Text = "Pamatujte si, že herní plocha může obsahovat překážky, kterým se musíte vyhnout, a nepřátele, které musíte porazit. \r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(103, 186, 36);
            label5.Location = new Point(291, 545);
            label5.Name = "label5";
            label5.Size = new Size(509, 32);
            label5.TabIndex = 25;
            label5.Text = "Přeji vám hodně zábavy a úspěchů ve hře!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(103, 186, 36);
            label6.Location = new Point(972, 595);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 26;
            label6.Text = "Alexandr Ivanov";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(103, 186, 36);
            label7.Location = new Point(143, 492);
            label7.Name = "label7";
            label7.Size = new Size(756, 21);
            label7.TabIndex = 27;
            label7.Text = "Buďte opatrní a dobře si vybírejte směr pohybu a střelby, abyste dosáhli svých cílů a přežili ve hře.";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1116, 635);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btZpet);
            Controls.Add(pictureUkrajina);
            Controls.Add(pictureBritanie);
            Controls.Add(pictureCesko);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureCesko).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBritanie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUkrajina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureCesko;
        private PictureBox pictureBritanie;
        private PictureBox pictureUkrajina;
        private Button btZpet;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}