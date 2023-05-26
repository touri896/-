namespace селюк
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Vytvořím si objekt s form2
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btOvladani_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Vytvořím si objekt s form2
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btKonec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }





}
