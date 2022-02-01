using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZv2
{
    public partial class Form1 : Form
    {
        // quiz zmienne
        int prawidłowaOdpowiedź;
        int numerPytania = 1;
        int wynik;
        int procent;
        int wszystkiePytania;

        public Form1()
        {
            InitializeComponent();

            ZadajPytanie(numerPytania);

            wszystkiePytania = 10;
        }

        private void Pytanie_Click(object sender, EventArgs e)
        {

        }

        private void SprawdźOdpowiedź(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == prawidłowaOdpowiedź)
            {
                wynik++;
            }

            if (numerPytania == wszystkiePytania)
            {
                // work out the percentage

                procent = (int)Math.Round((double)(wynik * 100) / wszystkiePytania);

                MessageBox.Show(
                    "GRATULACJE!" + Environment.NewLine +
                    "Odpowiedziałeś/aś na " + wynik + " pytań prawidłowo," + Environment.NewLine +
                    "co stanowi " + procent + "% pytań." + Environment.NewLine +
                    "Naciśnij OK, aby zagrać ponownie"
                    );
                wynik = 0;
                numerPytania = 0;
                ZadajPytanie(numerPytania);
            }
            numerPytania++;
            ZadajPytanie(numerPytania);
        }

        private void ZadajPytanie(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.mazurek;
                    Pytanie.Text = "Ptak widoczny na zdjęciu to?";

                    button1.Text = "drzemlik";
                    button2.Text = "wróbel";
                    button3.Text = "mazurek";
                    button4.Text = "dzięcioł";

                    prawidłowaOdpowiedź = 3;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.trznadel;
                    Pytanie.Text = "Jak nazwa się ten ptak?";

                    button1.Text = "trznadel";
                    button2.Text = "mysikrólik";
                    button3.Text = "lodówka";
                    button4.Text = "dudek";

                    prawidłowaOdpowiedź = 1;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.kaktus;
                    Pytanie.Text = "Największa sowa w polsce to?";

                    button1.Text = "sowa śnieżna";
                    button2.Text = "płomykówka";
                    button3.Text = "puszczyk";
                    button4.Text = "puchacz";

                    prawidłowaOdpowiedź = 4;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.question;
                    Pytanie.Text = "Jaki jest najmniejszy ptak w Polsce?";

                    button1.Text = "zniczek";
                    button2.Text = "wróbel";
                    button3.Text = "mysikrólik";
                    button4.Text = "zimorodek";

                    prawidłowaOdpowiedź = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.waga;
                    Pytanie.Text = "Największy ptak w Polsce pod względem ciężaru to?";

                    button1.Text = "kormoran";
                    button2.Text = "czapla";
                    button3.Text = "łabędź niemy";
                    button4.Text = "słowik";

                    prawidłowaOdpowiedź = 3;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.skrzydla;
                    Pytanie.Text = "Jak nazywa się największy ptak w Polsce" + Environment.NewLine +
                        "pod względem rozpiętości skrzydeł?";

                    button1.Text = "flaming";
                    button2.Text = "bielik";
                    button3.Text = "sęp";
                    button4.Text = "orzeł przedni";

                    prawidłowaOdpowiedź = 2;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.nuty;
                    Pytanie.Text = "Największy polski ptak śpiewający to?";

                    button1.Text = "sójka";
                    button2.Text = "harpia wielka";
                    button3.Text = "skowronek";
                    button4.Text = "kruk";

                    prawidłowaOdpowiedź = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.woda;
                    Pytanie.Text = "Jak nazywa się jedyny polski ptak śpiewający," + Environment.NewLine +
                        "który potrafi dobrze nurkować i pływać?";

                    button1.Text = "pluszcz zwyczajny";
                    button2.Text = "pingwin białobrewy";
                    button3.Text = "zimorodek";
                    button4.Text = "perkoz";

                    prawidłowaOdpowiedź = 1;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.question;
                    Pytanie.Text = "Który z tych ptaków nie jest chroniony?";

                    button1.Text = "pójdźka";
                    button2.Text = "bażant";
                    button3.Text = "cietrzew";
                    button4.Text = "jemiołuszka";

                    prawidłowaOdpowiedź = 2;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.limby;
                    Pytanie.Text = "Ptak, który omyłkowo sieje sosny limby to?";
                    button1.Text = "kopciuszek";
                    button2.Text = "gil";
                    button3.Text = "biegus rdzawy";
                    button4.Text = "orzechówka zwyczajna";

                    prawidłowaOdpowiedź = 4;

                    break;
            }
        }
    }
}
