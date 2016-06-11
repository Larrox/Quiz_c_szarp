using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projekt
{
    class Pytanie
    {
        private string[,] pytanie = new string[10, 6];

         public Pytanie()
        {
            //
            //pytania
            //
            //1
            pytanie[0, 0] = "Których z podanych nie ma wśród cząstek subatomowych?";
            pytanie[0, 1] = "A.fermionów";
            pytanie[0, 2] = "B. hadronów";
            pytanie[0, 3] = "C. barionów";
            pytanie[0, 4] = "D. kationów";
            pytanie[0, 5] = "D";
            //2
            pytanie[1, 0] = "Które z podanych nie jest nazwą cząstki w fizyce kwantowej?";
            pytanie[1, 1] = "A. pion";
            pytanie[1, 2] = "B. mion";
            pytanie[1, 3] = "C. baon";
            pytanie[1, 4] = "D. taon";
            pytanie[1, 5] = "C";
            //3
            pytanie[2, 0] = "Co nie jest używane do opisu cząstek w fizyce kwantowej?";
            pytanie[2, 1] = "A. powab";
            pytanie[2, 2] = "B.wklęsłość";
            pytanie[2, 3] = "C. kolor";
            pytanie[2, 4] = "D. dziwność";
            pytanie[2, 5] = "B";
            //4
            pytanie[3, 0] = "Antycząstką elektronu jest:";
            pytanie[3, 1] = "A. Bozon";
            pytanie[3, 2] = "B. Fermion";
            pytanie[3, 3] = "C. Mion";
            pytanie[3, 4] = "D. Pozyton";
            pytanie[3, 5] = "D";
            //5
            pytanie[4, 0] = "Jaką jednostkę używamy przy przyśpieszaniu cząstek w akceleratorach?";
            pytanie[4, 1] = "A. c";
            pytanie[4, 2] = "B. m/s";
            pytanie[4, 3] = "C. eV";
            pytanie[4, 4] = "D. V";
            pytanie[4, 5] = "C";
            //6
            pytanie[5, 0] = "Cząstką elementarną jest:";
            pytanie[5, 1] = "A. Foton";
            pytanie[5, 2] = "B. Proton";
            pytanie[5, 3] = "C. Atom";
            pytanie[5, 4] = "D. Neutron";
            pytanie[5, 5] = "A";
            //7
            pytanie[6, 0] = "Proton jest zbudowany z:";
            pytanie[6, 1] = "A. Gluonów";
            pytanie[6, 2] = "B. Kwarków";
            pytanie[6, 3] = "C. Atomów";
            pytanie[6, 4] = "D. Anionów";
            pytanie[6, 5] = "B";
            //8
            pytanie[7, 0] = "Co przenoszą fale podczerwone?";
            pytanie[7, 1] = "A. Zimno";
            pytanie[7, 2] = "B. Kolory";
            pytanie[7, 3] = "C. UV";
            pytanie[7, 4] = "D. Ciepło";
            pytanie[7, 5] = "D";
            //9
            pytanie[8, 0] = "Co jest najmniejsze?";
            pytanie[8, 1] = "A. Proton";
            pytanie[8, 2] = "B. Atom";
            pytanie[8, 3] = "C. Elektron";
            pytanie[8, 4] = "D. Neutron";
            pytanie[8, 5] = "C";
            //10
            pytanie[9, 0] = "Zakres serii Lymana to:";
            pytanie[9, 1] = "A. UV";
            pytanie[9, 2] = "B. VIS + UV";
            pytanie[9, 3] = "C. IR";
            pytanie[9, 4] = "D. PH";
            pytanie[9, 5] = "A";
        }

        public string get(int i, int j)
        {
            return pytanie[i, j];
        }
    }
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private static int i = 0;
        private static string[] zaznaczone = new string[10];
        private static System.Drawing.Color[]  kolor = new System.Drawing.Color[10];

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Button1.Visible = false;
            RadioButton1.Visible = true;
            RadioButton2.Visible = true;
            RadioButton3.Visible = true;
            RadioButton4.Visible = true;
            Button2.Visible = true;
            Pytanie mirek= new Pytanie();
            Label3.Text = "Pytanie " + (i + 1) + ".:";
            Label1.Text = mirek.get(i, 0);
            RadioButton1.Text = mirek.get(i, 1);
            RadioButton2.Text = mirek.get(i, 2);
            RadioButton3.Text = mirek.get(i, 3);
            RadioButton4.Text = mirek.get(i, 4);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Pytanie marek = new Pytanie();

            if (Button2.Text == "Następne pytanie")
            {
                if (i < 9)
                {
                    if (RadioButton1.Checked)
                    {
                        zaznaczone[i] = "A";
                    }
                    if (RadioButton2.Checked)
                    {
                        zaznaczone[i] = "B";
                    }
                    if (RadioButton3.Checked)
                    {
                        zaznaczone[i] = "C";
                    }
                    if (RadioButton4.Checked)
                    {
                        zaznaczone[i] = "D";
                    }

                    i++;
                    Label3.Text = "Pytanie " + (i + 1) + ".:";
                    Label1.Text = marek.get(i, 0);
                    RadioButton1.Text = marek.get(i, 1);
                    RadioButton2.Text = marek.get(i, 2);
                    RadioButton3.Text = marek.get(i, 3);
                    RadioButton4.Text = marek.get(i, 4);

                }
                if (i == 9)
                {

                    Button2.Text = "Zakończ i sprawdź odpowiedzi";
                }
            }
            else
            {
                if (RadioButton1.Checked)
                {
                    zaznaczone[i] = "A";
                }
                if (RadioButton2.Checked)
                {
                    zaznaczone[i] = "B";
                }
                if (RadioButton3.Checked)
                {
                    zaznaczone[i] = "C";
                }
                if (RadioButton4.Checked)
                {
                    zaznaczone[i] = "D";
                }

                Button2.Visible = false;
                Label2.Text = "Twoje odpowiedzi to:";

                Numer.Text = "Numer pytania:";
                Numer0.Text = "1.";
                Numer1.Text = "2.";
                Numer2.Text = "3.";
                Numer3.Text = "4.";
                Numer4.Text = "5.";
                Numer5.Text = "6.";
                Numer6.Text = "7.";
                Numer7.Text = "8.";
                Numer8.Text = "9.";
                Numer9.Text = "10.";

                Zaznaczona.Text = "Zaznczona odpowiedź:";
                Zaznaczona0.Text = zaznaczone[0];
                Zaznaczona1.Text = zaznaczone[1];
                Zaznaczona2.Text = zaznaczone[2];
                Zaznaczona3.Text = zaznaczone[3];
                Zaznaczona4.Text = zaznaczone[4];
                Zaznaczona5.Text = zaznaczone[5];
                Zaznaczona6.Text = zaznaczone[6];
                Zaznaczona7.Text = zaznaczone[7];
                Zaznaczona8.Text = zaznaczone[8];
                Zaznaczona9.Text = zaznaczone[9];

                Poprawna.Text = "Poprawna odpowiedź:";
                Poprawna0.Text = marek.get(0, 5);
                Poprawna1.Text = marek.get(1, 5);
                Poprawna2.Text = marek.get(2, 5);
                Poprawna3.Text = marek.get(3, 5);
                Poprawna4.Text = marek.get(4, 5);
                Poprawna5.Text = marek.get(5, 5);
                Poprawna6.Text = marek.get(6, 5);
                Poprawna7.Text = marek.get(7, 5);
                Poprawna8.Text = marek.get(8, 5);
                Poprawna9.Text = marek.get(9, 5);

                int licznik = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (zaznaczone[i] == marek.get(i, 5))
                    {
                        licznik++;
                        kolor[i] = System.Drawing.Color.Green;
                    }
                    else
                    {
                        kolor[i] = System.Drawing.Color.Red;
                    }
                }

                Zaznaczona0.ForeColor = kolor[0];
                Zaznaczona1.ForeColor = kolor[1];
                Zaznaczona2.ForeColor = kolor[2];
                Zaznaczona3.ForeColor = kolor[3];
                Zaznaczona4.ForeColor = kolor[4];
                Zaznaczona5.ForeColor = kolor[5];
                Zaznaczona6.ForeColor = kolor[6];
                Zaznaczona7.ForeColor = kolor[7];
                Zaznaczona8.ForeColor = kolor[8];
                Zaznaczona9.ForeColor = kolor[9];

                Wynik.Text = "Gratulacje, udało Ci się uzyskać " + (licznik * 10).ToString() + "% punktów!!!";
            }
        }
    }
}