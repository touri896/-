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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(103, 186, 36);
            label1.Location = new Point(459, 12);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "OVLÁDÁNÍ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(103, 186, 36);
            textBox1.Location = new Point(274, 63);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(539, 26);
            textBox1.TabIndex = 1;
            textBox1.Text = "Vítejte ve hře! Zde je detailní návod k ovládání postavičky:";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(77, 29);
            button1.TabIndex = 7;
            button1.Text = "ZPĚT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(103, 186, 36);
            textBox2.Location = new Point(12, 141);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1092, 301);
            textBox2.TabIndex = 8;
            textBox2.Text = resources.GetString("textBox2.Text");
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Black;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(103, 186, 36);
            textBox3.Location = new Point(12, 448);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1092, 50);
            textBox3.TabIndex = 9;
            textBox3.Text = resources.GetString("textBox3.Text");
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Black;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox4.ForeColor = Color.FromArgb(103, 186, 36);
            textBox4.Location = new Point(274, 537);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(539, 51);
            textBox4.TabIndex = 10;
            textBox4.Text = "Přeji vám hodně zábavy a úspěchů ve hře!";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Black;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox5.ForeColor = Color.FromArgb(103, 186, 36);
            textBox5.Location = new Point(942, 571);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 19);
            textBox5.TabIndex = 11;
            textBox5.Text = "Олександр Іванов";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1116, 635);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Enabled = false;
            ForeColor = Color.Black;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}