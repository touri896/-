namespace селюк
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            lbNaboje = new Label();
            lbSkore = new Label();
            lbZdravi = new Label();
            pgZdravi = new ProgressBar();
            player = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // lbNaboje
            // 
            lbNaboje.AutoSize = true;
            lbNaboje.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNaboje.ForeColor = Color.FromArgb(103, 186, 36);
            lbNaboje.Location = new Point(177, 20);
            lbNaboje.Name = "lbNaboje";
            lbNaboje.Size = new Size(83, 21);
            lbNaboje.TabIndex = 0;
            lbNaboje.Text = "Náboje: 0";
            // 
            // lbSkore
            // 
            lbSkore.AutoSize = true;
            lbSkore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSkore.ForeColor = Color.FromArgb(103, 186, 36);
            lbSkore.Location = new Point(453, 20);
            lbSkore.Name = "lbSkore";
            lbSkore.Size = new Size(117, 21);
            lbSkore.TabIndex = 1;
            lbSkore.Text = "Počet zabití: 0";
            // 
            // lbZdravi
            // 
            lbZdravi.AutoSize = true;
            lbZdravi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbZdravi.ForeColor = Color.FromArgb(103, 186, 36);
            lbZdravi.Location = new Point(812, 20);
            lbZdravi.Name = "lbZdravi";
            lbZdravi.Size = new Size(63, 21);
            lbZdravi.TabIndex = 2;
            lbZdravi.Text = "Zdraví:";
            // 
            // pgZdravi
            // 
            pgZdravi.Location = new Point(881, 18);
            pgZdravi.Name = "pgZdravi";
            pgZdravi.Size = new Size(187, 23);
            pgZdravi.TabIndex = 3;
            pgZdravi.Value = 100;
            // 
            // player
            // 
            player.Image = Properties.Resources.up;
            player.Location = new Point(499, 503);
            player.Name = "player";
            player.Size = new Size(71, 100);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 4;
            player.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainTimer;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(77, 29);
            button1.TabIndex = 6;
            button1.Text = "ZPĚT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1116, 635);
            Controls.Add(button1);
            Controls.Add(player);
            Controls.Add(pgZdravi);
            Controls.Add(lbZdravi);
            Controls.Add(lbSkore);
            Controls.Add(lbNaboje);
            Name = "Form3";
            Text = "Form3";
            KeyDown += KlavesaDolu;
            KeyUp += KlavesaNahoru;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNaboje;
        private Label lbSkore;
        private Label lbZdravi;
        private ProgressBar pgZdravi;
        private PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private Button button1;
    }
}