namespace Uygulama2_BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int soruNo = 0, dogru = 0, yanlis = 0;
        public void IsikKapat()
        {
            // YANAN T�M I�IKLARI KAPAT
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void buttonSonraki_Click(object sender, EventArgs e)
        {
            soruNo++;
            labelSoruSayisi.Text = soruNo.ToString();

            if (soruNo == 1)
            {

                richTextBox1.Text = "Cumhuriyet ne zaman ilan edilmi�tir?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
            }
            IsikKapat();


            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege b�lgesinde bulunmaz?";
                buttonA.Text = "�zmir";
                buttonB.Text = "Bal�kesir";
                buttonC.Text = "Ayd�n";
                buttonD.Text = "Manisa";
            }
            IsikKapat();
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Ku�lar hangi yazar�m�za ait bir eserdir?";
                buttonA.Text = "Sait Faik";
                buttonB.Text = "Cemal S�reya";
                buttonC.Text = "Attila �lhan";
                buttonD.Text = "Re�at Nuri";
            }
            IsikKapat();

            if (soruNo == 4)
            {
                richTextBox1.Text = "Fatih Sultan Mehmet'in babas� kimdir?";
                buttonA.Text = "2.Murat";
                buttonB.Text = "1.Mehmet";
                buttonC.Text = "Y�ld�r�m Beyaz�t";
                buttonD.Text = "Kan�n� Sultan S�leyman";
            }
            IsikKapat();

            if (soruNo == 5)
            {
                richTextBox1.Text = "Galatasaray hangi y�l UEFA kupas�n� alm��t�r?";
                buttonA.Text = "1998";
                buttonB.Text = "2001";
                buttonC.Text = "2000";
                buttonD.Text = "2002";
            }
            IsikKapat();

            if (soruNo == 6)
            {
                richTextBox1.Text = "Hangi �lke Asya k�tas�ndad�r?";
                buttonA.Text = "Madagaskar";
                buttonB.Text = "Singapur";
                buttonC.Text = "Peru";
                buttonD.Text = "Kanada";
            }
            IsikKapat();

            if (soruNo == 7)
            {
                richTextBox1.Text = "Hangisi Kan�n� Sultan S�leyman'�n e�idir?";
                buttonA.Text = "K�sem Sultan";
                buttonB.Text = "Safiye Sultan";
                buttonC.Text = "H�rrem Sultan";
                buttonD.Text = "Nurbanu Sultan";
            }
            IsikKapat();

            if (soruNo == 8)
            {
                richTextBox1.Text = "Osmanl� �mparatorlu�u yakla��k ka� as�r h�k�m s�rm��t�r?";
                buttonA.Text = "5";
                buttonB.Text = "7";
                buttonC.Text = "9";
                buttonD.Text = "6";
            }
            IsikKapat();

            if (soruNo == 9)
            {
                richTextBox1.Text = "T�rk Silahl� Kuvvetlerinde hangi r�tbe daha y�ksektir?";
                buttonA.Text = "Korgeneral";
                buttonB.Text = "T�mgeneral";
                buttonC.Text = "Tu�general";
                buttonD.Text = "Orgeneral";
            }
            IsikKapat();

            if (soruNo == 10)
            {
                richTextBox1.Text = "Ka� y�lda bir �ubat ay� 29 �eker?";
                buttonA.Text = "3";
                buttonB.Text = "5";
                buttonC.Text = "4";
                buttonD.Text = "8";
            }
            IsikKapat();

            if (soruNo == 11)
            {
                richTextBox1.Text = "Yar��ma bitmi�tir!";

                buttonSonraki.Visible = false;
                buttonA.Visible = false;
                buttonB.Visible = false;
                buttonC.Visible = false;
                buttonD.Visible = false;

                label4.Visible = false;

                if (dogru > yanlis)
                    richTextBox1.Text += "\nKazand�n�z :)";
                else 
                    richTextBox1.Text += "\n Kaybettiniz :(";
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            switch (soruNo)
            {
                case 1: //1.SORUNUN DO�RU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "1923"; break;

                case 2:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Bal�kesir";
                    break;

                case 3:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    break;

                case 4:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2.Murat";
                    break;

                case 5:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2000";
                    break;

                case 6:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Singapur";
                    break;

                case 7:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "H�rrem Sultan";
                    break;

                case 8: //8.SORUNUN DO�RU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "6"; break;

                case 9: //9.SORUNUN DO�RU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "Orgeneral"; break;

                case 10:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "4";
                    break;

            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            switch (soruNo)
            {
                case 1:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "1923";
                    break;

                case 2:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Bal�kesir";
                    break;

                case 3: //3.SORUNUN DO�RU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "Sait Faik"; break;

                case 4: //4.SORUNUN DO�RU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "2.Murat"; break;

                case 5:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2000";
                    break;

                case 6:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Singapur";
                    break;

                case 7:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "H�rrem Sultan";
                    break;

                case 8:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "6";
                    break;

                case 9:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Orgeneral";
                    break;

                case 10:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "4";
                    break;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            switch (soruNo)
            {
                case 1:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "1923";
                    break;

                case 2: //�K�NC� SORUNUN D�RU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "Bal�kesir"; break;

                case 3:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Sait Faik";
                    break;

                case 4:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2.Murat";
                    break;

                case 5:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2000";
                    break;

                case 6: //6.SORUNUN DO�RU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "Singapur"; break;

                case 7:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "H�rrem Sultan";
                    break;

                case 8:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "6";
                    break;

                case 9:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Orgeneral";
                    break;

                case 10:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "4";
                    break;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            switch (soruNo)
            {
                case 1:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "1923";
                    break;

                case 2:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Bal�kesir";
                    break;

                case 3:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Sait Faik";
                    break;

                case 4:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "2.Murat";
                    break;

                case 5: //5.SORUNUN DO�RU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "2000"; break;

                case 6:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Singapur";
                    break;

                case 7: //7.SORUNUN DO�RU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "H�rrem Sultan"; break;

                case 8:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "6";
                    break;

                case 9:
                    pictureBox2.Visible = true;
                    yanlis++;
                    labelYanlisSoru.Text = yanlis.ToString();
                    label4.Text = "Orgeneral";
                    break;

                case 10: //10.SORUNUN DO�RU CEVABI
                    pictureBox1.Visible = true;
                    dogru++;
                    labelDogruSoru.Text = dogru.ToString();
                    label4.Text = "4"; break;
            }
        }
    }
}