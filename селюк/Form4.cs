using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace селюк
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btZpet_Click(object sender, EventArgs e)
        {
            this.Close();
            // Vytvořím si objekt s form2
            Form1 form1 = new Form1();
            form1.Show();
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
            Localization.SetCurrentLanguage(languageCode);

            // Aktualizovat textové zdroje na formuláři
            label1.Text = Localization.GetText("label1", languageCode);
            label2.Text = Localization.GetText("label2", languageCode);
            label3.Text = Localization.GetText("label3", languageCode);
            label4.Text = Localization.GetText("label4", languageCode);
            label5.Text = Localization.GetText("label5", languageCode);
            label6.Text = Localization.GetText("label6", languageCode); //hh
            btZpet.Text = Localization.GetText("btZpet", languageCode);
        }

        public static class Localization
        {
            private static Dictionary<string, string> csTexts = new Dictionary<string, string>
            {
                { "label1", "OVLÁDÁNÍ" },
                { "label2", "Vítejte ve hře! Zde je detailní návod k ovládání postavičky:" },
                { "label3", "\r\nŠipka nahoru: Použijte toto tlačítko pro pohyb postavičky nahoru po herní ploše. \r\n\r\nŠipka dolů: Tlačítko šipky dolů slouží k pohybu postavičky dolů po herní ploše. \r\n\r\nŠipka doleva: Tímto tlačítkem můžete posunout postavičku doleva po herní ploše. \r\n\r\nŠipka doprava: Tlačítko šipky doprava slouží k posunu postavičky doprava po herní ploše. \r\n\r\n[Pokud zmáčknete více než jedno tlačítko najednou, například šipku doprava a šipku dolů, postavička se bude pohybovat diagonálně.]\r\n\r\nMezerník: Pro vystřelení použijte tlačítko mezerníku. Postavička vystřelí projektil směrem, kterým se dívá. \r\n\r\nSkok: Pro skok použijte tlačítko Ctrl. Postavička vyskočí směrem, kterým se dívá\r\n" },
                { "label4", "Pamatujte si, že herní plocha může obsahovat překážky, kterým se musíte vyhnout, a nepřátele, které musíte porazit. Buďte opatrní a dobře si vybírejte směr pohybu a střelby, abyste dosáhli svých cílů a přežili ve hře.\r\n" },
                { "label5", "Přeji vám hodně zábavy a úspěchů ve hře!" },
                { "label6", "Alexandr Ivanov" },
                { "btZpet", "Zpět" },
                // Další textové zdroje pro češtinu
            };

            private static Dictionary<string, string> enTexts = new Dictionary<string, string>
            {
                { "label1", "CONTROLS" },
                { "label2", "Welcome to the game! Here is a detailed guide for controlling the character" },
                { "label3", "\r\nUp Arrow: Use this button to move the characters up the play area. \r\n\r\nDown Arrow: The down arrow button is used to move the figure down along the playing surface. \r\n\r\nArrow left: Use this button to move the figure to the left along the playing surface. \r\n\r\nRightwards Arrow: Use the right arrow button to move the figure to the right along the playing surface \r\n\r\n[If you press more than one button at a time, such as the right arrow and the down arrow, the figure will move diagonally.]\r\n\r\nSpace bar Use the space bar button to shoot. The figure fires the projectile in the direction it's looking. \r\n\r\nJump Use the Ctrl button to jump. The figure jumps up in the direction it's looking\r\n" },
                { "label4", "Remember, the playing surface can contain obstacles you need to avoid and enemies you need to defeat. Be careful and choose your direction of movement and shooting well to achieve your goals and survive in the game.\r\n" },
                { "label5", "I wish you a lot of fun and success in the game!" },
                { "label6", "Alexandr Ivanov" },
                { "btZpet", "Back" },
                // Další textové zdroje pro angličtinu
            };

            private static Dictionary<string, string> ukTexts = new Dictionary<string, string>
            {
                { "label1", "КЕРУВАННЯ" },
                { "label2", "Ласкаво просимо у гру! Ось детальна інструкція з керування фігурою:" },
                { "label3", "\r\nСтрілка вгору: Використовуйте цю кнопку для переміщення фігури вгору по ігровій стільниці. \r\n\r\nСтрілка вниз: Кнопка стрілки вниз служить для переміщення фігурки вниз по ігровій площі. \r\n\r\nСтрілка ліворуч: За допомогою цієї кнопки ви можете перемістити фігуру вліво по ігровій стільниці. \r\n\r\nСтрілка вправо: Кнопка стрілки вправо служить для переміщення фігури вправо по ігровій площі. \r\n\r\n[Якщо ви натиснете більше однієї кнопки одночасно, наприклад, стрілку праворуч і стрілку вниз, фігура буде рухатися по діагоналі.]\r\n\r\nПробіл: Для пострілу скористайтеся кнопкою пробілу. Персонаж вистрілює снаряд в той бік, в якому він дивиться. \r\n\r\nСтрибки: Для стрибка скористайтеся кнопкою Ctrl. Персонаж стрибає в той бік, в якому дивиться\r\n" },
                { "label4", "Пам'ятайте, що ігрова площа може містити перешкоди, яких потрібно уникати, і ворогів, яких потрібно перемогти. Будьте обережні і добре вибирайте напрямок руху і стрільби, щоб досягти своїх цілей і вижити у грі.\r\n" },
                { "label5", "Бажаю вам веселощів та успіхів у грі!" },
                { "label6", "Олександр Іванов" },
                { "btZpet", "Назад" },
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
