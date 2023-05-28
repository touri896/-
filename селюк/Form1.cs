namespace селюк
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            this.Hide();  //if close, than open that window and add another
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
            Application.Exit();
        }

        private void pictureCesko_Click(object sender, EventArgs e)
        {
            // Nastavení češtiny jako aktuálního jazyka
            SetLanguage("cs");
        }

        private void pictureBritanie_Click(object sender, EventArgs e)
        {
            // Nastavení angličtiny jako aktuálního jazyka
            SetLanguage("en");
        }

        private void pictureUkrajina_Click(object sender, EventArgs e)
        {
            // Nastavení ukrajinštiny jako aktuálního jazyka
            SetLanguage("uk");
        }

        private void SetLanguage(string languageCode)
        {
            // Nastavit aktuální jazyk aplikace

            // Příklad použití: 
            Localization.SetCurrentLanguage(languageCode);

            // Aktualizovat textové zdroje na formuláři

            // Příklad použití:
            btStart.Text = Localization.GetText("btStart", languageCode);
            btOvladani.Text = Localization.GetText("btOvladani", languageCode);
            btKonec.Text = Localization.GetText("btKonec", languageCode);
            // ...

            // Aktualizovat textové zdroje na ostatních formulářích (pokud existují)

            // Příklad použití:
            // form2.UpdateLanguage();

            // Opakujte tyto kroky pro všechny prvky a formuláře, které chcete aktualizovat podle jazyka.
        }

        public static class Localization
        {
            private static Dictionary<string, string> csTexts = new Dictionary<string, string>
            {
                { "btStart", "HRÁT" },
                { "btOvladani", "OVLÁDÁNÍ" },
                { "btKonec", "KONEC" },
                // Další textové zdroje pro češtinu
            };

            private static Dictionary<string, string> enTexts = new Dictionary<string, string>
            {
                { "btStart", "PLAY" },
                { "btOvladani", "CONTROLS" },
                { "btKonec", "END" },
                // Další textové zdroje pro angličtinu
            };

            private static Dictionary<string, string> ukTexts = new Dictionary<string, string>     //OKEJ TED KOD HRY     
            {
                { "btStart", "ГРАТИ" },
                { "btOvladani", "КЕРУВАННЯ" },
                { "btKonec", "КІНЕЦЬ" },
                // Další textové zdroje pro ukrajinštinu
            };

            public static void SetCurrentLanguage(string languageCode)
            {
                // Nastavit aktuální jazyk na základě languageCode
            }

            public static string GetText(string key, string languageCode)
            {
                // Vrátit překlad pro daný klíč a aktuální jazyk
                switch (languageCode)
                {
                    case "cs":
                        return csTexts[key];
                    case "en":
                        return enTexts[key];
                    case "uk":
                        return ukTexts[key];

                    default:
                        return "";
                }
            }
        }
    }





}
